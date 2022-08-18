using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //değer tutucu
            String kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            String kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            String kurs2 = "Programlamaya Giriş";
            String kurs3 = "Java";
            String kurs4 = "C++";
            //array

            string[] kurslar = new string[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("For each bitti.");

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Kurs kursA = new Kurs();
            kursA.KursAdi = "Java";
            kursA.Eğitmen = "Kerem Varış";
            kursA.IzlenmaOranı = 68;

            Kurs kursB = new Kurs();
            kursB.KursAdi = "C#";
            kursB.Eğitmen = "Engin Demiroğ";
            kursB.IzlenmaOranı = 68;

            Kurs kursC = new Kurs();
            kursC.KursAdi = "Python";
            kursC.Eğitmen = "Berkay Bilgin";
            kursC.IzlenmaOranı = 68;


           // Console.WriteLine(kursA.KursAdi + " : " + kursA.Eğitmen);

            Kurs[] kurslarHarf = new Kurs[] { kursA, kursB, kursC };

            foreach (var kurs in kurslarHarf)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
               // Console.WriteLine(kurs.KursAdi.GetType());
            }

            int sayi = 8;
            String sonuc = sayi % 2 == 0 ? "Cift" : "Tek";
            Console.WriteLine(sonuc);   
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmaOranı { get; set; }
    }

    
}
