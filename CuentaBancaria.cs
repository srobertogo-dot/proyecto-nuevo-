using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPOOArch
{
   public class CuentaBancaria
    {
        public int IdCta { get; set; }
        public double MontoCta { get; set; }
        public CuentaBancaria()
        {
            IdCta = 0;
            MontoCta = 0;
        }
        public CuentaBancaria(int id,double monto)
        {
            IdCta = id;
            MontoCta = monto;
        }
    }
    

}
