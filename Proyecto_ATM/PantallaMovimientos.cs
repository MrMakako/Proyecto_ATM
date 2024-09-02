﻿using Proyecto_ATM.api;
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

            tecnico.obtener_movimientos();

            List<MovimientoModel> movimientos = tecnico.movimientos;
            for (int i = 0; i < movimientos.Count; i++) {

                tablaMovimientos.Controls.Add(new Label() { Text = movimientos[i].fecha }, 0, tablaMovimientos.RowCount - 1);
                tablaMovimientos.Controls.Add(new Label() { Text = movimientos[i].hora }, 1, tablaMovimientos.RowCount - 1);
                tablaMovimientos.Controls.Add(new Label() { Text = movimientos[i].id_cliente +""}, 2, tablaMovimientos.RowCount - 1);
                tablaMovimientos.Controls.Add(new Label() { Text = movimientos[i].tipo_retiro }, 3, tablaMovimientos.RowCount - 1);
                tablaMovimientos.Controls.Add(new Label() { Text = movimientos[i].monto }, 4, tablaMovimientos.RowCount - 1);
                tablaMovimientos.RowCount = tablaMovimientos.RowCount + 1;
                tablaMovimientos.RowStyles.Add(new System.Windows.Forms.RowStyle());

            }

            
            
            /*
           
            */
        }
    }
}
