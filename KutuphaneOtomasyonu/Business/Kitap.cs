using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using VarlikKatmani;

namespace IsKatmani
{
    public class Kitap
    {
        VeriErisimKatmani.DAL data = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data nesnesi oluşturma 

        public List<kitapVarlik> kitap_goster()
        //Kitap goster fonksiyonunu entity katmanindaki kitapVarlik sınıfından 
        //koleksiyon(liste) şeklinde olusturuyor
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = data.DRVeriCek("SELECT * FROM Kitap", CommandType.Text);
            if (dr.HasRows)
            //DAL'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<kitapVarlik> kitaplar = new List<kitapVarlik>();
                while (dr.Read())
                //entity katmanindaki kitapVarlik uzerinden kitaplar adinda nesne olusturuyor
                //kitapVarlik'da tanimladigimiz elemanlari türlerine göre stringe donusturme islemi

                {
                    kitapVarlik ktp = new kitapVarlik
                    {
                        KitapID = int.Parse(dr["KitapID"].ToString()),
                        KitapAdi = dr["KitapAdi"].ToString(),
                        YazarAdi = dr["YazarAdi"].ToString(),
                        SayfaSayisi = int.Parse(dr["SayfaSayisi"].ToString()),
                        KitapTuru = dr["KitapTuru"].ToString(),
                    };

                    kitaplar.Add(ktp);    //Kitaplar koleksiyonuna(listesine) yeni girilen kitap bilgilerini ekler

                }
                return kitaplar;  //koleksiyon icin olusturulan kitaplar nesnesi geri donduruluyor

            }

            return null;
        }
        VeriErisimKatmani.DAL data1 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data1 nesnesi oluşturma 

        public List<kitapVarlik> kitap_goster(string deger, string konum)
        //Kitap goster fonksiyonunu entity katmanindaki kitapVarlik sınıfından 
        //koleksiyon(liste) şeklinde olusturuyor
        //kitapgoster islemi parametre olarak deger ve konum aldigi icin bu islem bu parametrelere baglidir

        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = data1.DRVeriCek("SELECT * FROM Kitap WHERE " + konum + " ='" + deger + "'", CommandType.Text);
            if (dr.HasRows)
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<kitapVarlik> kitaplar = new List<kitapVarlik>();
                while (dr.Read())
                {
                    kitapVarlik ktp = new kitapVarlik
                    {
                        KitapID = int.Parse(dr["KitapID"].ToString()),
                        KitapAdi = dr["KitapAdi"].ToString(),
                        YazarAdi = dr["YazarAdi"].ToString(),
                        SayfaSayisi = int.Parse(dr["SayfaSayisi"].ToString()),
                        KitapTuru = dr["KitapTuru"].ToString(),
                    };
                    kitaplar.Add(ktp);// Kitaplar koleksiyonuna(listesine) yeni girilen kitap bilgilerini ekler

                }
                return kitaplar;//koleksiyon icin olusturulan kitaplar nesnesi geri donduruluyor

            }

            return null;
        }

        VeriErisimKatmani.DAL data2 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data2 nesnesi oluşturma 

        public int ktp_ekle(int KitapID, string KitapAdi, string YazarAdi,int SayfaSayisi,
            string KitapTuru)
        //eklenecek olan her veri tabanindaki  alan veri tipleri ile birlikte parametrenin icerisine eklendi

        {
            //kitap eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data2.EkleSilGuncelle("INSERT into Kitap (KitapID,KitapAdi,YazarAdi,SayfaSayisi,KitapTuru)" +
                            " VALUES ('" + KitapID + "','" + KitapAdi + "','" + YazarAdi + "','" + SayfaSayisi + "','"
                             + KitapTuru + "')", System.Data.CommandType.Text);
            //Veri tabanindaki Kitap tablosuna entityde tanimli alanların eklenmesi islemi

            return sonuc;//sonuc degeri donduruluyor
        }

        VeriErisimKatmani.DAL data3 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data3 nesnesi oluşturma 

        public int ktp_guncelle(int KitapID, string KitapAdi, string YazarAdi,int SayfaSayisi,
            string KitapTuru)
        //guncellenecek olan her veri tabanindaki  alan veri tipleri ile birlikte paremetrenin icerisine eklendi

        {
            //kitap güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data3.EkleSilGuncelle("UPDATE Kitap SET KitapAdi='" + KitapAdi + "', YazarAdi='" + YazarAdi + "', SayfaSayisi=" + SayfaSayisi + "" +
               ",KitapTuru='" + KitapTuru + "' WHERE KitapID=" + KitapID + "", System.Data.CommandType.Text);
            //Veri tabanindaki Kitap tablosuna entityde tanimli alanların guncelleme islemi bu islem KitapID'ye göre yapilmaktadir

            return sonuc;//sonuc degeri donduruluyor
        }

        VeriErisimKatmani.DAL data4 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data4 nesnesi oluşturma 

        public int ktp_sil(int KitapID)
        {
            //Silme islemini KitapId gore yapilmaktadir

            //kitap silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data4.EkleSilGuncelle("DELETE from Kitap where KitapID =" + KitapID + "", System.Data.CommandType.Text);
            return sonuc;//sonuc degerini donduruyor
        }
    }
}
