namespace TareaIVPIII
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
            label1 = new Label();
            label2 = new Label();
            btnGenerar = new Button();
            btnClientes = new Button();
            btnPedidos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 45);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 0;
            label1.Text = "BASE DE DATOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 106);
            label2.Name = "label2";
            label2.Size = new Size(272, 41);
            label2.TabIndex = 1;
            label2.Text = "GENERADA EN C#";
            // 
            // btnGenerar
            // 
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.Location = new Point(123, 220);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(134, 66);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.Location = new Point(50, 299);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(134, 66);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Cursor = Cursors.Hand;
            btnPedidos.Location = new Point(202, 299);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(134, 66);
            btnPedidos.TabIndex = 4;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 408);
            Controls.Add(btnPedidos);
            Controls.Add(btnClientes);
            Controls.Add(btnGenerar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnGenerar;
        private Button btnClientes;
        private Button btnPedidos;
    }
}