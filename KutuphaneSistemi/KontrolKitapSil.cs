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
    public partial class KontrolKitapSil : UserControl
    {
        public KontrolKitapSil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");
        private void Listele()
        {
            SqlCommand komut1 = new SqlCommand("SELECT k.KitapID, k.KitapAd, yaz.AdSoyad AS Yazar, k.Sayfa, y.Ad AS Yayinevi, k.Tur, k.Durum FROM TblKitaplar k INNER JOIN TblYayinevi y ON k.Yayinevi = y.ID INNER JOIN TblYazar yaz ON k.Yazar = yaz.ID", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridViewKitap.DataSource = dt;
            dataGridViewKitap.Columns["Durum"].Visible = false; // Kategoriid sütununu gizle
        }
        private void dataGridViewKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbAd.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbYazar.SelectedValue = dataGridViewKitap.Rows[e.RowIndex].Cells[2].Value.ToString();
            nmrSayfa.Value = Convert.ToDecimal(dataGridViewKitap.Rows[e.RowIndex].Cells[3].Value.ToString());
            cbYayinevi.SelectedValue = dataGridViewKitap.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbTur.Text = dataGridViewKitap.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void KontrolKitapSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TblKitaplar where KitapID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", tbID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi!");
            Listele();
        }
    }
}
