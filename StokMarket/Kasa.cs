using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StokMarket
{
    internal class Kasa
    {
        public Urun[] urunler;
        public double[] toplam;

        public Kasa()
        {
            urunler = new Urun[3];

            Urun urun1 = new Urun();
            urun1.ürünAdı = "Domates";
            urun1.ürünFiyat = 13.4;
            urun1.ürünStok = 30;
            urunler[0] = urun1;

            Urun urun2 = new Urun();
            urun2.ürünAdı = "Biber";
            urun2.ürünFiyat = 38;
            urun2.ürünStok = 20;
            urunler[1] = urun2;

            Urun urun3 = new Urun();
            urun3.ürünAdı = "Soğan";
            urun3.ürünFiyat = 17.9;
            urun3.ürünStok = 15;
            urunler[2] = urun3;

        }

        public void UrunListele()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                if (urunler[i].ürünStok != 0)
                {
                    Console.WriteLine((i + 1) + $") {urunler[i].ürünAdı} {urunler[i].ürünFiyat}\tTL\tÜRÜN STOK MİKTARI = {urunler[i].ürünStok}");
                }
                else
                {
                    Console.WriteLine((i + 1) + $") {urunler[i].ürünAdı} {urunler[i].ürünFiyat}\tTL\tÜRÜN STOKTA KALMAMIŞTIR");
                }
                
            }
        }
        public void UrunAlma(int p_urun)
        {
            double toplam = 0;
            for (int i = 0; i < urunler.Length; i++)
            {
                if ((i + 1) == p_urun && urunler[i].ürünStok != 0)
                {
                    Console.WriteLine("Kaç adet " + urunler[i].ürünAdı + " almak istersiniz?");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    urunler[i].ürünStok -= adet;

                    toplam += (adet * urunler[i].ürünFiyat);

                    break;
                }


            }

        }
        public void UrunSepete()
        {
            

        }

    }
}
