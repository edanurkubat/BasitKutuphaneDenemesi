namespace KutuphaneSistemi
{
    partial class FormGiris
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbKullanici = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbKod = new System.Windows.Forms.TextBox();
            this.tbOlusanKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.lblKod = new System.Windows.Forms.Label();
            this.cbSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.libklblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbKullanici
            // 
            this.tbKullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbKullanici.Location = new System.Drawing.Point(148, 188);
            this.tbKullanici.Name = "tbKullanici";
            this.tbKullanici.Size = new System.Drawing.Size(180, 30);
            this.tbKullanici.TabIndex = 1;
            // 
            // tbSifre
            // 
            this.tbSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSifre.Location = new System.Drawing.Point(148, 229);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(180, 30);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // tbKod
            // 
            this.tbKod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbKod.Location = new System.Drawing.Point(148, 303);
            this.tbKod.Name = "tbKod";
            this.tbKod.Size = new System.Drawing.Size(87, 30);
            this.tbKod.TabIndex = 4;
            // 
            // tbOlusanKod
            // 
            this.tbOlusanKod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOlusanKod.Enabled = false;
            this.tbOlusanKod.Location = new System.Drawing.Point(241, 303);
            this.tbOlusanKod.Name = "tbOlusanKod";
            this.tbOlusanKod.Size = new System.Drawing.Size(87, 30);
            this.tbOlusanKod.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(29, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(90, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiris.BackgroundImage")));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGiris.Location = new System.Drawing.Point(81, 393);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(105, 34);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUyeOl.BackColor = System.Drawing.Color.Transparent;
            this.btnUyeOl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUyeOl.BackgroundImage")));
            this.btnUyeOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUyeOl.FlatAppearance.BorderSize = 0;
            this.btnUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeOl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUyeOl.Location = new System.Drawing.Point(205, 393);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(105, 34);
            this.btnUyeOl.TabIndex = 7;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // lblKod
            // 
            this.lblKod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKod.AutoSize = true;
            this.lblKod.BackColor = System.Drawing.Color.Transparent;
            this.lblKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblKod.Location = new System.Drawing.Point(64, 309);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(78, 20);
            this.lblKod.TabIndex = 9;
            this.lblKod.Text = "Güvenlik:";
            // 
            // cbSifreyiGoster
            // 
            this.cbSifreyiGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSifreyiGoster.AutoSize = true;
            this.cbSifreyiGoster.BackColor = System.Drawing.Color.Transparent;
            this.cbSifreyiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSifreyiGoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cbSifreyiGoster.Location = new System.Drawing.Point(148, 270);
            this.cbSifreyiGoster.Name = "cbSifreyiGoster";
            this.cbSifreyiGoster.Size = new System.Drawing.Size(120, 22);
            this.cbSifreyiGoster.TabIndex = 3;
            this.cbSifreyiGoster.Text = "Şifreyi Göster";
            this.cbSifreyiGoster.UseVisualStyleBackColor = false;
            this.cbSifreyiGoster.CheckedChanged += new System.EventHandler(this.cbSifreyiGoster_CheckedChanged);
            // 
            // libklblSifremiUnuttum
            // 
            this.libklblSifremiUnuttum.AutoSize = true;
            this.libklblSifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.libklblSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.libklblSifremiUnuttum.LinkColor = System.Drawing.Color.ForestGreen;
            this.libklblSifremiUnuttum.Location = new System.Drawing.Point(145, 345);
            this.libklblSifremiUnuttum.Name = "libklblSifremiUnuttum";
            this.libklblSifremiUnuttum.Size = new System.Drawing.Size(114, 18);
            this.libklblSifremiUnuttum.TabIndex = 5;
            this.libklblSifremiUnuttum.TabStop = true;
            this.libklblSifremiUnuttum.Text = "Şifremi Unuttum";
            this.libklblSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.libklblSifremiUnuttum_LinkClicked);
            // 
            // FormGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 455);
            this.Controls.Add(this.libklblSifremiUnuttum);
            this.Controls.Add(this.cbSifreyiGoster);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOlusanKod);
            this.Controls.Add(this.tbKod);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbKullanici);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sisteme Giriş";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbKullanici;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbKod;
        private System.Windows.Forms.TextBox tbOlusanKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.CheckBox cbSifreyiGoster;
        private System.Windows.Forms.LinkLabel libklblSifremiUnuttum;
    }
}

