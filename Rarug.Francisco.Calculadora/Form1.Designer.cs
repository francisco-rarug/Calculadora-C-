namespace Rarug.Francisco.Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbDisplay = new TextBox();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicacion = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPunto = new Button();
            btn0 = new Button();
            btnIgual = new Button();
            btnDivision = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbDisplay.Location = new Point(12, 29);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(327, 53);
            tbDisplay.TabIndex = 0;
            // 
            // btnSuma
            // 
            btnSuma.FlatStyle = FlatStyle.System;
            btnSuma.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuma.Location = new Point(257, 280);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(82, 44);
            btnSuma.TabIndex = 1;
            btnSuma.Tag = "1";
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnOperacion_Click;
            // 
            // btnResta
            // 
            btnResta.FlatStyle = FlatStyle.System;
            btnResta.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResta.Location = new Point(257, 219);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(82, 44);
            btnResta.TabIndex = 2;
            btnResta.Tag = "2";
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnOperacion_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.FlatStyle = FlatStyle.System;
            btnMultiplicacion.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicacion.Location = new Point(257, 159);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(82, 44);
            btnMultiplicacion.TabIndex = 3;
            btnMultiplicacion.Tag = "3";
            btnMultiplicacion.Text = "x";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnOperacion_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(12, 159);
            btn7.Name = "btn7";
            btn7.Size = new Size(57, 44);
            btn7.TabIndex = 4;
            btn7.Tag = "7";
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumero_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(93, 158);
            btn8.Name = "btn8";
            btn8.Size = new Size(56, 45);
            btn8.TabIndex = 5;
            btn8.Tag = "8";
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumero_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(174, 158);
            btn9.Name = "btn9";
            btn9.Size = new Size(57, 45);
            btn9.TabIndex = 6;
            btn9.Tag = "9";
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumero_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(12, 219);
            btn4.Name = "btn4";
            btn4.Size = new Size(57, 44);
            btn4.TabIndex = 7;
            btn4.Tag = "4";
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumero_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(92, 217);
            btn5.Name = "btn5";
            btn5.Size = new Size(57, 46);
            btn5.TabIndex = 8;
            btn5.Tag = "5";
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumero_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(174, 218);
            btn6.Name = "btn6";
            btn6.Size = new Size(57, 44);
            btn6.TabIndex = 9;
            btn6.Tag = "6";
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumero_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(12, 280);
            btn1.Name = "btn1";
            btn1.Size = new Size(57, 44);
            btn1.TabIndex = 10;
            btn1.Tag = "1";
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumero_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(92, 280);
            btn2.Name = "btn2";
            btn2.Size = new Size(57, 44);
            btn2.TabIndex = 11;
            btn2.Tag = "2";
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumero_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(174, 280);
            btn3.Name = "btn3";
            btn3.Size = new Size(57, 44);
            btn3.TabIndex = 12;
            btn3.Tag = "3";
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumero_Click;
            // 
            // btnPunto
            // 
            btnPunto.Location = new Point(174, 341);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(57, 44);
            btnPunto.TabIndex = 13;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(93, 341);
            btn0.Name = "btn0";
            btn0.Size = new Size(56, 44);
            btn0.TabIndex = 14;
            btn0.Tag = "0";
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumero_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.ActiveCaption;
            btnIgual.FlatStyle = FlatStyle.Popup;
            btnIgual.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.Location = new Point(257, 341);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(82, 44);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.TextAlign = ContentAlignment.TopCenter;
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivision
            // 
            btnDivision.FlatStyle = FlatStyle.System;
            btnDivision.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivision.Location = new Point(257, 101);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(82, 42);
            btnDivision.TabIndex = 16;
            btnDivision.Tag = "4";
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnOperacion_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(174, 101);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(57, 44);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.TextAlign = ContentAlignment.TopCenter;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 410);
            Controls.Add(btnClear);
            Controls.Add(btnDivision);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btnPunto);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(tbDisplay);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplay;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicacion;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPunto;
        private Button btn0;
        private Button btnIgual;
        private Button btnDivision;
        private Button btnClear;
    }
}