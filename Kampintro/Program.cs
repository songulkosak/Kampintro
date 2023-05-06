using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampintro
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            Telefon tel1 = new Telefon();
            tel1.Markasi = "Samsung Galaxy Z Flip4";
            tel1.Rengi = "Siyah";
            tel1.UrunFiyat = "29.996";

            Telefon tel2 = new Telefon();
            tel2.Markasi = "iPhone 14 Pro";
            tel2.Rengi = "Mavi";
            tel2.UrunFiyat = "41.999,00";


            Telefon[] tel = new Telefon[] { tel1, tel2 };
            for (int i = 0; i < tel.Length; i++)
            {
                Console.WriteLine(tel[i].Rengi + " " +
                tel[i].Markasi +" : " + tel[i].UrunFiyat);
            }

            foreach (var urunler in tel)
            {
                Console.WriteLine(urunler.Markasi + " " + urunler.Rengi + " : " + urunler.UrunFiyat + "TL");
            }

            int t = 0;
            while (t < tel.Length)
            {
                Console.WriteLine(tel[t].Markasi + " " + tel[t].Rengi + " : " + tel[t].UrunFiyat);
                t++;
            }

        }
    }

    class Telefon
    {
        public string Markasi { get; set; }
        public string Rengi { get; set; }
        public string UrunFiyat { get; set; }
    }
}
    
