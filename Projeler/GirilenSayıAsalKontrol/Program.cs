using System;

namespace GirilenSayıAsalKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            int GirilenSayi = 0;
            string Sayilar = "";
            int sayac = 0;
            int SayilarSayac = 0;
            bool SıfırKontrol = false , BirKontrol = false;

            Console.Write("Bir Sayı Giriniz. ");
            while (true)
            {

                try
                {
                    GirilenSayi = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Girilen Değer Sayı Değil Tekrar Değer Giriniz. ");
                }

                if (GirilenSayi < 0 )
                {
                    Console.WriteLine("Girilen Değer Sayı Değil.");
                }
                else if (GirilenSayi == 0)
                {
                    SıfırKontrol = true;
                    break;
                }
                else if (GirilenSayi > 0)
                {
                    break;
                }
                
            } // Sayı Giriş
                        
            for (int b = 2; b <= GirilenSayi; b++)
            {
                if (GirilenSayi % b == 0)
                {
                    if (GirilenSayi == b)
                    {
                        Sayilar += "Ve " + b.ToString();
                    }
                    else
                    {
                        sayac++;
                        Sayilar += b.ToString() + " ";
                    }
                }
            }
            if (SıfırKontrol == true)
            {
                Console.WriteLine("0 asal değildir nedeni bütün sayılara bölünür.");
            }
            else if (BirKontrol == true)
            {
                Console.WriteLine("1 sayısının asal değildir nedeni 2 adet böleni bulunmamasıdır.");
            }
            else if (sayac > 0)
            {
                Console.WriteLine("Asal Değildir. " + Sayilar + " Sayılarına Bölünür.");
            }else 
            {
                Console.WriteLine("Sayı Asaldır.");
            }
            }
            Console.ReadKey();

        }
    }
}
