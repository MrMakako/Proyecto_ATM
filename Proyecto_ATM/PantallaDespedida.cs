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
        private string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName;
        private string imageFolderPath;
        private string[] imageFiles;
        public PantallaDespedida()
        {
            InitializeComponent();

            imageFolderPath = Path.Combine(projectDirectory, "Pantalla de Despedida");
        }
        private void PantallaDespedida_Load(object sender, EventArgs e)
        {
            //Agarrar el arreglo de las imagenes para solo agarrarse la primera
            imageFiles = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.TopDirectoryOnly)
                                  .Where(file => file.ToLower().EndsWith("jpg") ||
                                                 file.ToLower().EndsWith("png") ||
                                                 file.ToLower().EndsWith("bmp") ||
                                                 file.ToLower().EndsWith("jpeg"))
                                  .OrderBy(file => file)
                                  .ToArray();

            //Posicionamiento de labels
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label2.Location = new Point(90, 205);
            label1.Location = new Point(96, 255);

            //Solo agarra la primera imagen que detecta en orden alfabetico
            pictureBox1.Image = Image.FromFile(imageFiles[0]); 


            Relojito = new System.Windows.Forms.Timer();
            Relojito.Interval = (10 * 1000);
            Relojito.Tick += new EventHandler(TimesUp);

        }
        private void  Cambio(object sender, EventArgs e)
        {

            try {

                if (this.Visible)
                {
                    Relojito.Start();
                }
                else
                {
                    Relojito.Stop();
                }
            } catch (Exception er) { 
            
            
            
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
