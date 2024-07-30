using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StokMarket
{
    internal class Kasa
    {
        public Urun[] urunler;


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
                if (urunler[i].ürünStok >= 0)
                {
                    Console.WriteLine((i + 1) + $") {urunler[i].ürünAdı}\t:{urunler[i].ürünFiyat}\tTL\tÜRÜN STOK MİKTARI = {urunler[i].ürünStok}");
                }
                else
                {
                    Console.WriteLine((i + 1) + $") {urunler[i].ürünAdı}\t:{urunler[i].ürünFiyat}\tTL\tÜRÜN STOKTA KALMAMIŞTIR");
                }

            }
        }
        public void StokAzalt(int p_urun, int p_adet)
        {
            int index = p_urun - 1;
            urunler[index].ürünStok -= p_adet;

        }
        public double AraToplam(int p_urun, int p_adet)
        {
            int index = p_urun - 1;
            return  urunler[index].ürünFiyat * p_adet;
        }

    }
}
