using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demirog
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demirog";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io"; 
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri(); // new referans no demek yani onun referansini tutuyor
            Musteri musteri4 = new TuzelMusteri(); // burda ise Musteri hem gercegin hem de tuzelin refaransini tutabiliyor

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            //Gercek Musteri - Tuzel Musteri
            //bu ikisi musteri fakat farkli musteriler
            //birbirleri yerine kullanilamaz
        }
    }
}
