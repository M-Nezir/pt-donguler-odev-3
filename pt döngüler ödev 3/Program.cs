using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt_döngüler_ödev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bu program girdiğiniz iki sayı arasındaki tek veya çift sayıları toplar");

            for (; ; ) 
            {
                Console.WriteLine("lütfen bir sayı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("lütfen 2.sayıyı giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("giridiğiniz sayıların arasındaki tek sayılar mı toplansın çift sayılar mı?");
                string tekçift = Convert.ToString(Console.ReadLine());
                Console.WriteLine(" ");

                int takas = 0, toplam = 0, b = 0;

                if (sayi1 > sayi2)
                {

                    takas = sayi1;
                    sayi1 = sayi2;
                    sayi2 = takas;
                }

                if (tekçift.ToLower() == "tek")
                {
                    for (int i = sayi2; i >= sayi1; i -= 2)
                    {

                        if (i % 2 == 0)
                        {
                            i--;
                        }

                        b = toplam + i;
                        toplam = b;

                        if (i == sayi1 || i == sayi1 + 1)
                        {
                            Console.WriteLine(sayi1 + " ile " + sayi2 + " arasındaki tek sayıların toplamı: " + toplam);
                            break;
                        }

                    }
                }


                if (tekçift.ToLower() == "çift")
                {
                    for (int j = sayi2; j >= sayi1; j -= 2)
                    {

                        if (j % 2 == 1)
                        {
                            j--;
                        }


                        b = toplam + j;
                        toplam = b;

                        if (j == sayi1 || j == sayi1 + 1)
                        {
                            Console.WriteLine(sayi1 + " ile " + sayi2 + " arasındaki çift sayıların toplamı: " + toplam);
                            break;
                        }

                    }
                }
                Console.WriteLine("");
                Console.WriteLine("tekrar işlem yapmak istiyorsanız lütfen e harfini tuşlayınız (bitirmek için enter)");
                string sonlansın = Convert.ToString(Console.ReadLine());
                Console.WriteLine(" ");
                 
                if (sonlansın.ToLower() != "e") 
                {
                    break;
                }
            }


        }
    }
}
