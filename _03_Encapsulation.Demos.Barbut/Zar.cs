using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Encapsulation.Demos.Barbut
{   // summary class'lar, alanlar, özellikler ve methodlar üzerinde kullanılabilir. Amacı class'ın kullanıldığı yerlerde class, alan, özellik veya method adı yazıldığında
    // bilgi amaçlı yazılan açıklamayı görebilmektir.

    /// <summary>
    /// İçerisinde zarın sayı değerini ve yüzünü tutacak, At methodu ile de rastgele sayı değerini atayacak Zar sınıfı.
    /// </summary>
    public class Zar
    {

        Random rastgele = new Random(); // rastgele zar sayılarını üretebilmek için Random (class) tipinde rastgele objemizi Zar class'ında new'liyoruz,
                                        // ihtiyaca göre başka class'lar üzerinden objeler bir class içerisinde sınıfta global olarak tanımlanarak new'lenip
                                        // sınıf içerisindeki özellik veya davranışlarda kullanılabilir,
                                        // Zar class'ı new'lendiğinde (initialize edildiğinde) Random class'ı da new'lenecektir (initialize edilecektir)

        int _sayi; // field (alan)

        string _yuz; // field (alan)
        public string Yuz // property (özellik)
        {
            get
            {
                _yuz = ""; // yuz alanının ilk değer atamasını içinde hiç bir karakter olmayan string olarak gerçekleştiriyoruz
                switch (_sayi)
                {
                    case 1: // _sayi 1 olma durumu
                        _yuz += "\n---";
                        _yuz += "\n-*-";
                        _yuz += "\n---";
                        break;
                    case 2: // _sayi 2 olma durumu
                        _yuz += "\n*--";
                        _yuz += "\n---";
                        _yuz += "\n--*";
                        break;
                    case 3: // _sayi 3 olma durumu
                        _yuz += "\n*--";
                        _yuz += "\n-*-";
                        _yuz += "\n--*";
                        break;
                    case 4: // _sayi 4 olma durumu
                        _yuz += "\n*-*";
                        _yuz += "\n---";
                        _yuz += "\n*-*";
                        break;
                    case 5: // _sayi 5 olma durumu
                        _yuz += "\n*-*";
                        _yuz += "\n-*-";
                        _yuz += "\n*-*";
                        break;
                    case 6: // _sayi 6 olma durumu
                        _yuz += "\n***";
                        _yuz += "\n---";
                        _yuz += "\n***";
                        break;
                        // default case'ini yazmadık çünkü Zar class'ı new'lendiğinde eğer _sayi değişkeni At methodu ile atanmazsa 0 olacak ve zarın yüzü "" dönecek
                }
                return _yuz;
            }
        }

        public int At() // behavior (davranış), zarın atılma işlemi
        {
            _sayi = rastgele.Next(1, 7); // minimum 1 (dahil) maksimum 7 (dahil değil) olacak şekilde rastgele sayıyı _sayi alanına atıyoruz
            return _sayi; // atanan rastgele sayıyı methoddan dönüyoruz
        }


    }
}
