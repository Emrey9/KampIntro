using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Emre";
            musteri1.Soyadı = "Yılmaz";
            musteri1.CalışmaDurumu = "Öğrenci";
            musteri1.Id = "18561500";
            musteri1.KayıtlıSube="Marmara";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Ahmet";
            musteri2.Soyadı = "Kaya";
            musteri2.CalışmaDurumu = "Çalışıyor";
            musteri2.Id = "05516516";
            musteri2.KayıtlıSube = "Ege";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Fuat";
            musteri3.Soyadı = "Erdem";
            musteri3.CalışmaDurumu = "Emekli";
            musteri3.Id = "156165";
            musteri3.KayıtlıSube = "Karadeniz";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine("-------------------------------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.Listele(musteriler);

            musteriManager.MusteriSilme(musteri3);

        }
    }
    
}
