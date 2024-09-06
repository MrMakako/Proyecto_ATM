using Proyecto_ATM.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ATM
{
    public partial class PantallaRetiroSinTarjetaP1 : UserControl
    {
        public event EventHandler EventoRegresar1;
        public static string codigo = "";
        private Conector conector;
        public PantallaRetiroSinTarjetaP1()
        {
            InitializeComponent();
            conector = new Conector();
        }

        public event EventHandler cambioPt2;
        public event EventHandler cambioMenuRetiro;


        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void RegresarBtn_Click(object sender, EventArgs e)
        {
            if (this.EventoRegresar1 != null)
            {
                this.EventoRegresar1(this, e);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            codigo = textBox1.Text;

            Usuario usuario = new Usuario();
            if (usuario.ObtenerCuentaDesdeCodigo(codigo, conector)) 
            {
                GlobalState.Usuario = usuario;

                if (this.cambioPt2 != null)
                {
                    this.cambioPt2(this, e);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {

                MessageBox.Show("Código no válido.");
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (this.cambioMenuRetiro != null)
            {

                this.cambioMenuRetiro(this, e);

            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
