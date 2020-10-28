using System;

namespace Kıyafet
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Renkler = new string[3];
            string[] Beden = new string[3];
            string[] KolUzunlugu = new string[2];
            string[] ParaDegerleri = new string[18];
            int ParaSayac = 0;
            int ParaDegerGoster = 0;

            //Renk Giriş 
            for (int R = 0; R <= 2; R++)
            {
                Console.Write( R +". Rengi Giriniz.");
                Renkler[R] = Console.ReadLine();
            }

            // Beden Giriş
            for (int B = 0; B <= 2; B++)
            {
                Console.Write(B + ". Bedeni Giriniz.");
                Beden[B] = Console.ReadLine();
            }

            // Kol Uzunluğu Giriş
            for (int K = 0; K <= 1; K++)
            {
                Console.Write( K + ". Kol Uzunluğunu Giriniz.");
                KolUzunlugu[K] = Console.ReadLine();
            }


            for (int i = 0; i < 3; i++)
            {

                for (int l = 0; l < 3; l++)
                {
                   
                    for (int k = 0; k < 2; k++)
                    {   
                        Random RndSayi = new Random();
                        int ParaDeger = RndSayi.Next(20, 100);
                        Console.WriteLine(Renkler[i] + " " + Beden[l] + " " + KolUzunlugu[k] + "Ücreti : " + ParaDeger + "₺");
                        ParaDegerleri[ParaSayac] = ParaDeger.ToString();
                        ParaSayac++;
                    }
                }
            }


            Console.WriteLine("Para Değerini Görmek İstediğiniz Kombinasyon Sayısını Giriniz.");
            ParaDegerGoster = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kombinasyonun Para Değeri : " + ParaDegerleri[ParaDegerGoster]);
            Console.ReadKey();
        }
    }
}
