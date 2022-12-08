using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikKatmani;
using VeriErisimKatmani;
using System.Data;
using System.Data.OleDb;
namespace IsKatmani
{
    public class Grafik
    {
        VeriErisimKatmani.DAL data = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data nesnesi oluşturma 

        public int listele()
        {
            //veritabanından kitap sayılarını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;//sayaca ilk olarak 0 degeri atanıyor
            OleDbDataReader dr = data.DRVeriCek("Select KitapID from Kitap", CommandType.Text);
            //Veri tabanindaki Kitap tablosundan veri cekiyoruz
            if (dr.HasRows)
            //bu değerleri bir liste ile geri döndürüyoruz.

            {
                List<kitapVarlik> kitaplar = new List<kitapVarlik>();
                //entity katmanindaki kitapVarlik uzerinden kitaplar adinda nesne olusturuyor
                //kitapVarlik'da tanimladigimiz elemanlari türlerine göre stringe donusturme islemi

                while (dr.Read())
                {
                    sayac++; //sayac arttırıyoruz
                }
                return sayac;//sayac geri donduruluyor
            }

            return 0;
        }

        VeriErisimKatmani.DAL data1 = new VeriErisimKatmani.DAL();
        //DAL katmanindaki DAL sinifindan data1 nesnesi oluşturma 

        public int alma()
        {
            //veritabanında işlem türü alım olan verilerin sayısını bir sayaçta tutup geri döndürüyoruz.
            int sayac = 0;//sayaca 0 atamasi yapiliyor
            OleDbDataReader dr = data1.DRVeriCek("Select * from EmaneTeslim where IslemTuru='" + "alım" + "'", CommandType.Text);
            //veritabanindan EmanTeslm tablosundan verileri okunuyor
            if (dr.HasRows)
            {
                List<kitapVarlik> kitaplar = new List<kitapVarlik>();
                //kitaplar adinda kitap varlik listesinin nesnesi olusturluyor
                while (dr.Read())
                {
                    sayac++;//sayac bir arttiriliyor
                }
                return sayac;//sayac degeri geri donduruluyor
            }

            return 0;
        }
    }
}
