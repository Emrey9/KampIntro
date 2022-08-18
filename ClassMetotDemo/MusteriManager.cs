using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
  

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+"Adlı müşteri eklendi.");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşterinin adı : " + musteri.Ad);
                Console.WriteLine("Müşterinin soyadı : " + musteri.Soyadı);
                Console.WriteLine("Müşterinin Kayıtlı olduğu şube : " + musteri.KayıtlıSube);
                Console.WriteLine("Müşterinin çalışma durumu : " + musteri.CalışmaDurumu);
                Console.WriteLine("-------------------------------------");
            }
                
           

        }
        public void MusteriSilme(Musteri musteri)
        {

            Console.WriteLine(musteri.Ad + "Adlı müşteri silindi.");
        }



    }
}
