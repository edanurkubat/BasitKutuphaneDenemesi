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
    public partial class FormUyeOl : Form
    {
        public FormUyeOl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
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
                this.Hide();
            }
            baglanti.Close();
        }

        private void cbSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreyiGoster.Checked)
            {
                // sifreyi göstermek için
                tbSifre.UseSystemPasswordChar = false;
            }
            else
            {
                tbSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
