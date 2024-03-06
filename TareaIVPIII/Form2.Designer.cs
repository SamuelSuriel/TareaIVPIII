namespace TareaIVPIII
{
    partial class Form2
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
            btnVolverC = new Button();
            btnLimpiarC = new Button();
            btnIngresarC = new Button();
            label2 = new Label();
            label1 = new Label();
            txtCliente = new TextBox();
            SuspendLayout();
            // 
            // btnVolverC
            // 
            btnVolverC.Cursor = Cursors.Hand;
            btnVolverC.Location = new Point(411, 224);
            btnVolverC.Name = "btnVolverC";
            btnVolverC.Size = new Size(134, 66);
            btnVolverC.TabIndex = 8;
            btnVolverC.Text = "Volver";
            btnVolverC.UseVisualStyleBackColor = true;
            btnVolverC.Click += btnVolverC_Click;
            // 
            // btnLimpiarC
            // 
            btnLimpiarC.Cursor = Cursors.Hand;
            btnLimpiarC.Location = new Point(227, 224);
            btnLimpiarC.Name = "btnLimpiarC";
            btnLimpiarC.Size = new Size(134, 66);
            btnLimpiarC.TabIndex = 7;
            btnLimpiarC.Text = "Limpiar";
            btnLimpiarC.UseVisualStyleBackColor = true;
            btnLimpiarC.Click += btnLimpiarC_Click;
            // 
            // btnIngresarC
            // 
            btnIngresarC.Cursor = Cursors.Hand;
            btnIngresarC.Location = new Point(42, 224);
            btnIngresarC.Name = "btnIngresarC";
            btnIngresarC.Size = new Size(134, 66);
            btnIngresarC.TabIndex = 6;
            btnIngresarC.Text = "Ingresar";
            btnIngresarC.UseVisualStyleBackColor = true;
            btnIngresarC.Click += btnIngresarC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(244, 31);
            label2.Name = "label2";
            label2.Size = new Size(153, 41);
            label2.TabIndex = 5;
            label2.Text = "CLIENTES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 129);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(227, 122);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(225, 27);
            txtCliente.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 360);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Controls.Add(btnVolverC);
            Controls.Add(btnLimpiarC);
            Controls.Add(btnIngresarC);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolverC;
        private Button btnLimpiarC;
        private Button btnIngresarC;
        private Label label2;
        private Label label1;
        private TextBox txtCliente;
    }
}