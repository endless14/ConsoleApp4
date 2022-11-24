using System;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            ürün ürün1 = new ürün();
            ürün1.ürünAdi = "leptop";
            ürün1.ürünMarkasi = "monster";
            ürün1.ürünÜretimYeri = "China";
            ürün1.ürünFiyat = 25000;

            ürün ürün2 = new ürün();
            ürün2.ürünAdi = "phone";
            ürün2.ürünMarkasi = "samsung";
            ürün2.ürünÜretimYeri = "korea";
            ürün2.ürünFiyat = 15000;

            ürün ürün3 = new ürün();
            ürün3.ürünAdi = "air pods";
            ürün3.ürünMarkasi = "apple";
            ürün3.ürünÜretimYeri = "usa";
            ürün3.ürünFiyat = 10000;

            ürün ürün4 = new ürün();
            ürün4.ürünAdi = "TV";
            ürün4.ürünMarkasi = "LG";
            ürün4.ürünÜretimYeri = "Germany";
            ürün4.ürünFiyat = 35000;


            ürün[] ürünler = new ürün[]
            {
                ürün1,ürün2,ürün3,ürün4
            };

            foreach (var ürün in ürünler)
            {
                Console.WriteLine(ürün.ürünAdi+" "+ürün.ürünFiyat+" "+ürün.ürünMarkasi);
            }
        }

        class ürün
        {
            public string ürünAdi { get; set; }
            public string ürünMarkasi { get; set; }
            public string ürünÜretimYeri { get; set; }
            public int ürünFiyat { get; set; }
        }
    }

}
