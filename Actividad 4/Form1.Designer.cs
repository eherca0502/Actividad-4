namespace Actividad_4
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
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(99, 77);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(112, 34);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(248, 77);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(112, 34);
            btnRestar.TabIndex = 1;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(404, 77);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(112, 34);
            btnMultiplicar.TabIndex = 2;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(555, 77);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(112, 34);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(99, 223);
            txt1.Name = "txt1";
            txt1.Size = new Size(150, 31);
            txt1.TabIndex = 4;
            // 
            // txt2
            // 
            txt2.Location = new Point(305, 223);
            txt2.Name = "txt2";
            txt2.Size = new Size(150, 31);
            txt2.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(555, 223);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 195);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 7;
            label1.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 195);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 8;
            label2.Text = "Numero 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(555, 195);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 9;
            label3.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 395);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}