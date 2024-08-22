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
    public partial class PantallaMenuRetiro : UserControl
    {
        public PantallaMenuRetiro()
        {
            InitializeComponent();
        }

        public event EventHandler salirMenuRetiro;
        public event EventHandler redIngresoTarjeta;
        public event EventHandler redIngresoSinTarjeta;

        private void PantallaMenuRetiro_Load(object sender, EventArgs e)
        {

        }

        private void R_Normal_B_Click(object sender, EventArgs e)
        {
            if (this.redIngresoTarjeta != null)
            {
                this.redIngresoTarjeta(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de Retiro ->ingreso de tarjeta\n");
            }
        }

        private void R_SinTarjeta_B_Click(object sender, EventArgs e)
        {
            if (this.redIngresoSinTarjeta != null)
            {
                this.redIngresoSinTarjeta(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de Retiro ->retiro sin tarjeta\n");
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            if(this.salirMenuRetiro != null)
            {
                this.salirMenuRetiro(this, e);
            }
            else{
                Console.WriteLine("Error al cambiar panel Menu de Retiro\n");
            }
        }
    }
}
