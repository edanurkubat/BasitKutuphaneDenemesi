using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneSistemi
{
    public partial class KontrolKitapEkleGuncelle : UserControl
    {
        public KontrolKitapEkleGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbAd.Text = "";
            cbYazar.SelectedIndex = -1;
            nmrSayfa.Value = 0;
            cbYayinevi.SelectedIndex = -1;
            cbTur.SelectedIndex = -1;
            checkbTeslim.Checked = false;
            tbAd.Focus();
        }
        private void Listele()
        {
            SqlCommand komut1 = new SqlCommand("SELECT k.KitapID, k.KitapAd, yaz.AdSoyad AS Yazar, k.Sayfa, y.Ad AS Yayinevi, k.Tur, k.Durum FROM TblKitaplar k INNER JOIN TblYayinevi y ON k.Yayinevi = y.ID INNER JOIN TblYazar yaz ON k.Yazar = yaz.ID", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridViewKitap.DataSource = dt;
            dataGridViewKitap.Columns["Durum"].Visible = false; // Kategoriid sütununu gizle
        }

        private void KontrolKitapEkleGuncelle_Load(object sender, EventArgs e)
        {
            Listele();
            ComboBoxDoldur();
            cbYazar.SelectedIndex = -1;
            cbYayinevi.SelectedIndex = -1;
            cbTur.SelectedIndex = -1;
        }

        private void ComboBoxDoldur()
        {   baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblYazar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbYazar.DisplayMember = "AdSoyad";
            cbYazar.ValueMember = "ID";
            cbYazar.DataSource = dt;

            SqlCommand komut1 = new SqlCommand("Select * From TblYayinevi", baglanti);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbYayinevi.DisplayMember = "Ad";
            cbYayinevi.ValueMember = "ID";
            cbYayinevi.DataSource = dt1;
            baglanti.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAd.Text) || cbYazar.SelectedIndex == -1 || nmrSayfa.Value == 0 || cbYayinevi.SelectedIndex == -1 || cbTur.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();

            string kitapID = tbID.Text;
            SqlCommand kontrol1 = new SqlCommand("SELECT COUNT(*) FROM TblKitaplar WHERE KitapID = @p1", baglanti);
            kontrol1.Parameters.AddWithValue("@p1", kitapID);
            int count = (int)kontrol1.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Bu kitap zaten var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("insert into TblKitaplar ( KitapAd, Yazar, Sayfa, Yayinevi, Tur) Values (@p1, @p2, @p3, @p4, @p5)", baglanti);
                komut2.Parameters.AddWithValue("@p1", tbAd.Text);
                komut2.Parameters.AddWithValue("@p2", cbYazar.SelectedValue);
                komut2.Parameters.AddWithValue("@p3", nmrSayfa.Value);
                komut2.Parameters.AddWithValue("@p4", cbYayinevi.SelectedValue);
                komut2.Parameters.AddWithValue("@p5", cbTur.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap Eklendi");
                Listele();
                tbID.Clear();
                tbAd.Text = "";
                cbYazar.SelectedIndex = -1;
                nmrSayfa.Value = 0;
                cbYayinevi.SelectedIndex = -1;
                cbTur.SelectedIndex = -1;
                checkbTeslim.Checked = false;
            }
            baglanti.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Lütfen güncellenecek kitabı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("update TblKitaplar set KitapAd=@p1, Yazar=@p2, Sayfa=@p3, Yayinevi=@p4, Tur=@p5 where KitapID=@p6", baglanti);
            komut3.Parameters.AddWithValue("@p1", tbAd.Text);
            komut3.Parameters.AddWithValue("@p2", cbYazar.SelectedValue);
            komut3.Parameters.AddWithValue("@p3", nmrSayfa.Value);
            komut3.Parameters.AddWithValue("@p4", cbYayinevi.SelectedValue);
            komut3.Parameters.AddWithValue("@p5", cbTur.Text);
            komut3.Parameters.AddWithValue("@p6", tbID.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Bilgileri Güncellendi");
            Listele();
        }

        private void dataGridViewKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbID.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbAd.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbYazar.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[2].Value.ToString();
                nmrSayfa.Value = Convert.ToDecimal(dataGridViewKitap.Rows[e.RowIndex].Cells[3].Value.ToString());
                cbYayinevi.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbTur.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[5].Value.ToString();

                // Kitapın emanet durumunu kontrol et ve checkbox'ı ayarla
                int kitapID = Convert.ToInt32(tbID.Text);
                checkbTeslim.Checked = KitapEmanetteMi(kitapID);
            }
        }

        // Kitapın emanette olup olmadığını kontrol eden metod
        private bool KitapEmanetteMi(int kitapID)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TblEmanet WHERE KitapID = @KitapID", baglanti);
                komut.Parameters.AddWithValue("@KitapID", kitapID);

                int count = Convert.ToInt32(komut.ExecuteScalar());
                baglanti.Close();

                return count > 0; // Eğer emanet kaydı varsa true, yoksa false
            }
            catch
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                return false;
            }
            // tbID.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[0].Value.ToString();
            //   tbAd.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[1].Value.ToString();
            //  cbYazar.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[2].Value.ToString();
            //  nmrSayfa.Value = Convert.ToDecimal(dataGridViewKitap.Rows[e.RowIndex].Cells[3].Value.ToString());
            //   cbYayinevi.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[4].Value.ToString();
            // cbTur.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
