
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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        //;Trust Server Certificate=True
        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");
        void kodolustur()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000, 100000);
            tbOlusanKod.Text = sayi.ToString();
        }
        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            FormUyeOl frm = new FormUyeOl();
            frm.Show();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            kodolustur();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // || string.IsNullOrWhiteSpace(tbKod.Text)
            if (string.IsNullOrWhiteSpace(tbKullanici.Text) || string.IsNullOrWhiteSpace(tbSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kodolustur();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbKod.Text))
            {
                MessageBox.Show("Lütfen kodu giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kodolustur();
                return;
            }
            string kullaniciAdi = tbKullanici.Text;
            string sifre = tbSifre.Text;

            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From TblUye Where KullaniciAdi=@p1 and Sifre=@p2", baglanti);
            komut1.Parameters.AddWithValue("@p1", tbKullanici.Text);
            komut1.Parameters.AddWithValue("@p2", tbSifre.Text);

            int sonuc = (int)komut1.ExecuteScalar();
            if (sonuc == 0)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                kodolustur();
                tbKullanici.Clear();
                tbSifre.Clear();
                tbKod.Clear();
                tbKullanici.Focus();
                baglanti.Close();
                return;
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblUye where KullaniciAdi=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", tbKullanici.Text);
            komut.Parameters.AddWithValue("@p2", tbSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (string.IsNullOrWhiteSpace(tbOlusanKod.Text))
            {
                MessageBox.Show("Lütfen kodu giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kodolustur();
                return;
            }
            if (dr.Read() && tbKod.Text == tbOlusanKod.Text)
            {
                FormAnasayfa frm = new FormAnasayfa();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kod hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbKod.Clear();
                kodolustur();
            }
            baglanti.Close();

        }

        private void libklblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSifremiUnuttum frm = new FormSifremiUnuttum();
            frm.Show();
        }

        private void cbSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreyiGoster.Checked)
            {
                // sifreyi göster
                tbSifre.UseSystemPasswordChar = false;
            }
            else
            {
                tbSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
