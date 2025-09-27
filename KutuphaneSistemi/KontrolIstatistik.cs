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
using System.Windows.Forms.DataVisualization.Charting;

namespace KutuphaneSistemi
{
    public partial class KontrolIstatistik : UserControl
    {
        public KontrolIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=DbKutuphane;Integrated Security=True");

        private void KontrolIstatistik_Load(object sender, EventArgs e)
        {
            IstatistikleriYukle();
            YazarGrafigi();
            YayineviGrafigi();
        }
        private void IstatistikleriYukle()
        {
            try
            {
                baglanti.Open();

                // Toplam kitap sayısı
                SqlCommand toplamKitap = new SqlCommand("SELECT COUNT(*) FROM TblKitaplar", baglanti);
                int kitapSayisi = Convert.ToInt32(toplamKitap.ExecuteScalar());
                lblToplamKitap.Text = "Toplam Kitap: " + kitapSayisi.ToString();

                // Müsait kitap sayısı
                SqlCommand musaitKitap = new SqlCommand("SELECT COUNT(*) FROM TblKitaplar WHERE Durum = 1", baglanti);
                int musaitSayisi = Convert.ToInt32(musaitKitap.ExecuteScalar());
                lblMusaitKitap.Text = "Müsait: " + musaitSayisi.ToString();

                // Emanetteki kitap sayısı
                SqlCommand emanetKitap = new SqlCommand("SELECT COUNT(*) FROM TblKitaplar WHERE Durum = 0", baglanti);
                int emanetSayisi = Convert.ToInt32(emanetKitap.ExecuteScalar());
                lblEmanetKitap.Text = "Emanette: " + emanetSayisi.ToString();

                // Toplam üye sayısı
                SqlCommand toplamUye = new SqlCommand("SELECT COUNT(*) FROM TblUye", baglanti);
                int uyeSayisi = Convert.ToInt32(toplamUye.ExecuteScalar());
                lblToplamUye.Text = "Toplam Üye: " + uyeSayisi.ToString();

                // Aktif emanet sayısı
                SqlCommand aktifEmanet = new SqlCommand("SELECT COUNT(*) FROM TblEmanet", baglanti);
                int aktifSayisi = Convert.ToInt32(aktifEmanet.ExecuteScalar());
                lblAktifEmanet.Text = "Aktif Emanet: " + aktifSayisi.ToString();

                // Toplam üye sayısı
                SqlCommand toplamYayinevi = new SqlCommand("SELECT COUNT(*) FROM TblYayinevi", baglanti);
                int yayineviSayisi = Convert.ToInt32(toplamYayinevi.ExecuteScalar());
                lblToplamYayinevi.Text = "Toplam Yayınevi: " + yayineviSayisi.ToString();

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistik yükleme hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void YazarGrafigi()
        {
            try
            {
                baglanti.Open();

                // Yazarların kitap sayılarını getir
                SqlCommand komut = new SqlCommand(@"SELECT TOP 10 y.AdSoyad, COUNT(k.KitapID) as KitapSayisi 
                                                   FROM TblYazar y 
                                                   LEFT JOIN TblKitaplar k ON y.ID = k.Yazar 
                                                   GROUP BY y.AdSoyad 
                                                   ORDER BY COUNT(k.KitapID) DESC", baglanti);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Chart temizle
                chartYazar.Series.Clear();
                chartYazar.ChartAreas.Clear();

                // Chart area ekle
                ChartArea chartArea = new ChartArea();
                chartArea.BackColor = Color.Transparent;
                chartYazar.ChartAreas.Add(chartArea);

                // Series ekle
                Series series = new Series("Yazarlar");
                series.ChartType = SeriesChartType.Doughnut;
                series.Color = Color.FromArgb(54, 162, 235);

                // Verileri ekle
                foreach (DataRow row in dt.Rows)
                {
                    string yazarAd = row["AdSoyad"].ToString();
                    int kitapSayisi = Convert.ToInt32(row["KitapSayisi"]);
                    series.Points.AddXY(yazarAd, kitapSayisi);
                }

                chartYazar.Series.Add(series);
                chartYazar.BackColor = Color.Transparent;

                // Başlık ekle
                Title title = new Title("Yazarlara Göre Kitap Sayısı");
                title.Font = new Font("Arial", 12, FontStyle.Bold);
                chartYazar.Titles.Add(title);

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yazar grafiği hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void YayineviGrafigi()
        {
            try
            {
                baglanti.Open();

                // Yayınevlerinin kitap sayılarını getir
                SqlCommand komut = new SqlCommand(@"SELECT TOP 10 y.Ad, COUNT(k.KitapID) as KitapSayisi 
                                                   FROM TblYayinevi y 
                                                   LEFT JOIN TblKitaplar k ON y.ID = k.Yayinevi 
                                                   GROUP BY y.Ad 
                                                   ORDER BY COUNT(k.KitapID) DESC", baglanti);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Chart temizle
                chartYayinevi.Series.Clear();
                chartYayinevi.ChartAreas.Clear();

                // Chart area ekle
                ChartArea chartArea = new ChartArea();
                chartArea.BackColor = Color.Transparent;
                chartYayinevi.ChartAreas.Add(chartArea);

                // Series ekle (Pie Chart)
                Series series = new Series("Yayınevleri");
                series.ChartType = SeriesChartType.Doughnut;

                // Renkler
                Color[] colors = {
                    Color.FromArgb(255, 99, 132),
                    Color.FromArgb(54, 162, 235),
                    Color.FromArgb(255, 205, 86),
                    Color.FromArgb(75, 192, 192),
                    Color.FromArgb(153, 102, 255),
                    Color.FromArgb(255, 159, 64),
                    Color.FromArgb(199, 199, 199),
                    Color.FromArgb(83, 102, 255),
                    Color.FromArgb(255, 99, 255),
                    Color.FromArgb(99, 255, 132)
                };

                // Verileri ekle
                int colorIndex = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string yayineviAd = row["Ad"].ToString();
                    int kitapSayisi = Convert.ToInt32(row["KitapSayisi"]);

                    DataPoint point = new DataPoint();
                    point.SetValueXY(yayineviAd, kitapSayisi);
                    point.Color = colors[colorIndex % colors.Length];
                    point.Label = yayineviAd + " (" + kitapSayisi + ")";

                    series.Points.Add(point);
                    colorIndex++;
                }

                chartYayinevi.Series.Add(series);
                chartYayinevi.BackColor = Color.Transparent;

                // Başlık ekle
                Title title = new Title("Yayınevlerine Göre Kitap Dağılımı");
                title.Font = new Font("Arial", 12, FontStyle.Bold);
                chartYayinevi.Titles.Add(title);

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yayınevi grafiği hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
    }
}
