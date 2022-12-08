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
    public partial class EmanetTeslimIslem : Form
    {
        public EmanetTeslimIslem()
        {
            InitializeComponent();
        }

        string konum = " ";
        string tablo = "";

        kitapAlimIade islem = new kitapAlimIade();
        //Kitap_Alim_İade sinifindan İade_islem nesnesi turetilir
        void veri_cek()
        {
            //almaverme tablosundaki verileri datagridview'e yüklemek için bu fonksiyonu kullanıyoruz.
            List<iadeVarlik> ktp = islem.iade_alim_yukle();
            dataGridView1.DataSource = ktp;
        }

        //alim baslangic

        kitapAlimIade iade_ekle = new kitapAlimIade();
        //business class'daki Kitap_Alim_İade sinifindan iade_ekle nesnesi türetilmesi
        private void btnEmanet_Click(object sender, EventArgs e)
        {
            //emanet_islemi fonksiyonuna gerekli parametreleri göndererek emanet verme işlemini yapıyoruz.
            try//hata olusabilecek kodlar
            {
                int Sonuc = iade_ekle.emanet_islemi(int.Parse(ogrenciNo1_txt.Text), int.Parse(kitapID_txt.Text),
                    DateTime.Parse(almaTarih_txt.Text), DateTime.Parse(emanetTarih_txt.Text), "alım");
                //iade_ekle nesnesi emanet_islemi fonksiyonuna girilen textbox textlerini gönderir
                MessageBox.Show("Emanet verme işlemi başarılı!");
            }
            catch (Exception)//hata olustugunda calisir
            {
                MessageBox.Show("Emanet işlemi için lütfen alanları doldurunuz!");
            }
        }

        Ogrenci ogrenci_islem = new Ogrenci();
        //Ogrenci sinifindan ogrenci_islem adinda nesne turetiliyor
        private void btnOgrenciAra_Click(object sender, EventArgs e)
        {
            //öğrenci tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try//hata olsuma ihtimalinde
            {
                List<ogrenciVarlik> ogr = ogrenci_islem.ogrenci_goster(int.Parse(ogrenciNo_txt.Text));
                //entity'deki ogrencivarlik'dantürettiği  ogr nesnesi liste seklinde 
                //textbox'a girilen ogrencino'yu ogrenci_goster fonksiyonuna gonderir.
                dataGridView1.DataSource = ogr;
                //kayitlar tablosunda gosterir
                tablo = "emanet_islemleri_ogrenci";
                MessageBox.Show("Arama başarılı!");
            }
            catch (Exception)//hata olustugunda calisir
            {
                MessageBox.Show("Geçersiz girdi!");
            }
        }
        Kitap kitap_islem = new Kitap();
        //businesslayer Kitap sinifindan kitap_islem nesnesi türetilmesi

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            //kitap tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try//hata olusabşlcek kodlar 
            {
                List<kitapVarlik> ktp2 = kitap_islem.kitap_goster(kitapBilgi_txt.Text, konum);
                //entity kitapvarlik ktp2 nesnesi liste şeklinde türetilir
                //combobox icerisinde secilen konum degeri ve textbox icerisine girilen deger
                //parametreli kitap_goster fonksiyonuna gönderilir.
                dataGridView1.DataSource = ktp2;
                //kayitltda ktp2 listesi gosterilir
                tablo = "emanet_islemleri_kitap";
                MessageBox.Show("Arama başrılı!");
            }
            catch (Exception)//hata olustugunda calisir
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //aramanın neye göre yapılacağı bilgisini combobox'tan alıyoruz.
            konum = cmbKategori.SelectedItem.ToString();
        }
        private void AlinanTarih_date_ValueChanged(object sender, EventArgs e)
        {
            //emanet alınan tarih bilgisini datetimepicker yardımıyla alıyoruz.
            almaTarih_txt.Text = AlinanTarih_date.Value.ToShortDateString();
            DateTime emanettarih = DateTime.Parse(almaTarih_txt.Text);

            //emanet tarihine 20 gün ekleyerek son teslim tarihini belirliyoruz.
            almaTarih_txt.Text = emanettarih.AddDays(20).ToShortDateString();
        }
        private void btnOgrenciAra1_Click(object sender, EventArgs e)
        {
            //öğrenci tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                List<iadeVarlik> kayitcekme = islem.kayit_listeleme1(int.Parse(ogrenciNo2_txt.Text));
                dataGridView1.DataSource = kayitcekme;
                MessageBox.Show("Arama başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }

        }
        private void btnKitapAra1_Click(object sender, EventArgs e)
        {
            //kitap tablosundan istediğimiz verileri çekip datagridview'e yüklüyoruz.
            try
            {
                string konum = " ";
                konum = Ara_kategori_cmb.SelectedItem.ToString();
                List<iadeVarlik> kayit_cek_2 = islem.kayit_listeleme2(ktp_bilgi_txt.Text, konum);
                dataGridView1.DataSource = kayit_cek_2;
                MessageBox.Show("Arama başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");
            }
        }
        private void btnIade_Click(object sender, EventArgs e)
        {
            //tablo_iade_duzenleme fonksiyonuna gerekli parametreleri göndererek iade etme işlemini yapıyoruz.
            try
            {
                int Sonuc = islem.tablo_iade_duzenleme(int.Parse(ktp_ıd_txt.Text), int.Parse(ogr_Id_txt.Text), "iade");
                MessageBox.Show("İade başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("İade işlemi için lütfen alanları doldurunuz!");
            }
        }
        public void Emanet_iade_renk()
        {
            double ceza;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                string islem_turu = dataGridView1.Rows[i].Cells[6].Value.ToString();

                //eğer islem_turu iade'ye eşitse ilgili satırlar yeşil olur.
                if (islem_turu == "iade")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                //almaverme tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);


                    //eğer iade tarihine 3 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        dataGridView1.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        dataGridView1.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                }
            }
        }
        private void btnKayitlar_Click(object sender, EventArgs e)
        {
            veri_cek();//vericek fonksiyonuna gider
            Emanet_iade_renk();//emanet iade renk fonksiyonuna gider
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş yapılır.
            Anasayfa sayfa = new Anasayfa();
            sayfa.Show();
            this.Hide();
        }






    }
}
