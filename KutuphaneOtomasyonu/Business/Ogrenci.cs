using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikKatmani;
using System.Data;
using System.Data.OleDb;

namespace IsKatmani
{
    public class Ogrenci
    {
        VeriErisimKatmani.DAL data = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data nesnesi oluşturma 
        public List<ogrenciVarlik> ogrenci_goster()
        //ogrenci goster fonksiyonunu entity katmanindaki ogrenciVarlik sınıfından 
        //koleksiyon(liste) şeklinde olusturuyor
        {

            OleDbDataReader dr = data.DRVeriCek("SELECT * FROM Ogrenci", CommandType.Text);
            //veritabanından Ogrenci tablosundaki değerleri çekiyoruz.
            if (dr.HasRows)
            //DAL'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<ogrenciVarlik> ogrenciler = new List<ogrenciVarlik>();
                while (dr.Read())
                {
                    //entity katmanindaki ogrenciVarlik uzerinden ogrenci adinda nesne olusturuyor
                    //Ogrencvarlik'da tanimladigimiz elemanlari türlerine göre stringe donusturme islemi
                    ogrenciVarlik ogrenci = new ogrenciVarlik
                    {
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()),
                        Isim = dr["Isim"].ToString(),
                        Soyisim = dr["Soyisim"].ToString(),
                        TC = int.Parse(dr["TC"].ToString()),
                        KayitTarihi = dr["KayitTarihi"].ToString()
                    };
                    ogrenciler.Add(ogrenci);//Ogrenciler koleksiyonuna(listesine) yeni girilen ogrenci bilgilerini ekler
                }
                return ogrenciler; //koleksiyon icin olusturulan ogrenciler nesnesi geri donduruluyor
            }

            return null;
        }

        VeriErisimKatmani.DAL data1 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data1 nesnesi oluşturma 
        public List<ogrenciVarlik> ogrenci_goster(int OgrenciID)
        //ogrenci goster fonksiyonunu entity katmanindaki ogrenciVarlik sınıfından 
        //koleksiyon(liste) şeklinde olusturuyor
        {
            OleDbDataReader dr = data1.DRVeriCek("SELECT * FROM Ogrenci WHERE OgrenciID=" + OgrenciID.ToString(), System.Data.CommandType.Text);
            //veritabanından ogrenci tablosundaki değerleri çekiyoruz.
            if (dr.HasRows)
            //DAL'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<ogrenciVarlik> ogrenciler = new List<ogrenciVarlik>();
                while (dr.Read())
                {
                    //entity katmanindaki ogrenciVarlik uzerinden ogrenci adinda nesne olusturuyor
                    //Ogrencvarlik'da tanimladigimiz elemanlari türlerine göre stringe donusturme islemi
                    ogrenciVarlik ogrenci = new ogrenciVarlik
                    {
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()),
                        Isim = dr["Isim"].ToString(),
                        Soyisim = dr["Soyisim"].ToString(),
                        TC = int.Parse(dr["TC"].ToString()),
                        KayitTarihi = dr["KayitTarihi"].ToString()
                    };
                    ogrenciler.Add(ogrenci);
                    //Ogrenciler koleksiyonuna(listesine) yeni girilen ogrenci bilgilerini ekler
                }
                return ogrenciler;//koleksiyon icin olusturulan ogrenciler nesnesi geri donduruluyor
            }
            return null;
        }


        VeriErisimKatmani.DAL data2 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data2 nesnesi oluşturma 
        public int ogr_ekle(string OgrenciID, string Isim, string Soyisim, int TC,  string KayitTarihi)
        //eklenecek olan her veri tabanindaki  alan veri tipleri ile birlikte paremetrenin icerisine eklendi
        {
            //öğrenci eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data2.EkleSilGuncelle("INSERT into Ogrenci (OgrenciID,Isim,Soyisim,TC,KayitTarihi)"+
                " VALUES ('" + OgrenciID + "','" + Isim + "','" + Soyisim + "','" + TC + "','" 
                 + KayitTarihi + "')", System.Data.CommandType.Text);
            //Veri tabanindaki Ogrenci tablosuna entityde tanimli alanların eklenmesi islemi
            return sonuc;//sonuc degeri donduruluyor
        }


        VeriErisimKatmani.DAL data3 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data3 nesnesi oluşturma 
        public int ogr_guncelle(int OgrenciID, string Isim, string Soyisim, int TC, string KayitTarihi)
        //eklenecek olan her veri tabanindaki  alan veri tipleri ile birlikte paremetrenin icerisine eklendi

        {
            //öğrenci güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data3.EkleSilGuncelle("UPDATE Ogrenci SET Isim='" + Isim + "', Soyisim='" + Soyisim + "', TC=" + TC + "" +
                ",KayitTarihi='" + KayitTarihi + "' WHERE OgrenciID=" + OgrenciID + "", System.Data.CommandType.Text);
            //Veri tabanindaki Ogrenci tablosuna entityde tanimli alanların guncelleme islemi

            return sonuc;//sonuc degeri donduruluyor
        }

        VeriErisimKatmani.DAL data4 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data4 nesnesi oluşturma 
        public int ogr_sil(int OgrenciID)
        //Silme islemini ogrenciId gore yapilmaktadir
        {
            //öğrenciyi silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data4.EkleSilGuncelle("DELETE from Ogrenci where OgrenciID =" + OgrenciID + "", System.Data.CommandType.Text);
            return sonuc;//sonuc degerini donduruyor
        }
    }
}
