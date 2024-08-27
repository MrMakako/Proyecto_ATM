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
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            pantallaTomeSuDinero = new PantallaTomeSuDinero();
            pantallaSaldo = new PantallaSaldo();
            pantallaRetiroNormalP2 = new PantallaRetiroNormalP2();
            pantallaRetiroNormalP1 = new PantallaRetiroNormalP1();
            pantallaRetiroSinTarjetaP2 = new PantallaRetiroSinTarjetaP2();
            pantallaRetiroSinTarjetaP1 = new PantallaRetiroSinTarjetaP1();
            pantallaMenuRetiro = new PantallaMenuRetiro();
            pantallaMenuTecnico = new PantallaMenuTecnico();
            pantallaMenuConsulta = new PantallaMenuConsulta();
            pantallaMenuAgente = new PantallaMenuAgente();
            pantallaDespedida = new PantallaDespedida();
            pantallaBienvenida = new PantallaBienvenida();
            pantallaIngresoTarjeta = new PantallaIngresoTarjeta();
            pantallaIngresoPin = new PantallaIngresoPin();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 960);
            panel1.TabIndex = 0;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.Location = new Point(0, 288);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(126, 36);
            button9.TabIndex = 7;
            button9.Text = "TomeDinero";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.Location = new Point(0, 252);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(126, 36);
            button8.TabIndex = 6;
            button8.Text = "PMenuA";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.Location = new Point(0, 216);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(126, 36);
            button7.TabIndex = 5;
            button7.Text = "PMenuC";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 180);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(126, 36);
            button5.TabIndex = 3;
            button5.Text = "PMenuR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 144);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(126, 36);
            button6.TabIndex = 4;
            button6.Text = "PMenuT";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 108);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(126, 36);
            button4.TabIndex = 2;
            button4.Text = "PRetiroN2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 72);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(126, 36);
            button1.TabIndex = 0;
            button1.Text = "PRetiroN1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 36);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(126, 36);
            button3.TabIndex = 1;
            button3.Text = "PDespedida";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(126, 36);
            button2.TabIndex = 0;
            button2.Text = "PBienvenida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pantallaTomeSuDinero);
            panel2.Controls.Add(pantallaSaldo);
            panel2.Controls.Add(pantallaRetiroNormalP2);
            panel2.Controls.Add(pantallaRetiroNormalP1);
            panel2.Controls.Add(pantallaRetiroSinTarjetaP2);
            panel2.Controls.Add(pantallaRetiroSinTarjetaP1);
            panel2.Controls.Add(pantallaMenuRetiro);
            panel2.Controls.Add(pantallaMenuTecnico);
            panel2.Controls.Add(pantallaMenuConsulta);
            panel2.Controls.Add(pantallaMenuAgente);
            panel2.Controls.Add(pantallaDespedida);
            panel2.Controls.Add(pantallaBienvenida);
            panel2.Controls.Add(pantallaIngresoTarjeta);
            panel2.Controls.Add(pantallaIngresoPin);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(126, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1302, 960);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pantallaTomeSuDinero
            // 
            pantallaTomeSuDinero.BackColor = Color.FromArgb(238, 39, 55);
            pantallaTomeSuDinero.Dock = DockStyle.Fill;
            pantallaTomeSuDinero.Location = new Point(0, 0);
            pantallaTomeSuDinero.Margin = new Padding(4, 3, 4, 3);
            pantallaTomeSuDinero.Name = "pantallaTomeSuDinero";
            pantallaTomeSuDinero.Size = new Size(1302, 960);
            pantallaTomeSuDinero.TabIndex = 8;
            // 
            // pantallaSaldo
            // 
            pantallaSaldo.Dock = DockStyle.Fill;
            pantallaSaldo.Location = new Point(0, 0);
            pantallaSaldo.Margin = new Padding(5);
            pantallaSaldo.Name = "pantallaSaldo";
            pantallaSaldo.Size = new Size(1302, 960);
            pantallaSaldo.TabIndex = 6;
            pantallaSaldo.Load += pantallaSaldo_Load;
            // 
            // pantallaRetiroNormalP2
            // 
            pantallaRetiroNormalP2.Dock = DockStyle.Fill;
            pantallaRetiroNormalP2.Location = new Point(0, 0);
            pantallaRetiroNormalP2.Margin = new Padding(5);
            pantallaRetiroNormalP2.Name = "pantallaRetiroNormalP2";
            pantallaRetiroNormalP2.Size = new Size(1302, 960);
            pantallaRetiroNormalP2.TabIndex = 5;
            pantallaRetiroNormalP2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaRetiroNormalP1
            // 
            pantallaRetiroNormalP1.BackColor = Color.FromArgb(238, 39, 55);
            pantallaRetiroNormalP1.Dock = DockStyle.Fill;
            pantallaRetiroNormalP1.Location = new Point(0, 0);
            pantallaRetiroNormalP1.Margin = new Padding(6);
            pantallaRetiroNormalP1.Name = "pantallaRetiroNormalP1";
            pantallaRetiroNormalP1.Size = new Size(1302, 960);
            pantallaRetiroNormalP1.TabIndex = 4;
            pantallaRetiroNormalP1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaRetiroSinTarjetaP2
            // 
            pantallaRetiroSinTarjetaP2.Dock = DockStyle.Fill;
            pantallaRetiroSinTarjetaP2.Location = new Point(0, 0);
            pantallaRetiroSinTarjetaP2.Margin = new Padding(5);
            pantallaRetiroSinTarjetaP2.Name = "pantallaRetiroSinTarjetaP2";
            pantallaRetiroSinTarjetaP2.Size = new Size(1302, 960);
            pantallaRetiroSinTarjetaP2.TabIndex = 5;
            pantallaRetiroSinTarjetaP2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaRetiroSinTarjetaP1
            // 
            pantallaRetiroSinTarjetaP1.Dock = DockStyle.Fill;
            pantallaRetiroSinTarjetaP1.Location = new Point(0, 0);
            pantallaRetiroSinTarjetaP1.Margin = new Padding(5);
            pantallaRetiroSinTarjetaP1.Name = "pantallaRetiroSinTarjetaP1";
            pantallaRetiroSinTarjetaP1.Size = new Size(1302, 960);
            pantallaRetiroSinTarjetaP1.TabIndex = 4;
            pantallaRetiroSinTarjetaP1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaMenuRetiro
            // 
            pantallaMenuRetiro.BackColor = Color.FromArgb(238, 39, 55);
            pantallaMenuRetiro.Dock = DockStyle.Fill;
            pantallaMenuRetiro.Location = new Point(0, 0);
            pantallaMenuRetiro.Margin = new Padding(5);
            pantallaMenuRetiro.Name = "pantallaMenuRetiro";
            pantallaMenuRetiro.Size = new Size(1302, 960);
            pantallaMenuRetiro.TabIndex = 3;
            pantallaMenuRetiro.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaMenuTecnico
            // 
            pantallaMenuTecnico.BackColor = Color.FromArgb(238, 39, 55);
            pantallaMenuTecnico.Dock = DockStyle.Fill;
            pantallaMenuTecnico.Location = new Point(0, 0);
            pantallaMenuTecnico.Margin = new Padding(5);
            pantallaMenuTecnico.Name = "pantallaMenuTecnico";
            pantallaMenuTecnico.Size = new Size(1302, 960);
            pantallaMenuTecnico.TabIndex = 2;
            pantallaMenuTecnico.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaMenuConsulta
            // 
            pantallaMenuConsulta.BackColor = Color.FromArgb(238, 39, 55);
            pantallaMenuConsulta.Dock = DockStyle.Fill;
            pantallaMenuConsulta.Location = new Point(0, 0);
            pantallaMenuConsulta.Margin = new Padding(5);
            pantallaMenuConsulta.Name = "pantallaMenuConsulta";
            pantallaMenuConsulta.Size = new Size(1302, 960);
            pantallaMenuConsulta.TabIndex = 3;
            pantallaMenuConsulta.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaMenuAgente
            // 
            pantallaMenuAgente.BackColor = Color.FromArgb(238, 39, 55);
            pantallaMenuAgente.Dock = DockStyle.Fill;
            pantallaMenuAgente.Location = new Point(0, 0);
            pantallaMenuAgente.Margin = new Padding(5);
            pantallaMenuAgente.Name = "pantallaMenuAgente";
            pantallaMenuAgente.Size = new Size(1302, 960);
            pantallaMenuAgente.TabIndex = 2;
            pantallaMenuAgente.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaDespedida
            // 
            pantallaDespedida.BackColor = Color.FromArgb(238, 39, 55);
            pantallaDespedida.Dock = DockStyle.Fill;
            pantallaDespedida.ForeColor = SystemColors.ControlText;
            pantallaDespedida.Location = new Point(0, 0);
            pantallaDespedida.Margin = new Padding(5);
            pantallaDespedida.MinimumSize = new Size(1280, 960);
            pantallaDespedida.Name = "pantallaDespedida";
            pantallaDespedida.Size = new Size(1302, 960);
            pantallaDespedida.TabIndex = 1;
            pantallaDespedida.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaBienvenida
            // 
            pantallaBienvenida.BackColor = Color.FromArgb(238, 39, 55);
            pantallaBienvenida.Dock = DockStyle.Fill;
            pantallaBienvenida.Location = new Point(0, 0);
            pantallaBienvenida.Margin = new Padding(5);
            pantallaBienvenida.Name = "pantallaBienvenida";
            pantallaBienvenida.Size = new Size(1302, 960);
            pantallaBienvenida.TabIndex = 0;
            pantallaBienvenida.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaIngresoTarjeta
            // 
            pantallaIngresoTarjeta.BackColor = SystemColors.Control;
            pantallaIngresoTarjeta.Dock = DockStyle.Fill;
            pantallaIngresoTarjeta.Location = new Point(0, 0);
            pantallaIngresoTarjeta.Margin = new Padding(5);
            pantallaIngresoTarjeta.Name = "pantallaIngresoTarjeta";
            pantallaIngresoTarjeta.Size = new Size(1302, 960);
            pantallaIngresoTarjeta.TabIndex = 0;
            pantallaIngresoTarjeta.usuario = null;
            pantallaIngresoTarjeta.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaIngresoPin
            // 
            pantallaIngresoPin.Dock = DockStyle.Fill;
            pantallaIngresoPin.Location = new Point(0, 0);
            pantallaIngresoPin.Margin = new Padding(5);
            pantallaIngresoPin.Name = "pantallaIngresoPin";
            pantallaIngresoPin.Size = new Size(1302, 960);
            pantallaIngresoPin.TabIndex = 1;
            pantallaIngresoPin.Usuario = null;
            pantallaIngresoPin.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaSaldo
            // 
            pantallaSaldo.Dock = DockStyle.Fill;
            pantallaSaldo.Location = new Point(0, 0);
            pantallaSaldo.Name = "pantallaSaldo";
            pantallaSaldo.Size = new Size(1041, 768);
            pantallaSaldo.TabIndex = 6;
            pantallaSaldo.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 960);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
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
        //Despedida & bienvenida
        private PantallaDespedida pantallaDespedida;
        private PantallaBienvenida pantallaBienvenida;
        //Menus
        private PantallaMenuTecnico pantallaMenuTecnico;
        private PantallaMenuAgente pantallaMenuAgente;
        private PantallaMenuConsulta pantallaMenuConsulta;
        private PantallaMenuRetiro pantallaMenuRetiro;
        //Retiro normal
        private PantallaIngresoTarjeta pantallaIngresoTarjeta;
        private PantallaIngresoPin pantallaIngresoPin;
        private PantallaRetiroNormalP1 pantallaRetiroNormalP1;
        private PantallaRetiroNormalP2 pantallaRetiroNormalP2;
        //Retiro sin Tarjeta
        private PantallaRetiroSinTarjetaP1 pantallaRetiroSinTarjetaP1;
        private PantallaRetiroSinTarjetaP2 pantallaRetiroSinTarjetaP2;

        private Button button7;
        private Button button8;
        private Button button9;
        private PantallaSaldo pantallaSaldo;
        private PantallaTomeSuDinero pantallaTomeSuDinero;
    }
}
