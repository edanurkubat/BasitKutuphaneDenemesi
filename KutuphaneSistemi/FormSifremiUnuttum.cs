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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace KutuphaneSistemi
{
    public partial class FormSifremiUnuttum : Form
    {
        public FormSifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");

        private void cbSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreyiGoster.Checked)
            {
                // sifreyi göstermek için özelliği kapatma
                tbSifre.UseSystemPasswordChar = false;
                tbSifreTekrarla.UseSystemPasswordChar = false;
            }
            else
            {
                tbSifre.UseSystemPasswordChar = true;
                tbSifreTekrarla.UseSystemPasswordChar = true;
            }
        }

        private void btnSifreYenile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbKullanici.Text) || string.IsNullOrWhiteSpace(tbSifre.Text) || string.IsNullOrWhiteSpace(tbSifreTekrarla.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            
            baglanti.Open();

            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM TblUye WHERE KullaniciAdi = @p1", baglanti);
            kontrol.Parameters.AddWithValue("@p1", tbKullanici.Text);
            int count = (int)kontrol.ExecuteScalar();
            if (count == 0)
            {
                MessageBox.Show("Bu kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSifre.Text = "";
                tbSifreTekrarla.Text = "";
                tbKullanici.Text = "";
                tbKullanici.Focus();
                baglanti.Close();
                return;
            }
            if (tbSifre.Text.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                return;     
            }
            if (tbSifre.Text != tbSifreTekrarla.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSifre.Text = "";
                tbSifreTekrarla.Text = "";
                baglanti.Close();
                return;
            }
            else
            {   
                SqlCommand komut = new SqlCommand("update TblUye set Sifre=@p2 where Kullaniciadi = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", tbKullanici.Text);
                komut.Parameters.AddWithValue("@p2", tbSifre.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Şifre Güncellendi");
                this.Hide();
                baglanti.Close();
            }
           
            baglanti.Close();
            
        }
    }
}
