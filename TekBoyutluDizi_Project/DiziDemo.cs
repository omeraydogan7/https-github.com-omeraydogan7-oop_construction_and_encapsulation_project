using System;
using System.Collections.Generic;
using System.Text;

namespace TekBoyutluDizi_Project
{
    class DiziDemo
    {
        public static void Calistir()
        {
            TekBoyutluDizi sayisalDizi = new TekBoyutluDizi()
            {
                Dizi = new double[] { 8, 1, 5, 6, 1.4, 9, 4, 2, 7, 1.6 }
            };

            // dizi elemanlarının ayraç olarak boşluk ile gösterimi:
            sayisalDizi.Goster(" ");

            Console.WriteLine("\n");

            // dizi elemanlarının default (varsayılan) ayraç ile gösterimi:
            sayisalDizi.Goster();

            Console.WriteLine();

            // dizinin eleman sayısı:
            Console.WriteLine($"Dizi eleman sayısı: {sayisalDizi.Boyut}");

            // dizi elemanlarının toplamı:
            Console.WriteLine($"Dizi elemanları toplamı: {sayisalDizi.Topla()}");

            // dizi elemanlarının ortalaması:
            Console.WriteLine($"Dizi elemanlarının ortalaması: {sayisalDizi.OrtalamaHesapla()}");

            // minimum dizi elemanı:
            Console.WriteLine($"Minimum eleman: {sayisalDizi.MinimumuGetir()}");

            // maksimum dizi elemanı:
            Console.WriteLine($"Maksimum eleman: {sayisalDizi.MaksimumuGetir()}");
        }


    }
}
