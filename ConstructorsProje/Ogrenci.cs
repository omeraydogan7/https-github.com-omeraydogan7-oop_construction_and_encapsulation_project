using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsProje
{
    /// <summary>
    /// Öğrenci adı ve soyadı verilerini tutan, 1. vize, 2. vize ve final notları üzerinden not ortalamasını ve geçme / kalma durumunu hesaplayan sınıf.
    /// </summary>
    class Ogrenci
    {
        // constant (sabit) fields
        const decimal VIZE1CARPAN = 0.2m; // decimal tipteki değişkenlere değer atanırken değer sonuna m veya M yazılmalıdır
        const decimal VIZE2CARPAN = 0.2M;
        const decimal FINALCARPAN = 0.6m;



        // fields
        decimal _vize1;
        decimal _vize2;
        decimal _final;

        decimal _ortalama = -1; // *1, alanlara ilk değer ataması burada yapılabileceği gibi constructor'larda da yapılabilir (özellikler için de geçerli),
                                // ortalamanın hesaplanmadığını belirtmek için -1 atadık, aşağıdaki OrtalamaVeDurumHesapla methodu çağrıldığında ortalama hesaplanmış olacak

        //string _durum = "Kaldı"; // *2, alanlara ilk değer ataması burada yapılabileceği gibi constructor'larda da yapılabilir (özellikler için de geçerli)
        string _durum; // *2



        // properties
        public string Adi { get; set; }
        public string Soyadi { get; set; }



        // constructors
        // 1. parametreli constructor, tıpkı methodlarda olduğu gibi parametreler üzerinden alan ve özellik atama işlemleri yapılabilir
        public Ogrenci(string adi, string soyadi, decimal vize1, decimal vize2, decimal final)
        {
            // özelliklerin parametreler üzerinden atanması
            Adi = adi;
            Soyadi = soyadi;

            // alanların parametreler üzerinden atanması
            _vize1 = vize1;
            _vize2 = vize2;
            _final = final;

            // alan ilk değerlerinin atanması (özellikler için de geçerli)
            // *1
            //_ortalama = -1;

            // *2
            _durum = "Kaldı";
        }

        // 2. parametreli constructor, constructor overload, tıpkı methodlarda olduğu gibi constructor'lar da imzaları üzerinden overload edilebilir
        public Ogrenci(decimal vize1, decimal vize2, decimal final)
        {
            // alanların parametreler üzerinden atanması
            _vize1 = vize1;
            _vize2 = vize2;
            _final = final;

            // alan ilk değerlerinin atanması (özellikler için de geçerli)
            // *1
            //_ortalama = -1;

            // *2
            _durum = "Kaldı";
        }

        // 3. parametreli constructor, constructor overload, tıpkı methodlarda olduğu gibi constructor'lar da imzaları üzerinden overload edilebilir,
        // istenirse en sondan başlanarak default parametreler de kullanılabilir
        public Ogrenci(string adi, string soyadi, string durum = "Devamsız")
        {
            // özelliklerin parametreler üzerinden atanması
            Adi = adi;
            Soyadi = soyadi;

            // alanların parametreler üzerinden atanması
            _durum = durum;
        }

        // 4. parametresiz (default) constructor, eğer bu constructor kullanılarak obje new'leme işlemi yapılmayacaksa yazmak zorunlu değildir
        public Ogrenci()
        {
            // alan ilk değerlerinin atanması (özellikler için de geçerli)
            // *1
            //_ortalama = -1;

            // *2
            _durum = "Kaldı";
        }


        // behaviors
        public void OrtalamaVeDurumHesapla()
        {
            _ortalama = _vize1 * VIZE1CARPAN + _vize2 * VIZE2CARPAN + _final * FINALCARPAN;
            if (_ortalama >= 60)
                _durum = "Geçti";
        }

        public string Getir()
        {
            string sonuc = $"Öğrenci: {Adi} {Soyadi}";
            if (_ortalama != -1) // eğer ortalama -1 ise OrtalamaVeDurumHesapla methodu çağrılmamış demektir, bu yüzden ortalamayı yazdırmıyoruz
                sonuc += $"\nNot Ortalaması: {_ortalama.ToString("N1")}"; // N: sayı formatı, 1: ondalıktan sonra 1 hane
            sonuc += $"\nDurumu: \"{_durum}\"";
            return sonuc;
        }
    }
}
