using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKarti_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BankKart

            //BemBankKart bbk = new BemBankKart();
            //bbk.Bakiye = 500;
            //bbk.KartNo = "1254789236589654";

            //bbk.Yukle(200);
            //bool sonuc = bbk.Ode(600);
            //Console.WriteLine(sonuc);

            #endregion

            #region EsKart

            EsKart kart = new EsKart();
            kart.tur = "tam";


            kart.Yukle(2);


            Console.WriteLine(kart.ode());
            #endregion
        }
    }
}
