using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual - Bireysel
    class GercekMusteri: Musteri //gercek musterinin bir musteri oldugunu bu sekilde anlattik buna miras denir (inheratance)
    {
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
    }
}
