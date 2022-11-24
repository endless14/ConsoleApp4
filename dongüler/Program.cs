using System;

namespace dongüler
{
    class Program
    {
        static void Main(string[] args)
        {

            string hero1 = "pyke";
            string hero2 = "yasuo";
            Console.WriteLine(hero1);
            Console.WriteLine(hero2);
            //arry
            string[] herolar = new string[]
            {
                "pyke","yasuo","akali","kled","vayne","saaa","asssss"
            };

            for (int i = 0; i < herolar.Length; i++)
            {
                Console.WriteLine(herolar[i]);
 
            }
            Console.WriteLine("for bitti");
            foreach (var hero in herolar)
            {
                Console.WriteLine(hero);
            }
            Console.WriteLine("sistemi kapatın görev bitti ");
        }
    }
}
