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
    public partial class KontrolYayinevi : UserControl
    {
        public KontrolYayinevi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");

        private void Listele()
        {
            SqlCommand komut = new SqlCommand("SELECT ID, Ad FROM TblYayinevi", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridViewYayinevi.DataSource = dt;
        }

        private void KontrolYayinevi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAd.Text))
            {
                MessageBox.Show("Yayınevi adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();

            string yayineviID = tbID.Text;
            string yayineviAd = tbAd.Text;
            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM TblYayinevi WHERE ID = @p1 and Ad=@p2", baglanti);
            kontrol.Parameters.AddWithValue("@p1", yayineviID);
            kontrol.Parameters.AddWithValue("@p2", yayineviAd);
            int count = (int)kontrol.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Bu yayınevi zaten var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TblYayinevi (Ad) VALUES (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", tbAd.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Yayınevi eklendi.");
               // baglanti.Close();
                Listele();
                tbID.Clear();
                tbAd.Clear();
            }
            baglanti.Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text) || string.IsNullOrWhiteSpace(tbAd.Text))
            {
                MessageBox.Show("Lütfen ID ve Ad alanlarını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();

            string yayineviAd = tbAd.Text;
            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM TblYayinevi WHERE Ad = @p1", baglanti);
            kontrol.Parameters.AddWithValue("@p1", yayineviAd);
            int count = (int)kontrol.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Bu yayınevi zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                return;
            }
            else
            {
               
                SqlCommand komut = new SqlCommand("UPDATE TblYayinevi SET Ad=@p1 WHERE ID=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", tbAd.Text);
                komut.Parameters.AddWithValue("@p2", tbID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Yayınevi güncellendi.");
               // baglanti.Close();
                Listele();

            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz yayınevini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();

            SqlCommand kontrol1 = new SqlCommand("SELECT COUNT(*) FROM TblKitaplar WHERE Yayinevi = @p1", baglanti);
            kontrol1.Parameters.AddWithValue("@p1", tbID.Text);
            int yayineviSayisi = (int)kontrol1.ExecuteScalar();

            if (yayineviSayisi > 0)
            {
                MessageBox.Show("Bu yayinevine kayıtlı kitap olduğu için silinemez!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string yayineviID = tbID.Text;
                SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM TblYayinevi WHERE ID = @p1", baglanti);
                kontrol.Parameters.AddWithValue("@p1", yayineviID);
                int count = (int)kontrol.ExecuteScalar();
                if (count > 0)
                {
                    SqlCommand komut = new SqlCommand("DELETE FROM TblYayinevi WHERE ID=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", tbID.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yayınevi silindi.");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Bu ID'ye sahip bir yayınevi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                baglanti.Close();
            }
        }

        private void dataGridViewYayinevi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dataGridViewYayinevi.CurrentRow.Cells[0].Value.ToString();
            tbAd.Text = dataGridViewYayinevi.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbAd.Clear();
        }
    }
}
