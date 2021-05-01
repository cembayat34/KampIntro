using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate - Tuzel Musteri
    class TuzelMusteri:Musteri  //tuzel musterinin bir musteri oldugunu bu sekilde anlattik buna miras denir (inheratance)
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
