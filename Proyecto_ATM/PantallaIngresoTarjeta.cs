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
        //Variables necesarias para hacer ufncionar el modal.
        public static int parentX, parentY;
        public PantallaIngresoTarjeta()
        {
            InitializeComponent();
            conector = new Conector();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PantallaIngresoTarjeta_Load(object sender, EventArgs e)
        {
            try
            {
                conector.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }

        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {


            usuario.set_numero_cuenta(textobox_numero_tarjeta.Text);
            if (usuario.validar_usuario(conector))
            {
                GlobalState.Usuario = usuario;
                textobox_numero_tarjeta.Clear();
                //pasar a ingresar pin 
                if (this.IrIngresoPin != null)
                {
                    this.IrIngresoPin(this, e);

                }
                else
                {
                    Console.WriteLine("Error al cambiar asegurese de asgina funcion al evento.\n");

                }

            }
            else {
                mostrar_error();
            }

        }
        
        private void mostrar_error() {
            //El error se muestra en formade Modal
            Form modalBackground = new Form();
            Form parentForm = this.FindForm();
            using (modalForm modal = new modalForm())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = 0.5d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = parentForm.Size ;
                modalBackground.Location = parentForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;
                parentX=this.Location.X;
                parentY=this.Location.Y;



                modal.ShowDialog();
                modalBackground.Dispose();


            }

        }

        private void Reset(object sender, EventArgs e) {

            textobox_numero_tarjeta.ResetText();
        }
    }
}
