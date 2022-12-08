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



namespace _192113035
{
    public partial class OgrenciIslem : Form
    {
        public OgrenciIslem()
        {
            InitializeComponent();
        }
        Ogrenci ogr = new Ogrenci();
        //Ogrenci sinifindan ogr nesnesi olusturdu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sonuc = ogr.ogr_ekle(ID_txt.Text, isim_txt.Text, soyisim_txt.Text, int.Parse(Tc_txt.Text),
                   tarih_txt.Text);
            //ogrenci islem formunda kullandıgımız textbox isimlerindeki texti  ogr.ekle() fonksiyonuna gönderir
            MessageBox.Show("Öğrenci Başarıyla Eklendi.");//basari ile eklendiginde ekrana mesaj gelir

        }
        private void btnArama_Click(object sender, EventArgs e)
        {
            List<ogrenciVarlik> ogrenciler = ogr.ogrenci_goster(int.Parse(ogrenciara.Text));
            //entity layer üzerinden ogrenciler adlı nesneyle liste olusturuyor
            //bu liste ogrenci sinifindan olusturdugumuz ogr nesnesiyle ogrenci sinifindan 
            //ogrenci_goster fonksiyonuna ogrenci ara textinin ismini gönderiyor
            kayitlar.DataSource = ogrenciler;
            //kayitlar tablosunda arar
            //
        }


        void ogr_gstr()
        {
            //ogrencilerrenciler listesindeki verileri ogr_goster fonkiyonu ile datagridview'e çağırır. 
            List<ogrenciVarlik> ogrenciler = ogr.ogrenci_goster();
            kayitlar.DataSource = ogrenciler;
        }
        private void btnOgrenciler_Click(object sender, EventArgs e)
        {
            ogr_gstr();//ogr goster fonksiyonuna gider
            MessageBox.Show("Öğrenciler Başarıyla Listelendi.");
        }

        private void ogrenciara_click(object sender, EventArgs e)
        {
            ogrenciara.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_guncelle fonksiyonu çalıştırılarak öğrenci 
            //güncelleme işlemi yapılır.
            try//Hata olusma ihtimali olan kod blogu
            {
                int sonuc = ogr.ogr_guncelle(int.Parse(ID_txt.Text), isim_txt.Text, soyisim_txt.Text,
                    int.Parse(Tc_txt.Text), 
                     tarih_txt.Text);
                //guncelleme isleminde textbox'ların her biri tekrardan kontrol edilerek yani 
                //textbox icerisindeki textler guncelleme fonksiyonuna gonderilerek calisir
                MessageBox.Show("Öğrenci Başarıyla Güncellendi.");
            }
            catch (Exception)//hata olusma ihtimaline karsi
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru girdiğinizden emin olun!");
            }
        }
        Ogrenci sil = new Ogrenci();
        //Ogrenci sinifindan sil nesnesi olusturdu

        private void btnSil_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_sil fonksiyonu çalıştırılarak öğrenci silme işlemi yapılır.
            try //hata olusma ihtimali olan kodlari barindirir
            {
                sil.ogr_sil(int.Parse(ID_txt.Text));
                //silme islemini ogrenciıd' ye girilen text ile ogr_sil fonksiyonuna yaptirir
                MessageBox.Show("Öğrenci Başarıyla Silindi.");
            }
            catch (Exception)//hata olustugunda bu blok calisir
            {
                MessageBox.Show("Lütfen girilen değerleri kontrol ediniz!");
            }
        }

        private void kayitlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kayitlar.Rows[e.RowIndex];
                ID_txt.Text = row.Cells[0].Value.ToString();
                isim_txt.Text = row.Cells[1].Value.ToString();
                soyisim_txt.Text = row.Cells[2].Value.ToString();
                Tc_txt.Text = row.Cells[3].Value.ToString();
                tarih_txt.Text = row.Cells[10].Value.ToString();


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
