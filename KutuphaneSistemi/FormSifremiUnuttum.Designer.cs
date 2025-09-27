namespace KutuphaneSistemi
{
    partial class FormSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSifremiUnuttum));
            this.lblKullanici = new System.Windows.Forms.Label();
            this.tbKullanici = new System.Windows.Forms.TextBox();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.tbSifreTekrarla = new System.Windows.Forms.TextBox();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.btnSifreYenile = new System.Windows.Forms.Button();
            this.cbSifreyiGoster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(65, 47);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(106, 20);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // tbKullanici
            // 
            this.tbKullanici.Location = new System.Drawing.Point(198, 44);
            this.tbKullanici.Name = "tbKullanici";
            this.tbKullanici.Size = new System.Drawing.Size(124, 27);
            this.tbKullanici.TabIndex = 1;
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(198, 87);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(124, 27);
            this.tbSifre.TabIndex = 2;
            this.tbSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(122, 90);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(49, 20);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // tbSifreTekrarla
            // 
            this.tbSifreTekrarla.Location = new System.Drawing.Point(198, 130);
            this.tbSifreTekrarla.Name = "tbSifreTekrarla";
            this.tbSifreTekrarla.Size = new System.Drawing.Size(124, 27);
            this.tbSifreTekrarla.TabIndex = 3;
            this.tbSifreTekrarla.UseSystemPasswordChar = true;
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.AutoSize = true;
            this.lblSifreTekrar.BackColor = System.Drawing.Color.Transparent;
            this.lblSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreTekrar.Location = new System.Drawing.Point(48, 133);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(127, 20);
            this.lblSifreTekrar.TabIndex = 4;
            this.lblSifreTekrar.Text = "Şifreyi Tekrarla:";
            // 
            // btnSifreYenile
            // 
            this.btnSifreYenile.BackColor = System.Drawing.Color.Transparent;
            this.btnSifreYenile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSifreYenile.BackgroundImage")));
            this.btnSifreYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifreYenile.FlatAppearance.BorderSize = 0;
            this.btnSifreYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreYenile.Location = new System.Drawing.Point(126, 203);
            this.btnSifreYenile.Name = "btnSifreYenile";
            this.btnSifreYenile.Size = new System.Drawing.Size(127, 33);
            this.btnSifreYenile.TabIndex = 5;
            this.btnSifreYenile.Text = "Şifremi Yenile";
            this.btnSifreYenile.UseVisualStyleBackColor = false;
            this.btnSifreYenile.Click += new System.EventHandler(this.btnSifreYenile_Click);
            // 
            // cbSifreyiGoster
            // 
            this.cbSifreyiGoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSifreyiGoster.AutoSize = true;
            this.cbSifreyiGoster.BackColor = System.Drawing.Color.Transparent;
            this.cbSifreyiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSifreyiGoster.Location = new System.Drawing.Point(198, 175);
            this.cbSifreyiGoster.Name = "cbSifreyiGoster";
            this.cbSifreyiGoster.Size = new System.Drawing.Size(120, 22);
            this.cbSifreyiGoster.TabIndex = 4;
            this.cbSifreyiGoster.Text = "Şifreyi Göster";
            this.cbSifreyiGoster.UseVisualStyleBackColor = false;
            this.cbSifreyiGoster.CheckedChanged += new System.EventHandler(this.cbSifreyiGoster_CheckedChanged);
            // 
            // FormSifremiUnuttum
            // 
            this.AcceptButton = this.btnSifreYenile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 272);
            this.Controls.Add(this.cbSifreyiGoster);
            this.Controls.Add(this.btnSifreYenile);
            this.Controls.Add(this.tbSifreTekrarla);
            this.Controls.Add(this.lblSifreTekrar);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.tbKullanici);
            this.Controls.Add(this.lblKullanici);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Yenileme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox tbKullanici;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox tbSifreTekrarla;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.Button btnSifreYenile;
        private System.Windows.Forms.CheckBox cbSifreyiGoster;
    }
}