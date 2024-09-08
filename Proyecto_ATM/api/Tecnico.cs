using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_ATM.api
{
    public class Tecnico
    {

        public List<MovimientoModel> movimientos { get; }

        Conector conector;

        public Tecnico()
        {

            conector = new Conector();

            movimientos = new List<MovimientoModel>();
        }



        public void obtener_movimientos()
        {

            conector.Open();
            movimientos.Clear();

            using (var cmd = new NpgsqlCommand("select fecha_registro,id_cliente,tipo_retiro,monto_retiro from registro_movimientos_atm rma order by fecha_registro desc;", conector.conector))
            {

                // Execute the query
                NpgsqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string fecha_hora = reader["fecha_registro"].ToString();

                    // Extracting fecha and hora from fecha_hora
                    string fecha = fecha_hora.Substring(0, fecha_hora.IndexOf(' ')); // Extracts the date part
                    string hora = fecha_hora.Substring(fecha_hora.IndexOf(' ') + 1);  // Extracts the time part

                    int id_cliente = (int)reader["id_cliente"];
                    string tipo_retiro = (string)reader["tipo_retiro"];
                    double monto = (double)reader["monto_retiro"];
                    
                    movimientos.Add(new MovimientoModel(id_cliente, fecha, hora, monto + "", tipo_retiro));
                    

                }
            }
            
            conector.Close();


        }






    }
}