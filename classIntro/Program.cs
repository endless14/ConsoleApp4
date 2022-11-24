using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.kursAdi = "c#";
            kurs1.kursegitmeni = "engin demiroğ";
            kurs1.kursIzlenme = 64;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "c++";
            kurs2.kursegitmeni = "Sinan Engin";
            kurs2.kursIzlenme = 85;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "java";
            kurs3.kursegitmeni = "enes";
            kurs3.kursIzlenme = 75;

            kurs[] kurslar = new kurs[]
            {
                kurs1,kurs2,kurs3
            };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi +":"+ kurs.kursegitmeni+":"+kurs.kursIzlenme);
            }
            {
                Console.WriteLine(kurs1);
            }
        }

        
	

	}
        
        

        
    }
    class kurs
    {
        public string kursAdi { get; set; }
        public string kursegitmeni { get; set; }
        public int kursIzlenme { get; set; }
    }

