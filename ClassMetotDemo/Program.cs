using System;

namespace ClassMetotDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.Ad = "Musa";
            m1.Soyad = "Balın";
            m1.Id = 1;
            Musteri m2 = new Musteri();
            m2.Id = 2;
            m2.Ad = "Burak";
            m2.Soyad = "Soycu";
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(m1);
            musteriManager.Sil(m2);
        }
    }
}
