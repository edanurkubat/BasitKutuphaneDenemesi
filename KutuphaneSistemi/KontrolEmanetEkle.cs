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
    public partial class KontrolEmanetEkle : UserControl
    {
        public KontrolEmanetEkle()
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
            dataGridViewEmanet.Columns["TeslimTarihi"].Visible = false;
            baglanti.Close();
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

        private void KontrolEmanetEkle_Load(object sender, EventArgs e)
        {
            KitapYukle();
            UyeYukle();
            Listele();
            cbUye.SelectedIndex = -1;
            cbKitap.SelectedIndex = -1;
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cbUye.SelectedValue == null || cbKitap.SelectedValue == null)
            {
                MessageBox.Show("Lütfen üye ve kitap seçiniz!");
                return;
            }

            // Mevcut emanet kontrolü
            if (EmanetVarMi(Convert.ToInt32(cbUye.SelectedValue), Convert.ToInt32(cbKitap.SelectedValue)))
            {
                MessageBox.Show("Bu kitap zaten bu üyeye emanet verilmiş!");
                return;
            }

            try
            {
                string connectionString = "Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Transaction başlat (hem emanet ekle hem kitap durumunu güncelle)
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Emanet kaydı ekle
                            string insertQuery = @"INSERT INTO TblEmanet (UyeID, KitapID, AlisTarihi) 
                                             VALUES (@UyeID, @KitapID, @AlisTarihi)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@UyeID", Convert.ToInt32(cbUye.SelectedValue));
                                cmd.Parameters.AddWithValue("@KitapID", Convert.ToInt32(cbKitap.SelectedValue));
                                cmd.Parameters.AddWithValue("@AlisTarihi", dtpEkle.Value.Date);
                                //cmd.Parameters.AddWithValue("@TeslimTarihi", dtpTeslim.Value.Date);

                                cmd.ExecuteNonQuery();
                            }

                            // 2. Kitap durumunu güncelle (artık emanette)
                            string updateQuery = "UPDATE TblKitaplar SET Durum = 0 WHERE KitapID = @KitapID";

                            using (SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@KitapID", Convert.ToInt32(cbKitap.SelectedValue));
                                cmd.ExecuteNonQuery();
                            }

                            // Transaction'ı commit et
                            transaction.Commit();

                            MessageBox.Show("Emanet başarıyla verildi!");
                            Listele();

                            // Formu temizle
                            cbUye.SelectedIndex = -1;
                            cbKitap.SelectedIndex = -1;
                            dtpEkle.Value = DateTime.Now;
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
                MessageBox.Show("Emanet verme hatası: " + ex.Message);
            }
        }
        private bool EmanetVarMi(int uyeID, int kitapID)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TblEmanet WHERE UyeID = @UyeID AND KitapID = @KitapID", baglanti);
                komut.Parameters.AddWithValue("@UyeID", uyeID);
                komut.Parameters.AddWithValue("@KitapID", kitapID);

                int count = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();

                return count > 0;
            }
            catch
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                return false;
            }
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
                // Hata mesajını kaldır - sessiz geç
            }

            //tbID.Text = e.RowIndex.ToString();
            //cbUye.SelectedValue = dataGridViewEmanet.Rows[e.RowIndex].Cells[2].Value.ToString();
            //cbKitap.SelectedValue = dataGridViewEmanet.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dtpEkle.Value = Convert.ToDateTime(dataGridViewEmanet.Rows[e.RowIndex].Cells[3].Value.ToString());
            //dtpTeslim.Value = Convert.ToDateTime(dataGridViewEmanet.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            cbUye.SelectedIndex = -1;
            cbKitap.SelectedIndex = -1;
            dtpEkle.Value = DateTime.Now;
            dtpTeslim.Value = DateTime.Now.AddDays(15);
        }
    }
}
