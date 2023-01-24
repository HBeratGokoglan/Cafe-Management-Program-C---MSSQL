namespace KafeProje
{
    partial class SiparisYonetimEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisYonetimEkranı));
            this.ıcecekTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeDBDataSet = new KafeProje.ProjeDBDataSet();
            this.yiyecekTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.icecekTbTableAdapter = new KafeProje.ProjeDBDataSetTableAdapters.IcecekTbTableAdapter();
            this.yiyecekTbTableAdapter = new KafeProje.ProjeDBDataSetTableAdapters.YiyecekTbTableAdapter();
            this.f2LbKapat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.f2LBoxUrun = new System.Windows.Forms.ListBox();
            this.f2BtnTemizle = new System.Windows.Forms.Button();
            this.f2BtnHesapla = new System.Windows.Forms.Button();
            this.f2BtnCikart = new System.Windows.Forms.Button();
            this.f2LBoxFiyat = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.YiyecekFiyati = new System.Windows.Forms.TextBox();
            this.f2CbMenu = new System.Windows.Forms.ComboBox();
            this.f2BtnSiparisEkle = new System.Windows.Forms.Button();
            this.YiyecekAdi = new System.Windows.Forms.TextBox();
            this.IcecekFiyati = new System.Windows.Forms.TextBox();
            this.f2LbCikisYap = new System.Windows.Forms.Label();
            this.IcecekAdi = new System.Windows.Forms.TextBox();
            this.f2DgvMenu = new System.Windows.Forms.DataGridView();
            this.urunIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f2LbUrun = new System.Windows.Forms.Label();
            this.f2LbFiyat = new System.Windows.Forms.Label();
            this.f2BtnAdisyonBastir = new System.Windows.Forms.Button();
            this.f2CbMasa = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.urunIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f2LbToplamTutar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.f2AdisyonMasaAdi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.f2LBoxAdisyonFiyat = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.f2LbAdisyonCikis = new System.Windows.Forms.Label();
            this.f2LbAdisyonToplamTutar = new System.Windows.Forms.Label();
            this.f2LBoxAdisyonUrun = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.f3LbTarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ıcecekTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyecekTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2DgvMenu)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ıcecekTbBindingSource
            // 
            this.ıcecekTbBindingSource.DataMember = "IcecekTb";
            this.ıcecekTbBindingSource.DataSource = this.projeDBDataSet;
            // 
            // projeDBDataSet
            // 
            this.projeDBDataSet.DataSetName = "ProjeDBDataSet";
            this.projeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yiyecekTbBindingSource
            // 
            this.yiyecekTbBindingSource.DataMember = "YiyecekTb";
            this.yiyecekTbBindingSource.DataSource = this.projeDBDataSet;
            // 
            // icecekTbTableAdapter
            // 
            this.icecekTbTableAdapter.ClearBeforeFill = true;
            // 
            // yiyecekTbTableAdapter
            // 
            this.yiyecekTbTableAdapter.ClearBeforeFill = true;
            // 
            // f2LbKapat
            // 
            this.f2LbKapat.AutoSize = true;
            this.f2LbKapat.BackColor = System.Drawing.Color.White;
            this.f2LbKapat.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2LbKapat.Location = new System.Drawing.Point(743, 9);
            this.f2LbKapat.Name = "f2LbKapat";
            this.f2LbKapat.Size = new System.Drawing.Size(24, 14);
            this.f2LbKapat.TabIndex = 20;
            this.f2LbKapat.Text = "X";
            this.f2LbKapat.Click += new System.EventHandler(this.f2LbKapat_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KafeProje.Properties.Resources.Üniversite_Futbol_Lig_Poster11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 609);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KafeProje.Properties.Resources.Üniversite_Futbol_Lig_Poster11;
            this.pictureBox2.Location = new System.Drawing.Point(626, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(627, 609);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(33, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 78);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::KafeProje.Properties.Resources.zyro_image__2_;
            this.pictureBox3.Location = new System.Drawing.Point(-3, -40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(306, 147);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // f2LBoxUrun
            // 
            this.f2LBoxUrun.FormattingEnabled = true;
            this.f2LBoxUrun.Location = new System.Drawing.Point(442, 142);
            this.f2LBoxUrun.Name = "f2LBoxUrun";
            this.f2LBoxUrun.Size = new System.Drawing.Size(120, 186);
            this.f2LBoxUrun.TabIndex = 12;
            // 
            // f2BtnTemizle
            // 
            this.f2BtnTemizle.Location = new System.Drawing.Point(529, 334);
            this.f2BtnTemizle.Name = "f2BtnTemizle";
            this.f2BtnTemizle.Size = new System.Drawing.Size(75, 23);
            this.f2BtnTemizle.TabIndex = 10;
            this.f2BtnTemizle.Text = "Temizle";
            this.f2BtnTemizle.UseVisualStyleBackColor = true;
            this.f2BtnTemizle.Click += new System.EventHandler(this.f2BtnTemizle_Click_1);
            // 
            // f2BtnHesapla
            // 
            this.f2BtnHesapla.Location = new System.Drawing.Point(478, 377);
            this.f2BtnHesapla.Name = "f2BtnHesapla";
            this.f2BtnHesapla.Size = new System.Drawing.Size(75, 23);
            this.f2BtnHesapla.TabIndex = 13;
            this.f2BtnHesapla.Text = "Hesapla";
            this.f2BtnHesapla.UseVisualStyleBackColor = true;
            this.f2BtnHesapla.Click += new System.EventHandler(this.f2BtnHesapla_Click_1);
            // 
            // f2BtnCikart
            // 
            this.f2BtnCikart.Location = new System.Drawing.Point(442, 334);
            this.f2BtnCikart.Name = "f2BtnCikart";
            this.f2BtnCikart.Size = new System.Drawing.Size(75, 23);
            this.f2BtnCikart.TabIndex = 9;
            this.f2BtnCikart.Text = "Çıkart";
            this.f2BtnCikart.UseVisualStyleBackColor = true;
            this.f2BtnCikart.Click += new System.EventHandler(this.f2BtnCikart_Click_1);
            // 
            // f2LBoxFiyat
            // 
            this.f2LBoxFiyat.FormattingEnabled = true;
            this.f2LBoxFiyat.Location = new System.Drawing.Point(562, 142);
            this.f2LBoxFiyat.Name = "f2LBoxFiyat";
            this.f2LBoxFiyat.Size = new System.Drawing.Size(42, 186);
            this.f2LBoxFiyat.TabIndex = 8;
            this.f2LBoxFiyat.SelectedIndexChanged += new System.EventHandler(this.f2LBoxFiyat_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sipariş Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // YiyecekFiyati
            // 
            this.YiyecekFiyati.Enabled = false;
            this.YiyecekFiyati.Location = new System.Drawing.Point(216, 495);
            this.YiyecekFiyati.Name = "YiyecekFiyati";
            this.YiyecekFiyati.Size = new System.Drawing.Size(34, 20);
            this.YiyecekFiyati.TabIndex = 5;
            this.YiyecekFiyati.Visible = false;
            // 
            // f2CbMenu
            // 
            this.f2CbMenu.FormattingEnabled = true;
            this.f2CbMenu.Items.AddRange(new object[] {
            "Yiyecekler",
            "İçecekler"});
            this.f2CbMenu.Location = new System.Drawing.Point(30, 26);
            this.f2CbMenu.Name = "f2CbMenu";
            this.f2CbMenu.Size = new System.Drawing.Size(284, 21);
            this.f2CbMenu.TabIndex = 7;
            this.f2CbMenu.Text = "              Menüyü Görebilmek İçin Kategori Seçiniz ";
            this.f2CbMenu.TextChanged += new System.EventHandler(this.f2CbMenu_TextChanged);
            // 
            // f2BtnSiparisEkle
            // 
            this.f2BtnSiparisEkle.Location = new System.Drawing.Point(141, 532);
            this.f2BtnSiparisEkle.Name = "f2BtnSiparisEkle";
            this.f2BtnSiparisEkle.Size = new System.Drawing.Size(75, 23);
            this.f2BtnSiparisEkle.TabIndex = 6;
            this.f2BtnSiparisEkle.Text = "Sipariş Ekle";
            this.f2BtnSiparisEkle.UseVisualStyleBackColor = true;
            this.f2BtnSiparisEkle.Click += new System.EventHandler(this.f2BtnSiparisEkle_Click_1);
            // 
            // YiyecekAdi
            // 
            this.YiyecekAdi.Enabled = false;
            this.YiyecekAdi.Location = new System.Drawing.Point(116, 495);
            this.YiyecekAdi.Name = "YiyecekAdi";
            this.YiyecekAdi.Size = new System.Drawing.Size(100, 20);
            this.YiyecekAdi.TabIndex = 4;
            this.YiyecekAdi.Visible = false;
            // 
            // IcecekFiyati
            // 
            this.IcecekFiyati.Enabled = false;
            this.IcecekFiyati.Location = new System.Drawing.Point(216, 495);
            this.IcecekFiyati.Name = "IcecekFiyati";
            this.IcecekFiyati.Size = new System.Drawing.Size(34, 20);
            this.IcecekFiyati.TabIndex = 3;
            // 
            // f2LbCikisYap
            // 
            this.f2LbCikisYap.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2LbCikisYap.Location = new System.Drawing.Point(556, 549);
            this.f2LbCikisYap.Name = "f2LbCikisYap";
            this.f2LbCikisYap.Size = new System.Drawing.Size(100, 28);
            this.f2LbCikisYap.TabIndex = 0;
            this.f2LbCikisYap.Text = "Çıkış Yap";
            this.f2LbCikisYap.Click += new System.EventHandler(this.f2LbCikisYap_Click);
            // 
            // IcecekAdi
            // 
            this.IcecekAdi.Enabled = false;
            this.IcecekAdi.Location = new System.Drawing.Point(116, 495);
            this.IcecekAdi.Name = "IcecekAdi";
            this.IcecekAdi.Size = new System.Drawing.Size(100, 20);
            this.IcecekAdi.TabIndex = 2;
            // 
            // f2DgvMenu
            // 
            this.f2DgvMenu.AutoGenerateColumns = false;
            this.f2DgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f2DgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIdDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunFiyatDataGridViewTextBoxColumn});
            this.f2DgvMenu.DataSource = this.ıcecekTbBindingSource;
            this.f2DgvMenu.Location = new System.Drawing.Point(17, 142);
            this.f2DgvMenu.Name = "f2DgvMenu";
            this.f2DgvMenu.Size = new System.Drawing.Size(343, 338);
            this.f2DgvMenu.TabIndex = 0;
            this.f2DgvMenu.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.f2DgvMenu_CellEnter_1);
            // 
            // urunIdDataGridViewTextBoxColumn
            // 
            this.urunIdDataGridViewTextBoxColumn.DataPropertyName = "UrunId";
            this.urunIdDataGridViewTextBoxColumn.HeaderText = "UrunId";
            this.urunIdDataGridViewTextBoxColumn.Name = "urunIdDataGridViewTextBoxColumn";
            this.urunIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // urunFiyatDataGridViewTextBoxColumn
            // 
            this.urunFiyatDataGridViewTextBoxColumn.DataPropertyName = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.HeaderText = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.Name = "urunFiyatDataGridViewTextBoxColumn";
            // 
            // f2LbUrun
            // 
            this.f2LbUrun.AutoSize = true;
            this.f2LbUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f2LbUrun.Location = new System.Drawing.Point(469, 123);
            this.f2LbUrun.Name = "f2LbUrun";
            this.f2LbUrun.Size = new System.Drawing.Size(39, 16);
            this.f2LbUrun.TabIndex = 14;
            this.f2LbUrun.Text = "Ürün";
            // 
            // f2LbFiyat
            // 
            this.f2LbFiyat.AutoSize = true;
            this.f2LbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f2LbFiyat.Location = new System.Drawing.Point(561, 123);
            this.f2LbFiyat.Name = "f2LbFiyat";
            this.f2LbFiyat.Size = new System.Drawing.Size(41, 16);
            this.f2LbFiyat.TabIndex = 15;
            this.f2LbFiyat.Text = "Fiyat";
            // 
            // f2BtnAdisyonBastir
            // 
            this.f2BtnAdisyonBastir.Location = new System.Drawing.Point(451, 457);
            this.f2BtnAdisyonBastir.Name = "f2BtnAdisyonBastir";
            this.f2BtnAdisyonBastir.Size = new System.Drawing.Size(126, 23);
            this.f2BtnAdisyonBastir.TabIndex = 18;
            this.f2BtnAdisyonBastir.Text = "Adisyon Bastır";
            this.f2BtnAdisyonBastir.UseVisualStyleBackColor = true;
            this.f2BtnAdisyonBastir.Click += new System.EventHandler(this.f2BtnAdisyonBastir_Click);
            // 
            // f2CbMasa
            // 
            this.f2CbMasa.FormattingEnabled = true;
            this.f2CbMasa.Items.AddRange(new object[] {
            "Masa-1",
            "Masa-2",
            "Masa-3",
            "Masa-4",
            "Masa-5"});
            this.f2CbMasa.Location = new System.Drawing.Point(394, 26);
            this.f2CbMasa.Name = "f2CbMasa";
            this.f2CbMasa.Size = new System.Drawing.Size(251, 21);
            this.f2CbMasa.TabIndex = 21;
            this.f2CbMasa.Text = "Hangi Masa İçin Sipariş Girmek İstediğinizi Seçin";
            this.f2CbMasa.SelectedValueChanged += new System.EventHandler(this.f2CbMasa_SelectedValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.f2CbMasa);
            this.panel3.Controls.Add(this.f2BtnAdisyonBastir);
            this.panel3.Controls.Add(this.f2LbFiyat);
            this.panel3.Controls.Add(this.f2LbUrun);
            this.panel3.Controls.Add(this.f2DgvMenu);
            this.panel3.Controls.Add(this.IcecekAdi);
            this.panel3.Controls.Add(this.f2LbCikisYap);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.IcecekFiyati);
            this.panel3.Controls.Add(this.YiyecekAdi);
            this.panel3.Controls.Add(this.f2BtnSiparisEkle);
            this.panel3.Controls.Add(this.f2CbMenu);
            this.panel3.Controls.Add(this.YiyecekFiyati);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.f2LBoxFiyat);
            this.panel3.Controls.Add(this.f2BtnCikart);
            this.panel3.Controls.Add(this.f2BtnHesapla);
            this.panel3.Controls.Add(this.f2BtnTemizle);
            this.panel3.Controls.Add(this.f2LBoxUrun);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.f2LbToplamTutar);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(58, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 580);
            this.panel3.TabIndex = 19;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIdDataGridViewTextBoxColumn1,
            this.urunAdiDataGridViewTextBoxColumn1,
            this.urunFiyatDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.yiyecekTbBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 142);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 338);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter_1);
            // 
            // urunIdDataGridViewTextBoxColumn1
            // 
            this.urunIdDataGridViewTextBoxColumn1.DataPropertyName = "UrunId";
            this.urunIdDataGridViewTextBoxColumn1.HeaderText = "UrunId";
            this.urunIdDataGridViewTextBoxColumn1.Name = "urunIdDataGridViewTextBoxColumn1";
            this.urunIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn1
            // 
            this.urunAdiDataGridViewTextBoxColumn1.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn1.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn1.Name = "urunAdiDataGridViewTextBoxColumn1";
            // 
            // urunFiyatDataGridViewTextBoxColumn1
            // 
            this.urunFiyatDataGridViewTextBoxColumn1.DataPropertyName = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn1.HeaderText = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn1.Name = "urunFiyatDataGridViewTextBoxColumn1";
            // 
            // f2LbToplamTutar
            // 
            this.f2LbToplamTutar.AutoSize = true;
            this.f2LbToplamTutar.Location = new System.Drawing.Point(469, 416);
            this.f2LbToplamTutar.Name = "f2LbToplamTutar";
            this.f2LbToplamTutar.Size = new System.Drawing.Size(10, 13);
            this.f2LbToplamTutar.TabIndex = 22;
            this.f2LbToplamTutar.Text = "-";
            this.f2LbToplamTutar.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.f3LbTarih);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.f2AdisyonMasaAdi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.f2LBoxAdisyonFiyat);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.f2LbAdisyonCikis);
            this.panel2.Controls.Add(this.f2LbAdisyonToplamTutar);
            this.panel2.Controls.Add(this.f2LBoxAdisyonUrun);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 46);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label14.Location = new System.Drawing.Point(479, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 29);
            this.label14.TabIndex = 27;
            this.label14.Text = "XXX ŞUBESİ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label13.Location = new System.Drawing.Point(149, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(362, 41);
            this.label13.TabIndex = 26;
            this.label13.Text = "*** AFİYET OLSUN ***";
            // 
            // f2AdisyonMasaAdi
            // 
            this.f2AdisyonMasaAdi.AutoSize = true;
            this.f2AdisyonMasaAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.f2AdisyonMasaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f2AdisyonMasaAdi.Location = new System.Drawing.Point(8, 61);
            this.f2AdisyonMasaAdi.Name = "f2AdisyonMasaAdi";
            this.f2AdisyonMasaAdi.Size = new System.Drawing.Size(23, 31);
            this.f2AdisyonMasaAdi.TabIndex = 25;
            this.f2AdisyonMasaAdi.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(287, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "ADİSYON";
            // 
            // f2LBoxAdisyonFiyat
            // 
            this.f2LBoxAdisyonFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.f2LBoxAdisyonFiyat.FormattingEnabled = true;
            this.f2LBoxAdisyonFiyat.ItemHeight = 31;
            this.f2LBoxAdisyonFiyat.Location = new System.Drawing.Point(357, 136);
            this.f2LBoxAdisyonFiyat.Name = "f2LBoxAdisyonFiyat";
            this.f2LBoxAdisyonFiyat.Size = new System.Drawing.Size(134, 314);
            this.f2LBoxAdisyonFiyat.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(397, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fiyat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(232, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ürün";
            // 
            // f2LbAdisyonCikis
            // 
            this.f2LbAdisyonCikis.AutoSize = true;
            this.f2LbAdisyonCikis.BackColor = System.Drawing.Color.White;
            this.f2LbAdisyonCikis.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2LbAdisyonCikis.Location = new System.Drawing.Point(626, 9);
            this.f2LbAdisyonCikis.Name = "f2LbAdisyonCikis";
            this.f2LbAdisyonCikis.Size = new System.Drawing.Size(24, 14);
            this.f2LbAdisyonCikis.TabIndex = 21;
            this.f2LbAdisyonCikis.Text = "X";
            this.f2LbAdisyonCikis.Click += new System.EventHandler(this.f2LbAdisyonCikis_Click);
            // 
            // f2LbAdisyonToplamTutar
            // 
            this.f2LbAdisyonToplamTutar.AutoSize = true;
            this.f2LbAdisyonToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f2LbAdisyonToplamTutar.Location = new System.Drawing.Point(201, 454);
            this.f2LbAdisyonToplamTutar.Name = "f2LbAdisyonToplamTutar";
            this.f2LbAdisyonToplamTutar.Size = new System.Drawing.Size(164, 29);
            this.f2LbAdisyonToplamTutar.TabIndex = 4;
            this.f2LbAdisyonToplamTutar.Text = "Toplam Tutar:";
            this.f2LbAdisyonToplamTutar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // f2LBoxAdisyonUrun
            // 
            this.f2LBoxAdisyonUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.f2LBoxAdisyonUrun.FormattingEnabled = true;
            this.f2LBoxAdisyonUrun.ItemHeight = 31;
            this.f2LBoxAdisyonUrun.Location = new System.Drawing.Point(163, 136);
            this.f2LBoxAdisyonUrun.Name = "f2LBoxAdisyonUrun";
            this.f2LBoxAdisyonUrun.Size = new System.Drawing.Size(194, 314);
            this.f2LBoxAdisyonUrun.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(640, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // f3LbTarih
            // 
            this.f3LbTarih.AutoSize = true;
            this.f3LbTarih.Location = new System.Drawing.Point(12, 99);
            this.f3LbTarih.Name = "f3LbTarih";
            this.f3LbTarih.Size = new System.Drawing.Size(10, 13);
            this.f3LbTarih.TabIndex = 28;
            this.f3LbTarih.Text = "-";
            // 
            // SiparisYonetimEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(779, 607);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.f2LbKapat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisYonetimEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıcecekTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yiyecekTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2DgvMenu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProjeDBDataSet projeDBDataSet;
        private System.Windows.Forms.BindingSource ıcecekTbBindingSource;
        private ProjeDBDataSetTableAdapters.IcecekTbTableAdapter icecekTbTableAdapter;
        private System.Windows.Forms.BindingSource yiyecekTbBindingSource;
        private ProjeDBDataSetTableAdapters.YiyecekTbTableAdapter yiyecekTbTableAdapter;
        private System.Windows.Forms.Label f2LbKapat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox f2LBoxUrun;
        private System.Windows.Forms.Button f2BtnTemizle;
        private System.Windows.Forms.Button f2BtnHesapla;
        private System.Windows.Forms.Button f2BtnCikart;
        private System.Windows.Forms.ListBox f2LBoxFiyat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox YiyecekFiyati;
        private System.Windows.Forms.ComboBox f2CbMenu;
        private System.Windows.Forms.Button f2BtnSiparisEkle;
        private System.Windows.Forms.TextBox YiyecekAdi;
        private System.Windows.Forms.TextBox IcecekFiyati;
        private System.Windows.Forms.Label f2LbCikisYap;
        private System.Windows.Forms.TextBox IcecekAdi;
        private System.Windows.Forms.DataGridView f2DgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label f2LbUrun;
        private System.Windows.Forms.Label f2LbFiyat;
        private System.Windows.Forms.Button f2BtnAdisyonBastir;
        private System.Windows.Forms.ComboBox f2CbMasa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label f2LbToplamTutar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox f2LBoxAdisyonUrun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label f2LbAdisyonToplamTutar;
        private System.Windows.Forms.Label f2LbAdisyonCikis;
        private System.Windows.Forms.ListBox f2LBoxAdisyonFiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label f2AdisyonMasaAdi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label f3LbTarih;
    }
}