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
using System.Globalization;

namespace Proyecto_ATM
{
    public partial class TecnicoEstadoActual : UserControl
    {
        public TecnicoEstadoActual()
        {
            InitializeComponent();
            LoadInfo();

        }

        private SaldoActual saldo = new SaldoActual();
        public event EventHandler regresarMenuTecnico;
        public event EventHandler salirPantallaBienvenida;

        public void LoadInfo()
        {
            saldo.LoadData();
            this.Valor100.Text = saldo.cant100.ToString();
            this.Valor200.Text = saldo.cant200.ToString();
            this.Valor500.Text = saldo.cant500.ToString();
            //this.ValorTotal.Text = saldo.saldoTotal.ToString() + " Lempiras";
            this.ValorTotal.Text = " L. " + saldo.saldoTotal.ToString("N", CultureInfo.InvariantCulture);
            this.Total100.Text = (saldo.cant100*100).ToString();  
            this.Total200.Text = (saldo.cant200*200).ToString();
            this.Total500.Text = (saldo.cant500*500).ToString();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void regresar_btn_Click(object sender, EventArgs e)
        {
            if (this.regresarMenuTecnico != null)
            {
                this.regresarMenuTecnico(this, e);

            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            if (this.salirPantallaBienvenida != null)
            {
                this.salirPantallaBienvenida(this, e);

            }
            else
            {
                Console.WriteLine("Error");
            }

        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
