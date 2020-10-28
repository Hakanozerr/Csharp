using System;

namespace PozitifSayılarıToplamaCift
{
    class Program
    {

        static void Main(string[] args)
        {

            int kucuksayi = 0, buyuksayi = 0;
            bool Kontrol = false;
            Console.Write("Başlangıç Sayısını Giriniz. ");
            while (0 == 0)
            {
                try
                {
                    kucuksayi = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Kontrol = true;
                    Console.Write("Girdiğiniz Değer Sayı Değil Tekrar Başlangıç Sayısı Giriniz. ");
                }
                if (kucuksayi < 0)
                {
                    Kontrol = false;
                    Console.Write("Girdiğiniz Değer Pozitif Değil Tekrar Başlangıç Sayısını Giriniz. ");
                }
                else if (kucuksayi >= 0 && Kontrol == false)
                {
                    break;
                }
            } // birinci while sonu
            Console.Write("Bitiş Sayısı Giriniz. ");
            while (0 == 0)
            {
                try
                {
                    buyuksayi = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Kontrol = true;
                    Console.Write("Girdiğiniz Değer Sayı Değil Tekrar Bitiş Sayısını Giriniz. ");
                }
                if (buyuksayi < 0)
                {
                    Kontrol = false;
                    Console.Write("Girdiğiniz Değer Pozitif Değil Tekrar Bitiş Sayısı Giriniz. ");
                }
                else if (buyuksayi <= kucuksayi && Kontrol == false)
                {
                    Console.Write("Giridiğiniz Değer Başlangıç Sayısı İle Aynı Veya Küçük Tekrar Bitiş Sayısını Giriniz.");
                }
                else if (kucuksayi >= 0 && Kontrol == false)
                {
                    break;
                }
            } // ikinci while sonu
            int toplama = 0;
            for (int i = kucuksayi; i < buyuksayi;)
            {
                toplama += i;
                i += 2;
            }
            Console.WriteLine("Toplama İşlemi Sonucu {0}", toplama);
        }
    }
}
