using System;
using System.Collections.Generic;
namespace FibonacciSayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Fibonacci = new List<int>(){0,1};

            int index = 0, sondeger = 0, listeson;

            Console.Write("Son Değeri Giriniz. ");
            sondeger = Convert.ToInt16(Console.ReadLine());

            while (sondeger > index)
            {
                listeson = Fibonacci.Count;
                index = Fibonacci[listeson - 1] + Fibonacci[listeson - 2];
                if (sondeger >= index)
                {
                    Fibonacci.Add(index);
                } else
                {
                    break;
                }

            }
            for (int i = 0; i < Fibonacci.Count; i++)
            {
                Console.Write(Fibonacci[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
