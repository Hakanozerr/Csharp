using System;

namespace AsalSayıBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int BaslangicDegeri = 0, BitisDegeri = 0;


            Console.Write("Baslangıç Değerini Giriniz. ");
            while (true)
            {
                try
                {
                    BaslangicDegeri = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Write("Girdiğiniz Değer Sayı Değil Tekrar Başlangıç Sayısı Giriniz. ");
                }
                if (BaslangicDegeri < 0)
                {
                    Console.Write("Girilen Değer Pozitif Değil Tekrar Giriniz . ");
                }
                else if (BaslangicDegeri > 0 )
                {
                    break;
                }
            } // Baslangıç Değeri Giriş

            Console.Write("Bitiş Değerini Giriniz. ");

            while (true)
            {
                try
                {
                    BitisDegeri = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Write("Girdiğiniz Değer Sayı Değil Tekrar Bitiş Değerini Giriniz. ");
                }
                if (BitisDegeri < 0 )
                {
                    Console.Write("Giridiğiniz Değer Pozitif Değil");
                }
                else if (BitisDegeri > 0 )
                {
                    break;
                }
            } // Bitiş Değeri Giriş

            for (int i = BaslangicDegeri; i < BitisDegeri; i++)
            {
                int sayac = 0;
                for (int b = 2; b <= 9; b++)
                {
                    if (i % b == 0)
                    {
                        if (i == b)
                        {
                        }
                        else
                        {
                            sayac++;
                            break;
                        }
                    }
                }
                if (sayac == 0)
                {
                    Console.WriteLine(i);
                }
            }
                        
            Console.ReadKey();
        }
    }
}
