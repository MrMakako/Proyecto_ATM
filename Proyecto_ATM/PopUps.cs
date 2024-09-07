using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ATM
{
    internal class PopUps
    {
        
        public PopUps()
        {
        }

        public void mostrar_error(String Error, Form Parent)
        {
            
            Form modalBackground = new Form();
            Form parentForm = Parent;
            using (modalForm modal = new modalForm(Error))
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = 0.5d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = parentForm.Size;
                modalBackground.Location = parentForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;
                modal.error = Error;
                //int parentX = parent.Location.X;
                //int parentY = parent.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();

            }

        }
    

        }

}
