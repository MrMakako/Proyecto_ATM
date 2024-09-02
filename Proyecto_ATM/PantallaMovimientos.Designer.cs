namespace Proyecto_ATM
{
    partial class PantallaMovimientosTecnico
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
            panel2 = new Panel();
            tablaMovimientos = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            regresar_btn = new RoundButton();
            roundButton2 = new RoundButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 39, 55);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(83, 761);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 24, 38);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(83, 636);
            panel2.Name = "panel2";
            panel2.Size = new Size(1226, 125);
            panel2.TabIndex = 1;
            // 
            // tablaMovimientos
            // 
            tablaMovimientos.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            tablaMovimientos.ColumnCount = 5;
            tablaMovimientos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9697437F));
            tablaMovimientos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9697437F));
            tablaMovimientos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9697437F));
            tablaMovimientos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.44932F));
            tablaMovimientos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6414528F));
            tablaMovimientos.ForeColor = Color.Black;
            tablaMovimientos.Location = new Point(299, 131);
            tablaMovimientos.Name = "tablaMovimientos";
            tablaMovimientos.RowCount = 1;
            tablaMovimientos.RowStyles.Add(new RowStyle());
            tablaMovimientos.Size = new Size(792, 45);
            tablaMovimientos.TabIndex = 2;
            tablaMovimientos.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(238, 39, 55);
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.61111F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5404034F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(label4, 3, 0);
            tableLayoutPanel2.Controls.Add(label5, 4, 0);
            tableLayoutPanel2.ForeColor = Color.White;
            tableLayoutPanel2.Location = new Point(299, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(792, 58);
            tableLayoutPanel2.TabIndex = 3;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label1.Location = new Point(37, 11);
            label1.Name = "label1";
            label1.Size = new Size(83, 35);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label2.Location = new Point(200, 11);
            label2.Name = "label2";
            label2.Size = new Size(71, 35);
            label2.TabIndex = 1;
            label2.Text = "Hora";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label3.Location = new Point(344, 11);
            label3.Name = "label3";
            label3.Size = new Size(97, 35);
            label3.TabIndex = 2;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(475, 11);
            label4.Name = "label4";
            label4.Size = new Size(178, 35);
            label4.TabIndex = 3;
            label4.Text = "Tipo de Retiro";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label5.Location = new Point(677, 11);
            label5.Name = "label5";
            label5.Size = new Size(94, 35);
            label5.TabIndex = 4;
            label5.Text = "Monto";
            // 
            // regresar_btn
            // 
            regresar_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            regresar_btn.BackColor = Color.FromArgb(204, 24, 38);
            regresar_btn.BackgroundColor = Color.FromArgb(204, 24, 38);
            regresar_btn.BorderColor = Color.FromArgb(204, 24, 38);
            regresar_btn.BorderRadius = 10;
            regresar_btn.BorderSize = 1;
            regresar_btn.FlatAppearance.BorderSize = 0;
            regresar_btn.FlatStyle = FlatStyle.Flat;
            regresar_btn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regresar_btn.ForeColor = Color.White;
            regresar_btn.Location = new Point(83, 516);
            regresar_btn.Name = "regresar_btn";
            regresar_btn.Size = new Size(223, 68);
            regresar_btn.TabIndex = 11;
            regresar_btn.Text = "Regresar";
            regresar_btn.TextColor = Color.White;
            regresar_btn.UseVisualStyleBackColor = false;
            regresar_btn.Click += regresar_btn_Click;
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
            roundButton2.Location = new Point(83, 532);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(223, 68);
            roundButton2.TabIndex = 12;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(582, 225);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(8, 8);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(0, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(0, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // PantallaMovimientosTecnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(regresar_btn);
            Controls.Add(roundButton2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tablaMovimientos);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PantallaMovimientosTecnico";
            Size = new Size(1309, 761);
            Load += PantallaMovimientosTecnico_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tablaMovimientos;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RoundButton regresar_btn;
        private RoundButton roundButton2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
