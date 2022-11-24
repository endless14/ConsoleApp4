using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            product ürün = new product();

            product ürün1 = new product();
            ürün1.ürünAdi = "cilek";
            ürün1.ürünAciklamasi = "yemezsen cilek ölürsün görürüsün";
            ürün1.ürünFiyati = 35;
            ürün1.id = "304";

            product ürün2 = new product();
            ürün2.ürünAdi = "karpuz";
            ürün2.ürünAciklamasi = "yemezsen karpuz yememiş olursun";
            ürün2.ürünFiyati = 150;
            ürün2.id = "676";

            product ürün3 = new product();
            ürün3.ürünAdi = "elma";
            ürün3.ürünAciklamasi = "amasya elması";
            ürün3.ürünFiyati = 10;
            ürün3.id = "123";

            product[] ürünler = new product[] { ürün1,ürün2,ürün3};

            foreach (var Ürün in     ürünler)
            {
                Console.WriteLine(Ürün.id);
                Console.WriteLine(Ürün.ürünAdi);
                Console.WriteLine(Ürün.ürünAciklamasi);
                Console.WriteLine(Ürün.ürünFiyati);
                Console.WriteLine("-----------------");
                
            }

            Console.WriteLine("-------------metotlar---------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(ürün1);
            sepetManager.Ekle(ürün3);
            sepetManager.Ekle(ürün2);

            sepetManager.Ekle2("armut", "ye", 12,23);
            sepetManager.Ekle2("muz", "uzun", 40,33);

        }
    }
}
