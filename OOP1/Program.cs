using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 5;
            product1.ProductName = "Masa";
            product1.UnitIdStock = 5;
            product1.UnitPrice = 600;

            Product product2 = new Product{Id=2,CategoryId=10,ProductName="kalem",UnitIdStock=20,UnitPrice=10 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            


            int sayi = 100;
            productManager.BisiYap(sayi);
            Console.WriteLine(sayi);

            productManager.Update(product2);

            //void li olan şart tek kullanımlık
            productManager.Topla2(1, 2);

            //int değeri bir yere kaydebiliriz
            int toplamSonucu = productManager.Topla(5,9);
            Console.WriteLine(toplamSonucu*5);
            
        }
    }
}
