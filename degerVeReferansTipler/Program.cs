using System;

namespace degerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi4 = 10;
            int sayi2 = 20;

            sayi4 = sayi2;
            sayi2 = 65;
            Console.WriteLine( sayi4);

            int[] sayi = new int[] {1,2,3};
            int[] sayi3 = new int[] {10,20,30 };
            sayi = sayi3;
            sayi3[0] = 999;
            Console.WriteLine(sayi[0]);


        }
    }
}
