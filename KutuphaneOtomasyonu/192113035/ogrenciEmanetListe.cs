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
    public partial class ogrenciEmanetListe : Form
    {
        public ogrenciEmanetListe()
        {
            InitializeComponent();
        }
        kitapAlimIade kitap_iade_alim = new kitapAlimIade();
        public void Emanet_iade_renk()
        {

            double ceza;
            for (int i = 0; i < kayit_dg.Rows.Count; i++)
            {

                string islem_turu = kayit_dg.Rows[i].Cells[6].Value.ToString();

                //eğer islem_turu iade'ye eşitse ilgili satırlar yeşil olur.
                if (islem_turu == "iade")
                {
                    kayit_dg.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    kayit_dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                //almaverme tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(kayit_dg.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);


                    //eğer iade tarihine 3 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        kayit_dg.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        kayit_dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        kayit_dg.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        kayit_dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        kayit_dg.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        kayit_dg.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                }
            }
        }
        private void btnKayitlar_Click(object sender, EventArgs e)
        {
            //öğrencilerin daha önce yaptığı kitap alım ve iadeleri datagridview üzerinde gösterilir.
            List<iadeVarlik> kitap_iade = kitap_iade_alim.iade_alim_yukle();
            kayit_dg.DataSource = kitap_iade;
            MessageBox.Show("Kayıt gösterme başarılı!");
            Emanet_iade_renk();
        }
        private void btnArama_Click(object sender, EventArgs e)
        {
            //BL'daki iade_alim_islemleri sınıfından ogrenci_emanet_iade_listele fanksiyonu çalıştırılıp
            //arama textbox içindeki veri tablodan çağırılıp datagridview üzerinden
            //gösterilir.
            List<iadeVarlik> arama = kitap_iade_alim.ogrenci_emanet_iade_listele(ogrenciNumara_txt.Text);
            //EmaneTeslim den olusturulan arama nesnesi liste olarak  olusturulur
            //kitap_iade_alim  öğrenci numarası parametreli ogrenci_emanet_iade_listele 
            kayit_dg.DataSource = arama;
            MessageBox.Show("Arama Başarılı!");

        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa geri = new Anasayfa();
            geri.Show();
            this.Hide();
        }
    }
}
