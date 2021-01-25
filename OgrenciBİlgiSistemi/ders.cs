using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace NESNEODEV1
{
    class ders
    {
        private string dersKodu;
        public string DersKodu
        {
            get
            {
                return dersKodu;
            }
            set
            {
                dersKodu = value.ToUpper();
            }
        }
        private string dersAdi;
        public string DersAdi
        {
            get
            {
                return dersAdi;
            }
            set
            {
                dersAdi = value.ToUpper();
            }
        }
        private int kredi;
        public int Kredi
        {
            get
            {
                return kredi;
            }
            set
            {
                kredi = Math.Abs(value);
            }
        }
        private double basariNotu;
        public double BasariNotu
        {
            get
            {
                return basariNotu;
            }
            set

            {
                if (value <= 100 && value >= 0)
                    basariNotu = value;
                else  Console.WriteLine("Lutfen 0 Ile 100 Arasinda bir sayi Giriniz");
            }
        }


        public ders(string dersKodu, string dersAdi, int kredi, double basariNotu)
        {
            this.DersKodu = dersKodu;
            this.DersAdi = dersAdi;
            this.Kredi = kredi;
            this.BasariNotu = basariNotu;
        }
    }
}
