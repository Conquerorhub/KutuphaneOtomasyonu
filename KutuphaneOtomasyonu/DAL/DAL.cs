using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace VeriErisimKatmani
{
    public class DAL
    {
        
        //Bu fonksiyonu acces veritabında sorgu yazabilmek için kullanıyoruz
        private OleDbCommand SorguYaz(string Sorgu, CommandType SorguTipi)
        {
            Baglanti baglanti = new Baglanti();
            //Data Access Layer'da bulunan Baglanti.cs'den baglantı isminde yeni bir nesne oluşturduk.
            OleDbCommand cmd = baglanti.baglanti.CreateCommand();
            //baglanti ile ilişkisi olan bir cmd nesnesi oluşturur ve bu cmd nesnesini döndürmektedir. 
            cmd.CommandText = Sorgu;
            
            //Veri kaynağında yürütülecek sorguyu cmd nesnesine atar
            cmd.CommandType = SorguTipi;
            //Commandtype Özelliğinin nasıl bir şekilde yorumlanacağını göstermek için bir değer alır.
            return cmd;
        }

        List<OleDbParameter> Parametreler = new List<OleDbParameter>();
        //Parametreler adında veri tabanı listesi oluşturuldu

        
        //Bu fonksiyonu veritabanına parametre eklemek için kullanmaktayız.
        public void InputParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            OleDbParameter parametre = new OleDbParameter();
            //Parametre adlı nesne oluşturuldu.
            parametre.ParameterName = ParametreAdi;
            //parametre nesnesinin parametrename'ini ParametreAdi'na verildi.
            parametre.Value = ParametreDegeri;
            //parametre nesnesinin value'sini ParametreDegeri'ne verildi.
            Parametreler.Add(parametre);
            //Parametrelere eklenmeye devam ediliyor.
        }

        public void OutParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            OleDbParameter parametre = new OleDbParameter(); //nesne oluşturma
            parametre.ParameterName = ParametreAdi;
            //Parametre nesnesinin parametrename'ini ParametreAdi'na verildi.
            parametre.Value = ParametreDegeri;
            //parametre nesnesinin value'sini ParametreDegeri'ne verildi.
            parametre.Direction = ParameterDirection.Output;
            //parametre nesnesinin direction'nu ParametreDegeri'ne verildi.

            Parametreler.Add(parametre);//Parametrelere eklenmeye devam ediliyor.
        }

        
        //Bu fonksiyonu alınan parametreleri sorguya eklemek için kullanıyoruz.
        private void ParametreleriSorguyaEkle(OleDbCommand CommandNesnesi)
        {
            CommandNesnesi.Parameters.AddRange(Parametreler.ToArray());
            //Parametreler koleksiyonunun öğelerini veritabanının son kısmına eklendi.
        }

        //Parametreye ait değeri almak için kullanıyoruz.
        public object ParametreDeğeriniGetir(string ParametreAdi)
        {
            foreach (var item in Parametreler)//Paremetre sayısı  kadar döngüye girilmektedir.
            {
                if (item.ParameterName == ParametreAdi)//ParametreAdi item'in ParameterName'ine eşit ise
                {
                    return item.Value.ToString(); //İtem'a ait value değerini stringe dönüştürüp döndürür.
                }
            }
            return null;
        }

        
        //Bu fonksiyon ile veritabanında ekleme,silme,güncelleme sorgu işlemlerini gerçekleştiriyoruz.
        public int EkleSilGuncelle(string Sorgu, CommandType SorguTipi)
        {
            try  //Hata oluşma ihtimaline dair kod bloğu
            {
                OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi);//cmd nesnesi olusturuldu.
                ParametreleriSorguyaEkle(cmd); //Cmd isimli nesne fonksiyona gönderilir.
                int sonuc = cmd.ExecuteNonQuery();//cmd yürütülür ve bundan etkilenen satır sayısını döndürmektedir.
                if (cmd.Connection.State == ConnectionState.Open)//Eğer bağlantı açık ise
                {
                    cmd.Connection.Close();//baglantı kapatılır.
                }
                cmd.Connection.Dispose();
         
                //Yönetilmeyen tüm kaynakları kaldırır ve bağlantının tekrar kullanmasını engellemek için tamamen temizlenir
                cmd.Dispose();
                return sonuc;
            }
            catch (Exception) //Try kısmında  hata olur ise bu kısım calısmaktadır.
            {

                throw;
            }


        }

        public object IlkSatirIlkSutun(string Sorgu, CommandType SorguTipi)
        {

            try
            {
                OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi);
                ParametreleriSorguyaEkle(cmd);
                object Sonuc = cmd.ExecuteScalar();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Connection.Dispose();
                cmd.Dispose();
                return Sonuc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        //Bu fonksiyon ile veritabanından veri çekme sorgularını gerçekleştiriyoruz.
        public OleDbDataReader DRVeriCek(string Sorgu, CommandType SorguTipi)
        {
            OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi); //Cmd nesnesi
            ParametreleriSorguyaEkle(cmd);//Cmd fonksiyonuna gönderildi.
            OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //Cmd nesnesinin veritabanı ile bağlantısını kapatmak için dr nesnesi oluşturur.
            return dr;//Dr'yi döndürür.
        }

        public DataTable DTVeriCek(string Sorgu, CommandType SorguTipi)
        {
            try //Hata oluşma ihtimaline dair kod bloğu
            {
                OleDbDataReader dr = DRVeriCek(Sorgu, SorguTipi);
                //Dr nesnesi ile DataReader okuma işlemi yapar.
                DataTable dt = new DataTable();
                //Dt nesnesi oluşturulup Data Table'daki DataReader'ın verilerini döndürür.
                dt.Load(dr); // Dt nesnesini kullanarak bir veritabanından değerleri yükler.
                return dt;//dt dondurur
            }
            catch (Exception) //Try kısmında  hata olustuğu an çalışır.
            {

                throw;
            }
        }
    }
}
