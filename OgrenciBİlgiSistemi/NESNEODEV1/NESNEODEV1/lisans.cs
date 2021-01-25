using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace NESNEODEV1
{
    class lisans : ogrenci
    {

        public lisans(string ogrNo, string ogrAdSoyad, string bolumAdi, ders[] dersler) : base(ogrNo,  ogrAdSoyad,  bolumAdi,  dersler)
        {
            this.dersler = dersler;
        }
        

    }
}
