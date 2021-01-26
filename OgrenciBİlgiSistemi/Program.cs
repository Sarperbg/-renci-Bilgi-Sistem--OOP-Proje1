using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESNEODEV1
{
    class Program
    {
        public static void BilgiGirisi(ArrayList ogrenciler)
        {

            ders[] Ders = new ders[100];
            double[] dersKumulatif = new double[100];
            string[] dersKodu = new string[100];
            string[] dersAdi = new string[100];
            int[] dersAkts = new int[100];

            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Ogrencinin İsmini Soy Ismini Giriniz:");
                    string ogrİsim = Console.ReadLine();
                    Console.WriteLine("Ogrencinin Numarasini Giriniz");
                    string ogrNumara = Console.ReadLine();
                    Console.WriteLine("Ogrencinin Kac Dersi Var");
                    int ogrDers = Convert.ToInt16(Console.ReadLine());

                    for (int i = 0; i < ogrDers; i++)
                    {
                        Console.WriteLine("Lutfen Sirasiyla Ogrencinin Ders Kodunu, Ders Adini, O Dersin Akts Kredisini, O Dersin Kümülatif Basari Notunu Giriniz");
                        dersKodu[i] = Console.ReadLine();
                        dersAdi[i] = Console.ReadLine();
                        dersAkts[i] = Convert.ToInt32(Console.ReadLine());
                        dersKumulatif[i] = Convert.ToDouble(Console.ReadLine());
                        ders DERS = new ders(dersKodu[i], dersAdi[i], dersAkts[i], dersKumulatif[i]);
                        Ders[i] = DERS;
                    }
                    lisans Lisans = new lisans(ogrNumara, ogrİsim, "bolumAdi", Ders);
                    Lisans.kumulatifBasariNotuHesapla();
                    ogrenciler.Add(Lisans);
                    break;
                case 2:
                    Console.WriteLine("Ogrencinin İsmini SoyIsmini Girin:");
                    ogrİsim = Console.ReadLine();
                    Console.WriteLine("Ogrencinin Numarasını Giriniz");
                    ogrNumara = Console.ReadLine();
                    Console.WriteLine("Ogrencinin Kac Dersi Var");
                    ogrDers = Convert.ToInt16(Console.ReadLine());

                    for (int i = 0; i < ogrDers; i++)
                    {
                        Console.WriteLine("Lutfen Sirasiyla Ogrencinin Ders Kodunu, Ders Adini, O Dersin Akts Kredisini, O Dersin Kümülatif Basari Notunu Girin");
                        dersKodu[i] = Console.ReadLine();
                        dersAdi[i] = Console.ReadLine();
                        dersAkts[i] = Convert.ToInt32(Console.ReadLine());
                        dersKumulatif[i] = Convert.ToDouble(Console.ReadLine());
                        ders DERS = new ders(dersKodu[i], dersAdi[i], dersAkts[i], dersKumulatif[i]);
                        Ders[i] = DERS;
                    }
                    yukseklisans yl = new yukseklisans("Mezun Oldugu Lisans Bolum Adi", "Mezun Oldugu Lisans Okul Adi", ogrNumara, ogrİsim, "bolumAdi", Ders);
                    yl.kumulatifBasariNotuHesapla();
                    ogrenciler.Add(yl);
                    break;


                case 3:
                    Console.WriteLine("Ogrencinin İsmini Soy Ismini Girin:");
                    ogrİsim = Console.ReadLine();
                    Console.WriteLine("Ogrencinin Numarasini Giriniz");
                    ogrNumara = Console.ReadLine();
                    Console.WriteLine("Ogrencinin Kac Dersi Var");
                    ogrDers = Convert.ToInt16(Console.ReadLine());

                    for (int i = 0; i < ogrDers; i++)
                    {
                        Console.WriteLine("Lutfen Sirasiyla Ogrencinin Ders Kodunu, Ders Adini, O Dersin Akts Kredisini, O Dersin Kümülatif Basari Notunu Girin");
                        dersKodu[i] = Console.ReadLine();
                        dersAdi[i] = Console.ReadLine();
                        dersAkts[i] = Convert.ToInt32(Console.ReadLine());
                        dersKumulatif[i] = Convert.ToDouble(Console.ReadLine());
                        ders DERS = new ders(dersKodu[i], dersAdi[i], dersAkts[i], dersKumulatif[i]);
                        Ders[i] = DERS;
                    }
                    doktora dr = new doktora("Mezun Oldugu Lisans Bolum Adi", "Mezun Oldugu Lisans Okul Adi", "Mezun Oldugu Yuksek Lisans Bolum Adi", "Mezun Oldugu Yuksek Lisans Okul Adi ",
                           ogrNumara, "bolumAdi", ogrİsim, Ders);
                    dr.kumulatifBasariNotuHesapla();
                    ogrenciler.Add(dr);
                    break;


            }
        }
        public static void bilgigoster(ArrayList ogrenciler)
        {
            int ogrNo = 0;
            foreach (ogrenci i in ogrenciler)
            {
               i.ogrenciBilgiGoster();
            }
        }
        public static void anamenu()
        {
            ArrayList ogrenciler = new ArrayList();
            Console.WriteLine("—ANA MENU —- \n 1 - Bilgi Girisi: \n 2 - Bilgileri ekrana goster: ");
            while (true)
            {
                int secim2 = int.Parse(Console.ReadLine());
                
                switch (secim2)
                {

                    case 1:
                        Console.WriteLine("Ogrenci Lisans Ogrencisi Ise : 1, Yuksek Lisans Ogrencisi ise: 2 , Doktora Ogrencisi Ise 3'e Basiniz.");
                        BilgiGirisi(ogrenciler);
                        Console.WriteLine("Kayit Basarili Ile Tamamlandi");
                        Console.WriteLine("\n- Bilgi Girisine Devam etmek için : 1 \n - Bilgileri ekrana goster  :2 ");

                        break;
                    case 2:
                        bilgigoster(ogrenciler);
                        break;




                    default: Console.WriteLine("Yanlis Secim Yaptiniz, Lütfen Gecerli Bir Secim Yapiniz: "); break;
                }
            }
            
            
        }


        static void Main(string[] args)
        {

            anamenu();
            Console.ReadKey();


        }
    }
}


        
    

