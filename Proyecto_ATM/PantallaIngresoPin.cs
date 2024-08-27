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
    public partial class PantallaIngresoPin : UserControl
    {

        public Usuario Usuario { get; set; }
        public event EventHandler IngresarMenuConsulta;
        public event EventHandler IngresarMenuAgente;
        public event EventHandler IngresarMenuTecnico; 

        public PantallaIngresoPin()
        {
            InitializeComponent();

        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            
            //revisar que el pin coincina
            if (textbox_pin.Text == Usuario.get_pin()) {
                Usuario usuario = GlobalState.Usuario;
                textbox_pin.Clear();

                if (usuario.rol == "cliente")
                {
                    if (IngresarMenuConsulta != null)
                    {
                        IngresarMenuConsulta(this, EventArgs.Empty);

                    }
                    else
                    {
                        Console.WriteLine("Error al cambiar de pantalla");
                    }
                } else if (usuario.rol == "agente") {
                    if (IngresarMenuAgente != null)
                    {
                        IngresarMenuAgente(this, EventArgs.Empty);

                    }
                    else
                    {
                        Console.WriteLine("Error al cambiar de pantalla");
                    }
                } else if (usuario.rol == "tecnico")
                {
                    if (IngresarMenuTecnico != null)
                    {
                        IngresarMenuTecnico(this, EventArgs.Empty);

                    }
                    else
                    {
                        Console.WriteLine("Error al cambiar de pantalla");
                    }
                }

            
            }
        }
        // private Usuario usuario;


        private void Reset(object sender, EventArgs e)
        {

            textbox_pin.ResetText();
        }


    }
}
