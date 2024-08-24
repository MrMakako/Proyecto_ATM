using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ATM.api
{
    internal class Usuario
    {


        private string numero_cuenta;
        private string pin;
        public Usuario(string numero_cuenta, string pin) {
            this.pin = pin;
            this.numero_cuenta = numero_cuenta;
        }
        public string get_numero_cuenta() {return numero_cuenta;}
        public string get_pin() { return pin; }

        public void set_numero_cuenta(string numero_cuenta) { this.numero_cuenta = numero_cuenta};
        public void set_pin(string pin) { this.pin = pin; }




    }
}
