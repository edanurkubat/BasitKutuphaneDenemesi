namespace KutuphaneSistemi
{
    partial class FormUyeOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeOl));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbKullanici = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.cbSifreyiGoster = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(92, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(161, 217);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(146, 30);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // tbKullanici
            // 
            this.tbKullanici.Location = new System.Drawing.Point(161, 166);
            this.tbKullanici.Name = "tbKullanici";
            this.tbKullanici.Size = new System.Drawing.Size(146, 30);
            this.tbKullanici.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.Color.Transparent;
            this.btnUyeOl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUyeOl.BackgroundImage")));
            this.btnUyeOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUyeOl.FlatAppearance.BorderSize = 0;
            this.btnUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeOl.Location = new System.Drawing.Point(115, 302);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(138, 39);
            this.btnUyeOl.TabIndex = 4;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Location = new System.Drawing.Point(1, 1);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(40, 43);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // cbSifreyiGoster
            // 
            this.cbSifreyiGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSifreyiGoster.AutoSize = true;
            this.cbSifreyiGoster.BackColor = System.Drawing.Color.Transparent;
            this.cbSifreyiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSifreyiGoster.Location = new System.Drawing.Point(161, 265);
            this.cbSifreyiGoster.Name = "cbSifreyiGoster";
            this.cbSifreyiGoster.Size = new System.Drawing.Size(120, 22);
            this.cbSifreyiGoster.TabIndex = 3;
            this.cbSifreyiGoster.Text = "Şifreyi Göster";
            this.cbSifreyiGoster.UseVisualStyleBackColor = false;
            this.cbSifreyiGoster.CheckedChanged += new System.EventHandler(this.cbSifreyiGoster_CheckedChanged);
            // 
            // FormUyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 402);
            this.Controls.Add(this.cbSifreyiGoster);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbKullanici);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUyeOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye Ol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbKullanici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.CheckBox cbSifreyiGoster;
    }
}