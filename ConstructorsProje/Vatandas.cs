using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsProje
{

    /// <summary>
    /// Ankara, İstanbul (Avrupa), İstanbul (Anadolu) ve İzmir için Türkiye Cumhuriyeti vatandaş verilerini tutan sınıf.
    /// </summary>
    class Vatandas
    {
        public string Adi { get; set; } // property

        public string Soyadi { get; set; } // property

        public string Ulke { get; } // property, Ulke özelliği her vatandaş için default contructor'da Türkiye Cumhuriyeti set edileceğinden
                                    // class içerisindeki herhangi bir method ve oluşturulan obje üzerinden değiştirilmemesi için getter ile
                                    // readonly (sadece okunur) yapıyoruz,
                                    // eğer değiştirilme ihtimalı varsa setter da yazılarak readonly yapılmayabilir

        public string Sehir { get; set; } // property

        public Vatandas() // default (parametresiz) constructor
        {
            Ulke = "Türkiye Cumhuriyeti"; // örneğimiz T.C. vatandaşları için olduğundan her new'lenen obje için Ulke atamasını Türkiye Cumhuriyeti yapıyoruz

            // Adi, Soyadi ve Sehir özelliklerinin veri tipi string olduğundan obje new'lendiğinde referans tip olmalarından dolayı bu özelliklere null atanacaktır
            // ve bu da bu özellikler üzerinden başka string özellikleri (Length gibi) veya methodları (Trim gibi) kullandığımızda Null Reference Exception hatası
            // almamıza sebep olabilir.
            // Bu hatanın önüne geçebilmek için istenirse bu özelliklere içerisinde hiç bir karakter olmayan string değer atanabilir.
            Adi = "";
            Soyadi = "";
            Sehir = "";

            // class'ta kullanılan özellik ve alan tipleri için constructor'da herhangi bir atama yapılmazsa sayısal değer tipler için
            // (long, int, short, byte, double, float, decimal) 0, enum değer tipler için ilk elemanın sayısal değeri, boolean değer tip için false ve
            // DateTime struct değer tip içinse 01.01.0001 atanır.
            // string, array, class ve class'la birlikte kullanılan interface ve kalıtım base class'ları (sonraki konularda anlatılacak)
            // referans tipler için null atanır.
        }



        public string UlkeVeSehirGetir() // behavior
        {
            return $"Ülke / Şehir: {Ulke} / {Sehir}";
        }
    }



}
