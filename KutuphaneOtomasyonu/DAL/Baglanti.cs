using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//Veri kaynağına yönelik açık bağlantı
using System.Data;//Verilerin bellekteki tuttuğu önbelleği
using System.Configuration;

namespace VeriErisimKatmani
{
    public class Baglanti
    {
        //Bu yapıyı veritabanı bağlantısını açmak için kullanıyoruz.
        OleDbConnection connection;//Connection Stringi yani bağlantıyı sağlar.

        public OleDbConnection baglanti
        {
            get
            {
                if (connection != null) //Eğer veritabanı bağlantısı boş deği ise
                {
                    if (connection.State == ConnectionState.Closed)//Veri kaynağıyla bağlantının geçerli olduğu durumda
                    {
                        connection.Open(); //Veritabanı baglantisini acar. 
                    }
                    return connection;//Değil ise baglantıyı geri döndürür.
                }
                else
                {
                    connection = new OleDbConnection(Provider());
                    //Bağlantı dizesine ait Provider() kod bloğuna erişerek belirtilen OLE DB sağlayıcısının adını almaktadır.
                    if (connection.State == ConnectionState.Closed)//Veri kaynağıyla bağlantının geçerli olduğu durumda
                    {
                        connection.Open();//Veritabanı baglantisini actırır.
                    }
                    return connection;//Degil ise baglantiyi geri döndürür.
                }

            }

        }

        //App.config'de bulunan veritabanı adresimizi almak için bir bağlantı cümlesi olusturmaktayız.
        private string Provider()
        {

            return veriTabani.DATA_ACCESS;
            //VeriErisimKatmani içerisinde Access.cs icerisine göndermekteyiz.
        }
    }
}
