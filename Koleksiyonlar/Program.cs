using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[]isimler = new string[]
            //{"arda","seref","ünal"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //isimler = new string[4];
            //isimler[3]= "ünal";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[1]);  burdaki hata new string dedeğimizde önceden yazdığımız değerler gg oluyor o yüzden arry kullanmıyoruz 
            //koleksiyon kullanıyoruz .

            List<string> isimler2 = new List<string> { "engin", "arda,", "seref", "yusuf" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //bu şekilde işimiz daha doğru


        }
    }
}
