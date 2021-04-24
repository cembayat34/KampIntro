using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //name convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        //bu yontem kullanilmamalidir
        //cunku degerler tanimlandiktan sonra baska bi deger girildiginde bu sefer
        //bu metodu kullandigimiz her yerde o degerin karsilgini girmemiz gerekir
        //ornek olarak ekle2 ye stok bilgisi ekleyelim
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
