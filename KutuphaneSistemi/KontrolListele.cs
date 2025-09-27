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
    public partial class KontrolListele : UserControl
    {
        public KontrolListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");
        private void Listele()
        {
            SqlCommand komut = new SqlCommand("SELECT k.KitapID, k.KitapAd, yaz.AdSoyad AS Yazar, k.Sayfa, y.Ad AS Yayinevi, k.Tur, k.Durum FROM TblKitaplar k INNER JOIN TblYayinevi y ON k.Yayinevi = y.ID INNER JOIN TblYazar yaz ON k.Yazar = yaz.ID", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridViewKitap.DataSource = dt;
            dataGridViewKitap.Columns["Durum"].Visible = false; 
        }
        private void ComboBoxDoldur()
        {
            baglanti.Open();
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
        private void KontrolListele_Load(object sender, EventArgs e)
        {
            Listele();
            ComboBoxDoldur();
            cbYazar.SelectedIndex = -1;
            cbYayinevi.SelectedIndex = -1;
            cbTur.SelectedIndex = -1;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            // Arama kriterlerini kontrol et - en az biri dolu olmalı
            if (string.IsNullOrWhiteSpace(tbKitapAdi.Text) &&
                string.IsNullOrWhiteSpace(cbYazar.Text) &&
                cbTur.SelectedIndex == -1 &&
                cbYayinevi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen en az bir arama kriteri girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();

                string sorgu = "SELECT k.*, y.AdSoyad as YazarAdi, yy.Ad as YayineviAdi " +
                    "FROM TblKitaplar k " +
                    "INNER JOIN TblYazar y ON k.Yazar = y.ID " +
                    "INNER JOIN TblYayinevi yy ON k.Yayinevi = yy.ID " +
                    "WHERE 1=1";

                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;

                // Kitap adı filtresi
                if (!string.IsNullOrWhiteSpace(tbKitapAdi.Text))
                {
                    sorgu += " AND k.KitapAd LIKE @KitapAd";
                    komut.Parameters.AddWithValue("@KitapAd", "%" + tbKitapAdi.Text + "%");
                }

                // Yazar filtresi - ComboBox'tan seçilen yazar
                if (cbYazar.SelectedIndex != -1 && cbYazar.SelectedValue != null)
                {
                    sorgu += " AND k.Yazar = @Yazar";
                    komut.Parameters.AddWithValue("@Yazar", cbYazar.SelectedValue);
                }

                // Tür filtresi
                if (cbTur.SelectedIndex != -1)
                {
                    sorgu += " AND k.Tur = @Tur";
                    komut.Parameters.AddWithValue("@Tur", cbTur.SelectedItem.ToString());
                }

                // Yayınevi filtresi
                if (cbYayinevi.SelectedIndex != -1 && cbYayinevi.SelectedValue != null)
                {
                    sorgu += " AND k.Yayinevi = @Yayinevi";
                    komut.Parameters.AddWithValue("@Yayinevi", cbYayinevi.SelectedValue);
                }

                // Sorguyu çalıştır
                komut.CommandText = sorgu;

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Sonuçları DataGridView'e bağla (dataGridViewKitap adında bir control olduğunu varsayıyorum)
                dataGridViewKitap.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Arama kriterlerinize uygun kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbKitapAdi.Text = "";
            cbYazar.SelectedIndex = -1;
            cbTur.SelectedIndex = -1;
            cbYayinevi.SelectedIndex = -1;
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
