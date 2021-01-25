using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace NESNEODEV1
{
    class doktora :ogrenci
    {
        private string mezunOlduguLisansOkulAdi;
        private string mezunOlduguLisansBolumAdi;
        private string mezunOlduguYuksekLisansOkulAdi;
        private string mezunOlduguYuksekLisansBolumAdi;

        public doktora(string mezunOlduguLisansOkulAdi , string mezunOlduguLisansBolumAdi ,string mezunOlduguYuksekLisansOkulAdi , string mezunOlduguYuksekLisansBolumAdi , string ogrNo, string ogrAdSoyad, string bolumAdi, ders[] dersler) : base (ogrNo,  ogrAdSoyad,  bolumAdi,  dersler)
        {
            this.mezunOlduguLisansBolumAdi = mezunOlduguLisansBolumAdi;
            this.mezunOlduguLisansOkulAdi = mezunOlduguLisansOkulAdi;
            this.mezunOlduguYuksekLisansBolumAdi = mezunOlduguYuksekLisansBolumAdi;
            this.mezunOlduguYuksekLisansOkulAdi = mezunOlduguYuksekLisansOkulAdi;
            



        }

    }
}
