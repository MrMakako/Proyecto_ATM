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
    public partial class PantallaIngresoTarjeta : UserControl
    {

        Conector conector;
        public EventHandler IrIngresoPin;
        public Usuario usuario { get; set; }
        public PantallaIngresoTarjeta()
        {
            InitializeComponent();
            conector = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PantallaIngresoTarjeta_Load(object sender, EventArgs e)
        {
            conector = new Conector();
            conector.conectar();
        }


        private void ingresar_btn_Click(object sender, EventArgs e)
        {


            usuario.set_numero_cuenta(textobox_numero_tarjeta.Text);
            if (usuario.validar_usuario(conector)) {
                //pasar a ingresar pin 
                if (this.IrIngresoPin != null)
                {
                    this.IrIngresoPin(this, e);
                }
                else {
                    Console.WriteLine("Error al cambiar asegurese de asgina funcion al evento.\n");

                }

            }

        }
    }
}
