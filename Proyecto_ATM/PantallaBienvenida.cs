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
    public partial class PantallaBienvenida : UserControl
    {
        public PantallaBienvenida()
        {
            InitializeComponent();
            
        }

        public event EventHandler IngresarMenuRetiro;
        public event EventHandler IrIngresoTarjeta;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (this.IngresarMenuRetiro != null)
            {
                this.IngresarMenuRetiro(this, e);                
            }
            else
            {
                Console.WriteLine("Error al cambiar panel bienvenida -> Menu de Retiro\n");
            }
        }
    }
}
