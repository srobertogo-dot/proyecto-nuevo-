using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPOOArch
{
   public class Cliente
    {
        //PROPIEDADES
        public int IdCli { get; set; }

        public string NombreCli { get; set; }
        public List<CuentaBancaria> lstCtas { get; set; }
        //CONTRUCTORES
        public Cliente()
        {
            IdCli = 0;
            NombreCli = "No definido";
            lstCtas = new List<CuentaBancaria>();
        }
        public Cliente(int idc,string nomc)
        {
            IdCli = idc;
            NombreCli = nomc;
            lstCtas = new List<CuentaBancaria>();
        }
    }
}
