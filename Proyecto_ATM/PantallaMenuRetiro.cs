﻿using System;
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
    public partial class PantallaMenuRetiro : UserControl
    {
        public PantallaMenuRetiro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
        }

     

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            

            // Hide the current form or UserControl
            this.Hide();
        }
    }
}
