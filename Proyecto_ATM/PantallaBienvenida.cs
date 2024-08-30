using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private PictureBox[] images;  
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

            images = new PictureBox[imageFiles.Length];
            for (int i = 0; i < imageFiles.Length; i++) {
                // Load the image into memory using a MemoryStream
                Image image;
                using (FileStream fs = new FileStream(imageFiles[i], FileMode.Open, FileAccess.Read))
                {
                    image = Image.FromStream(fs);
                }

                // Alternatively, you can use Image.Clone() if you want to clone the image
                // Image image = Image.FromFile(imageFiles[i]).Clone() as Image;

                // Initialize a new PictureBox
                images[i] = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage, // Set the SizeMode as needed
                    Width = 100, // Set the width as needed
                    Height = 100, // Set the height as needed
                    Image = image // Assign the image that is now in memory
                };
            }

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
            if (images != null && images.Length > 0)
            {
                pictureBox1.Image = images[currentIndex].Image;
        

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
