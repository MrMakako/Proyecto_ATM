using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ATM
{
    public partial class PantallaDespedida : UserControl
    {
        private System.Windows.Forms.Timer Relojito;
        public event EventHandler despedidaTimeUp;
        public PantallaDespedida()
        {
            InitializeComponent();
        }
        private void PantallaDespedida_Load(object sender, EventArgs e)
        {
            //Posicionamiento de labels
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label2.Location = new Point(90, 205);
            label1.Location = new Point(96, 255);

            Relojito = new System.Windows.Forms.Timer();
            Relojito.Interval = (10 * 1000);
            Relojito.Tick += new EventHandler(TimesUp);

        }
        private void  Cambio(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Relojito.Start(); 
            }
            else
            {
                Relojito.Stop(); 
            }
        }

        private void TimesUp(object sender, EventArgs e)
        {
            Relojito.Stop();
            Relojito.Dispose();
            this.Hide();
            if (this.despedidaTimeUp != null)
            {
                this.despedidaTimeUp(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel de Despedida\n");
            }


        }

    }
}
