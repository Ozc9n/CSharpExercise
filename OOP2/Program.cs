using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri = new GercekMusteri();
            musteri.Adi = "Hüseyin";
            musteri.SoyAdi = "Özcan";
            musteri.TcNo = "12312312312";
            musteri.Id = 1;
            musteri.MusteriNo = "1";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "1";
            musteri2.VergiNo = "123";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new GercekMusteri();

            MusteriManager manager = new MusteriManager();
            manager.Add(musteri2);

        }
    }
}
