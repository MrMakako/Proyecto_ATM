namespace Proyecto_ATM
{
    partial class PantallaMenuRetiro
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
            R_SinTarjeta_B = new PictureBox();
            R_Normal_B = new PictureBox();
            roundButton1 = new RoundButton();
            roundButton2 = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)R_SinTarjeta_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)R_Normal_B).BeginInit();
            SuspendLayout();
            // 
            // R_SinTarjeta_B
            // 
            R_SinTarjeta_B.Anchor = AnchorStyles.None;
            R_SinTarjeta_B.Image = Properties.Resources.retiro_sin_tarjeta;
            R_SinTarjeta_B.Location = new Point(71, 153);
            R_SinTarjeta_B.Name = "R_SinTarjeta_B";
            R_SinTarjeta_B.Size = new Size(400, 400);
            R_SinTarjeta_B.SizeMode = PictureBoxSizeMode.StretchImage;
            R_SinTarjeta_B.TabIndex = 2;
            R_SinTarjeta_B.TabStop = false;
            R_SinTarjeta_B.Click += R_SinTarjeta_B_Click;
            // 
            // R_Normal_B
            // 
            R_Normal_B.Anchor = AnchorStyles.None;
            R_Normal_B.Image = Properties.Resources.retiro_Normal;
            R_Normal_B.Location = new Point(553, 153);
            R_Normal_B.Name = "R_Normal_B";
            R_Normal_B.Size = new Size(400, 400);
            R_Normal_B.SizeMode = PictureBoxSizeMode.StretchImage;
            R_Normal_B.TabIndex = 3;
            R_Normal_B.TabStop = false;
            R_Normal_B.Click += R_Normal_B_Click;
            // 
            // roundButton1
            // 
            roundButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roundButton1.BackColor = Color.FromArgb(204, 24, 38);
            roundButton1.BackgroundColor = Color.FromArgb(204, 24, 38);
            roundButton1.BorderColor = Color.FromArgb(204, 24, 38);
            roundButton1.BorderRadius = 10;
            roundButton1.BorderSize = 1;
            roundButton1.FlatAppearance.BorderSize = 0;
            roundButton1.FlatStyle = FlatStyle.Flat;
            roundButton1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundButton1.ForeColor = Color.White;
            roundButton1.Location = new Point(805, 664);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(223, 68);
            roundButton1.TabIndex = 5;
            roundButton1.Text = "Salir";
            roundButton1.TextColor = Color.White;
            roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            roundButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roundButton2.BackColor = Color.FromArgb(143, 14, 24);
            roundButton2.BackgroundColor = Color.FromArgb(143, 14, 24);
            roundButton2.BorderColor = Color.PaleVioletRed;
            roundButton2.BorderRadius = 10;
            roundButton2.BorderSize = 0;
            roundButton2.FlatAppearance.BorderSize = 0;
            roundButton2.FlatStyle = FlatStyle.Flat;
            roundButton2.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundButton2.ForeColor = Color.White;
            roundButton2.Location = new Point(805, 677);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(223, 68);
            roundButton2.TabIndex = 6;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // PantallaMenuRetiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 39, 55);
            Controls.Add(roundButton1);
            Controls.Add(roundButton2);
            Controls.Add(R_Normal_B);
            Controls.Add(R_SinTarjeta_B);
            Name = "PantallaMenuRetiro";
            Size = new Size(1024, 768);
            Load += PantallaMenuRetiro_Load;
            ((System.ComponentModel.ISupportInitialize)R_SinTarjeta_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)R_Normal_B).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox R_SinTarjeta_B;
        private PictureBox R_Normal_B;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
    }
}
