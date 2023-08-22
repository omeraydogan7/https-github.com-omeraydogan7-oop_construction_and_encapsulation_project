using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationProje
{
    class CH_MainProgram
    {
        // Encapsulation: class'ların field'lerine (alanlarına) public olarak ulaşmak yerine field'ler için set ve get methodları üzerinden kapsülleyerek yönetmektir,
        // public olan property kullanımı ile encapsulation gerçekleştirilmiş olur. 
        // Eğer istenirse alanların set veya get davranışlarında veya özelliklerin setter veya getter'larında koda müdahele edilerek özelliştirme yapılabilir. 
        // Örneğin bir cüzdan ortada bırakılıp herkesin ulaşabilmesi sağlanmamalıdır (public field),
        // bunun yerine cüzdana sanki izin alınıyormuş gibi setter ve getter'larla ulaşılmalıdır.

        static void CH_Main()
        {
            // Musteri class'ının namespace'i, Program class'ının namespace'inden farklı olduğundan ya Musteri class'ının namespace'i ile birlikte kullanılabilir
            // ya da using ile en yukarıya Musteri class'ının namespace'i eklenir.

            //_03_Encapsulation.Models.Musteri musteri1 = new _03_Encapsulation.Models.Musteri()  // 1. yöntem
            //Models.Musteri musteri1 = new Models.Musteri()  // 2. yöntem
            CH_Musteri ch_musteri_1 = new CH_Musteri() // 3. yöntem, using en yukarıya eklenir
            {
                Adi = "Çağıl",
                Soyadi = "Alsaç",
                Yasi = 42,
                CepTelefonu = "0 532 111 22 33",
                Adresi = "Çankaya, Ankara, Türkiye",
                KrediKartiNumarasi = "1234 5678 9012 3456",
                KadinMi = false
            };
            // Class üzerinden obje new'lenirken (initialization) class özellikleri set edilebilir.

            // Ya da class üzerinden obje new'lendikten sonra (initialization) class özellikleri set edilebilir.
            CH_Musteri ch_musteri_2 = new CH_Musteri();
            ch_musteri_2.Adi = "Luna";
            ch_musteri_2.Soyadi = "Alsaç";
            ch_musteri_2.Yasi = 1;
            ch_musteri_2.CepTelefonu = "0 532 999 88 77";
            ch_musteri_2.Adresi = "Çankaya, Ankara, Türkiye";
            ch_musteri_2.KrediKartiNumarasi = "9876 5432 1098 7654";
            ch_musteri_2.KadinMi = true;

            // 1. müşterinin ekrana yazdırılması:
            Console.WriteLine("Müşteri Bilgileri\nAdı: " + ch_musteri_1.Adi + "\nSoyadı: " + ch_musteri_1.Soyadi + "\nYaşı: " + ch_musteri_1.Yasi +
                "\nCep Telefonu: " + ch_musteri_1.CepTelefonu + "\nAdresi: " + ch_musteri_1.Adresi +
                "\nCinsiyeti: " + /*ch_musteri_1.Cinsiyeti*/  "\nKart No: " + ch_musteri_1.KrediKartiNumarasi); // konsola Cinsiyeti: Erkek, Kart No: **** **** **** 3456 yazdıracak
            Console.WriteLine($"Müşteri: {ch_musteri_1.UnvanliTamAdi}"); // konsola "Bay Çağıl Alsaç" yazdıracak

            Console.WriteLine();

            // 2. müşterinin ekrana yazdırılması:
            Console.WriteLine($"Müşteri Bilgileri:\nMüşteri: {ch_musteri_2.UnvanliTamAdi}\nYaşı: {ch_musteri_2.Yasi}" +
                $"\nCep Telefonu: {ch_musteri_2.CepTelefonu}\nAdresi: {ch_musteri_2.Adresi}" +
                $"\nKart No: {ch_musteri_2.KrediKartiNumarasi}"); // konsola Kart No: **** **** **** 7654 yazdıracak

            Console.WriteLine();



            #region Demos
            // DiziDemo.Calistir();
            //  Console.WriteLine();
            //   BarbutDemo.Calistir();
            #endregion
        }

    }
}

