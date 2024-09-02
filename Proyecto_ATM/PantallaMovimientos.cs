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
    public partial class PantallaMovimientosTecnico : UserControl
    {
        public PantallaMovimientosTecnico()
        {
            InitializeComponent();
        }
        private Tecnico tecnico;
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresar_btn_Click(object sender, EventArgs e)
        {

        }

        private void PantallaMovimientosTecnico_Load(object sender, EventArgs e)
        {
            tecnico = new Tecnico();

            

            
            
            /*
            tablaMovimientos.RowCount =tablaMovimientos.RowCount + 1;
            tablaMovimientos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tablaMovimientos.Controls.Add(new Label() { Text = "Street, City, State" }, 0, tablaMovimientos.RowCount - 1);
            tablaMovimientos.Controls.Add(new Label() { Text = "888888888888" }, 1, tablaMovimientos.RowCount - 1);
            tablaMovimientos.Controls.Add(new Label() { Text = "xxxxxxx@gmail.com" }, 2, tablaMovimientos.RowCount - 1);
            */
        }
    }
}
