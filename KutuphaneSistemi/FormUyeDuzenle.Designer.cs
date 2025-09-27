namespace KutuphaneSistemi
{
    partial class FormUyeDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeDuzenle));
            this.dataGridViewUyeler = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbKullanici = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSifreyiGoster = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyeler)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUyeler
            // 
            this.dataGridViewUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUyeler.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewUyeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUyeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewUyeler.Location = new System.Drawing.Point(0, 155);
            this.dataGridViewUyeler.Name = "dataGridViewUyeler";
            this.dataGridViewUyeler.RowHeadersWidth = 51;
            this.dataGridViewUyeler.RowTemplate.Height = 24;
            this.dataGridViewUyeler.Size = new System.Drawing.Size(406, 267);
            this.dataGridViewUyeler.TabIndex = 0;
            this.dataGridViewUyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUyeler_CellClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblID.Location = new System.Drawing.Point(54, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(69, 22);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Uye ID:";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblKullanici.Location = new System.Drawing.Point(10, 65);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(113, 22);
            this.lblKullanici.TabIndex = 2;
            this.lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSifre.Location = new System.Drawing.Point(71, 97);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(52, 22);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre:";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(129, 33);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(138, 22);
            this.tbID.TabIndex = 4;
            // 
            // tbKullanici
            // 
            this.tbKullanici.Location = new System.Drawing.Point(129, 65);
            this.tbKullanici.Name = "tbKullanici";
            this.tbKullanici.Size = new System.Drawing.Size(138, 22);
            this.tbKullanici.TabIndex = 1;
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(129, 97);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(138, 22);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.Location = new System.Drawing.Point(355, 80);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(38, 39);
            this.btnTemizle.TabIndex = 42;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
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
            this.btnGuncelle.Location = new System.Drawing.Point(287, 80);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(38, 39);
            this.btnGuncelle.TabIndex = 41;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.btnKaydet.Location = new System.Drawing.Point(321, 23);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(38, 39);
            this.btnKaydet.TabIndex = 40;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temizleToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(142, 34);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // cbSifreyiGoster
            // 
            this.cbSifreyiGoster.AutoSize = true;
            this.cbSifreyiGoster.BackColor = System.Drawing.Color.Transparent;
            this.cbSifreyiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSifreyiGoster.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbSifreyiGoster.Location = new System.Drawing.Point(129, 125);
            this.cbSifreyiGoster.Name = "cbSifreyiGoster";
            this.cbSifreyiGoster.Size = new System.Drawing.Size(120, 22);
            this.cbSifreyiGoster.TabIndex = 3;
            this.cbSifreyiGoster.Text = "Şifreyi Göster";
            this.cbSifreyiGoster.UseVisualStyleBackColor = false;
            this.cbSifreyiGoster.CheckedChanged += new System.EventHandler(this.cbSifreyiGoster_CheckedChanged);
            // 
            // FormUyeDuzenle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 422);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.cbSifreyiGoster);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbKullanici);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridViewUyeler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUyeDuzenle";
            this.Text = "Üyeleri Düzenle";
            this.Load += new System.EventHandler(this.FormUyeDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyeler)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUyeler;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbKullanici;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbSifreyiGoster;
    }
}