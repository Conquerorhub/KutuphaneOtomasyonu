using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikKatmani
{
    //Diğer katmanlardan basit bir şekilde bu katmana erişebilmekteyiz.
    //Veritabanında bulunan elemanları veritabanı bağlı olmadan nesneler halinde kullanmamıza olanak sağlar.
    public class ogrenciVarlik
    {
        public int OgrenciID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int TC { get; set; }
        public string KayitTarihi { get; set; }
    }
}
