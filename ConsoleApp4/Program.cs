using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "kategori";
            int ogrenciSayisi = 22;
            double faiz = 1.565;
            bool sistemeGirisVarmı = false;
            double dolarDün = 7.35;
            double dolarBugün = 7.35;

            if (dolarBugün > dolarDün)
            {
                Console.WriteLine("dolar arttı");
            }
            else if (dolarBugün < dolarDün) 
            {
                Console.WriteLine("dolar düştü");
            }
            else
            {
                Console.WriteLine("dolar eşit ");
            }

            if (sistemeGirisVarmı==true)
            {
                Console.WriteLine("sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("kullanıcı bilgileri yanlış");
            }
            Console.WriteLine(KategoriEtiketi);
        }
    }
}
