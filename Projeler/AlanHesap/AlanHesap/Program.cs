using System;

namespace AlanHesap
{

    class Program
    {
        static void Main(string[] args)
        {
            int Kenar1 = 0,Kenar2 = 0;


            while (0 == 0)
            {   

                Console.Write("Birinci kenarı giriniz.");
                while (0 == 0)
                {
                    try
                    {
                        Kenar1 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.Write("Girdiğiniz Değer Harf Sayı Giriniz! Tekrar ");
                    }
                    break;
                }

                if (Kenar1 < 1)
                {
                    Console.WriteLine("Sadece 1'den Büyük ve Pozitif Sayılar Girilmeli");
                }
                else if (Kenar1 > 1)
                {

                    break;
                }
            }


            while (0 == 0)
            {
                while (0 == 0)
                {
                    Console.Write("İkinci kenarı giriniz.");
                    try
                    {
                        Kenar2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.Write("Girdiğiniz Değer Harf Sayı Giriniz! Tekrar");
                    }
                    break;
                }
                if (Kenar2 < 1)
                {
                    Console.WriteLine("Sadece 1'den Büyük ve Pozitif Sayılar Girilmeli");
                }
                else if (Kenar2 > 1)
                {
                    
                    break; 
                }
            }
            int Alan = Kenar1 * Kenar2;

            Console.WriteLine("Alan = {0}",Alan);
        }
    }
}
