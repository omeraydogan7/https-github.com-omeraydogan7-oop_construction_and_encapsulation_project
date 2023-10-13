using System;

namespace ConstructorsProje
{
    class Program
    {
       // public static object TimeOperationsDemo { get; private set; }

        static void Main(string[] args)
        {
            OgrenciMethod();
            VatandasMethod();
        }
        #region MyRegion
        //// Constructor'lar (inşa edici) bir class new'lendiğinde (initialization) çalışan class adına sahip ve genelde başına public yazılan özel methodlardır.
        // Constructor'lar parametresiz (default constructor) veya parametreli kullanılabilir, default constructor'ları yazmak zorunlu değildir
        // çünkü oluşturulan class içerisinde mevcuttur.
        // Ancak bir class'a parametreli constructor yazılırsa ve default constructor da kullanılmak istenirse o zaman default constructor yazılmalıdır.
        // Parametreli constructor'lar dependency injection (ilerki konularda anlatılacak) veya her zaman şart olmasa da constructor üzerinden daha kolay ve hızlı şekilde
        // obje oluşturmak için kullanılır.
        #endregion
        static void VatandasMethod()
        {
            #region Default Constructor'lı Vatandas Sınıfı
            Vatandas vatandas1 = new Vatandas(); // default constructor üzerinden obje oluşturuyoruz, default constructor'daki kod bloğu çalışacak

            Console.WriteLine(vatandas1.Ulke); // örnek için default constructor'da atanan Ulke özelliğini yazdırıyoruz

            Console.WriteLine(vatandas1.Sehir); // örnek için default constructor'da Sehir özelliği Adi ve Soyadi özelliklerinde olduğu gibi "" atandığından konsola "" yazdırılacak

            // ilk vatandas objemizin özelliklerini objeyi oluşturduktan sonra set ediyoruz
            vatandas1.Sehir = "Istanbul";
            vatandas1.Adi = "Ömer";
            vatandas1.Soyadi = "Aydoğan";

            // ilk vatandaş objemizi ekrana yazdırıyoruz
            Console.WriteLine("Adı: " + vatandas1.Adi + " " + vatandas1.Soyadi);
            Console.WriteLine(vatandas1.UlkeVeSehirGetir());
            
            Console.WriteLine();
            
            Vatandas vatandas2 = new Vatandas() // ikinci vatandaş objemizi new'lerken özelliklerini set ediyoruz, yine default constructor'daki kod bloğu çalışacak,
                                                // Ulke özelliğini set edemeyiz çünkü getter üzerinden readonly (sadece okunur) yaptık
            {
                Adi = "Ömer1",
                Soyadi = "Aydoğan",
                Sehir = "İzmir"
            };

            // ikinci vatandaş objemizi ekrana yazdırıyoruz
            Console.WriteLine("Adı: " + vatandas2.Adi + " " + vatandas2.Soyadi);
            Console.WriteLine(vatandas2.UlkeVeSehirGetir());
            #endregion
            
            Console.WriteLine();
            

            #region Demos
          // TimeOperationsDemo.Calistir();
            #endregion
        }

        static void OgrenciMethod()
        {
            #region Parametreli ve Default Constructor'lı Constructor Overload Yapılan Ogrenci Sınıfı
            Ogrenci ogrenci1 = new Ogrenci("Emin", "Aydoğan", 100, 90, 80); // parametreli constructor üzerinden obje oluşturuyoruz,
                                                                         // kullandığımız imzaya sahip constructor kod bloğu çalışacak

            // ilk öğrenciyi ortalama ve durumunu hesaplatarak ekrana yazdırıyoruz
            ogrenci1.OrtalamaVeDurumHesapla();
            Console.WriteLine(ogrenci1.Getir());

            Console.WriteLine();

            Ogrenci ogrenci2 = new Ogrenci(92, 78, 79) // parametreli constructor üzerinden obje oluşturuyoruz,
                                                       // kullandığımız imzaya sahip constructor kod bloğu çalışacak,
                                                       // özellikleri objeyi oluştururken atıyoruz
            {
                Adi = "Ömer2",
                Soyadi = "Aydoğan"
            };

            // ikinci öğrenciyi ortalama ve durumunu hesaplatarak ekrana yazdırıyoruz
            ogrenci2.OrtalamaVeDurumHesapla();
            Console.WriteLine(ogrenci2.Getir());

            Console.WriteLine();

            Ogrenci ogrenci3 = new Ogrenci("Nazir", "Ayar"); // parametreli constructor üzerinden obje oluşturuyoruz,
                                                              // kullandığımız imzaya sahip constructor kod bloğu çalışacak

            // üçüncü öğrenciyi devamsız olduğu için ortalama ve durumunu hesaplatmadan ekrana yazdırıyoruz
            Console.WriteLine(ogrenci3.Getir());
            #endregion
        }
    }
}
