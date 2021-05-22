using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKarti_uygulama
{
    class BemBankKart
    {
        public string KartNo;
        public double Bakiye;

        public void Yukle(double miktar)
        {
            Bakiye += miktar;
        }
        public bool Ode(double miktar)
        {
            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
                return true;
            }
            else
            {
                return false;
            }
         
        }
    }
}
