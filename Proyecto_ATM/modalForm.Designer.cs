namespace Proyecto_ATM
{
    partial class modalForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            ok_btn = new RoundButton();
            roundButton2 = new RoundButton();
            modalEffect_Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(204, 24, 38);
            label1.Location = new Point(26, 54);
            label1.Name = "label1";
            label1.Size = new Size(339, 27);
            label1.TabIndex = 0;
            label1.Text = "Este número de tarjeta no es valido";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // ok_btn
            // 
            ok_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ok_btn.BackColor = Color.FromArgb(204, 24, 38);
            ok_btn.BackgroundColor = Color.FromArgb(204, 24, 38);
            ok_btn.BorderColor = Color.FromArgb(204, 24, 38);
            ok_btn.BorderRadius = 10;
            ok_btn.BorderSize = 1;
            ok_btn.FlatAppearance.BorderSize = 0;
            ok_btn.FlatStyle = FlatStyle.Flat;
            ok_btn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ok_btn.ForeColor = Color.White;
            ok_btn.Location = new Point(110, 112);
            ok_btn.Margin = new Padding(3, 2, 3, 2);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new Size(195, 51);
            ok_btn.TabIndex = 9;
            ok_btn.Text = "Ok";
            ok_btn.TextColor = Color.White;
            ok_btn.UseVisualStyleBackColor = false;
            ok_btn.Click += ok_btn_Click;
            // 
            // roundButton2
            // 
            roundButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roundButton2.BackColor = Color.FromArgb(143, 14, 24);
            roundButton2.BackgroundColor = Color.FromArgb(143, 14, 24);
            roundButton2.BorderColor = Color.PaleVioletRed;
            roundButton2.BorderRadius = 10;
            roundButton2.BorderSize = 0;
            roundButton2.Enabled = false;
            roundButton2.FlatAppearance.BorderSize = 0;
            roundButton2.FlatStyle = FlatStyle.Flat;
            roundButton2.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundButton2.ForeColor = Color.White;
            roundButton2.Location = new Point(110, 122);
            roundButton2.Margin = new Padding(3, 2, 3, 2);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(195, 51);
            roundButton2.TabIndex = 10;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // modalEffect_Timer
            // 
            modalEffect_Timer.Enabled = true;
            modalEffect_Timer.Interval = 1;
            modalEffect_Timer.Tick += modalEffect_Timer_Tick;
            // 
            // modalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(404, 197);
            Controls.Add(ok_btn);
            Controls.Add(roundButton2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "modalForm";
            Text = "modalFormcs";
            Load += modalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RoundButton ok_btn;
        private RoundButton roundButton2;
        private System.Windows.Forms.Timer modalEffect_Timer;
    }
}