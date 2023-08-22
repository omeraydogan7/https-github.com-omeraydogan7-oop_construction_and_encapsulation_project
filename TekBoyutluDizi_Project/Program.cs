using System;

namespace TekBoyutluDizi_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] sayilar = new int[2, 3];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //     sayilar[i, j] = i + 10;
            //}
            //foreach (var item in sayilar)
            //{
            //     Console.WriteLine(item);

            //}
            oku();
                
            Console.ReadKey();
        }
        static void oku()
        {
            TekBoyutluDizi tekBoyutluDizi = new TekBoyutluDizi()
            {
                Dizi=new double[5] {5,6,7,8,9}
            };
            tekBoyutluDizi.Goster("\n");

        }
    }
}
