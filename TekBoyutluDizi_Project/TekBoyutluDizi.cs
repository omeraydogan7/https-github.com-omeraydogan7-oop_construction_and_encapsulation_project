using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TekBoyutluDizi_Project
{
    // summary class'lar, alanlar, özellikler ve methodlar üzerinde kullanılabilir. Amacı class'ın kullanıldığı yerlerde class, alan, özellik veya method adı yazıldığında
    // bilgi amaçlı yazılan açıklamayı görebilmektir.
    /// <summary>
    /// Sayısal Tek Boyutlu Dizi'lerin en çok kullanılan özellik ve methodlarını içeren ve dizinin bu özellik ve methodlar üzerinden yönetilebildiği class.
    /// </summary>
    class TekBoyutluDizi
    {
        #region Dizi Property'si Oluşturma 1. Yöntem:
        /*
        double[] _dizi; // field (alan)

        /// <summary>
        /// Tek Boyutlu Dizi özelliği.
        /// </summary>
        public double[] Dizi // dizi property'si
        {
            get => _dizi; // _dizi alanını dön, Dizi özelliği üzerinden class içerisindeki _dizi alanının refere ettiği diziye ulaşılabilir
            set => _dizi = value; // değeri _dizi alanına ata
        }
        */
        #endregion

        #region Dizi Property'si Oluşturma 2. Yöntem: Genel Kullanım
        public double[] Dizi { get; set; }
        #endregion



        /// <summary>
        /// Tek Boyutlu Dizi'nin eleman sayısı özelliği.
        /// </summary>
        public int Boyut => Dizi.Length; // Boyut readonly property'si (obje üzerinden set edilemez)

        /// <summary>
        /// Tek Boyutlu Dizi elemanlarını parametre olarak gönderilen ve default (varsayılan) olarak "\n" (new line) atanmış ayraca göre ekrana yazdırır.
        /// </summary>
        /// <param name="ayrac"></param>
        public void Goster(string ayrac = "\n")
        {
            Console.WriteLine("Dizi elemanları:");
            foreach (double eleman in Dizi) // dizideki her bir elemanı döngüde turla (iterate et)
            {
                Console.Write($"{eleman}{ayrac}"); // ve konsola ayrac parametresi ile birlikte yazdır
            }
        }

        /// <summary>
        /// Tek Boyutlu Dizi elemanlarının toplamını dönen method.
        /// </summary>
        /// <returns>double</returns>
        public double Topla() // Topla behavior'ı (davranış)
        {
            // 1. yöntem:
            //double toplam = 0; // methoddan dönecek toplam local variable (değişken), dizinin içerisinde eleman olmadığında aşağıdaki foreach döngüsüne girmeme ihtimali olduğu için
            //                   // ilk değer olarak 0 ataması yapıyoruz.
            //foreach (double eleman in Dizi) // dizideki her bir eleman için
            //{
            //    toplam += eleman; // dizi elemanlarını toplam'a ekle
            //}
            //return toplam; // toplam sonucunu dön

            // 2. yöntem:
            return Dizi.Sum(); // Sum: koleksiyon üzerinden sayısal elemanları toplama methodu
        }

        /// <summary>
        /// Tek Boyutlu Dizi elemanlarının ortlamasını dönen method.
        /// </summary>
        /// <returns>double</returns>
        public double OrtalamaHesapla() // OrtalamaHesapla behavior'ı (davranış)
        {
            // 1. yöntem:
            //double ortalama; // toplam ve dizi eleman sayısı üzerinden hesaplanacak ve methoddan dönülecek ortalama local variable'ı (değişken)
            //double toplam = Topla(); // Topla methodu sonucunun set edildiği local variable (değişken)
            //ortalama = toplam / Boyut; // ortalamayı toplam ve Boyut üzerinden hesapla
            //return ortalama; // ortalama sonucunu methoddan dön

            // 2. yöntem:
            return Dizi.Average(); // Average: koleksiyon üzerinden sayısal elemanların ortalamasını dönen method
        }

        /// <summary>
        /// Tek Boyutlu Dizi elemanlarından en küçüğünü dönen method.
        /// </summary>
        /// <returns>double</returns>
        public double MinimumuGetir() // MinimumuGetir behavior'ı (davranış)
        {
            // 1. yöntem:
            //double minimum = Dizi[0]; // dizinin ilk elemanını minimum olarak ata
            //for (int i = 1; i < Boyut; i++) // dizinin 1. index'ten başlayarak tüm elemanlarını turla (iteration)
            //{
            //    if (Dizi[i] < minimum) // eğer dizinin i. index'teki elemanı minimum değişkeninin değerinden küçükse
            //        minimum = Dizi[i]; // minimum değişkeninin değerini i. index'teki elemanın değeri olarak güncelle
            //}
            //return minimum; // minimum sonucunu methoddan dön

            // 2. yöntem:
            return Dizi.Min(); // Min: koleksiyondaki minimum sayısal elemanı dönen method
        }

        /// <summary>
        /// Tek Boyutlu Dizi elemanlarından en büyüğünü dönen method.
        /// </summary>
        /// <returns>double</returns>
        public double MaksimumuGetir() // MaksimumuGetir behavior'ı (davranış)
        {
            // 1. yöntem:
            //double maksimum = Dizi[0]; // dizinin ilk elemanını maksimum olarak ata
            //for (int i = 1; i < Boyut; i++) // dizinin 1. index'ten başlayarak tüm elemanlarını turla (iteration)
            //{
            //    if (Dizi[i] > maksimum) // eğer dizinin i. index'teki elemanı maksimum değişkeninin değerinden büyükse
            //        maksimum = Dizi[i]; // maksimum değişkeninin değerini i. index'teki elemanın değeri olarak güncelle
            //}
            //return maksimum; // maksimum sonucunu methoddan dön

            // 2. yöntem:
            return Dizi.Max(); // Max: koleksiyondaki maksimum sayısal elemanı dönen method
        }
    }
}
