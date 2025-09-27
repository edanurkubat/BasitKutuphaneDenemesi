using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemi
{
    public partial class KontrolEmanetTeslim : UserControl
    {
        public KontrolEmanetTeslim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");

        private void Listele()
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT e.EmanetID, k.KitapAd, u.KullaniciAdi AS Uye, e.AlisTarihi, e.TeslimTarihi FROM TblEmanet e INNER JOIN TblKitaplar k ON e.KitapID = k.KitapID INNER JOIN TblUye u ON e.UyeID = u.UyeID", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridViewEmanet.DataSource = dt;
            baglanti.Close();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            cbUye.SelectedIndex = -1;
            cbKitap.SelectedIndex = -1;
            dtpEkle.Value = DateTime.Now;
            dtpTeslim.Value = DateTime.Now.AddDays(15);
        }

        private void KontrolEmanetTeslim_Load(object sender, EventArgs e)
        {
            Listele();
            UyeYukle();
            KitapYukle();
            cbUye.SelectedIndex = -1;
            cbKitap.SelectedIndex = -1;
        }
        private void UyeYukle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblUye", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbUye.DisplayMember = "KullaniciAdi";
            cbUye.ValueMember = "UyeID";
            cbUye.DataSource = dt;
            baglanti.Close();
        }
        private void KitapYukle()
        {
            SqlCommand komut1 = new SqlCommand("Select * From TblKitaplar", baglanti);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbKitap.DisplayMember = "KitapAd";
            cbKitap.ValueMember = "KitapID";
            cbKitap.DataSource = dt1;
            baglanti.Close();
        }

        private void dataGridViewEmanet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    tbID.Text = dataGridViewEmanet.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cbKitap.Text = dataGridViewEmanet.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cbUye.Text = dataGridViewEmanet.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dtpEkle.Value = Convert.ToDateTime(dataGridViewEmanet.Rows[e.RowIndex].Cells[3].Value.ToString());
                    dtpTeslim.Value = Convert.ToDateTime(dataGridViewEmanet.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            catch
            {
                // Sessiz geç
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Lütfen teslim edilecek emaneti seçiniz!");
                return;
            }

            try
            {
                string connectionString = "Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            int emanetID = Convert.ToInt32(tbID.Text);
                            int kitapID = Convert.ToInt32(cbKitap.SelectedValue);

                             // Emanet kaydını sil (veya teslim tarihini güncelle)
                            string teslim = "UPDATE TblEmanet SET UyeID = @UyeID, KitapID = @KitapID, AlisTarihi = @AlisTarihi, TeslimTarihi = @TeslimTarihi WHERE EmanetID = @EmanetID";
                            using (SqlCommand cmd = new SqlCommand(teslim, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@UyeID", Convert.ToInt32(cbUye.SelectedValue));
                                cmd.Parameters.AddWithValue("@KitapID", Convert.ToInt32(cbKitap.SelectedValue));
                                cmd.Parameters.AddWithValue("@AlisTarihi", dtpEkle.Value.Date);
                                cmd.Parameters.AddWithValue("@TeslimTarihi", dtpTeslim.Value.Date);

                                // güncellenecek kaydın ID’si mesela textbox’tan geliyor
                                cmd.Parameters.AddWithValue("@EmanetID", Convert.ToInt32(tbID.Text));

                                cmd.ExecuteNonQuery();
                            }


                            // 2. Kitap durumunu güncelle (artık müsait)
                            string updateQuery = "UPDATE TblKitaplar SET Durum = 1 WHERE KitapID = @KitapID";
                            using (SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@KitapID", kitapID);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Kitap başarıyla teslim alındı!");
                            Listele();
                            
                            // Formu temizle
                            tbID.Clear();
                            cbUye.SelectedIndex = -1;
                            cbKitap.SelectedIndex = -1;
                            dtpTeslim.Value = DateTime.Now;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teslim alma hatası: " + ex.Message);
            }
        }

        // Kitap teslim edildi mi kontrol eden metod
       /* private bool KitapTeslimEdildiMi(int emanetID)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TblEmanet e INNER JOIN TblKitaplar k ON e.KitapID = k.KitapID WHERE e.EmanetID = @EmanetID AND k.Durum = 1", baglanti);
                komut.Parameters.AddWithValue("@EmanetID", emanetID);

                int count = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();

                return count > 0; // Eğer kitap durumu 1 ise (müsait) zaten teslim edilmiş demektir
            }
            catch
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                return false;
            }
        }*/
    }
}
