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
    public class Movimiento
    {
        private string numeroCuenta;
        private Conector conector;
        private string pin;

        public Movimiento(string numeroCuenta, string pin, Conector conector)
        {
            if (conector == null)
            {
                throw new ArgumentNullException(nameof(conector), "Connector is null");
            }
            this.numeroCuenta = numeroCuenta;
            this.conector = conector;
            this.pin = pin;
        }

        public bool retiro(double monto)
        {
            double saldo = ConsultarSaldo(numeroCuenta);

            if (saldo < monto)
            {
                MessageBox.Show("No hay suficiente saldo en la cuenta.");
                return false;
            }

            try
            {
                conector.Open();
                using (var cmd = new NpgsqlCommand("UPDATE cuentas SET saldo_cuenta = @saldo_restante WHERE no_cuenta = @numero_cuenta", conector.ConectorConnection))
                {
                    double saldoRestante = saldo - monto;

                    cmd.Parameters.AddWithValue("saldo_restante", saldoRestante);
                    cmd.Parameters.AddWithValue("numero_cuenta", numeroCuenta);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al realizar el retiro: " + e.Message);
                return false;
            }
            finally
            {
                conector.Close();
            }
        }


        public double ConsultarSaldo(string numeroCuenta)
        {
            double saldo = 0.0;

            try
            {

                conector.Open();
                using (var cmd = new NpgsqlCommand("SELECT saldo_cuenta FROM cuentas WHERE no_cuenta = @numero_cuenta", conector.ConectorConnection))
                {
                    cmd.Parameters.AddWithValue("numero_cuenta", numeroCuenta);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            saldo = reader.IsDBNull(reader.GetOrdinal("saldo_cuenta")) ? 0.0 : reader.GetDouble(reader.GetOrdinal("saldo_cuenta"));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar el saldo: " + e.Message);
            }
            finally
            {
                conector.Close();
            }

            return saldo;
        }


        public string GetNumeroCuenta() { return numeroCuenta; }
        public Conector GetConector() { return conector; }
    }
}