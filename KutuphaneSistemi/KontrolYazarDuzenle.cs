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
    public partial class KontrolYazarDuzenle : UserControl
    {
        public KontrolYazarDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");
        private void KontrolYazarDuzenle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele ()
        {
            SqlCommand komut = new SqlCommand("SELECT ID, AdSoyad, DogumTarihi FROM TblYazar", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridViewYazar.DataSource = dt;
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAd.Text))
            {
                MessageBox.Show("Yazar adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();
            string yazarID = tbID.Text;
            SqlCommand kontrol1 = new SqlCommand("SELECT COUNT(*) FROM TblYazar WHERE ID = @p1", baglanti);
            kontrol1.Parameters.AddWithValue("@p1", yazarID);
            int count = (int)kontrol1.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Bu yazar zaten var!","Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TblYazar (AdSoyad, DogumTarihi) VALUES (@p1, @p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", tbAd.Text);
                komut.Parameters.AddWithValue("@p2", dtpDogumTarihi.Value);
                komut.ExecuteNonQuery();
                //baglanti.Close();
                MessageBox.Show("Yazar eklendi.");
                Listele();
                tbAd.Clear();
                tbAd.Focus();
            }
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz yazarı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE TblYazar SET AdSoyad=@p1, DogumTarihi=@p2 WHERE ID=@p3", baglanti);
                komut.Parameters.AddWithValue("@p1", tbAd.Text);
                komut.Parameters.AddWithValue("@p2", dtpDogumTarihi.Value);
                komut.Parameters.AddWithValue("@p3", tbID.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yazar güncellendi.");
                Listele();
                tbAd.Clear();
                tbAd.Focus();
        }

        private void dataGridViewYazar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dataGridViewYazar.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbAd.Text = dataGridViewYazar.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(dataGridViewYazar.Rows[e.RowIndex].Cells[2].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz yazarı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baglanti.Open();

            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM TblKitaplar WHERE Yazar = @p1", baglanti);
            kontrol.Parameters.AddWithValue("@p1", tbID.Text);
            int kitapSayisi = (int)kontrol.ExecuteScalar();

            if (kitapSayisi > 0)
            {
                MessageBox.Show("Bu yazar kitaplarda kullanıldığı için silinemez!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                SqlCommand komut = new SqlCommand("DELETE FROM TblYazar WHERE ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", tbID.Text);
            komut.ExecuteNonQuery();
            //baglanti.Close();
            MessageBox.Show("Yazar silindi.");
            Listele();
            tbAd.Clear();
            tbAd.Focus();
            }
            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbAd.Clear();
            tbAd.Focus();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbYazar.Text))
            {
                MessageBox.Show("Lütfen aramak istediğiniz yazar adını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string arananYazar = tbYazar.Text;

            SqlCommand komut = new SqlCommand("SELECT * FROM TblYazar WHERE AdSoyad LIKE @p1 ORDER BY AdSoyad", baglanti);
            komut.Parameters.AddWithValue("@p1", "%" + arananYazar + "%"); // % yazmazsan sadece tam eşleşir

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridViewYazar.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                dataGridViewYazar.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Böyle bir yazar bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
        }
    }
}
