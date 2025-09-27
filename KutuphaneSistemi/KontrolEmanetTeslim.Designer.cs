namespace KutuphaneSistemi
{
    partial class KontrolEmanetTeslim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontrolEmanetTeslim));
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dataGridViewEmanet = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbKitap = new System.Windows.Forms.ComboBox();
            this.cbUye = new System.Windows.Forms.ComboBox();
            this.lblTeslim = new System.Windows.Forms.Label();
            this.lblAlis = new System.Windows.Forms.Label();
            this.lblKitap = new System.Windows.Forms.Label();
            this.lblUye = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dtpTeslim = new System.Windows.Forms.DateTimePicker();
            this.dtpEkle = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).BeginInit();
            this.SuspendLayout();
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
            this.btnTemizle.Location = new System.Drawing.Point(126, 359);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(146, 42);
            this.btnTemizle.TabIndex = 53;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dataGridViewEmanet
            // 
            this.dataGridViewEmanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmanet.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmanet.Location = new System.Drawing.Point(352, 15);
            this.dataGridViewEmanet.Name = "dataGridViewEmanet";
            this.dataGridViewEmanet.RowHeadersWidth = 51;
            this.dataGridViewEmanet.RowTemplate.Height = 24;
            this.dataGridViewEmanet.Size = new System.Drawing.Size(474, 407);
            this.dataGridViewEmanet.TabIndex = 52;
            this.dataGridViewEmanet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmanet_CellContentClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEkle.Location = new System.Drawing.Point(126, 294);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(146, 42);
            this.btnEkle.TabIndex = 51;
            this.btnEkle.Text = "Emanet Teslim";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(116, 59);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(200, 28);
            this.tbID.TabIndex = 50;
            // 
            // cbKitap
            // 
            this.cbKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitap.Enabled = false;
            this.cbKitap.FormattingEnabled = true;
            this.cbKitap.Location = new System.Drawing.Point(116, 145);
            this.cbKitap.Name = "cbKitap";
            this.cbKitap.Size = new System.Drawing.Size(200, 30);
            this.cbKitap.TabIndex = 49;
            // 
            // cbUye
            // 
            this.cbUye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUye.Enabled = false;
            this.cbUye.FormattingEnabled = true;
            this.cbUye.Location = new System.Drawing.Point(116, 101);
            this.cbUye.Name = "cbUye";
            this.cbUye.Size = new System.Drawing.Size(200, 30);
            this.cbUye.TabIndex = 48;
            // 
            // lblTeslim
            // 
            this.lblTeslim.AutoSize = true;
            this.lblTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeslim.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTeslim.Location = new System.Drawing.Point(35, 231);
            this.lblTeslim.Name = "lblTeslim";
            this.lblTeslim.Size = new System.Drawing.Size(75, 22);
            this.lblTeslim.TabIndex = 47;
            this.lblTeslim.Text = "Teslim:";
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAlis.Location = new System.Drawing.Point(61, 189);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(49, 22);
            this.lblAlis.TabIndex = 46;
            this.lblAlis.Text = "Alış:";
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitap.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblKitap.Location = new System.Drawing.Point(48, 147);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(62, 22);
            this.lblKitap.TabIndex = 45;
            this.lblKitap.Text = "Kitap:";
            // 
            // lblUye
            // 
            this.lblUye.AutoSize = true;
            this.lblUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUye.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUye.Location = new System.Drawing.Point(59, 105);
            this.lblUye.Name = "lblUye";
            this.lblUye.Size = new System.Drawing.Size(51, 22);
            this.lblUye.TabIndex = 44;
            this.lblUye.Text = "Üye:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblID.Location = new System.Drawing.Point(75, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 22);
            this.lblID.TabIndex = 43;
            this.lblID.Text = "ID:";
            // 
            // dtpTeslim
            // 
            this.dtpTeslim.Location = new System.Drawing.Point(116, 231);
            this.dtpTeslim.Name = "dtpTeslim";
            this.dtpTeslim.Size = new System.Drawing.Size(200, 28);
            this.dtpTeslim.TabIndex = 42;
            // 
            // dtpEkle
            // 
            this.dtpEkle.Enabled = false;
            this.dtpEkle.Location = new System.Drawing.Point(116, 189);
            this.dtpEkle.Name = "dtpEkle";
            this.dtpEkle.Size = new System.Drawing.Size(200, 28);
            this.dtpEkle.TabIndex = 41;
            // 
            // KontrolEmanetTeslim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dataGridViewEmanet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.cbKitap);
            this.Controls.Add(this.cbUye);
            this.Controls.Add(this.lblTeslim);
            this.Controls.Add(this.lblAlis);
            this.Controls.Add(this.lblKitap);
            this.Controls.Add(this.lblUye);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dtpTeslim);
            this.Controls.Add(this.dtpEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "KontrolEmanetTeslim";
            this.Size = new System.Drawing.Size(850, 436);
            this.Load += new System.EventHandler(this.KontrolEmanetTeslim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dataGridViewEmanet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbKitap;
        private System.Windows.Forms.ComboBox cbUye;
        private System.Windows.Forms.Label lblTeslim;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Label lblUye;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtpTeslim;
        private System.Windows.Forms.DateTimePicker dtpEkle;
    }
}
