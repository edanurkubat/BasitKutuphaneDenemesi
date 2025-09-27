namespace KutuphaneSistemi
{
    partial class KontrolIstatistik
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblToplamKitap = new System.Windows.Forms.Label();
            this.lblMusaitKitap = new System.Windows.Forms.Label();
            this.lblEmanetKitap = new System.Windows.Forms.Label();
            this.lblToplamUye = new System.Windows.Forms.Label();
            this.lblAktifEmanet = new System.Windows.Forms.Label();
            this.lblToplamYayinevi = new System.Windows.Forms.Label();
            this.chartYazar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartYayinevi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartYazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYayinevi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToplamKitap
            // 
            this.lblToplamKitap.AutoSize = true;
            this.lblToplamKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKitap.ForeColor = System.Drawing.Color.Navy;
            this.lblToplamKitap.Location = new System.Drawing.Point(31, 17);
            this.lblToplamKitap.Name = "lblToplamKitap";
            this.lblToplamKitap.Size = new System.Drawing.Size(140, 25);
            this.lblToplamKitap.TabIndex = 5;
            this.lblToplamKitap.Text = "Toplam Kitap";
            // 
            // lblMusaitKitap
            // 
            this.lblMusaitKitap.AutoSize = true;
            this.lblMusaitKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusaitKitap.ForeColor = System.Drawing.Color.Navy;
            this.lblMusaitKitap.Location = new System.Drawing.Point(329, 17);
            this.lblMusaitKitap.Name = "lblMusaitKitap";
            this.lblMusaitKitap.Size = new System.Drawing.Size(132, 25);
            this.lblMusaitKitap.TabIndex = 6;
            this.lblMusaitKitap.Text = "Müsait Kitap";
            // 
            // lblEmanetKitap
            // 
            this.lblEmanetKitap.AutoSize = true;
            this.lblEmanetKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmanetKitap.ForeColor = System.Drawing.Color.Navy;
            this.lblEmanetKitap.Location = new System.Drawing.Point(614, 17);
            this.lblEmanetKitap.Name = "lblEmanetKitap";
            this.lblEmanetKitap.Size = new System.Drawing.Size(141, 25);
            this.lblEmanetKitap.TabIndex = 7;
            this.lblEmanetKitap.Text = "Emanet Kitap";
            // 
            // lblToplamUye
            // 
            this.lblToplamUye.AutoSize = true;
            this.lblToplamUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUye.ForeColor = System.Drawing.Color.Navy;
            this.lblToplamUye.Location = new System.Drawing.Point(31, 56);
            this.lblToplamUye.Name = "lblToplamUye";
            this.lblToplamUye.Size = new System.Drawing.Size(128, 25);
            this.lblToplamUye.TabIndex = 8;
            this.lblToplamUye.Text = "Toplam Üye";
            // 
            // lblAktifEmanet
            // 
            this.lblAktifEmanet.AutoSize = true;
            this.lblAktifEmanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktifEmanet.ForeColor = System.Drawing.Color.Navy;
            this.lblAktifEmanet.Location = new System.Drawing.Point(329, 56);
            this.lblAktifEmanet.Name = "lblAktifEmanet";
            this.lblAktifEmanet.Size = new System.Drawing.Size(134, 25);
            this.lblAktifEmanet.TabIndex = 9;
            this.lblAktifEmanet.Text = "Aktif Emanet";
            // 
            // lblToplamYayinevi
            // 
            this.lblToplamYayinevi.AutoSize = true;
            this.lblToplamYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamYayinevi.ForeColor = System.Drawing.Color.Navy;
            this.lblToplamYayinevi.Location = new System.Drawing.Point(614, 56);
            this.lblToplamYayinevi.Name = "lblToplamYayinevi";
            this.lblToplamYayinevi.Size = new System.Drawing.Size(172, 25);
            this.lblToplamYayinevi.TabIndex = 10;
            this.lblToplamYayinevi.Text = "Toplam Yayinevi";
            // 
            // chartYazar
            // 
            this.chartYazar.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartYazar.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartYazar.Legends.Add(legend1);
            this.chartYazar.Location = new System.Drawing.Point(8, 84);
            this.chartYazar.Name = "chartYazar";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Transparent;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartYazar.Series.Add(series1);
            this.chartYazar.Size = new System.Drawing.Size(412, 340);
            this.chartYazar.TabIndex = 11;
            this.chartYazar.Text = "chart1";
            // 
            // chartYayinevi
            // 
            this.chartYayinevi.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartYayinevi.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            legend2.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartYayinevi.Legends.Add(legend2);
            this.chartYayinevi.Location = new System.Drawing.Point(428, 84);
            this.chartYayinevi.Name = "chartYayinevi";
            this.chartYayinevi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series2.BackSecondaryColor = System.Drawing.Color.Transparent;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.Transparent;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Transparent;
            series2.MarkerColor = System.Drawing.Color.Transparent;
            series2.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chartYayinevi.Series.Add(series2);
            this.chartYayinevi.Size = new System.Drawing.Size(412, 341);
            this.chartYayinevi.TabIndex = 12;
            this.chartYayinevi.Text = "chart1";
            // 
            // KontrolIstatistik
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.chartYayinevi);
            this.Controls.Add(this.chartYazar);
            this.Controls.Add(this.lblToplamYayinevi);
            this.Controls.Add(this.lblAktifEmanet);
            this.Controls.Add(this.lblToplamUye);
            this.Controls.Add(this.lblEmanetKitap);
            this.Controls.Add(this.lblMusaitKitap);
            this.Controls.Add(this.lblToplamKitap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.Name = "KontrolIstatistik";
            this.Size = new System.Drawing.Size(850, 436);
            this.Load += new System.EventHandler(this.KontrolIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartYazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartYayinevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblToplamKitap;
        private System.Windows.Forms.Label lblMusaitKitap;
        private System.Windows.Forms.Label lblEmanetKitap;
        private System.Windows.Forms.Label lblToplamUye;
        private System.Windows.Forms.Label lblAktifEmanet;
        private System.Windows.Forms.Label lblToplamYayinevi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYazar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYayinevi;
    }
}
