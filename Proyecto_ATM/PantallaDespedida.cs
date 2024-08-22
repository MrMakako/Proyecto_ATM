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
    public partial class PantallaDespedida : UserControl
    {
        private System.Windows.Forms.Timer Relojito;
        public Action OnTimeout { get; set; }
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
        protected override void OnVisibleChanged(EventArgs e)
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
            OnTimeout?.Invoke();
            
        }

    }
}
