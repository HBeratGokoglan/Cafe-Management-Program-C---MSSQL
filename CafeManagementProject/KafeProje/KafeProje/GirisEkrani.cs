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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KafeProje
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BERAT;Initial Catalog=ProjeDB;Integrated Security=True");//Veritabani ile baglanti saglamak icin baglanti degiskeni kullandim.
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public bool PersonelKontrol(string KullaniciAdi, string sifre) // Personelin siparis yönetim ekranına erismesini saglayan güvenlik kontrol fonksiyonu.
        {
            // Veritabanındaki "PersonelTb" tablosundaki tüm kayıtlar arasından
            // Personel adı ve şifre ile eşleşen kaydı aramaya yarayan sorgu metni hazırlanır.

            string veri = "select*from PersonelTb where PersonelAdi=@PersonelAdi and PersonelSifre=@PersonelSifre"; 
            SqlCommand komut = new SqlCommand();// Sorgu metnini çalıştırmak için bir SqlCommand nesnesi oluşturulur.
            komut.Connection = baglanti;
            komut.CommandText = veri;// SqlCommand nesnesine sorgu metni atanır.
            komut.Parameters.AddWithValue("@PersonelAdi", KullaniciAdi);// Sorgu metninde kullanılan parametrelerin değerleri atanır.
            komut.Parameters.AddWithValue("@PersonelSifre", sifre);// Sorgu metninde kullanılan parametrelerin değerleri atanır.

            DataSet sonucDS = new DataSet();// Veritabanından alınan sonuçları tutmak için bir DataSet nesnesi oluşturulur.
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);// Veritabanından sorgu sonuçlarını almak için bir SqlDataAdapter nesnesi oluşturulur.
            baglanti.Open();
            adaptor.Fill(sonucDS); // SqlDataAdapter nesnesi ile sorgu sonuçları DataSet nesnesine doldurulur.
            baglanti.Close();
            bool sonuc = false;// Fonksiyondan döndürülecek olan sonuç değişkeni oluşturulur ve false değeri atanır.
            if (sonucDS.Tables[0].Rows.Count > 0)// Eğer DataSet nesnesinde kayıt var ise,sonuc true'a döner.
                sonuc = true;
            return sonuc;//sonuc değiskenini döndürür
        }

        public bool AdminKontrol(string KullaniciAdi, string sifre) // Adminin yönetici ekranına erismesini saglayan güvenlik kontrol fonksiyonu.
        {
            // Veritabanındaki "AdminTb" tablosundaki tüm kayıtlar arasından
            // Kullanıcı adı ve şifre ile eşleşen kaydı aramaya yarayan sorgu metni hazırlanır.

            string veri = "select*from AdminTb where ADMIN=@ADMIN and Sifre=@Sifre";
            SqlCommand komut = new SqlCommand();// Sorgu metnini çalıştırmak için bir SqlCommand nesnesi oluşturulur.
            komut.Connection = baglanti;
            komut.CommandText = veri;// SqlCommand nesnesine sorgu metni atanır.
            komut.Parameters.AddWithValue("@ADMIN", KullaniciAdi);// Sorgu metninde kullanılan parametrelerin değerleri atanır.
            komut.Parameters.AddWithValue("@Sifre", sifre);// Sorgu metninde kullanılan parametrelerin değerleri atanır.

            DataSet sonucDS = new DataSet(); // Veritabanından alınan sonuçları tutmak için bir DataSet nesnesi oluşturulur.
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);// Veritabanından sorgu sonuçlarını almak için bir SqlDataAdapter nesnesi oluşturulur.
            baglanti.Open();
            adaptor.Fill(sonucDS); // SqlDataAdapter nesnesi ile sorgu sonuçları DataSet nesnesine doldurulur.
            baglanti.Close();
            bool sonuc = false;// Fonksiyondan döndürülecek olan sonuç değişkeni oluşturulur ve false değeri atanır.
            if (sonucDS.Tables[0].Rows.Count > 0) // Eğer DataSet nesnesinde kayıt var ise,sonuc true'a döner.
                sonuc = true;
            return sonuc; //sonuc değiskenini döndürür
        }

        private void f1BtnPersonel_Click(object sender, EventArgs e) // Personel giris butonuna basıldığı zaman;
        {
            if (PersonelKontrol(f1TxtKullaniciAdi.Text, f1TxtSifre.Text))  //Eger bilgiler dogru ise sisteme giris yapar. 
            {
                MessageBox.Show(f1TxtKullaniciAdi.Text + " Sisteme Giriş Yaptı");
                f1TxtKullaniciAdi.Clear();
                f1TxtSifre.Clear();
                SiparisYonetimEkranı frm = new SiparisYonetimEkranı(); //Giris yapan personel dogrulanirsa siparis yonetim ekrani acilir
                frm.ShowDialog();

                
            }
            else
            {
                MessageBox.Show(" PERSONEL BILGILERI DOGRU DEGIL !"); //Bilgiler dogru degil ise uyarı verir.
                f1TxtKullaniciAdi.Clear(); // Textboxlari sifirlar
                f1TxtSifre.Clear();
                
            }
                
        }

        private void f1BtnAdmin_Click(object sender, EventArgs e) // Admin giris butonuna basıldığı zaman;
        {
            if (AdminKontrol(f1TxtKullaniciAdi.Text, f1TxtSifre.Text))
            {
                MessageBox.Show(f1TxtKullaniciAdi.Text + " Sisteme Giriş Yaptı");//Eger bilgiler dogru ise sisteme giris yapar. 
                f1TxtKullaniciAdi.Clear();
                f1TxtSifre.Clear();
                AdminEkrani frm = new AdminEkrani();  // AdminEkranini acar.
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Admin BILGILERI DOGRU DEGIL !");//Bilgiler dogru degil ise uyarı verir.
                f1TxtKullaniciAdi.Clear(); //Kullanici adi ve sifre textboxlarini temizler.
                f1TxtSifre.Clear();
            }
            
        }

        private void f1LbCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kafe Yönetim Sistemini Kapatmak İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Cikis yap butonuna basınca ekrana uyarı veren messagebox
            if (sonuc == DialogResult.No)
            {
                //Eger hayir tusuna basilirsa islem yapma.
            }
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit(); // Evet tusuna basilirsa uygulamayi kapat.
            }
        }

    }
}
