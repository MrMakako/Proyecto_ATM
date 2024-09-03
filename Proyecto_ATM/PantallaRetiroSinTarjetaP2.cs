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
    public partial class PantallaRetiroSinTarjetaP2 : UserControl
    {

        Movimiento movi;
        string codigo = "";
        public event EventHandler retiroSinTarjetaExitoso;


        public PantallaRetiroSinTarjetaP2()
        {
            InitializeComponent();
            movi = new Movimiento();
        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            codigo = PantallaRetiroSinTarjetaP1.codigo;
            int monto = int.Parse(textBox1.Text);
            if(movi.retiro_sin_tarjeta(codigo, monto))
            {
                if (retiroSinTarjetaExitoso != null)
                {
                    retiroSinTarjetaExitoso(this, EventArgs.Empty);
                }
                else
                {
                    Console.WriteLine("Error al cambiar de pantalla");
                }
            }
            else
            {
                
            }
            

            

        }
    }
}
