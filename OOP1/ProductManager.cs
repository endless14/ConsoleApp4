using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"EKLENDİ :");
        }

        public void BisiYap(int sayi)
        {
            sayi = 00;
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+":  GÜNCELLENDİ ");
        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1,int say2i)
        {
            Console.WriteLine(sayi1+say2i);
        }
    }
}
