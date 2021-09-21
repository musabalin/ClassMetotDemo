using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" Eklendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" Silindi.");
        }
    }
}
