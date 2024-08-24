using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ATM.api
{
    public  class Conector
    {
        public  NpgsqlConnection conector = new NpgsqlConnection();


        static string password="password";
        static string port="5432";
        static string db="ATM";
        static string username="atm";
        static string host = "localhost";
       

    

        public NpgsqlConnection conectar() {
            try {

                conector.ConnectionString = "server="+host+";"+ "port=" + port+";" + "user id=" + username + ";"+"password="+password+";"+"database="+db+";";
                conector.Open();
               // MessageBox.Show("conexion correcta");
            }
            catch(NpgsqlException e) {
                MessageBox.Show(e.Message);
            }

            return conector;
        
        }

        public void Close() {

            conector.Close();
       
        }
        public void Open() {
            if (conector.State != ConnectionState.Open)
            {
                conector.Open();
            }
        
        }

       


    }
}
