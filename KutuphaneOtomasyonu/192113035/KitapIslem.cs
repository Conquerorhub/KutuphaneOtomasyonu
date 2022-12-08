using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsKatmani;
using VarlikKatmani;
using VeriErisimKatmani;

namespace _192113035
{
    public partial class KitapIslem : Form
    {
        public KitapIslem()
        {
            InitializeComponent();
        }


        string konum = " ";

        Kitap kitapl = new Kitap();
        //kitap sinifindan kitap1 nesnesi olusturdum
        private void btnEkle_Click(object sender, EventArgs e)
        {

            //BL'daki kitap_islem sınıfındaki ktp_ekle fonksiyonu çaılştırılarak kitap ekleme işlemi yapılır.
            int sonuc = kitapl.ktp_ekle(int.Parse(ID_txt.Text), kitapAdi_txt.Text, yazarAdi_txt.Text,
                 int.Parse(sayfaSayi_txt.Text),
                kitapTur_txt.Text);
            //textboc'lar içerisine girilen text degerlerini ktp_ekle fonksiyonuna gönderir
            MessageBox.Show("Kitap Başarıyla Eklendi.");
        }

        void veri_cek()
        {
            //kitaplar listesinden sütun bilgilerini çekip datagridview'e aktarır.
            List<kitapVarlik> ktp = kitapislem.kitap_goster();
            //Kitapvarlikdan türetilen ktp nesnesi liste seklinde kitap gosterir
            kitapKayitlar.DataSource = ktp;
        }
        Kitap kitapislem = new Kitap();
        //Kitap sinifindan kitapislem nesnesi olsturma islemi
        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            //veri_cek fonksiyonu ile tüm kitap bilgileri datagridview'e aktarılır.
            veri_cek();//fonksiyona gider
            MessageBox.Show("Tüm kayıtlar listelendi");
        }


        Kitap guncelleme = new Kitap();
        //Kitap sinifindan guncelleme nesnesi olustudum
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfındaki ktp_guncelle fonksiyonu çalıştırılarak kitap güncellleme işlemi yapılır.
            try//hata olusabilecek kod blokları
            {
                int Sonuc = guncelleme.ktp_guncelle(int.Parse(ID_txt.Text), kitapAdi_txt.Text, yazarAdi_txt.Text,
                   int.Parse(sayfaSayi_txt.Text), kitapTur_txt.Text);
                //guncelleme islemi icin textboxlar icine girilen textleri kitap_guncelle 
                //fonksiyonuna guncelleme nesnesine gonderir
                MessageBox.Show("Kitap başarıyla güncellendi");
            }
            catch (Exception)//eger hata olusursa bu kodlar calisir
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru giriniz!");
            }


        }

        Kitap sil = new Kitap();
        //Kitap sinifindan sil nesnesi türetme islemi
        private void btnSil_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfındaki ktp_sil fonksiyonu çalıştırılarak kitap silme işlemi yapılır.
            try//hata olusma ihtimali olan kof bloklari
            {
                int Sonuc = sil.ktp_sil(int.Parse(ID_txt.Text));
                //silme islemini kitapıd girilen textbox içerisindeki degeri int degerine donusturerek
                //ktp_sil fonksiyonuna gönderiyorum
                MessageBox.Show("Kitap başarıyla silindi");
            }
            catch (Exception)//Herhangi bir hatada bu blok calisir
            {
                MessageBox.Show("Lütfen alanları doldurduğunuzdan veya doğru olduğundan emin olunuz!");
            }






        }

        private void kitap_dgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kitapKayitlar.Rows[e.RowIndex];
                ID_txt.Text = row.Cells[0].Value.ToString();
                kitapAdi_txt.Text = row.Cells[1].Value.ToString();
                yazarAdi_txt.Text = row.Cells[2].Value.ToString();
                sayfaSayi_txt.Text = row.Cells[4].Value.ToString();
                kitapTur_txt.Text = row.Cells[6].Value.ToString();
                
            }
        }

        private void cmbKitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //konum değeri textbox içersindeki seçilen değere eşitlenir.
            konum = cmbKitap.SelectedItem.ToString();

        }

        private void kitap_txt_TextChanged(object sender, EventArgs e)
        {
            kitap_txt.Text = "";//üzerine tiklandiginda textbox icindeki yazi silinir
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfından kitap_goster fonksiyonu çalıştırılarak kitap bilgileri
            //datagridview'e aktarılır.
            try//hata olusabilcek kod blogu
            {
                List<kitapVarlik> ktp2 = kitapislem.kitap_goster(kitap_txt.Text, konum);
                //entity'deki kitapvarlik üzerinden ktp2 nesneli liste olusturuyorum
                //combobox'da seçtiğim konumu ve ara textbox'ı içine yazdıgımız text kitap goster parametreli fonksiyonuna gonderir
                kitapKayitlar.DataSource = ktp2;
                MessageBox.Show("Arama sonuçları listelendi");
            }
            catch (Exception)//hata durumunda bu kodlar calisir
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz!");
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }




    }
}
