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
            Console.WriteLine("");

            Kasa islem = new Kasa();

            string devam = "e";
           
            double geneltoplam = 0;
        
            while (devam == "e")
            {

                islem.UrunListele();

                Console.WriteLine("Almak istediğiniz ürün numarısını giriniz: ");
                int urunno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kaç adet " + islem.urunler[urunno - 1].ürünAdı + " almak istiyorsunuz");
                int adet = Convert.ToInt32(Console.ReadLine());

                if (islem.urunler[urunno - 1].ürünStok <= 0)
                {
                    Console.WriteLine("Ürün Stokta Yoktur");
                }
                else
                {
                    islem.StokAzalt(urunno, adet);
                    geneltoplam += islem.AraToplam(urunno, adet);
                }

                Console.WriteLine("Alışverişe devam etmek istiyor musunuz?e/h");
                devam = Console.ReadLine();

            }
            Console.WriteLine("TOPLAM = " + geneltoplam + " TL");
        }
    }
}
