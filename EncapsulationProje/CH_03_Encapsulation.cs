using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationProje
{
    // summary class'lar, alanlar, özellikler ve methodlar üzerinde kullanılabilir. Amacı class'ın kullanıldığı yerlerde class, alan, özellik veya method adı yazıldığında
    // bilgi amaçlı yazılan açıklamayı görebilmektir.

    /// <summary>
    /// Müşteri verilerini tutan model sınıfı.
    /// </summary>
   public class CH_Musteri
    {
        // Musteri class'ı veri taşıdığı için bir model sınıftır, gerçek hayattan bir müşteriyi modellemiş olduk.

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public byte Yasi { get; set; }
        public string CepTelefonu { get; set; }
        public string Adresi { get; set; }
      //  public bool Cinsiyeti { get; set; }



        string _krediKartiNumarasi; // kredi kartı numarasının son 4 hanesini göstereceğiz
        public string KrediKartiNumarasi
        {
            // 1. yöntem:
            get // kredi kartı numarasının son 4 hanesi dışında olan haneleri gizleyip sonundaki son 4 hane ile beraber dönüyoruz
            {
                return "**** **** **** " + _krediKartiNumarasi.Substring(15);
            }
            set // kredi kartı numarasını obje üzerinden atanan değer olarak set ediyoruz
            {
                _krediKartiNumarasi = value;
            }

            // 2. yöntem:
          //  get => "**** **** **** " + _krediKartiNumarasi.Substring(15);
           // set => _krediKartiNumarasi = value;
        }



        public bool KadinMi { get; set; } // obje üzerinden true veya false olarak set edilecek



        // kullanıcıya obje verilerini gösterirken true ve false anlamsız olacağı için set edilen KadinMi özelliğine göre Kadın veya Erkek string'i dönüyoruz
        public string Cinsiyeti // readonly (sadece okunur), 1. yöntem
        {
            get
            {
                if (KadinMi)
                    return "Kadın";
                return "Erkek";
            }
          
        }

        public string Cinsiyeti => KadinMi ? "Kadın" : "Erkek"; // readonly (sadece okunur), 2. yöntem

        public string UnvanliTamAdi => (KadinMi ? "Bayan " : "Bay ") + Adi + " " + Soyadi;


    }
}
