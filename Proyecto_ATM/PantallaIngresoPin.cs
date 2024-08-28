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
        public event EventHandler AcctorPinIncorrect;
        private Conector conector;

        public PantallaIngresoPin()
        {
            InitializeComponent();
            conector = new Conector();

        }

        private void PantallaIngresoPin_Load(object sender, EventArgs e)
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
            Usuario usuario = GlobalState.Usuario;

            if (usuario == null)
            {
                mostrar_error("Usuario no inicializado.");
                return;
            }

            // Validate the account number and PIN
            if (usuario.validar_usuario(conector, textbox_pin.Text))
            {
                // Clear PIN text box
                textbox_pin.Clear();

                // Transition based on user role
                switch (usuario.get_rol())
                {
                    case "cliente":
                        IngresarMenuConsulta?.Invoke(this, EventArgs.Empty);
                        break;
                    case "agente":
                        IngresarMenuAgente?.Invoke(this, EventArgs.Empty);
                        break;
                    case "tecnico":
                        IngresarMenuTecnico?.Invoke(this, EventArgs.Empty);
                        break;
                    default:
                        Console.WriteLine("Error: Unknown user role.");
                        break;
                }
            }
            else
            {
                AcctorPinIncorrect?.Invoke(this, EventArgs.Empty);
                mostrar_error("Incorrect account number or PIN.");
            }
        }

        private void mostrar_error(string mensaje)
        {
            // Display the error message
            MessageBox.Show(mensaje);

            // Optionally, reset the input fields
            textbox_pin.Clear();
        }

        private void Reset(object sender, EventArgs e)
        {

            textbox_pin.ResetText();
        }


    }
}
