using System;
using System.Collections.Generic;

namespace DiziSayıArtırma
{
    class Program
    {
        static void Main(string[] args)
        {
            var SayiDizi = new List<int>() { 9,9, 9, 9, 5, 9 };
            int Sonsayi = 0, Uzunluk = 0 , UzunlukIki = 0 , UzunlukUc = 0;
            bool Kontrol = false;
            Uzunluk = SayiDizi.Count;

            for (int i = 0; i < SayiDizi.Count; i++)
            {
                Sonsayi = SayiDizi[Uzunluk - (UzunlukIki += 1)];
                UzunlukUc += 1;
                if (Sonsayi < 9 )
                {
                    Sonsayi += 1;
                    SayiDizi[Uzunluk - UzunlukUc] = Sonsayi;
                    Kontrol = true;
                    break;
                }
            }
            if (SayiDizi[0] > 8 && Kontrol == false)
            {
                SayiDizi.Reverse();
                SayiDizi.Add(1);
                SayiDizi.Reverse();
            }

            for (int i = 0; i < SayiDizi.Count; i++)
            {
                Console.Write(SayiDizi[i] + " ");
            }
        }
    }
}
