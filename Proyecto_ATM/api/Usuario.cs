using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ATM.api
{
    public class Usuario
    {


        public string numero_cuenta;
        public string pin;
        public Usuario(string numero_cuenta, string pin) {
            this.pin = pin;
            this.numero_cuenta = numero_cuenta;
        }
        public Usuario() {
            pin = "";
            numero_cuenta = "";
        }
        public string get_numero_cuenta() {return numero_cuenta;}
        public string get_pin() { return pin; }

        public void set_numero_cuenta(string numero_cuenta) { this.numero_cuenta = numero_cuenta; }
        public void set_pin(string pin) { this.pin = pin; }

        public bool validar_usuario(Conector conector)
        {


            bool valido = true;
            conector.Open();
            using (var cmd = new NpgsqlCommand("SELECT pin_cuenta FROM cuentas WHERE no_cuenta = @numero_cuenta ", conector.conector))
            {
                cmd.Parameters.AddWithValue("numero_cuenta",numero_cuenta);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    pin = (string)reader["pin_cuenta"];


                }
                else
                {
                    MessageBox.Show("Su tarjeta no existe");
                    valido = false;
                }



            }
            conector.Close();
            return valido;

        }



    }




}

