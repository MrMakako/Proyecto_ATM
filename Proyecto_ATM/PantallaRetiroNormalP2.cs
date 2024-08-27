using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_ATM.api;

namespace Proyecto_ATM
{
    public partial class PantallaRetiroNormalP2 : UserControl
    {
        private KeyPressEventHandler textbox1_Keypress;
        public event EventHandler EventoRegresar1;
        public event EventHandler retiroExitoso;
        private Conector conector;

        public PantallaRetiroNormalP2()
        {
            InitializeComponent();
            conector = new Conector();

            if (textBox1 != null)
            {
                textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void RegresarBtn_Click(object sender, EventArgs e)
        {
            if (this.EventoRegresar1 != null)
            {
                this.EventoRegresar1(this, e);
            }
        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double monto))
            {
                Usuario usuario = GlobalState.Usuario; 

                Movimiento movimiento = new Movimiento(usuario.get_numero_cuenta(), usuario.get_pin(), conector);

                bool exito = movimiento.retiro(monto);

                if (exito)
                {
                    if (retiroExitoso != null)
                    {
                        retiroExitoso(this, EventArgs.Empty);

                    }
                    else
                    {
                        Console.WriteLine("Error al cambiar de pantalla");
                    }
                    
                }
                else
                {
                    MessageBox.Show("No hay suficiente saldo en la cuenta.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido.");
            }
        }

        private void Reset(object sender, EventArgs e)
        {

            textBox1.ResetText();
        }
    }
}
