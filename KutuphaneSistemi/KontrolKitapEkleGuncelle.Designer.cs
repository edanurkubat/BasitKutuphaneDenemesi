namespace KutuphaneSistemi
{
    partial class KontrolKitapEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolKitapEkleGuncelle));
            this.dataGridViewKitap = new System.Windows.Forms.DataGridView();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblYayinevi = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.checkbTeslim = new System.Windows.Forms.CheckBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.cbYazar = new System.Windows.Forms.ComboBox();
            this.cbYayinevi = new System.Windows.Forms.ComboBox();
            this.nmrSayfa = new System.Windows.Forms.NumericUpDown();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbAd = new System.Windows.Forms.RichTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKitap
            // 
            this.dataGridViewKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitap.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewKitap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitap.Location = new System.Drawing.Point(290, 20);
            this.dataGridViewKitap.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKitap.Name = "dataGridViewKitap";
            this.dataGridViewKitap.RowHeadersWidth = 51;
            this.dataGridViewKitap.RowTemplate.Height = 24;
            this.dataGridViewKitap.Size = new System.Drawing.Size(546, 388);
            this.dataGridViewKitap.TabIndex = 31;
            this.dataGridViewKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitap_CellClick);
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.BackColor = System.Drawing.Color.Transparent;
            this.lblTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTur.Location = new System.Drawing.Point(65, 241);
            this.lblTur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(47, 22);
            this.lblTur.TabIndex = 30;
            this.lblTur.Text = "Tür:";
            // 
            // lblYayinevi
            // 
            this.lblYayinevi.AutoSize = true;
            this.lblYayinevi.BackColor = System.Drawing.Color.Transparent;
            this.lblYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayinevi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblYayinevi.Location = new System.Drawing.Point(21, 204);
            this.lblYayinevi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYayinevi.Name = "lblYayinevi";
            this.lblYayinevi.Size = new System.Drawing.Size(92, 22);
            this.lblYayinevi.TabIndex = 29;
            this.lblYayinevi.Text = "Yayınevi:";
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.BackColor = System.Drawing.Color.Transparent;
            this.lblSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSayfa.Location = new System.Drawing.Point(45, 167);
            this.lblSayfa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(67, 22);
            this.lblSayfa.TabIndex = 28;
            this.lblSayfa.Text = "Sayfa:";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.BackColor = System.Drawing.Color.Transparent;
            this.lblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblYazar.Location = new System.Drawing.Point(45, 130);
            this.lblYazar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(67, 22);
            this.lblYazar.TabIndex = 27;
            this.lblYazar.Text = "Yazar:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdi.Location = new System.Drawing.Point(15, 57);
            this.lblAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(97, 22);
            this.lblAdi.TabIndex = 26;
            this.lblAdi.Text = "Kitap Adı:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblID.Location = new System.Drawing.Point(26, 21);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(87, 22);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "Kitap ID:";
            // 
            // checkbTeslim
            // 
            this.checkbTeslim.AutoSize = true;
            this.checkbTeslim.BackColor = System.Drawing.Color.Transparent;
            this.checkbTeslim.Enabled = false;
            this.checkbTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkbTeslim.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkbTeslim.Location = new System.Drawing.Point(121, 274);
            this.checkbTeslim.Margin = new System.Windows.Forms.Padding(4);
            this.checkbTeslim.Name = "checkbTeslim";
            this.checkbTeslim.Size = new System.Drawing.Size(134, 26);
            this.checkbTeslim.TabIndex = 24;
            this.checkbTeslim.Text = "Teslim Edildi";
            this.checkbTeslim.UseVisualStyleBackColor = false;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(121, 23);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(134, 27);
            this.tbID.TabIndex = 18;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKaydet.Location = new System.Drawing.Point(30, 328);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 36);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.BackColor = System.Drawing.Color.Transparent;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDurum.Location = new System.Drawing.Point(39, 278);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(74, 22);
            this.lblDurum.TabIndex = 32;
            this.lblDurum.Text = "Durum:";
            // 
            // cbYazar
            // 
            this.cbYazar.DropDownHeight = 150;
            this.cbYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYazar.FormattingEnabled = true;
            this.cbYazar.IntegralHeight = false;
            this.cbYazar.Location = new System.Drawing.Point(121, 131);
            this.cbYazar.Name = "cbYazar";
            this.cbYazar.Size = new System.Drawing.Size(134, 28);
            this.cbYazar.TabIndex = 33;
            // 
            // cbYayinevi
            // 
            this.cbYayinevi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYayinevi.FormattingEnabled = true;
            this.cbYayinevi.Location = new System.Drawing.Point(121, 202);
            this.cbYayinevi.Name = "cbYayinevi";
            this.cbYayinevi.Size = new System.Drawing.Size(134, 28);
            this.cbYayinevi.TabIndex = 34;
            // 
            // nmrSayfa
            // 
            this.nmrSayfa.Location = new System.Drawing.Point(121, 167);
            this.nmrSayfa.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmrSayfa.Name = "nmrSayfa";
            this.nmrSayfa.Size = new System.Drawing.Size(134, 27);
            this.nmrSayfa.TabIndex = 35;
            // 
            // cbTur
            // 
            this.cbTur.DropDownHeight = 150;
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.DropDownWidth = 28;
            this.cbTur.FormattingEnabled = true;
            this.cbTur.IntegralHeight = false;
            this.cbTur.Items.AddRange(new object[] {
            "Roman",
            "Öykü / Hikaye",
            "Şiir",
            "Tiyatro / Oyun",
            "Deneme",
            "Makale",
            "Gezi yazısı",
            "Biyografi",
            "Otobiyografi",
            "Anı (Hatıra)",
            "Günlük",
            "Masal",
            "Fabl",
            "Destan"});
            this.cbTur.Location = new System.Drawing.Point(121, 238);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(134, 28);
            this.cbTur.TabIndex = 36;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuncelle.Location = new System.Drawing.Point(158, 328);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 36);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(121, 58);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(134, 65);
            this.tbAd.TabIndex = 38;
            this.tbAd.Text = "";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(95, 372);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(97, 36);
            this.btnTemizle.TabIndex = 39;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // KontrolKitapEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.nmrSayfa);
            this.Controls.Add(this.cbYayinevi);
            this.Controls.Add(this.cbYazar);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.dataGridViewKitap);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblYayinevi);
            this.Controls.Add(this.lblSayfa);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.checkbTeslim);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnKaydet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KontrolKitapEkleGuncelle";
            this.Size = new System.Drawing.Size(860, 428);
            this.Load += new System.EventHandler(this.KontrolKitapEkleGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKitap;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblYayinevi;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox checkbTeslim;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.ComboBox cbYazar;
        private System.Windows.Forms.ComboBox cbYayinevi;
        private System.Windows.Forms.NumericUpDown nmrSayfa;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.RichTextBox tbAd;
        private System.Windows.Forms.Button btnTemizle;
    }
}
