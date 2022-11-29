using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            GercekMusteri musteri2 = new GercekMusteri();
            musteri2.Id = 5;
            musteri2.MusteriNo = "12";
            musteri2.Soyadi = "ass";
            musteri2.Ad = "saa";
            musteri2.TcNo = "312312312";
            //Kodlama.io

            TuzelMusteri musteri1 = new TuzelMusteri();
            {
                musteri1.Id = 2;
                musteri1.MusteriNo = "213";
                musteri1.SirketAdi = "ultra";
                musteri1.VergiNo = "13131";

            }
            Musteri musteri3 = new TuzelMusteri();
            Musteri musteri4 = new GercekMusteri();
            //burda musteriyi isteğimiz yerde kullanabiliriz musteriye  gercek müsteri tanımlayabilirz
            CustomerManeger customerManeger = new CustomerManeger();
            customerManeger.Ekle(musteri2);
            customerManeger.Ekle(musteri1);
            //customer manager e de müsterinin icindeki herşey atanabilir birbirne bağlı 
            Console.WriteLine(musteri1.Id);
        }
    }
}
