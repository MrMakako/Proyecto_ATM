﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proyecto_ATM
{
    public partial class modalForm : Form
    {
        public modalForm()
        {
            InitializeComponent();
        }
        int i;
        int y;
        private void modalForm_Load(object sender, EventArgs e)
        {
            i = Form1.parentY+550;
            y = Form1.parentY +250;
            this.Location = new Point(Form1.parentX +250, y);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += 0.03;
            }

            y +=1;
            this.Location = new Point(Form1.parentX + 250,y);

            if (y >= i) {
                modalEffect_Timer.Stop();
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
