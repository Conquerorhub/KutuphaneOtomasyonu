using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikKatmani
{
    //Diğer katmanlardan basit bir şekilde bu katmana erişebilmekteyiz.
    //Veritabanında bulunan elemanları veritabanı bağlı olmadan nesneler halinde kullanmamıza olanak sağlar.
    
    //Acces veritabanında bulunan Kitap tablosundaki sütunlara ait tanımlamalar bu şekildedir;
    public class kitapVarlik
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public int SayfaSayisi { get; set; }
        public string KitapTuru { get; set; }

    }
}
