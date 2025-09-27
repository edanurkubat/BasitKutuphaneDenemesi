namespace KutuphaneSistemi
{
    partial class KontrolListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolListele));
            this.dataGridViewKitap = new System.Windows.Forms.DataGridView();
            this.cbYazar = new System.Windows.Forms.ComboBox();
            this.cbYayinevi = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.tbKitapAdi = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.btnYayinevi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitap)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKitap
            // 
            this.dataGridViewKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitap.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewKitap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitap.Location = new System.Drawing.Point(9, 114);
            this.dataGridViewKitap.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKitap.Name = "dataGridViewKitap";
            this.dataGridViewKitap.RowHeadersWidth = 51;
            this.dataGridViewKitap.RowTemplate.Height = 24;
            this.dataGridViewKitap.Size = new System.Drawing.Size(831, 311);
            this.dataGridViewKitap.TabIndex = 0;
            // 
            // cbYazar
            // 
            this.cbYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYazar.FormattingEnabled = true;
            this.cbYazar.Location = new System.Drawing.Point(105, 16);
            this.cbYazar.Margin = new System.Windows.Forms.Padding(4);
            this.cbYazar.Name = "cbYazar";
            this.cbYazar.Size = new System.Drawing.Size(233, 28);
            this.cbYazar.TabIndex = 1;
            // 
            // cbYayinevi
            // 
            this.cbYayinevi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYayinevi.FormattingEnabled = true;
            this.cbYayinevi.Location = new System.Drawing.Point(446, 17);
            this.cbYayinevi.Margin = new System.Windows.Forms.Padding(4);
            this.cbYayinevi.Name = "cbYayinevi";
            this.cbYayinevi.Size = new System.Drawing.Size(136, 28);
            this.cbYayinevi.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Transparent;
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(793, 33);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(42, 38);
            this.btnAra.TabIndex = 3;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // tbKitapAdi
            // 
            this.tbKitapAdi.Location = new System.Drawing.Point(105, 56);
            this.tbKitapAdi.Name = "tbKitapAdi";
            this.tbKitapAdi.Size = new System.Drawing.Size(670, 27);
            this.tbKitapAdi.TabIndex = 4;
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.BackColor = System.Drawing.Color.Transparent;
            this.lblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.ForeColor = System.Drawing.Color.Navy;
            this.lblYazar.Location = new System.Drawing.Point(38, 17);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(61, 22);
            this.lblYazar.TabIndex = 5;
            this.lblYazar.Text = "Yazar:";
            // 
            // btnYayinevi
            // 
            this.btnYayinevi.AutoSize = true;
            this.btnYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayinevi.ForeColor = System.Drawing.Color.Navy;
            this.btnYayinevi.Location = new System.Drawing.Point(345, 18);
            this.btnYayinevi.Name = "btnYayinevi";
            this.btnYayinevi.Size = new System.Drawing.Size(83, 22);
            this.btnYayinevi.TabIndex = 6;
            this.btnYayinevi.Text = "Yayınevi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitap Adı:";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.ForeColor = System.Drawing.Color.Navy;
            this.lblTur.Location = new System.Drawing.Point(589, 18);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(43, 22);
            this.lblTur.TabIndex = 9;
            this.lblTur.Text = "Tür:";
            // 
            // cbTur
            // 
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.FormattingEnabled = true;
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
            this.cbTur.Location = new System.Drawing.Point(639, 17);
            this.cbTur.Margin = new System.Windows.Forms.Padding(4);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(136, 28);
            this.cbTur.TabIndex = 8;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temizleToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 68);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // KontrolListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYayinevi);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.tbKitapAdi);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cbYayinevi);
            this.Controls.Add(this.cbYazar);
            this.Controls.Add(this.dataGridViewKitap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KontrolListele";
            this.Size = new System.Drawing.Size(850, 436);
            this.Load += new System.EventHandler(this.KontrolListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitap)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKitap;
        private System.Windows.Forms.ComboBox cbYazar;
        private System.Windows.Forms.ComboBox cbYayinevi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox tbKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label btnYayinevi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}
