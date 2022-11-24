using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        public void Ekle(product Ürün)
        {
            Console.WriteLine("Ürün Sepete Eklendi !" + Ürün.ürünAdi);
        }
        public void Ekle2(string ürünadi,string aciklama,double fiyat,int stok)
        {
            Console.WriteLine("tekbikler eklendi "+ürünadi+stok);
        }
    }
}
