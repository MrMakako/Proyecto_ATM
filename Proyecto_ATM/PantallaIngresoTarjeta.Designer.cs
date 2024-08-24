namespace Proyecto_ATM
{
    partial class PantallaIngresoTarjeta
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textobox_numero_tarjeta = new TextBox();
            panel2 = new Panel();
            boton_ingresar = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 24, 38);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 721);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 92);
            label1.Name = "label1";
            label1.Size = new Size(767, 103);
            label1.TabIndex = 1;
            label1.Text = " ¡Bienvenido al ATM!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 30, 30);
            label2.Location = new Point(345, 220);
            label2.Name = "label2";
            label2.Size = new Size(491, 49);
            label2.TabIndex = 2;
            label2.Text = "Ingrese su número de tarjeta";
            // 
            // textobox_numero_tarjeta
            // 
            textobox_numero_tarjeta.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textobox_numero_tarjeta.Location = new Point(286, 340);
            textobox_numero_tarjeta.Name = "textobox_numero_tarjeta";
            textobox_numero_tarjeta.Size = new Size(629, 56);
            textobox_numero_tarjeta.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 24, 38);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 636);
            panel2.Name = "panel2";
            panel2.Size = new Size(1024, 85);
            panel2.TabIndex = 0;
            // 
            // boton_ingresar
            // 
            boton_ingresar.BackColor = Color.Transparent;
            boton_ingresar.ForeColor = Color.Transparent;
            boton_ingresar.Image = Properties.Resources.ingresar_boton;
            boton_ingresar.Location = new Point(798, 554);
            boton_ingresar.Name = "boton_ingresar";
            boton_ingresar.Size = new Size(251, 76);
            boton_ingresar.TabIndex = 4;
            boton_ingresar.UseVisualStyleBackColor = false;
            boton_ingresar.Click += boton_ingresar_Click;

            // 
            // PantallaIngresoTarjeta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            Controls.Add(boton_ingresar);
            Controls.Add(panel2);
            Controls.Add(textobox_numero_tarjeta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);

            Name = "PantallaIngresoTarjeta";
            Size = new Size(1024, 721);
            Load += PantallaIngresoTarjeta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textobox_numero_tarjeta;
        private Panel panel2;
        private Button boton_ingresar;

    }
}
