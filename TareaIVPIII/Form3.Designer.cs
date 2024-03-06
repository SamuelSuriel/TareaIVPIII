namespace TareaIVPIII
{
    partial class Form3
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
            label1 = new Label();
            btnVolverP = new Button();
            btnLimpiarP = new Button();
            btnIngresarP = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbCliente = new ComboBox();
            dTime1 = new DateTimePicker();
            label5 = new Label();
            lblNombreC = new Label();
            nUDcant = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nUDcant).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 180);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 15;
            label1.Text = "Cantidad de Libros";
            // 
            // btnVolverP
            // 
            btnVolverP.Cursor = Cursors.Hand;
            btnVolverP.Location = new Point(633, 339);
            btnVolverP.Name = "btnVolverP";
            btnVolverP.Size = new Size(134, 46);
            btnVolverP.TabIndex = 14;
            btnVolverP.Text = "Volver";
            btnVolverP.UseVisualStyleBackColor = true;
            btnVolverP.Click += btnVolverP_Click;
            // 
            // btnLimpiarP
            // 
            btnLimpiarP.Cursor = Cursors.Hand;
            btnLimpiarP.Location = new Point(206, 339);
            btnLimpiarP.Name = "btnLimpiarP";
            btnLimpiarP.Size = new Size(134, 46);
            btnLimpiarP.TabIndex = 13;
            btnLimpiarP.Text = "Limpiar";
            btnLimpiarP.UseVisualStyleBackColor = true;
            btnLimpiarP.Click += btnLimpiarP_Click;
            // 
            // btnIngresarP
            // 
            btnIngresarP.Cursor = Cursors.Hand;
            btnIngresarP.Location = new Point(39, 339);
            btnIngresarP.Name = "btnIngresarP";
            btnIngresarP.Size = new Size(134, 46);
            btnIngresarP.TabIndex = 12;
            btnIngresarP.Text = "Ingresar";
            btnIngresarP.UseVisualStyleBackColor = true;
            btnIngresarP.Click += btnIngresarP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 41);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 11;
            label2.Text = "PEDIDOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 123);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 17;
            label3.Text = "Id. Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 247);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 18;
            label4.Text = "Fecha:";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(193, 123);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(274, 28);
            cbCliente.TabIndex = 19;
            cbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
            // 
            // dTime1
            // 
            dTime1.Location = new Point(193, 240);
            dTime1.Name = "dTime1";
            dTime1.Size = new Size(274, 27);
            dTime1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 123);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 21;
            label5.Text = "Nombre:";
            // 
            // lblNombreC
            // 
            lblNombreC.AutoSize = true;
            lblNombreC.Location = new Point(524, 180);
            lblNombreC.Name = "lblNombreC";
            lblNombreC.Size = new Size(0, 20);
            lblNombreC.TabIndex = 22;
            // 
            // nUDcant
            // 
            nUDcant.Location = new Point(193, 173);
            nUDcant.Name = "nUDcant";
            nUDcant.Size = new Size(67, 27);
            nUDcant.TabIndex = 23;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 413);
            Controls.Add(nUDcant);
            Controls.Add(lblNombreC);
            Controls.Add(label5);
            Controls.Add(dTime1);
            Controls.Add(cbCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnVolverP);
            Controls.Add(btnLimpiarP);
            Controls.Add(btnIngresarP);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)nUDcant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnVolverP;
        private Button btnLimpiarP;
        private Button btnIngresarP;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbCliente;
        private DateTimePicker dTime1;
        private Label label5;
        private Label lblNombreC;
        private NumericUpDown nUDcant;
    }
}