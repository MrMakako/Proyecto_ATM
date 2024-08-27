using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Proyecto_ATM
{
    public partial class PantallaBienvenida : UserControl
    {
        public event EventHandler IngresarMenuRetiro;
        public event EventHandler IrIngresoTarjeta;
        private string[] imageFiles;
        private int currentIndex = 0;
        private Timer slideshowTimer;


        private string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName;
        private string imageFolderPath;
        public PantallaBienvenida()
        {
            InitializeComponent();
            slideshowTimer = new Timer();
            slideshowTimer.Interval = 4000; // 3 seconds interval
            slideshowTimer.Tick += SlideshowTimer_Tick;

            imageFolderPath = Path.Combine(projectDirectory, "Pantalla de Espera");
            LoadImagesFromHardcodedFolder();

        }


        private void LoadImagesFromHardcodedFolder()
        {
            imageFiles = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.TopDirectoryOnly)
                                  .Where(file => file.ToLower().EndsWith("jpg") ||
                                                 file.ToLower().EndsWith("png") ||
                                                 file.ToLower().EndsWith("bmp") ||
                                                 file.ToLower().EndsWith("jpeg"))
                                  .OrderBy(file => file)
                                  .ToArray();

            if (imageFiles.Length > 0)
            {

                currentIndex = 0;
                slideshowTimer.Start(); // Start the slideshow
                DisplayCurrentImage();
            }
            else
            {
                MessageBox.Show("No images found in the specified folder.");
            }
        }

        private void DisplayCurrentImage()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(imageFiles[currentIndex]);
            }
        }


        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {



            // Update to the next image
            currentIndex++;
            if (currentIndex >= imageFiles.Length)
            {
                currentIndex = 0; // Loop back to the first image
            }
            DisplayCurrentImage();

        }

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
