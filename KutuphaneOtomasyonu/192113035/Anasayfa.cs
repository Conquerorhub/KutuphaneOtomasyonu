using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _192113035
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Ogrenci_islemleri(object sender, EventArgs e)
        {
            OgrenciIslem ogrenci = new OgrenciIslem();//OgrenciIslem'den ogrenci nesnesi türetildi
            ogrenci.Show();//ogrenci formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Kitapislemleri_btn_Click(object sender, EventArgs e)
        {
            KitapIslem kitap = new KitapIslem();//KitapIslemleri'den kitap nesnesi türetildi
            kitap.Show();//kitap formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Emanetiade_btn_Click(object sender, EventArgs e)
        {
           EmanetTeslimIslem emanet = new EmanetTeslimIslem();//EmanetTeslimIslem'den emanet nesnesi türetildi
           emanet.Show();//emanet formunu goster
           this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Kitap_emanet_iade_btn_Click(object sender, EventArgs e)
        {
        KitapEmanetListe emanet_iade = new KitapEmanetListe();//Kitap_Emanet_iade_Listesi'den emanet_iade nesnesi türetildi
          emanet_iade.Show();//emanet_iade formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Ogrenci_emanet_iade_btn_Click_1(object sender, EventArgs e)
        {
          ogrenciEmanetListe ogrenci = new ogrenciEmanetListe();//Ogrenci_Emanet_Iade_Listesi'den ogrenci nesnesi türetildi
            ogrenci.Show();//ogrenci formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Grafik_btn_Click(object sender, EventArgs e)
        {
           GrafikOlusturma grafik = new GrafikOlusturma();//KitapGrafik'den grafik nesnesi türetildi
            grafik.Show();//grafik formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
