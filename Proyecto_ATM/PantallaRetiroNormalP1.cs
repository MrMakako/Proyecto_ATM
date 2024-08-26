using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Pantalla de Seleccion de Dinero
namespace Proyecto_ATM
{
    public partial class PantallaRetiroNormalP1 : UserControl
    {
        public PantallaRetiroNormalP1()
        {
            InitializeComponent();
        }

        public EventHandler EventoRegresar;
        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton11_Click(object sender, EventArgs e)
        {

        }

        private void roundButton5_Click(object sender, EventArgs e) // BotonRegresar 
        {

            if (this.EventoRegresar != null) { 
            this.EventoRegresar(this, e);
            }

        }
    }
}
