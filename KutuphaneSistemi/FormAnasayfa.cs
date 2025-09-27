using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneSistemi
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void ekleGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); // önceki kontrolleri temizle
            KontrolKitapEkleGuncelle kc = new KontrolKitapEkleGuncelle(); // UserControl
            kc.Dock = DockStyle.Fill; // paneli doldursun
            panelMain.Controls.Add(kc);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            panelMain.Controls.Clear(); // önceki kontrolleri temizle
            KontrolKitapSil ks = new KontrolKitapSil(); // UserControl
            ks.Dock = DockStyle.Fill; // paneli doldursun
            panelMain.Controls.Add(ks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            KontrolListele kl = new KontrolListele();
            kl.Dock = DockStyle.Fill; // paneli doldursun
            panelMain.Controls.Add(kl);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); // önceki kontrolleri temizle
            KontrolYazarDuzenle ky = new KontrolYazarDuzenle(); // UserControl
            ky.Dock = DockStyle.Fill; // paneli doldursun
            panelMain.Controls.Add(ky);
        }

        private void düzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); // önceki kontrolleri temizle
            KontrolYayinevi yy = new KontrolYayinevi(); // UserControl
            yy.Dock = DockStyle.Fill; // paneli doldursun
            panelMain.Controls.Add(yy);
        }

        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            KontrolListele kl = new KontrolListele();
            kl.Dock = DockStyle.Fill; // paneli doldursun
            panelMain.Controls.Add(kl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUyeDuzenle uye = new FormUyeDuzenle();
            uye.Show();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); // önceki kontrolleri temizle
            KontrolEmanetEkle ke = new KontrolEmanetEkle(); // UserControl
            ke.Dock = DockStyle.Fill; // paneli doldursun
            panelMain.Controls.Add(ke);
        }

        private void teslimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); // önceki kontrolleri temizle
            KontrolEmanetTeslim kt = new KontrolEmanetTeslim(); // UserControl
            kt.Dock = DockStyle.Fill; // paneli doldursun
            panelMain.Controls.Add(kt);
        }

        private void iSTATİSTİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); // önceki kontrolleri temizle
            KontrolIstatistik ki = new KontrolIstatistik(); // UserControl  
            ki.Dock = DockStyle.Fill; // paneli doldursun
            panelMain.Controls.Add(ki);
        }
    }
}
