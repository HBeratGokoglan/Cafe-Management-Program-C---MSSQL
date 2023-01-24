using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KafeProje
{
    public partial class SiparisYonetimEkranı : Form
    {
        public SiparisYonetimEkranı()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BERAT;Initial Catalog=ProjeDB;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e) // Siparis ekranı açıldığı zaman 
        {
            this.icecekTbTableAdapter.Fill(this.projeDBDataSet.IcecekTb); // Ilk olarak bizi icecek menusu karsilar
            f2DgvMenu.Visible = true; //Visible ozelligi aktif edilir.

        }

        public int hesapla() //Bu fonksiyon Form 2 de yer alan fiyatların olduğu listboxdaki değerleri toplayan fonksiyondur.
        {
            int toplam = 0;// ilk degeri 0 olan toplam degişkeni for dongusu ile artarak toplamı dondurur.
            for (int i = 0; i < f2LBoxFiyat.Items.Count; i++)
            {
                toplam += Convert.ToInt32(f2LBoxFiyat.Items[i]); // burada toplama işlemini yapabilmek için integer'a donusum yapılıp toplama ekleniyor.
            }
            f2LbToplamTutar.Text = "Toplam Tutar= " + Convert.ToString(toplam) + " ₺"; // en son olarak da toplam tutarı form 2 de yer alan toplamtutar textbox'ına yazar.
            return toplam;

        }

        private void f2DgvMenu_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            IcecekAdi.Text = f2DgvMenu.CurrentRow.Cells[1].Value.ToString(); // Secilen icecek adini siparis textbox'ına gecirir
            IcecekFiyati.Text = f2DgvMenu.CurrentRow.Cells[2].Value.ToString(); // Secilen icecek fiyatini siparis textbox'ına gecirir
        }

        private void dataGridView2_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            YiyecekAdi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString(); // Secilen yiyecek adini siparis textbox'ına gecirir
            YiyecekFiyati.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString(); // Secilen yiyecek fiyatini siparis textbox'ına gecirir
        }
        public void ShowUserData()
        {
            // Veritabanındaki "IcecekTb" tablosundaki tüm kayıtları getirmeye yarayan sorgu metni hazırlanır
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from IcecekTb ";// SQL Sorgusu
            komut.Connection = baglanti;
            SqlDataAdapter adapter = new SqlDataAdapter(komut); // Sorgu sonuçlarının doldurulacağı bir SqlDataAdapter nesnesi oluşturulur.
            DataTable tablo = new DataTable(); // Sorgu sonuçlarının tutulacağı bir DataTable nesnesi oluşturulur.
            adapter.Fill(tablo); // SqlDataAdapter nesnesi ile sorgu sonuçları DataTable nesnesine doldurulur.
            f2DgvMenu.DataSource = tablo; // Formda bir DataGridView nesnesine DataTable nesnesi verileri atanır.
        }
        public void ShowUserData1()
        {
            // Veritabanındaki "YiyecekTb" tablosundaki tüm kayıtları getirmeye yarayan sorgu metni hazırlanır
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from YiyecekTb "; // SQL Sorgusu
            komut.Connection = baglanti; // veritabanına erişim 
            SqlDataAdapter adapter = new SqlDataAdapter(komut); // Sorgu sonuçlarının doldurulacağı bir SqlDataAdapter nesnesi oluşturulur.
            DataTable tablo = new DataTable(); // Sorgu sonuçlarının tutulacağı bir DataTable nesnesi oluşturulur.
            adapter.Fill(tablo); // SqlDataAdapter nesnesi ile sorgu sonuçları DataTable nesnesine doldurulur.
            dataGridView2.DataSource = tablo; // Formda bir DataGridView nesnesine DataTable nesnesi verileri atanır.
        }

        private void f2BtnSiparisEkle_Click_1(object sender, EventArgs e)
        {
            //Burada eklenen iceceklerin adi ve fiyatı gorunur ve hesapla fonksiyonu ile toplam tutar hesaplanir
            f2LBoxFiyat.Items.Add(IcecekFiyati.Text);
            f2LBoxUrun.Items.Add(IcecekAdi.Text);
            hesapla();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Burada eklenen yiyeceklerin adi ve fiyatı gorunur ve hesapla fonksiyonu ile toplam tutar hesaplanir
            f2LBoxFiyat.Items.Add(YiyecekFiyati.Text);
            f2LBoxUrun.Items.Add(YiyecekAdi.Text);
            hesapla();
        }

        private void f2BtnCikart_Click_1(object sender, EventArgs e)
        {
            int a = f2LBoxUrun.SelectedIndex; //Burada cikart butonu ile yanlislikla eklenen
            if (a > -1)
            {
                f2LBoxFiyat.Items.RemoveAt(a);
                f2LBoxUrun.Items.RemoveAt(a);

            }
        }

        private void f2BtnTemizle_Click_1(object sender, EventArgs e)
        {
            f2LBoxFiyat.Items.Clear();  // Temizle butonu ile listboxlar temizlenir.
            f2LBoxUrun.Items.Clear();
            f2LbToplamTutar.Text = "Toplam Tutar=  0₺"; // toplam tutar 0'a esitlenir.
        }

        private void f2BtnHesapla_Click_1(object sender, EventArgs e) //hesapla butonuna bastigim zaman hesapla fonksiyonu calisir ve toplamtutar label gorunurlugu aktiflesir.
        {
            hesapla();   //Hesapla butonu ile adisyon oncesi hesap gösterilir.
            f2LbToplamTutar.Visible = true;
        }

        private void f2LbCikisYap_Click(object sender, EventArgs e) // cikis yap butonuna bastıgım zaman evet hayır seklinde uyari veren click olayi
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Aktif Kullanıcıdan Çıkış Yapmak İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void f2LbKapat_Click_1(object sender, EventArgs e) // kapat butonuna bastıgım zaman evet hayır seklinde uyari veren click olayi
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kafe Yönetim Sistemini Kapatmak İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void f2CbMenu_TextChanged(object sender, EventArgs e) //Menu combobox'ı degistigi zaman gorunurlugu acilacak olan datagridviewları bu sekilde kontrol ediyorum.
        {
            if (f2CbMenu.Text == "Yiyecekler")
            {
                ShowUserData1();
                dataGridView2.Visible = true;
                YiyecekAdi.Visible = true;
                YiyecekFiyati.Visible = true;
                button2.Visible = true;

                f2DgvMenu.Visible = false;
                IcecekAdi.Visible = false;
                IcecekFiyati.Visible = false;
                f2BtnSiparisEkle.Visible = false;
            }
            else if (f2CbMenu.Text == "İçecekler")
            {
                ShowUserData();
                f2DgvMenu.Visible = true;
                IcecekAdi.Visible = true;
                IcecekFiyati.Visible = true;
                f2BtnSiparisEkle.Visible = true;

                dataGridView2.Visible = false;
                YiyecekAdi.Visible = false;
                YiyecekFiyati.Visible = false;
                button2.Visible = false;
            }

        }

        private void f2BtnAdisyonBastir_Click(object sender, EventArgs e) // Adisyon bastir butonuna basinca 
        {
            if (f2CbMasa.Text == "Hangi Masa İçin Sipariş Girmek İstediğinizi Seçin") // Eger masa secilmemisse uyari veriyor
            {
                MessageBox.Show("Lütfen Geçerli Bir Masa Seçin");
            }
            else //Eger secilmis ise
            {
                baglanti.Open(); // Baglanti Ac
                using (SqlCommand command = new SqlCommand("sp_Ciro_Ekle", baglanti)) // "command" adlı bir SqlCommand nesnesi oluşturulur. Bu command nesnesi Icecek_Duzenle spsini calistirir.
                {
                    command.CommandType = CommandType.StoredProcedure;// "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                    command.Parameters.AddWithValue("@MasaAdi", f2CbMasa.Text);// Eklenecek olan masa adini "Form2 ComboBox'ından alıyor."
                    command.Parameters.AddWithValue("@HesapTutari", hesapla());// Eklenecek olan hesap tutarini' hesapla fonksiyonundan aliyor.
                    command.ExecuteNonQuery();// "command" nesnesinin çalıştırılacağı sorgu veritabanına gönderilir ve sorgunun etkisi olan satır sayısı döndürülür.
                }
                baglanti.Close();//baglanti kapat

                foreach (var item in f2LBoxUrun.Items) //Adisyon oncesindeki listboxdaki verileri adisyon listboxuna cekiyor.
                {
                    f2LBoxAdisyonUrun.Items.Add(item);
                }

                foreach (var item in f2LBoxFiyat.Items) //Adisyon oncesindeki listboxdaki verileri adisyon listboxuna cekiyor.
                {
                    f2LBoxAdisyonFiyat.Items.Add(item + " ₺");
                }
                f3LbTarih.Text = DateTime.Now.ToString();
                f2LbAdisyonToplamTutar.Text = f2LbToplamTutar.Text;
                panel2.Visible = true;// gorunurlugunu aciyor
                f2AdisyonMasaAdi.Text = f2CbMasa.Text;
                panel2.Size = new Size(659, 580); // panel boyutunu degistiriyor
                panel2.BringToFront(); //paneli ön plana getiriyor
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void f2LbAdisyonCikis_Click(object sender, EventArgs e) //Adisyon uzerindeki cikis butonuna basinca panel gizleniyor
        {
            panel2.Visible = false;
        }

        private void f2CbMasa_SelectedValueChanged(object sender, EventArgs e) // Secilen masa degisirse listboxları temizliyor.
        {
            f2LBoxFiyat.Items.Clear();
            f2LBoxUrun.Items.Clear();
        }

        private void f2LBoxFiyat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
