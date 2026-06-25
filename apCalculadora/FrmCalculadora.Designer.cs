namespace apCalculadora
{
    partial class FrmCalculadora
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
            txtVisor = new TextBox();
            txtResultado = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button18 = new Button();
            button13 = new Button();
            button20 = new Button();
            btnLimpar = new Button();
            btnIgual = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            lbSequencias = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.Font = new Font("Trebuchet MS", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVisor.Location = new Point(16, 17);
            txtVisor.Margin = new Padding(7, 8, 7, 8);
            txtVisor.Name = "txtVisor";
            txtVisor.ReadOnly = true;
            txtVisor.Size = new Size(930, 42);
            txtVisor.TabIndex = 0;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Trebuchet MS", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(16, 92);
            txtResultado.Margin = new Padding(7, 8, 7, 8);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(930, 42);
            txtResultado.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button18, 0, 4);
            tableLayoutPanel1.Controls.Add(button13, 0, 3);
            tableLayoutPanel1.Controls.Add(button20, 3, 4);
            tableLayoutPanel1.Controls.Add(btnLimpar, 2, 4);
            tableLayoutPanel1.Controls.Add(btnIgual, 1, 4);
            tableLayoutPanel1.Controls.Add(button16, 3, 3);
            tableLayoutPanel1.Controls.Add(button15, 2, 3);
            tableLayoutPanel1.Controls.Add(button14, 1, 3);
            tableLayoutPanel1.Controls.Add(button12, 3, 2);
            tableLayoutPanel1.Controls.Add(button11, 2, 2);
            tableLayoutPanel1.Controls.Add(button10, 1, 2);
            tableLayoutPanel1.Controls.Add(button9, 0, 2);
            tableLayoutPanel1.Controls.Add(button8, 3, 1);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.ForeColor = SystemColors.ControlText;
            tableLayoutPanel1.Location = new Point(16, 228);
            tableLayoutPanel1.Margin = new Padding(7, 8, 7, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(930, 619);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.ButtonHighlight;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Trebuchet MS", 20F);
            button18.Location = new Point(7, 500);
            button18.Margin = new Padding(7, 8, 7, 8);
            button18.Name = "button18";
            button18.Size = new Size(216, 107);
            button18.TabIndex = 21;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = false;
            button18.Click += btnCalculadora_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ButtonHighlight;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Trebuchet MS", 20F);
            button13.Location = new Point(7, 377);
            button13.Margin = new Padding(7, 8, 7, 8);
            button13.Name = "button13";
            button13.Size = new Size(216, 107);
            button13.TabIndex = 20;
            button13.Text = "1";
            button13.UseVisualStyleBackColor = false;
            button13.Click += btnCalculadora_Click;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.ButtonHighlight;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Trebuchet MS", 20F);
            button20.Location = new Point(703, 500);
            button20.Margin = new Padding(7, 8, 7, 8);
            button20.Name = "button20";
            button20.Size = new Size(216, 107);
            button20.TabIndex = 19;
            button20.Text = "(";
            button20.UseVisualStyleBackColor = false;
            button20.Click += btnCalculadora_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ButtonHighlight;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Trebuchet MS", 20F);
            btnLimpar.Location = new Point(471, 500);
            btnLimpar.Margin = new Padding(7, 8, 7, 8);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(216, 107);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.ButtonHighlight;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Trebuchet MS", 20F);
            btnIgual.Location = new Point(239, 500);
            btnIgual.Margin = new Padding(7, 8, 7, 8);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(216, 107);
            btnIgual.TabIndex = 17;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.ButtonHighlight;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Trebuchet MS", 20F);
            button16.Location = new Point(703, 377);
            button16.Margin = new Padding(7, 8, 7, 8);
            button16.Name = "button16";
            button16.Size = new Size(216, 107);
            button16.TabIndex = 15;
            button16.Text = ")";
            button16.UseVisualStyleBackColor = false;
            button16.Click += btnCalculadora_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ButtonHighlight;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Trebuchet MS", 20F);
            button15.Location = new Point(471, 377);
            button15.Margin = new Padding(7, 8, 7, 8);
            button15.Name = "button15";
            button15.Size = new Size(216, 107);
            button15.TabIndex = 14;
            button15.Text = "3";
            button15.UseVisualStyleBackColor = false;
            button15.Click += btnCalculadora_Click;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ButtonHighlight;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Trebuchet MS", 20F);
            button14.Location = new Point(239, 377);
            button14.Margin = new Padding(7, 8, 7, 8);
            button14.Name = "button14";
            button14.Size = new Size(216, 107);
            button14.TabIndex = 13;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = false;
            button14.Click += btnCalculadora_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ButtonHighlight;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Trebuchet MS", 20F);
            button12.Location = new Point(703, 254);
            button12.Margin = new Padding(7, 8, 7, 8);
            button12.Name = "button12";
            button12.Size = new Size(216, 107);
            button12.TabIndex = 11;
            button12.Text = ".";
            button12.UseVisualStyleBackColor = false;
            button12.Click += btnCalculadora_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ButtonHighlight;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Trebuchet MS", 20F);
            button11.Location = new Point(471, 254);
            button11.Margin = new Padding(7, 8, 7, 8);
            button11.Name = "button11";
            button11.Size = new Size(216, 107);
            button11.TabIndex = 10;
            button11.Text = "6";
            button11.UseVisualStyleBackColor = false;
            button11.Click += btnCalculadora_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ButtonHighlight;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Trebuchet MS", 20F);
            button10.Location = new Point(239, 254);
            button10.Margin = new Padding(7, 8, 7, 8);
            button10.Name = "button10";
            button10.Size = new Size(216, 107);
            button10.TabIndex = 9;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnCalculadora_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonHighlight;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Trebuchet MS", 20F);
            button9.Location = new Point(7, 254);
            button9.Margin = new Padding(7, 8, 7, 8);
            button9.Name = "button9";
            button9.Size = new Size(216, 107);
            button9.TabIndex = 8;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnCalculadora_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Trebuchet MS", 20F);
            button8.Location = new Point(703, 131);
            button8.Margin = new Padding(7, 8, 7, 8);
            button8.Name = "button8";
            button8.Size = new Size(216, 107);
            button8.TabIndex = 7;
            button8.Text = "+";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnCalculadora_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Trebuchet MS", 20F);
            button7.Location = new Point(471, 131);
            button7.Margin = new Padding(7, 8, 7, 8);
            button7.Name = "button7";
            button7.Size = new Size(216, 107);
            button7.TabIndex = 6;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnCalculadora_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Trebuchet MS", 20F);
            button6.Location = new Point(239, 131);
            button6.Margin = new Padding(7, 8, 7, 8);
            button6.Name = "button6";
            button6.Size = new Size(216, 107);
            button6.TabIndex = 5;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnCalculadora_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Trebuchet MS", 20F);
            button5.Location = new Point(7, 131);
            button5.Margin = new Padding(7, 8, 7, 8);
            button5.Name = "button5";
            button5.Size = new Size(216, 107);
            button5.TabIndex = 4;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnCalculadora_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Trebuchet MS", 20F);
            button4.Location = new Point(703, 8);
            button4.Margin = new Padding(7, 8, 7, 8);
            button4.Name = "button4";
            button4.Size = new Size(216, 107);
            button4.TabIndex = 3;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnCalculadora_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Trebuchet MS", 20F);
            button3.Location = new Point(471, 8);
            button3.Margin = new Padding(7, 8, 7, 8);
            button3.Name = "button3";
            button3.Size = new Size(216, 107);
            button3.TabIndex = 2;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnCalculadora_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 20F);
            button2.Location = new Point(239, 8);
            button2.Margin = new Padding(7, 8, 7, 8);
            button2.Name = "button2";
            button2.Size = new Size(216, 107);
            button2.TabIndex = 1;
            button2.Text = "/";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnCalculadora_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 20F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(7, 8);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(216, 107);
            button1.TabIndex = 0;
            button1.Text = "^";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCalculadora_Click;
            // 
            // lbSequencias
            // 
            lbSequencias.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSequencias.Location = new Point(16, 159);
            lbSequencias.Margin = new Padding(7, 0, 7, 0);
            lbSequencias.Name = "lbSequencias";
            lbSequencias.Size = new Size(930, 61);
            lbSequencias.TabIndex = 3;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(967, 878);
            Controls.Add(lbSequencias);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtResultado);
            Controls.Add(txtVisor);
            Font = new Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 8, 7, 8);
            Name = "FrmCalculadora";
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisor;
        private TextBox txtResultado;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button20;
        private Button btnLimpar;
        private Button btnIgual;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label lbSequencias;
        private Button button18;
        private Button button13;
    }
}
