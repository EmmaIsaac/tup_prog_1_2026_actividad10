namespace Ejercicio1_VentanaSimple
{
    partial class FormPrincipal
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
            label1 = new Label();
            label2 = new Label();
            tbValor = new TextBox();
            btnRegistrar = new Button();
            lbResultado = new Label();
            btnCalcularPromedio = new Button();
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            tbResultado = new TextBox();
            btnListarOrdenado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 80);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 134);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Promedio:";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(211, 77);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(199, 23);
            tbValor.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(459, 76);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(210, 134);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 4;
            lbResultado.Text = "lbResultado";
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(459, 130);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(75, 42);
            btnCalcularPromedio.TabIndex = 5;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(117, 267);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(151, 23);
            tbBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(335, 267);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(115, 339);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(164, 23);
            tbResultado.TabIndex = 8;
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Location = new Point(335, 338);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(106, 23);
            btnListarOrdenado.TabIndex = 9;
            btnListarOrdenado.Text = "Listar Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListarOrdenado);
            Controls.Add(tbResultado);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(lbResultado);
            Controls.Add(btnRegistrar);
            Controls.Add(tbValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "Busqueda y Odenamiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbValor;
        private Button btnRegistrar;
        private Label lbResultado;
        private Button btnCalcularPromedio;
        private TextBox tbBuscar;
        private Button btnBuscar;
        private TextBox tbResultado;
        private Button btnListarOrdenado;
    }
}
