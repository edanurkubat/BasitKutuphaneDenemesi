namespace KutuphaneSistemi
{
    partial class KontrolKitapSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolKitapSil));
            this.tbAd = new System.Windows.Forms.RichTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.nmrSayfa = new System.Windows.Forms.NumericUpDown();
            this.cbYayinevi = new System.Windows.Forms.ComboBox();
            this.cbYazar = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.dataGridViewKitap = new System.Windows.Forms.DataGridView();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblYayinevi = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.checkbTeslim = new System.Windows.Forms.CheckBox();
            this.tbID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAd
            // 
            this.tbAd.Enabled = false;
            this.tbAd.Location = new System.Drawing.Point(141, 65);
            this.tbAd.Margin = new System.Windows.Forms.Padding(4);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(166, 80);
            this.tbAd.TabIndex = 56;
            this.tbAd.Text = "";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSil.Location = new System.Drawing.Point(165, 381);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(41, 36);
            this.btnSil.TabIndex = 55;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbTur
            // 
            this.cbTur.DropDownHeight = 150;
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.DropDownWidth = 28;
            this.cbTur.Enabled = false;
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
            this.cbTur.Location = new System.Drawing.Point(141, 290);
            this.cbTur.Margin = new System.Windows.Forms.Padding(4);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(166, 28);
            this.cbTur.TabIndex = 54;
            // 
            // nmrSayfa
            // 
            this.nmrSayfa.Enabled = false;
            this.nmrSayfa.Location = new System.Drawing.Point(141, 201);
            this.nmrSayfa.Margin = new System.Windows.Forms.Padding(4);
            this.nmrSayfa.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmrSayfa.Name = "nmrSayfa";
            this.nmrSayfa.Size = new System.Drawing.Size(168, 27);
            this.nmrSayfa.TabIndex = 53;
            // 
            // cbYayinevi
            // 
            this.cbYayinevi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYayinevi.Enabled = false;
            this.cbYayinevi.FormattingEnabled = true;
            this.cbYayinevi.Location = new System.Drawing.Point(141, 245);
            this.cbYayinevi.Margin = new System.Windows.Forms.Padding(4);
            this.cbYayinevi.Name = "cbYayinevi";
            this.cbYayinevi.Size = new System.Drawing.Size(166, 28);
            this.cbYayinevi.TabIndex = 52;
            // 
            // cbYazar
            // 
            this.cbYazar.DropDownHeight = 150;
            this.cbYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYazar.Enabled = false;
            this.cbYazar.FormattingEnabled = true;
            this.cbYazar.IntegralHeight = false;
            this.cbYazar.Location = new System.Drawing.Point(141, 156);
            this.cbYazar.Margin = new System.Windows.Forms.Padding(4);
            this.cbYazar.Name = "cbYazar";
            this.cbYazar.Size = new System.Drawing.Size(166, 28);
            this.cbYazar.TabIndex = 51;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.BackColor = System.Drawing.Color.Transparent;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDurum.Location = new System.Drawing.Point(58, 341);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(74, 22);
            this.lblDurum.TabIndex = 50;
            this.lblDurum.Text = "Durum:";
            // 
            // dataGridViewKitap
            // 
            this.dataGridViewKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitap.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewKitap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitap.Location = new System.Drawing.Point(343, 18);
            this.dataGridViewKitap.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewKitap.Name = "dataGridViewKitap";
            this.dataGridViewKitap.RowHeadersWidth = 51;
            this.dataGridViewKitap.RowTemplate.Height = 24;
            this.dataGridViewKitap.Size = new System.Drawing.Size(490, 399);
            this.dataGridViewKitap.TabIndex = 49;
            this.dataGridViewKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitap_CellClick);
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.BackColor = System.Drawing.Color.Transparent;
            this.lblTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTur.Location = new System.Drawing.Point(85, 295);
            this.lblTur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(47, 22);
            this.lblTur.TabIndex = 48;
            this.lblTur.Text = "Tür:";
            // 
            // lblYayinevi
            // 
            this.lblYayinevi.AutoSize = true;
            this.lblYayinevi.BackColor = System.Drawing.Color.Transparent;
            this.lblYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYayinevi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblYayinevi.Location = new System.Drawing.Point(40, 249);
            this.lblYayinevi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYayinevi.Name = "lblYayinevi";
            this.lblYayinevi.Size = new System.Drawing.Size(92, 22);
            this.lblYayinevi.TabIndex = 47;
            this.lblYayinevi.Text = "Yayınevi:";
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.BackColor = System.Drawing.Color.Transparent;
            this.lblSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSayfa.Location = new System.Drawing.Point(65, 202);
            this.lblSayfa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(67, 22);
            this.lblSayfa.TabIndex = 46;
            this.lblSayfa.Text = "Sayfa:";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.BackColor = System.Drawing.Color.Transparent;
            this.lblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblYazar.Location = new System.Drawing.Point(65, 156);
            this.lblYazar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(67, 22);
            this.lblYazar.TabIndex = 45;
            this.lblYazar.Text = "Yazar:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdi.Location = new System.Drawing.Point(35, 65);
            this.lblAdi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(97, 22);
            this.lblAdi.TabIndex = 44;
            this.lblAdi.Text = "Kitap Adı:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblID.Location = new System.Drawing.Point(45, 20);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(87, 22);
            this.lblID.TabIndex = 43;
            this.lblID.Text = "Kitap ID:";
            // 
            // checkbTeslim
            // 
            this.checkbTeslim.AutoSize = true;
            this.checkbTeslim.BackColor = System.Drawing.Color.Transparent;
            this.checkbTeslim.Enabled = false;
            this.checkbTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkbTeslim.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkbTeslim.Location = new System.Drawing.Point(141, 337);
            this.checkbTeslim.Margin = new System.Windows.Forms.Padding(5);
            this.checkbTeslim.Name = "checkbTeslim";
            this.checkbTeslim.Size = new System.Drawing.Size(134, 26);
            this.checkbTeslim.TabIndex = 42;
            this.checkbTeslim.Text = "Teslim Edildi";
            this.checkbTeslim.UseVisualStyleBackColor = false;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(141, 18);
            this.tbID.Margin = new System.Windows.Forms.Padding(5);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(166, 27);
            this.tbID.TabIndex = 41;
            // 
            // KontrolKitapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.btnSil);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KontrolKitapSil";
            this.Size = new System.Drawing.Size(850, 436);
            this.Load += new System.EventHandler(this.KontrolKitapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tbAd;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.NumericUpDown nmrSayfa;
        private System.Windows.Forms.ComboBox cbYayinevi;
        private System.Windows.Forms.ComboBox cbYazar;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.DataGridView dataGridViewKitap;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblYayinevi;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox checkbTeslim;
        private System.Windows.Forms.TextBox tbID;
    }
}
