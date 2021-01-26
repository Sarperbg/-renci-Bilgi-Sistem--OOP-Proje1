using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NESNEODEV1
{
    class yukseklisans : ogrenci
    {

        private string mezunOlduguLisansOkulAdi;
        private string mezunOlduguLisansBolumAdi;
        
        public yukseklisans(string mezunOlduguLisansBolumAdi, string mezunOlduguLisansOkulAdi , string ogrNo, string ograAdSoyad, string bolumAdi, ders[] dersler) : base(ogrNo,  ograAdSoyad,  bolumAdi,  dersler)
        {

            this.mezunOlduguLisansBolumAdi = mezunOlduguLisansBolumAdi;
            this.mezunOlduguLisansOkulAdi = mezunOlduguLisansOkulAdi;
        }
        







    }
}
