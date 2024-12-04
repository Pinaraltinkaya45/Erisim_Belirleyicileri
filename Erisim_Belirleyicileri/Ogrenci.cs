using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim_Belirleyicileri
{
    public class Ogrenci
    {
        private int id = 1;
        private string isim = "Enes";
        public string soyisim = "Bayram";
        public string okul = "Doğuş Üniversitesi";

        public void adSoyadYazdir()
        {
            Console.WriteLine("Adı: " + isim + "Soyadi: " + soyisim);
        }
       
        public void okulYazdir()
        {
            Console.WriteLine("Okul İsmi: " + okul);
        }

    }
}
