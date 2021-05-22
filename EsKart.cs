using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKarti_uygulama
{
    class EsKart
    {
        public double Bakiye;
        public string tur;

        public void Yukle(double miktar)
        {
            Bakiye += miktar;
        }

        public string ode()
        {
            string mesaj = "";
            double dusulecek = 0;

           if(tur == "Ogrenci") dusulecek = 1.60;
           else dusulecek = 2.50;

            if (Bakiye >= dusulecek)
            {
                Bakiye -= dusulecek;
                mesaj = "Kalan = " + Bakiye;
                Console.Beep(1000, 500);
            }
            else
            {
                mesaj = "Bakiye Yetersiz";
                Console.Beep(400, 100);
                Console.Beep(400, 100);
                Console.Beep(400, 100);
            }
            return mesaj;
        }
    }
}
