using System;

namespace Metotlar
{
    /*
     METOTLAR BIZIM ICIN TEKRAR TEKRAR KULLANILABILIRGI SAGLAYAN BIR ORTAM SUNUYOR
     */


    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";
                        
            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("-------------Metotlar-----------");

            //instance - ornek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //sonradan stok adedi eklendi ve suan bu ekleme islemleri basarisizdir
            //cunku stok adedinin karsiligi yok bu ekleme isleminde 
            //tek tek eklemek gerekicek bu yuzden yanlis bir kullanim turudur ekle2
            
            /*
            sepetManager.Ekle2("Armut", "Yesil armut", 12);
            sepetManager.Ekle2("Elma", "Yesil elma", 5);
            sepetManager.Ekle2("Kivi", "Yesil kivi", 11);
            */

           
        }
    }
}



//Dont repeat yourself
