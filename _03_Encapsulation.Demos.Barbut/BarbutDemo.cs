using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Encapsulation.Demos.Barbut
{
    class BarbutDemo
    {
         public static void Calistir()
        {
            string giris; // kullanıcının oynamak için evet (e), oyundan çıkmak için hayır (h) girişinin tutulacağı değişken

            Zar zar = new Zar(); // zar model objesi

            int zarSayi1, zarSayi2; // 1. ve 2. zarların sayısal değerlerinin tutulacağı değişkenler

            string zarYuz1, zarYuz2; // 1. ve 2. zarların yüzlerinin tutulacağı değişkenler

            Console.Write("Barbut oynamak ister misiniz? (e: evet, h: hayır) ");
            giris = Console.ReadLine().ToLower(); // while döngüsü için giris değişkenine ilk değer ataması,
                                                  // kullanıcı girişini ToLower methodu ile küçük harfe dönüştürüp giris değişkenine atıyoruz
                                                  // ki kolayca while'da ve if'te koşulları küçük harf üzerinden kontrol edebilelim

            while (giris != "h") // kullanıcı h girene kadar oyun devam edecek 
            {
                if (giris == "e") // kullanıcı e girdiyse oyunu oynatıyoruz
                {
                    // zarların atılması:
                    zarSayi1 = zar.At();
                    zarYuz1 = zar.Yuz;
                    zarSayi2 = zar.At();
                    zarYuz2 = zar.Yuz;

                    // gelen zarların yüzlerinin gösterimi:
                    Console.Write($"1. zar: {zarSayi1}");
                    Console.WriteLine(zarYuz1);
                    Console.Write($"2. zar: {zarSayi2}");
                    Console.WriteLine(zarYuz2);

                    // hangi zarın kazandığının belirlenmesi:
                    if (zarSayi1 == zarSayi2)
                        Console.WriteLine("Berabere.");
                    else if (zarSayi1 > zarSayi2)
                        Console.WriteLine("1. zar kazandı.");
                    else // if (zarSayi1 < zarSayi2) // son koşul olduğu için if koşulunu yazmaya gerek yok
                        Console.WriteLine("2. zar kazandı.");

                    Console.Write("Tekrar oynamak ister misiniz? (e: evet, h: hayır) ");
                }
                else // kullanıcı giriş validasyonu: kullanıcı e veya h girmediyse
                {
                    Console.Write("Lütfen evet için \"e\", hayır için \"h\" giriniz: "); // kullanıcıya e veya h girmesi gerektiği mesajını gösteriyoruz
                }
                giris = Console.ReadLine().ToLower(); // while döngüsü için giris değişkenine güncel değer ataması
            }
        }

    }
}
