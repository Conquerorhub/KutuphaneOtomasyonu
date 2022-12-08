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
    public class kitapAlimIade
    {
        VeriErisimKatmani.DAL data = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data nesnesi oluşturma 

        public List<iadeVarlik> iade_alim_yukle()
        {
            //iade alim yukle fonksiyonunu entity katmanindaki iadeVarlik sınıfından 
            //koleksiyon(liste) şeklinde olusturuyor

            OleDbDataReader dr = data.DRVeriCek("Select * from iadeVarlik", CommandType.Text);
            //DAL katmanı yardımıyla almaverme tablosundaki verilerimizi çekiyoruz.
            if (dr.HasRows)//DAL'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                List<iadeVarlik> islem_kayit = new List<iadeVarlik>();//bu değerleri bir liste ile geri döndürüyoruz.

                while (dr.Read())
                {
                    //tablodaki verileri çekip yukle listesine ekliyoruz. 
                    iadeVarlik yukle = new iadeVarlik
                    {
                        KitapID = int.Parse(dr["KitapID"].ToString()),
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()),
                        EmanetTarihi = dr["EmanetTarihi"].ToString(),
                        IadeTarihi = dr["IadeTarihi"].ToString(),
                        IadeEdilenTarih = dr["IadeEdilenTarih"].ToString(),
                        Borc = dr["Borc"].ToString(),
                        IslemTuru = dr["IslemTuru"].ToString()
                    };

                    islem_kayit.Add(yukle);//islem_kayit koleksiyonuna(listesine) yeni girilen emanet bilgilerini ekler

                }
                return islem_kayit; //listeyi geri yolluyoruz.
            }

            return null;
        }

        VeriErisimKatmani.DAL data1 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data1 nesnesi oluşturma 

        public int tablo_iade_duzenleme(int KitapID, int OgrenciID, string IslemTuru)
        {
            //almaverme tablosundaki verileri güncellemek için sorgumuzu OgrenciID ve KitapID'ye  gore gönderiyoruz.
            int Sonuc = data1.EkleSilGuncelle("update iadeVarlik set IslemTuru='" + IslemTuru + "' " +
                "where OgrenciID=" + OgrenciID + " and KitapID = " + KitapID + "", System.Data.CommandType.Text);

            return Sonuc;//sonuc degerini donduruyor
        }



        public List<iadeVarlik> kayit_listeleme1(int OgrenciNo)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = data1.DRVeriCek("Select * from iadeVarlik where OgrenciID in " +
                "(select OgrenciID from Ogrenci where OgrenciNo ='" + OgrenciNo + "') ", CommandType.Text);

            if (dr.HasRows)//DAL'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<iadeVarlik> islem_kayit = new List<iadeVarlik>();
                while (dr.Read())//tablodaki verileri çekip yukle listesine ekliyoruz. 

                {



                    iadeVarlik kaydet = new iadeVarlik
                    {
                        KitapID = int.Parse(dr["KitapID"].ToString()),
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()),
                        EmanetTarihi = dr["EmanetTarihi"].ToString(),
                        IadeTarihi = dr["IadeTarihi"].ToString(),
                        IadeEdilenTarih = dr["IadeEdilenTarih"].ToString(),
                        Borc = dr["Borc"].ToString(),
                        IslemTuru = dr["IslemTuru"].ToString()
                    };
                    //tablodaki verileri çekip yukle listesine ekliyoruz. 

                    islem_kayit.Add(kaydet); //islem_kayit koleksiyonuna(listesine) yeni girile n emanet bilgilerini kaydeder
                }
                return islem_kayit;//listeyi geri yolluyoruz.
            }

            return null;
        }

        VeriErisimKatmani.DAL data2 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data2 nesnesi oluşturma 

        public int emanet_islemi(int KitapID, int OgrenciID, DateTime EmanetTarihi, DateTime IadeTarihi, string IslemTuru)
        //eklenecek olan her veri tabanindaki  alan veri tipleri ile birlikte parametrenin icerisine eklendi

        {

            //emanet vermek için almaverme tablosuna gerekli verileri yolluyoruz.
            int Sonuc = data2.EkleSilGuncelle("insert into iadeVarlik (KitapID,OgrenciID,EmanetTarihi,IadeTarihi,IslemTuru) " +
                "values (" + KitapID + "," + OgrenciID + ",'" + EmanetTarihi + "','" + IadeTarihi + "','" + IslemTuru + "')",
                System.Data.CommandType.Text);
            return Sonuc;//sonuc degerini dondurur
        }



        VeriErisimKatmani.DAL data3 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data3 nesnesi oluşturma 

        public List<iadeVarlik> ogrenci_emanet_iade_listele(string deger)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = data3.DRVeriCek("Select * from iadeVarlik where OgrenciID in" +
                " (Select OgrenciID from Ogrenci where OgrenciNo='" + deger + "')", CommandType.Text);
            //Verileri iadeVarlik ve Ogrenci tablosundan cekiyor
            if (dr.HasRows) //DAL'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<iadeVarlik> islem_kayit = new List<iadeVarlik>();
                while (dr.Read())//tablodaki verileri çekip yukle listesine ekliyoruz. 

                {
                    iadeVarlik kayit_etme = new iadeVarlik
                    {
                        KitapID = int.Parse(dr["KitapID"].ToString()),
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()),
                        EmanetTarihi = dr["EmanetTarihi"].ToString(),
                        IadeTarihi = dr["IadeTarihi"].ToString(),
                        IadeEdilenTarih = dr["IadeEdilenTarih"].ToString(),
                        Borc = dr["Borc"].ToString(),
                        IslemTuru = dr["IslemTuru"].ToString()
                    };

                    islem_kayit.Add(kayit_etme); //islem_kayit koleksiyonuna(listesine) yeni girilen emanet bilgilerini kaydeder

                }
                return islem_kayit; //islem_kayit degerini donduruyor
            }

            return null;
        }


        VeriErisimKatmani.DAL data4 = new VeriErisimKatmani.DAL();
        //VeriErisimKatmani katmanindaki DAL sinifindan data4 nesnesi oluşturma 

        public List<iadeVarlik> kayit_listeleme2(string deger, string konum)
        {
            //listelemeyi değer ve konum parametrelerine gore yapıyoruz
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
            OleDbDataReader dr = data4.DRVeriCek("Select * from iadeVarlik where KitapID in (Select KitapID from Kitap where "
                + konum + " ='" + deger + "')", CommandType.Text);
            if (dr.HasRows)//DAL'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<iadeVarlik> islem_kayit = new List<iadeVarlik>();
                while (dr.Read())//tablodaki verileri çekip yukle listesine ekliyoruz. 

                {
                    iadeVarlik kayit_etme = new iadeVarlik
                    {
                        KitapID = int.Parse(dr["KitapID"].ToString()),
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()),
                        EmanetTarihi = dr["EmanetTarihi"].ToString(),
                        IadeTarihi = dr["IadeTarihi"].ToString(),
                        IadeEdilenTarih = dr["IadeEdilenTarih"].ToString(),
                        Borc = dr["Borc"].ToString(),
                        IslemTuru = dr["IslemTuru"].ToString()
                    };

                    islem_kayit.Add(kayit_etme);//islem_kayit koleksiyonuna(listesine) yeni girilen emanet bilgilerini kaydeder

                }
                return islem_kayit; //islem_kayit degerini donduruyor
            }

            return null;
        }
    }
}
