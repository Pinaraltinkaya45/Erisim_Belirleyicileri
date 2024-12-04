using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Erisim_Belirleyicileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Private: sahip olduğu class içinde erişilebilen, sadece bulunduğu classa özgüdür
            // Public: hiç bir kısıtlaması olmayan her yerden erişmemize olanak sağlayan erişim belirleyicisidir
          

            Ogrenci ogrenci = new Ogrenci();

            Console.WriteLine(ogrenci.okul);
            Console.WriteLine(ogrenci.soyisim);
            ogrenci.okulYazdir();

            Console.ReadLine();
        }
    }
}
