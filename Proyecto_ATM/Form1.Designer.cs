namespace Proyecto_ATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            pantallaRetiroSinTarjetaP21 = new PantallaRetiroSinTarjetaP2();
            pantallaRetiroSinTarjetaP11 = new PantallaRetiroSinTarjetaP1();
            pantallaRetiroNormalP2 = new PantallaRetiroNormalP2();
            pantallaRetiroNormalP1 = new PantallaRetiroNormalP1();
            pantallaMenuRetiro = new PantallaMenuRetiro();
            pantallaMenuTecnico = new PantallaMenuTecnico();
            pantallaDespedida = new PantallaDespedida();
            pantallaBienvenida = new PantallaBienvenida();
            pantallaSaldo1 = new PantallaSaldo();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(88, 541);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 110);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(88, 22);
            button5.TabIndex = 3;
            button5.Text = "PMenuR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 88);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(88, 22);
            button6.TabIndex = 4;
            button6.Text = "PMenuT";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 66);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(88, 22);
            button4.TabIndex = 2;
            button4.Text = "PRetiroN2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 44);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(88, 22);
            button1.TabIndex = 0;
            button1.Text = "PRetiroN1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 22);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(88, 22);
            button3.TabIndex = 1;
            button3.Text = "PDespedida";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(88, 22);
            button2.TabIndex = 0;
            button2.Text = "PBienvenida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pantallaSaldo1);
            panel2.Controls.Add(pantallaRetiroSinTarjetaP21);
            panel2.Controls.Add(pantallaRetiroSinTarjetaP11);
            panel2.Controls.Add(pantallaRetiroNormalP2);
            panel2.Controls.Add(pantallaRetiroNormalP1);
            panel2.Controls.Add(pantallaMenuRetiro);
            panel2.Controls.Add(pantallaMenuTecnico);
            panel2.Controls.Add(pantallaDespedida);
            panel2.Controls.Add(pantallaBienvenida);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(88, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 541);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pantallaRetiroSinTarjetaP21
            // 
            pantallaRetiroSinTarjetaP21.BackColor = Color.FromArgb(238, 39, 55);
            pantallaRetiroSinTarjetaP21.Location = new Point(0, 0);
            pantallaRetiroSinTarjetaP21.Margin = new Padding(3, 2, 3, 2);
            pantallaRetiroSinTarjetaP21.Name = "pantallaRetiroSinTarjetaP21";
            pantallaRetiroSinTarjetaP21.Size = new Size(896, 541);
            pantallaRetiroSinTarjetaP21.TabIndex = 6;
            // 
            // pantallaRetiroSinTarjetaP11
            // 
            pantallaRetiroSinTarjetaP11.BackColor = Color.FromArgb(238, 39, 55);
            pantallaRetiroSinTarjetaP11.Location = new Point(0, 2);
            pantallaRetiroSinTarjetaP11.Margin = new Padding(3, 2, 3, 2);
            pantallaRetiroSinTarjetaP11.Name = "pantallaRetiroSinTarjetaP11";
            pantallaRetiroSinTarjetaP11.Size = new Size(896, 541);
            pantallaRetiroSinTarjetaP11.TabIndex = 5;
            // 
            // pantallaRetiroNormalP2
            // 
            pantallaRetiroNormalP2.Dock = DockStyle.Fill;
            pantallaRetiroNormalP2.Location = new Point(0, 0);
            pantallaRetiroNormalP2.Margin = new Padding(3, 2, 3, 2);
            pantallaRetiroNormalP2.Name = "pantallaRetiroNormalP2";
            pantallaRetiroNormalP2.Size = new Size(896, 541);
            pantallaRetiroNormalP2.TabIndex = 5;
            // 
            // pantallaRetiroNormalP1
            // 
            pantallaRetiroNormalP1.BackColor = Color.FromArgb(238, 39, 55);
            pantallaRetiroNormalP1.Dock = DockStyle.Fill;
            pantallaRetiroNormalP1.Location = new Point(0, 0);
            pantallaRetiroNormalP1.Margin = new Padding(4, 3, 4, 3);
            pantallaRetiroNormalP1.Name = "pantallaRetiroNormalP1";
            pantallaRetiroNormalP1.Size = new Size(896, 541);
            pantallaRetiroNormalP1.TabIndex = 4;
            // 
            // pantallaMenuRetiro
            // 
            pantallaMenuRetiro.BackColor = Color.FromArgb(238, 39, 55);
            pantallaMenuRetiro.Dock = DockStyle.Fill;
            pantallaMenuRetiro.Location = new Point(0, 0);
            pantallaMenuRetiro.Margin = new Padding(3, 2, 3, 2);
            pantallaMenuRetiro.Name = "pantallaMenuRetiro";
            pantallaMenuRetiro.Size = new Size(896, 541);
            pantallaMenuRetiro.TabIndex = 3;
            // 
            // pantallaMenuTecnico
            // 
            pantallaMenuTecnico.Dock = DockStyle.Fill;
            pantallaMenuTecnico.Location = new Point(0, 0);
            pantallaMenuTecnico.Margin = new Padding(3, 2, 3, 2);
            pantallaMenuTecnico.Name = "pantallaMenuTecnico";
            pantallaMenuTecnico.Size = new Size(896, 541);
            pantallaMenuTecnico.TabIndex = 2;
            // 
            // pantallaDespedida
            // 
            pantallaDespedida.BackColor = Color.FromArgb(238, 39, 55);
            pantallaDespedida.Dock = DockStyle.Fill;
            pantallaDespedida.ForeColor = SystemColors.ControlText;
            pantallaDespedida.Location = new Point(0, 0);
            pantallaDespedida.Margin = new Padding(3, 2, 3, 2);
            pantallaDespedida.Name = "pantallaDespedida";
            pantallaDespedida.OnTimeout = null;
            pantallaDespedida.Size = new Size(896, 541);
            pantallaDespedida.TabIndex = 1;
            // 
            // pantallaBienvenida
            // 
            pantallaBienvenida.BackColor = Color.FromArgb(238, 39, 55);
            pantallaBienvenida.Dock = DockStyle.Fill;
            pantallaBienvenida.Location = new Point(0, 0);
            pantallaBienvenida.Margin = new Padding(3, 2, 3, 2);
            pantallaBienvenida.Name = "pantallaBienvenida";
            pantallaBienvenida.Size = new Size(896, 541);
            pantallaBienvenida.TabIndex = 0;
            // 
            // pantallaSaldo1
            // 
            pantallaSaldo1.Location = new Point(3, 0);
            pantallaSaldo1.Margin = new Padding(3, 2, 3, 2);
            pantallaSaldo1.Name = "pantallaSaldo1";
            pantallaSaldo1.Size = new Size(896, 541);
            pantallaSaldo1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 541);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button6;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PantallaDespedida pantallaDespedida;
        private PantallaBienvenida pantallaBienvenida;
        private PantallaMenuTecnico pantallaMenuTecnico;
        private PantallaRetiroNormalP1 pantallaRetiroNormalP1;
        private PantallaMenuRetiro pantallaMenuRetiro;
        private PantallaRetiroNormalP2 pantallaRetiroNormalP2;
        private PantallaRetiroSinTarjetaP1 pantallaRetiroSinTarjetaP11;
        private PantallaRetiroSinTarjetaP2 pantallaRetiroSinTarjetaP21;
        private PantallaSaldo pantallaSaldo1;
    }
}
