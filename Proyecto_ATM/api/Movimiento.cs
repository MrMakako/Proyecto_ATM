using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public bool retiro(int monto)
        {
            //Tenemos que saber cuanot dinero tenemos      
            double saldo = consultar_saldo(numero_cuenta);
            conector.Open();
            try
            {

                // Realizar query que deduzca dinero de una cuenta.
                //no hay suficientes fondos se retorna falso.
                if (saldo > monto)
                {

                    double saldo_restante = saldo - monto;
                    //UPDATE 
                    using (var cmd = new NpgsqlCommand("UPDATE cuentas SET saldo= @saldo_restante WHERE numero_cuenta=@numero_cuenta", conector.conector))
                    {

                        cmd.Parameters.AddWithValue("saldo_restante", saldo_restante);
                        cmd.Parameters.AddWithValue("numero_cuenta", numero_cuenta);
                        //Ejecutamos el Query 
                        cmd.ExecuteNonQuery();

                    };

                }
                //Asegurar de cerrar la conexion
                conector.Close();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            //asegurarse de cerrar la conexion
            conector.Close();
            return false;

        }

        public  double consultar_saldo(string numero_cuenta) {

            //consultar el saldo de la cuneta.
            double? saldo=0.0;

            conector.Open();
            using (var cmd = new NpgsqlCommand("SELCT saldo FROM cuentas WHERE numero_cuenta = @numero_cuenta",conector.conector))
            {
                cmd.Parameters.AddWithValue("numero_cuenta",numero_cuenta );


                NpgsqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                saldo = reader["saldo"] as double ?;

            }

            conector.Close();
            return (double)saldo;
            
            
        }
        public string getNumero_cuenta() { return numero_cuenta; }
        public Conector getConector() { return conector; }







    }
}
