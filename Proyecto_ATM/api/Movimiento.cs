using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ATM.api
{
    internal class Movimiento
    {
        private string numero_cuenta;
        private Conector conector;
        private string pin;

        public Movimiento(string numero_cuenta,string pin,Conector conector) {
            this.numero_cuenta = numero_cuenta;
            this.conector = conector;
            this.pin = pin;

        }
        public bool retiro(int monto) {

            try
            {

                // Realizar query que deduzca dinero de una cuenta.
                return true;

            }
            catch (Exception)
            {

            }

            return false;
       
        }

        public double consultar_saldo(string numero_cuenta) {
            
            //consultar el saldo de la cuneta.
            return 0.0;
        
        }
        public string getNumero_cuenta() { return numero_cuenta; }
        public Conector getConector() { return conector; }







    }
}
