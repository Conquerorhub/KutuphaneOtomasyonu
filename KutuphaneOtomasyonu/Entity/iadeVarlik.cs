using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikKatmani
{
    //Diğer katmanlardan basit bir şekilde bu katmana erişebilmekteyiz.
    //Veritabanında bulunan elemanları veritabanı bağlı olmadan nesneler halinde kullanmamıza olanak sağlar.
    //Access veritabanındaki bulunan iade tablosundaki sütunlara ait tanımlamalar bu sekildedir;


    public class iadeVarlik
    {
        public int KitapID { get; set; }
        public int OgrenciID { get; set; }
        public string EmanetTarihi { get; set; }
        public string IadeTarihi { get; set; }
        public string IadeEdilenTarih { get; set; }
        public string Borc { get; set; }
        public string IslemTuru { get; set; }
    }
}
