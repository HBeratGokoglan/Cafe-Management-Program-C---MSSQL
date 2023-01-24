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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace KafeProje
{
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BERAT;Initial Catalog=ProjeDB;Integrated Security=True");//Veritabani ile baglanti saglamak icin baglanti degiskeni kullandim.
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDBDataSet4.GunlukCiroTb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gunlukCiroTbTableAdapter1.Fill(this.projeDBDataSet4.GunlukCiroTb);
            // TODO: Bu kod satırı 'projeDBDataSet11.GunlukCiroTb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gunlukCiroTbTableAdapter.Fill(this.projeDBDataSet11.GunlukCiroTb);
            // TODO: Bu kod satırı 'projeDBDataSet1.PersonelTb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTbTableAdapter.Fill(this.projeDBDataSet1.PersonelTb);
            // TODO: Bu kod satırı 'projeDBDataSet1.YiyecekTb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yiyecekTbTableAdapter.Fill(this.projeDBDataSet1.YiyecekTb);
            // TODO: Bu kod satırı 'projeDBDataSet1.IcecekTb' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.icecekTbTableAdapter.Fill(this.projeDBDataSet1.IcecekTb);
        }

        private void f3BtnIcecekEkle_Click(object sender, EventArgs e) // Icecek eklemek için kullandığım buton ve sp.
        {
            {
                baglanti.Open(); // Baglantı aç
                using (SqlCommand command = new SqlCommand("sp_Icecek_Ekle", baglanti)) // "command" adlı bir SqlCommand nesnesi oluşturulur. Bu command nesnesi Icecek_Ekle spsini çalıştırır.
                {
                    command.CommandType = CommandType.StoredProcedure; // "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                    command.Parameters.AddWithValue("@UrunAdi", f3TxtIcecekAdi.Text);  // EKlenecek olan urun adini "Form3 Icecek Adi Textbox'ından alıyor."
                    command.Parameters.AddWithValue("@UrunFiyat", Convert.ToInt32(f3TxtIcecekFiyat.Text)); // EKlenecek olan urun Fiyatini "Form3 Icecek Fiyati Textbox'ından alıyor."
                    try
                    {
                    command.ExecuteNonQuery(); // "command" nesnesinin çalıştırılacağı sorgu veritabanına gönderilir ve sorgunun etkisi olan satır sayısı döndürülür.
                    MessageBox.Show("Kayıt Eklendi! "); // Ekrana Uyarı Mesajı Gönderiyor 
                    }
                    catch
                    {
                    MessageBox.Show("Bu isimde bir içecek zaten mevcut!");
                    }
                }
                baglanti.Close(); // Baglantıyı kapatıyor

            }
            f3TxtIcecekId.Clear();
            f3TxtIcecekAdi.Clear();
            f3TxtIcecekFiyat.Clear();
            this.icecekTbTableAdapter.Fill(this.projeDBDataSet1.IcecekTb); // IcecekTb isimli tabloyu yeniliyor.
        }

        private void f3BtnIcecekDuzenle_Click(object sender, EventArgs e) // Icecek Duzenlemek için kullandığım buton ve sp.
        {
            {
                using (SqlCommand command = new SqlCommand("sp_Icecek_Duzenle", baglanti))// "command" adlı bir SqlCommand nesnesi oluşturulur. Bu command nesnesi Icecek_Duzenle spsini calistirir.
                {
                    baglanti.Open();// Baglantı aç
                    command.CommandType = CommandType.StoredProcedure;// "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                    command.Parameters.AddWithValue("@UrunId", f3TxtIcecekId.Text);// Duzenlenecek olan urun Id'sini "Form3 Icecek Id Textbox'ından alıyor."
                    command.Parameters.AddWithValue("@UrunAdi", f3TxtIcecekAdi.Text);// Duzenlenecek olan urun Adini "Form3 Icecek Adi Textbox'ından alıyor."
                    command.Parameters.AddWithValue("@UrunFiyat", f3TxtIcecekFiyat.Text);// Duzenlenecek olan urun Fiyatini "Form3 Icecek Fiyati Textbox'ından alıyor."
                    command.ExecuteNonQuery();// "command" nesnesinin calistiracagi sorgu veritabanına gonderilir ve sorgunun etkisi olan satır sayısı donduruluyor.
                    baglanti.Close();// Baglantı kapat
                }
            }
            f3TxtIcecekId.Clear();
            f3TxtIcecekAdi.Clear();
            f3TxtIcecekFiyat.Clear();
            MessageBox.Show("Kayıt Düzenlendi! "); // Ekrana Uyarı Mesajı Gönderiyor 
            this.icecekTbTableAdapter.Fill(this.projeDBDataSet1.IcecekTb);// IcecekTb isimli tabloyu yeniliyor.
        }

        private void f3BtnIcecekCikar_Click(object sender, EventArgs e) //Icecek silmek için kullandığım buton ve sp.
        {
            {
                using (SqlCommand command = new SqlCommand("sp_Icecek_Sil", baglanti))// "command" adlı bir SqlCommand nesnesi oluşturulur. Bu command nesnesi Icecek_Duzenle spsini calistirir.
                {
                    baglanti.Open();// Baglantı ac
                    command.CommandType = CommandType.StoredProcedure;// "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                    command.Parameters.AddWithValue("@UrunId", Convert.ToInt32(f3TxtIcecekId.Text));// Silinecek olan urun Id'sini "Form3 Icecek Id Textbox'ından alıyor."
                    command.ExecuteNonQuery();// "command" nesnesinin çalıştırılacağı sorgu veritabanına gönderilir ve sorgunun etkisi olan satır sayısı döndürülür.
                    baglanti.Close();// Baglantı kapat
                }
            }
            f3TxtIcecekId.Clear();
            f3TxtIcecekAdi.Clear();
            f3TxtIcecekFiyat.Clear();
            MessageBox.Show("Kayıt Silindi! ");// Ekrana Uyarı Mesajı Gönderiyor
            this.icecekTbTableAdapter.Fill(this.projeDBDataSet1.IcecekTb);// IcecekTb isimli tabloyu yeniliyor.
        }

        private void f3LbUrunId_Click(object sender, EventArgs e)
        {

        }

        private void f3TxtIcecekId_TextChanged(object sender, EventArgs e)
        {

        }

        private void f3Dgvİcecek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  //Bu fonksiyon DataGridView uzerinden secilen nesneyi textboxlara aktarir.
        {
            int secilenIcecek = f3Dgvİcecek.SelectedCells[0].RowIndex;
            f3TxtIcecekId.Text = f3Dgvİcecek.Rows[secilenIcecek].Cells[0].Value.ToString();
            f3TxtIcecekAdi.Text = f3Dgvİcecek.Rows[secilenIcecek].Cells[1].Value.ToString();
            f3TxtIcecekFiyat.Text = f3Dgvİcecek.Rows[secilenIcecek].Cells[2].Value.ToString();
        }

        private void f3DgvYiyecek_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//Bu fonksiyon DataGridView uzerinden secilen nesneyi textboxlara aktarir.
        {
            int secilenYiyecek = f3DgvYiyecek.SelectedCells[0].RowIndex;
            f3TBoxUrunId.Text = f3DgvYiyecek.Rows[secilenYiyecek].Cells[0].Value.ToString();
            f3TBoxUrunAdi.Text = f3DgvYiyecek.Rows[secilenYiyecek].Cells[1].Value.ToString();
            f3TBoxUrunFiyati.Text = f3DgvYiyecek.Rows[secilenYiyecek].Cells[2].Value.ToString();
        }

        private void f3BtnYiyecekEkle_Click(object sender, EventArgs e) // Yiyecek eklemek için kullandığım buton ve sp.
        {
            {
                baglanti.Open();// Baglanti Ac
                using (SqlCommand command = new SqlCommand("sp_Yiyecek_Ekle", baglanti)) // "command" adlı bir SqlCommand nesnesi oluşturulur. Bu command nesnesi Icecek_Duzenle spsini calistirir.
                {
                    command.CommandType = CommandType.StoredProcedure;// "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                    command.Parameters.AddWithValue("@UrunAdi", f3TBoxUrunAdi.Text);// Eklenecek olan yiyecek adini "Form3 urunadi textbox'ından alıyor."
                    command.Parameters.AddWithValue("@UrunFiyat", Convert.ToInt32(f3TBoxUrunFiyati.Text)); // Eklenecek olan yiyecek fiyatini "Form3 urunadi textbox'ından alıyor."
                    try
                    {
                    command.ExecuteNonQuery();// "command" nesnesinin çalıştırılacağı sorgu veritabanına gönderilir ve sorgunun etkisi olan satır sayısı döndürülür.
                    MessageBox.Show("Kayıt Eklendi! ");// Ekrana Uyarı Mesajı Gönderiyor
                    }
                    catch
                    {
                    MessageBox.Show("Bu isimde bir yiyecek zaten mevcut!");
                    }
                }
                baglanti.Close();// Baglanti kapat

            }
            f3TBoxUrunId.Clear();
            f3TBoxUrunAdi.Clear();
            f3TBoxUrunFiyati.Clear();
            this.yiyecekTbTableAdapter.Fill(this.projeDBDataSet1.YiyecekTb);// YiyecekTb isimli tabloyu yeniliyor.
        }

        private void f3BtnYiyecekCikar_Click(object sender, EventArgs e) // Yiyecek cikarmak için kullandığım buton ve sp.
        {
            {
                using (SqlCommand command = new SqlCommand("sp_Yiyecek_Sil", baglanti))// "command" adlı bir SqlCommand nesnesi oluşturulur. Bu command nesnesi Icecek_Duzenle spsini calistirir.
                {
                    baglanti.Open();// Baglanti Ac
                    command.CommandType = CommandType.StoredProcedure;// "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                    command.Parameters.AddWithValue("@UrunId", Convert.ToInt32(f3TBoxUrunId.Text));// Silinecek olan urun Id'sini "Form3 Yiyecek Id Textbox'ından alıyor."
                    command.ExecuteNonQuery();// "command" nesnesinin çalıştırılacağı sorgu veritabanına gönderilir ve sorgunun etkisi olan satır sayısı döndürülür.
                    baglanti.Close(); // Baglanti Kapat
                }
            }
            f3TBoxUrunId.Clear();
            f3TBoxUrunAdi.Clear();
            f3TBoxUrunFiyati.Clear();
            MessageBox.Show("Kayıt Silindi! ");// Ekrana Uyarı Mesajı Gönderiyor
            this.yiyecekTbTableAdapter.Fill(this.projeDBDataSet1.YiyecekTb);// YiyecekTb isimli tabloyu yeniliyor.
        }

        private void f3BtnYiyecekDuzenle_Click(object sender, EventArgs e) // Yiyecek cikarmak için kullandığım buton ve sp.
        {
            {
                using (SqlCommand command = new SqlCommand("sp_Yiyecek_Duzenle", baglanti))// "command" adlı bir SqlCommand nesnesi oluşturulur. Bu command nesnesi Icecek_Duzenle spsini calistirir.
                {
                    baglanti.Open();//Baglanti Ac
                    command.CommandType = CommandType.StoredProcedure;// "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                    command.Parameters.AddWithValue("@UrunId", f3TBoxUrunId.Text);// Duzenlenecek olan urun Id'sini "Form3 Yiyecek Id Textbox'ından alıyor."
                    command.Parameters.AddWithValue("@UrunAdi", f3TBoxUrunAdi.Text);// Duzenlenecek olan urun Id'sini "Form3 Yiyecek adi Textbox'ından alıyor."
                    command.Parameters.AddWithValue("@UrunFiyat", f3TBoxUrunFiyati.Text);// Duzenlenecek olan urun Fiyatini "Form3 Yiyecek fiyati Textbox'ından alıyor."
                    command.ExecuteNonQuery();// "command" nesnesinin çalıştırılacağı sorgu veritabanına gönderilir ve sorgunun etkisi olan satır sayısı döndürülür.
                    baglanti.Close();//Baglanti kapat
                }
            }
            f3TBoxUrunId.Clear();
            f3TBoxUrunAdi.Clear();
            f3TBoxUrunFiyati.Clear();
            MessageBox.Show("Kayıt Düzenlendi! ");
            this.yiyecekTbTableAdapter.Fill(this.projeDBDataSet1.YiyecekTb);
        }

        private void f3BtnPersonelEkle_Click_1(object sender, EventArgs e)// Personel eklemek icin kullandığım buton ve sp.
        {
            {
                baglanti.Open();// Baglanti ac
                using (SqlCommand command = new SqlCommand("sp_Personel_Ekle", baglanti))// "command" adlı bir SqlCommand nesnesi oluşturulur. Bu command nesnesi Personel_Ekle spsini calistirir.
                {
                    command.CommandType = CommandType.StoredProcedure;// "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                    command.Parameters.AddWithValue("@ad", f3TBoxPersonelAdi.Text);// Eklenecek olan personel adini "Form3 personel adi textbox'ından alıyor."
                    command.Parameters.AddWithValue("@sifre", f3TBoxPersonelSifre.Text);// Eklenecek olan personel sifresini "Form3 personel sifresi textbox'ından alıyor."
                    command.ExecuteNonQuery();// "command" nesnesinin çalıştırılacağı sorgu veritabanına gönderilir ve sorgunun etkisi olan satır sayısı döndürülür.
                    MessageBox.Show("Kayıt Eklendi! ");
                    
                }
                baglanti.Close();// Baglanti kapat
            }
            f3TBoxUrunId.Clear();  //Ekleme sonrası textboxları temizle
            f3TBoxUrunAdi.Clear();//Ekleme sonrası textboxları temizle
            f3TBoxUrunFiyati.Clear();//Ekleme sonrası textboxları temizle
            this.personelTbTableAdapter.Fill(this.projeDBDataSet1.PersonelTb); //Tabloyu yeniliyor
        }

        private void f3BtnPersonelCikar_Click(object sender, EventArgs e)// Personel cikartmak icin kullandığım buton ve sp.
        {
            {

                baglanti.Open();// Baglanti ac
                using (SqlCommand command = new SqlCommand("sp_Personel_Sil", baglanti)) // "command" adlı bir SqlCommand nesnesi oluşturulur. Bu command nesnesi Personel_Ekle spsini calistirir.
                {
                    command.CommandType = CommandType.StoredProcedure;// "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                    command.Parameters.AddWithValue("@PersonelId", Convert.ToInt32(f3TBoxPersonelId.Text));// Cikartilacak olan personel id'sini "Form3 personel ıd textbox'ından alıyor."
                    command.ExecuteNonQuery();// "command" nesnesinin çalıştırılacağı sorgu veritabanına gönderilir ve sorgunun etkisi olan satır sayısı döndürülür.
                    MessageBox.Show("Kayıt Silindi! ");

                }
                baglanti.Close();
            }
            f3TBoxPersonelId.Clear();//Ekleme sonrası textboxları temizle
            f3TBoxPersonelSifre.Clear();//Ekleme sonrası textboxları temizle
            f3TBoxPersonelAdi.Clear();//Ekleme sonrası textboxları temizle
            this.personelTbTableAdapter.Fill(this.projeDBDataSet1.PersonelTb);//Tabloyu yeniliyor
        }

        private void f3BtnPersonelDuzenle_Click(object sender, EventArgs e)// Personel duzenlemek icin kullandığım buton ve sp.
        {
            {
                baglanti.Open();// Baglanti ac
                using (SqlCommand command = new SqlCommand("sp_Personel_Duzenle", baglanti))// "command" nesnesinin çalıştırılacağı sorgunun bir stored procedure olduğu belirtilir.
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonelId", f3TBoxPersonelId.Text);// Duzenlenecek olan personel ıd'sini "Form3 personel id textbox'ından alıyor."
                    command.Parameters.AddWithValue("@PersonelAdi", f3TBoxPersonelAdi.Text);// Duzenlenecek olan personel adini "Form3 personel adi textbox'ından alıyor."
                    command.Parameters.AddWithValue("@PersonelSifre", f3TBoxPersonelSifre.Text);// Duzenlenecek olan personel sifresini "Form3 personel sifre textbox'ından alıyor."
                    command.ExecuteNonQuery();// "command" nesnesinin çalıştırılacağı sorgu veritabanına gönderilir ve sorgunun etkisi olan satır sayısı döndürülür.
                    MessageBox.Show("Kayıt Düzenlendi! ");
                }
                baglanti.Close();
            }
            f3TBoxPersonelId.Clear();//Ekleme sonrası textboxları temizle
            f3TBoxPersonelSifre.Clear();//Ekleme sonrası textboxları temizle
            f3TBoxPersonelAdi.Clear();//Ekleme sonrası textboxları temizle
            this.personelTbTableAdapter.Fill(this.projeDBDataSet1.PersonelTb);//Tabloyu yeniliyor
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  //Bu fonksiyon DataGridView uzerinden secilen nesneyi textboxlara aktarir.
        {
            int secilenPersonel = dataGridView3.SelectedCells[0].RowIndex;
            f3TBoxPersonelAdi.Text = dataGridView3.Rows[secilenPersonel].Cells[1].Value.ToString();
            f3TBoxPersonelSifre.Text = dataGridView3.Rows[secilenPersonel].Cells[2].Value.ToString();
            f3TBoxPersonelId.Text = dataGridView3.Rows[secilenPersonel].Cells[0].Value.ToString();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void f3TBoxPersonelAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void f3BtnHesapView_Click(object sender, EventArgs e) // en yuksek hesap tutarli 3 masa tutarini gosteren view'ı gosteren buton
        {
            {
                baglanti.Open(); // Baglanti ac
                string query = "SELECT * FROM vw_En_Yuksek_Hesapli_3_Masa"; // Sorguyu query isimli string degiskenine atadım.
                SqlCommand command = new SqlCommand(query, baglanti); // Burada SQL komutunu kullanmak için SQLCommand nesnesini kullandım. query ve baglanti değişkenlerini parametre olarak alıyor
                SqlDataAdapter adapter = new SqlDataAdapter(command); //Veritabanından verileri çekmek için SQLDataAdapter kullandım
                DataTable table = new DataTable(); //Bu kod bir veri tablosu nesnesi oluşturur
                adapter.Fill(table); // Bu kod ise veri tablosu nesnesini doldurur
                f3DgvHesapKitap.DataSource = table; // Bu kod veri tablosunu DataGridView ile birleştirir
                baglanti.Close();// Baglantı Kapat
            }
        }

        private void f3BtnHesapKitapHepsi_Click(object sender, EventArgs e) // Admin panelinde view ve ciro tablosu arasındaki gecisi saglayan buton.
        {
            baglanti.Open(); //Baglantı ac
            string query = "SELECT * FROM GunlukCiroTb"; // Sorguyu query isimli string degiskenine atadım.
            SqlCommand command = new SqlCommand(query, baglanti);// Burada SQL komutunu kullanmak için SQLCommand nesnesini kullandım. query ve baglanti değişkenlerini parametre olarak alıyor
            SqlDataAdapter adapter = new SqlDataAdapter(command);//Veritabanından verileri çekmek için SQLDataAdapter kullandım
            DataTable table = new DataTable();//Bu kod bir veri tablosu nesnesi oluşturur
            adapter.Fill(table);// Bu kod ise veri tablosu nesnesini doldurur
            f3DgvHesapKitap.DataSource = table;// Bu kod veri tablosunu DataGridView ile birleştirir
            baglanti.Close(); // Baglantı kapat
        }

        private void f3LbKapat_Click(object sender, EventArgs e)// kapat butonuna bastıgım zaman evet hayır seklinde uyari veren click olayi
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

        private void f3LbCikisYap_Click_1(object sender, EventArgs e)// cikis yap butonuna bastıgım zaman evet hayır seklinde uyari veren click olayi
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Yönetici Panelinden Çıkış Yapmak  İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
