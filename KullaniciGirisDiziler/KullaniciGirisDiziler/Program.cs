using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "cinar topcinar", "kerem mert eryigit", "sarp toygar akkaya", "efee ogul", "ezel cetinkaya" };
            string[] numaralar = { "500", "501", "502", "503", "504" };
            string[] kullaniciadlari = { "c.topcinar", "k.eryigit", "s.akkaya", "e.ogul", "e.cetinkaya" };
            string[] sifreler = { "1234", "1235", "1236", "1237", "1238" };

            Console.WriteLine("kullanici adinizi giriniz");
            string kullaniciad = Console.ReadLine();

            Console.WriteLine("sifrenizi giriniz");
            string sifree = Console.ReadLine();

            bool kullanicivarmi = false;
            int kullaniciindex = -1;

            for (int i = 0; i < isimler.Length; i++)
            {
                if (kullaniciad == kullaniciadlari[i])
                {
                    kullanicivarmi = true;
                    kullaniciindex = i;
                    
                }

            }
            if (kullanicivarmi == true)
            {
                if (sifree == sifreler[kullaniciindex])
                {
                    Console.WriteLine("merhaba");
                    Console.WriteLine("no: " + numaralar[kullaniciindex] + " " + isimler[kullaniciindex]);
                }
                else
                {
                    Console.WriteLine("sifre hatali");
                }
            }
            else
            {
                Console.WriteLine("kullanici  bulunamadi");
            }

        }
    }
}
