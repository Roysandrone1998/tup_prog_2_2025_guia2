namespace guia2
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
            btnListar = new Button();
            btnVer = new Button();
            btnAgregar = new Button();
            btnNodificar = new Button();
            btnEliminar = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(576, 28);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(155, 50);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(576, 107);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(155, 50);
            btnVer.TabIndex = 1;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(576, 189);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 50);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNodificar
            // 
            btnNodificar.Location = new Point(576, 255);
            btnNodificar.Name = "btnNodificar";
            btnNodificar.Size = new Size(155, 50);
            btnNodificar.TabIndex = 3;
            btnNodificar.Text = "modificar";
            btnNodificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(576, 327);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 50);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Elliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(73, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(382, 244);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnNodificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnVer);
            Controls.Add(btnListar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        public Button btnListar;
        public Button btnVer;
        public Button btnAgregar;
        public Button btnNodificar;
        public Button btnEliminar;
        public ListBox listBox1;
    }
}
