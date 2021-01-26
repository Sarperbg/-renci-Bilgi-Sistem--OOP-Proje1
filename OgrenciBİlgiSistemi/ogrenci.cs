using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NESNEODEV1
{
    class ogrenci
    {
        public string ogrNo;
        protected string ogrAdSoyad;
        protected string bolumAdi;
        protected double kbn;
        protected ders[] dersler;

        public ogrenci(string ogrNo, string ogrAdSoyad, string bolumAdi, ders[] dersler)
        {
            Console.WriteLine(dersler[0].DersAdi);
            this.ogrNo = ogrNo;
            this.ogrAdSoyad = ogrAdSoyad;
            this.bolumAdi = bolumAdi;
            this.dersler = dersler;

        }

        public void kumulatifBasariNotuHesapla(int ects = 5)
        {
            double kbn = 0;
            double toplam = 0;
            double toplamKredi = 0;
            for (int i = 0; i < dersler.Length; i++)
            {
                if(dersler[i]!=null)
                {
                toplam += dersler[i].BasariNotu * dersler[i].Kredi;
                toplamKredi += dersler[i].Kredi;
                }
                
            }

              kbn = toplam / toplamKredi;
              this.kbn = kbn;
        }
    
        public void ogrenciBilgiGoster()
        {
            Console.WriteLine(this.ogrAdSoyad);
            Console.WriteLine(this.ogrNo);
            for(int i=0;i<this.dersler.Length;i++)
            {
                if(dersler[i]!=null)
                {
                    Console.WriteLine(dersler[i].DersAdi);
                    Console.WriteLine(dersler[i].DersKodu);
                    Console.WriteLine(dersler[i].BasariNotu);
                    Console.WriteLine(dersler[i].Kredi);
                }
               
                
            }
            Console.WriteLine(this.kbn);
        }
        
    }
}
