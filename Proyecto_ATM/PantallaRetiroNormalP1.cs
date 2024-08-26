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

        public event EventHandler EventoRegresar;
        public event EventHandler EventoMonto;



        private void roundButton5_Click(object sender, EventArgs e) // BotonRegresar 
        {

            if (this.EventoRegresar != null)
            {
                this.EventoRegresar(this, e);
            }

        }

        private void L100_Click(object sender, EventArgs e)
        {
            if (this.EventoMonto != null) {
                this.EventoMonto(this, e);
            }
        }

        private void L200_Click(object sender, EventArgs e)
        {
            if (this.EventoMonto != null)
            {
                this.EventoMonto(this, e);
            }
        }

        private void L500_Click(object sender, EventArgs e)
        {
            if (this.EventoMonto != null)
            {
                this.EventoMonto(this, e);
            }
        }

        private void L1000_Click(object sender, EventArgs e)
        {
            if (this.EventoMonto != null)
            {
                this.EventoMonto(this, e);
            }
        }

        private void L2000_Click(object sender, EventArgs e)
        {
            if (this.EventoMonto != null)
            {
                this.EventoMonto(this, e);
            }
        }

        private void L3000_Click(object sender, EventArgs e)
        {
            if (this.EventoMonto != null)
            {
                this.EventoMonto(this, e);
            }
        }

        private void L4000_Click(object sender, EventArgs e)
        {
            if (this.EventoMonto != null)
            {
                this.EventoMonto(this, e);
            }
        }

        private void L5000_Click(object sender, EventArgs e)
        {
            if (this.EventoMonto != null)
            {
                this.EventoMonto(this, e);
            }
        }

        private void MontoPersonalizado_Click(object sender, EventArgs e)
        {

        }
    }
}
