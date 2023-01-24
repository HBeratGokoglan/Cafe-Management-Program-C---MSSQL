namespace KafeProje
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.f1TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.f1TxtSifre = new System.Windows.Forms.TextBox();
            this.f1BtnPersonel = new System.Windows.Forms.Button();
            this.f1lbKullaniciAdi = new System.Windows.Forms.Label();
            this.f1lbSifre = new System.Windows.Forms.Label();
            this.f1BtnAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.f1LbCikis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // f1TxtKullaniciAdi
            // 
            this.f1TxtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f1TxtKullaniciAdi.Location = new System.Drawing.Point(119, 149);
            this.f1TxtKullaniciAdi.Name = "f1TxtKullaniciAdi";
            this.f1TxtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.f1TxtKullaniciAdi.TabIndex = 0;
            // 
            // f1TxtSifre
            // 
            this.f1TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f1TxtSifre.Location = new System.Drawing.Point(119, 186);
            this.f1TxtSifre.Name = "f1TxtSifre";
            this.f1TxtSifre.Size = new System.Drawing.Size(100, 20);
            this.f1TxtSifre.TabIndex = 1;
            this.f1TxtSifre.UseSystemPasswordChar = true;
            // 
            // f1BtnPersonel
            // 
            this.f1BtnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f1BtnPersonel.Location = new System.Drawing.Point(132, 242);
            this.f1BtnPersonel.Name = "f1BtnPersonel";
            this.f1BtnPersonel.Size = new System.Drawing.Size(98, 24);
            this.f1BtnPersonel.TabIndex = 2;
            this.f1BtnPersonel.Text = "Personel Girişi";
            this.f1BtnPersonel.UseVisualStyleBackColor = true;
            this.f1BtnPersonel.Click += new System.EventHandler(this.f1BtnPersonel_Click);
            // 
            // f1lbKullaniciAdi
            // 
            this.f1lbKullaniciAdi.AutoSize = true;
            this.f1lbKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f1lbKullaniciAdi.Location = new System.Drawing.Point(11, 152);
            this.f1lbKullaniciAdi.Name = "f1lbKullaniciAdi";
            this.f1lbKullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.f1lbKullaniciAdi.TabIndex = 3;
            this.f1lbKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // f1lbSifre
            // 
            this.f1lbSifre.AutoSize = true;
            this.f1lbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f1lbSifre.Location = new System.Drawing.Point(12, 189);
            this.f1lbSifre.Name = "f1lbSifre";
            this.f1lbSifre.Size = new System.Drawing.Size(31, 13);
            this.f1lbSifre.TabIndex = 4;
            this.f1lbSifre.Text = "Şifre:";
            // 
            // f1BtnAdmin
            // 
            this.f1BtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f1BtnAdmin.Location = new System.Drawing.Point(15, 243);
            this.f1BtnAdmin.Name = "f1BtnAdmin";
            this.f1BtnAdmin.Size = new System.Drawing.Size(85, 23);
            this.f1BtnAdmin.TabIndex = 5;
            this.f1BtnAdmin.Text = "Yönetici Girişi";
            this.f1BtnAdmin.UseVisualStyleBackColor = true;
            this.f1BtnAdmin.Click += new System.EventHandler(this.f1BtnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.f1LbCikis);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Harlow Solid Italic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(261, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 324);
            this.panel1.TabIndex = 6;
            // 
            // f1LbCikis
            // 
            this.f1LbCikis.AutoSize = true;
            this.f1LbCikis.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1LbCikis.Location = new System.Drawing.Point(311, 9);
            this.f1LbCikis.Name = "f1LbCikis";
            this.f1LbCikis.Size = new System.Drawing.Size(24, 14);
            this.f1LbCikis.TabIndex = 7;
            this.f1LbCikis.Text = "X";
            this.f1LbCikis.Click += new System.EventHandler(this.f1LbCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-23, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(328, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 136);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.f1BtnAdmin);
            this.Controls.Add(this.f1lbSifre);
            this.Controls.Add(this.f1lbKullaniciAdi);
            this.Controls.Add(this.f1BtnPersonel);
            this.Controls.Add(this.f1TxtSifre);
            this.Controls.Add(this.f1TxtKullaniciAdi);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Yönetim ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f1TxtKullaniciAdi;
        private System.Windows.Forms.TextBox f1TxtSifre;
        private System.Windows.Forms.Button f1BtnPersonel;
        private System.Windows.Forms.Label f1lbKullaniciAdi;
        private System.Windows.Forms.Label f1lbSifre;
        private System.Windows.Forms.Button f1BtnAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label f1LbCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}

