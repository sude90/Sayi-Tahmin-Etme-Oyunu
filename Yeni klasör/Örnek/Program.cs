using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Random r = new Random();
            int[] rastgele_sayi = new int[3];
            for (int i = 0; i < rastgele_sayi.Length; i++)
            {
                rastgele_sayi[i] = r.Next(1,10);
            }
            int ilk_puan = 0;
            int ikinci_puan = 0;
            for (int i = 0; i < rastgele_sayi.Length; i++)
            {
                Console.WriteLine("Birinci oyuncu tahmini : ");
                int tahmini_sayi1 = Convert.ToInt32(Console.ReadLine());
                if (tahmini_sayi1 != rastgele_sayi[i])
                {
                    Console.WriteLine("Yanlış Tahmin");

                    if (rastgele_sayi[i] > tahmini_sayi1)
                    {
                        ilk_puan += 10 - (rastgele_sayi[i] - tahmini_sayi1);
                    }
                    else if (rastgele_sayi[i] != tahmini_sayi1)
                    {
                        ilk_puan += 10 - (tahmini_sayi1 - rastgele_sayi[i]);
                    }
                }
                else if (tahmini_sayi1 == rastgele_sayi[i])
                {
                    Console.WriteLine("Doğru Tahmin");
                }
                Console.Clear();

                //*******************************************//

                Console.WriteLine("İkinci oyuncu tahmini : ");
                int tahmini_sayi2 = Convert.ToInt32(Console.ReadLine());
                if (tahmini_sayi2 != rastgele_sayi[i])
                {
                    Console.WriteLine("Yanlış Tahmin");
                    if (rastgele_sayi[i] > tahmini_sayi2)
                    {
                        ikinci_puan += 10 - (rastgele_sayi[i] - tahmini_sayi2);
                    }
                    else if (rastgele_sayi[i] != tahmini_sayi2)
                    {
                        ikinci_puan += 10 - (tahmini_sayi2 - rastgele_sayi[i]);
                    }
                }
                else if (tahmini_sayi2 == rastgele_sayi[i])
                {
                    Console.WriteLine("Doğru Tahmin");
                }
            }

            Console.Clear();
            Console.WriteLine("1.Oyuncunun Puanı : " + ilk_puan);
            Console.WriteLine("2.Oyuncunun Puanı : " + ikinci_puan);
            Console.ReadKey();
        }
    }
}
