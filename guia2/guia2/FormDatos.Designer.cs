namespace guia2
{
    partial class FormDatos
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(141, 202);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 47);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(390, 202);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 53);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 65);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 110);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 5;
            // 
            // datoscs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "datoscs";
            Text = "datoscs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        public Button btnCancelar;
        public Button btnAceptar;
        public TextBox textBox1;
        public TextBox textBox2;
    }
}