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
    public partial class FormUyeDuzenle : Form
    {
        public FormUyeDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");
    
        private void Listele()
        {
            SqlCommand komut = new SqlCommand("SELECT UyeID, KullaniciAdi, Sifre from TblUye", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridViewUyeler.DataSource = dt;
        }

        private void FormUyeDuzenle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridViewUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dataGridViewUyeler.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbKullanici.Text = dataGridViewUyeler.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbSifre.Text = dataGridViewUyeler.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void cbSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreyiGoster.Checked)
            {
                // sifreyi göstermek için özelliği kapatma
                tbSifre.UseSystemPasswordChar = false;
            }
            else
            {
                tbSifre.UseSystemPasswordChar = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbKullanici.Text == "" || tbSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbSifre.Text.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string kullaniciAdi = tbKullanici.Text;
            string sifre = tbSifre.Text;
            baglanti.Open();

            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM TblUye WHERE KullaniciAdi = @p1", baglanti);
            kontrol.Parameters.AddWithValue("@p1", kullaniciAdi);

            int count = (int)kontrol.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Bu kullanıcı zaten var!");
            }

            else
            {
                SqlCommand komut = new SqlCommand("insert into TblUye (KullaniciAdi, Sifre) Values (@p1, @p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", tbKullanici.Text);
                komut.Parameters.AddWithValue("@p2", tbSifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Üyelik Oluşturuldu");
                Listele();
                Temizle();
            }
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbKullanici.Text == "" || tbSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbSifre.Text.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            baglanti.Open();

            string kullaniciAdi = tbKullanici.Text;
            string sifre = tbSifre.Text;
            SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM TblUye WHERE KullaniciAdi=@p1 AND Sifre=@p2 and UyeID=@p3", baglanti);
            kontrolKomut.Parameters.AddWithValue("@p1", tbKullanici.Text);
            kontrolKomut.Parameters.AddWithValue("@p2", tbSifre.Text);
            kontrolKomut.Parameters.AddWithValue("@p3", tbID.Text);

            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

            if (kayitSayisi > 0)
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor! Lütfen farklı bir kullanıcı adı seçin.",
                               "Kullanıcı Adı Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SqlCommand komut = new SqlCommand("UPDATE TblUye SET KullaniciAdi=@p1, Sifre=@p2 WHERE UyeID=@p3", baglanti);
                komut.Parameters.AddWithValue("@p1", tbKullanici.Text);
                komut.Parameters.AddWithValue("@p2", tbSifre.Text);
                komut.Parameters.AddWithValue("@p3", tbID.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Üye bilgileri güncellendi.");
                Listele();
                baglanti.Close();
            }
        }

        private void Temizle()
        {
            tbID.Clear();
            tbKullanici.Clear();
            tbSifre.Clear();
            tbKullanici.Focus();
        }
        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Önce silme onayı al
            DialogResult onay = MessageBox.Show("Bu üyeyi silmek istediğinize emin misiniz?",
                                               "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.No)
            {
                return;
            }

            try
            {
                baglanti.Open();

                // Önce bu üyenin emanet kaydı var mı kontrol et
                SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM TblEmanet WHERE UyeID=@uyeID", baglanti);
                kontrolKomut.Parameters.AddWithValue("@uyeID", tbID.Text); // veya seçili satırdan aldığınız ID

                int emanetSayisi = (int)kontrolKomut.ExecuteScalar();

                if (emanetSayisi > 0)
                {
                    MessageBox.Show("Bu üyenin emanet kitap kaydı bulunmaktadır! " +
                                   "Önce emanet kitapları iade ettiriniz.",
                                   "Silme İşlemi Yapılamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Emanet kaydı yoksa üyeyi sil
                SqlCommand silKomut = new SqlCommand("DELETE FROM TblUye WHERE UyeID=@uyeID", baglanti);
                silKomut.Parameters.AddWithValue("@uyeID", tbID.Text);

                int etkilenenSatir = silKomut.ExecuteNonQuery();

                if (etkilenenSatir > 0)
                {
                    MessageBox.Show("Üye başarıyla silindi.", "Başarılı",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele(); // Listeyi yenile

                    // Formdaki alanları temizle
                    tbID.Clear();
                    tbKullanici.Clear();
                    tbSifre.Clear();
                    // diğer alanları da temizleyin...
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız! Üye bulunamadı.", "Hata",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
    }
}
