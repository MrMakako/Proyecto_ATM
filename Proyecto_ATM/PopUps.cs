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
        String ErrorMessage;
        Form parent;
        public PopUps(String Error, Form Parent)
        {
            ErrorMessage = Error;
            parent = Parent;
        }

        public void mostrar_error()
        {
            
            Form modalBackground = new Form();
            Form parentForm = parent;
            using (modalForm modal = new modalForm())
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
                modal.error = ErrorMessage;
                //int parentX = parent.Location.X;
                //int parentY = parent.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();

            }

        }
    

        }

}
