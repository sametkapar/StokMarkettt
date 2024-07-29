using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MARKET");

            Kasa islem = new Kasa();

            string devam = "e";
           
            while(devam == "e")
            {
                
                islem.UrunListele();

                Console.WriteLine("Almak istediğiniz ürün numarısını giriniz: ");
                int urunno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kaç adet " + islem.urunler[urunno-1].ürünAdı + " almak istiyorsunuz");
                int adet = Convert.ToInt32(Console.ReadLine());
                islem.UrunAlma(urunno, adet);
                islem.UrunSepete(urunno);


                Console.WriteLine("Alışverişe devam etmek istiyor musunuz?e/h");
                devam = Console.ReadLine();

            }

        }
    }
}
