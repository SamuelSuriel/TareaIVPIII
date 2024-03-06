namespace TareaIVPIII.AlumnoMateria
{
    partial class frmMateria
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
            btnGuardarMat = new Button();
            txtMateriaBuscar = new TextBox();
            dgvMaterias = new DataGridView();
            btnVolverMat = new Button();
            btnEliminarMat = new Button();
            btnEditarMat = new Button();
            btnBuscarMat = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dNumUv = new NumericUpDown();
            label7 = new Label();
            txtCodMateria = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtPrerequisito = new TextBox();
            label2 = new Label();
            txtNombreMateria = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dNumUv).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarMat
            // 
            btnGuardarMat.ForeColor = Color.Green;
            btnGuardarMat.Location = new Point(20, 370);
            btnGuardarMat.Name = "btnGuardarMat";
            btnGuardarMat.Size = new Size(104, 51);
            btnGuardarMat.TabIndex = 18;
            btnGuardarMat.Text = "Guardar";
            btnGuardarMat.UseVisualStyleBackColor = true;
            btnGuardarMat.Click += btnGuardarMat_Click;
            // 
            // txtMateriaBuscar
            // 
            txtMateriaBuscar.Location = new Point(139, 93);
            txtMateriaBuscar.Name = "txtMateriaBuscar";
            txtMateriaBuscar.Size = new Size(346, 27);
            txtMateriaBuscar.TabIndex = 17;
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaterias.BackgroundColor = SystemColors.Control;
            dgvMaterias.BorderStyle = BorderStyle.None;
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new Point(12, 126);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowHeadersVisible = false;
            dgvMaterias.RowHeadersWidth = 51;
            dgvMaterias.RowTemplate.Height = 29;
            dgvMaterias.Size = new Size(634, 434);
            dgvMaterias.TabIndex = 16;
            // 
            // btnVolverMat
            // 
            btnVolverMat.Location = new Point(829, 578);
            btnVolverMat.Name = "btnVolverMat";
            btnVolverMat.Size = new Size(93, 37);
            btnVolverMat.TabIndex = 15;
            btnVolverMat.Text = "Volver";
            btnVolverMat.UseVisualStyleBackColor = true;
            btnVolverMat.Click += btnVolverMat_Click;
            // 
            // btnEliminarMat
            // 
            btnEliminarMat.ForeColor = Color.Red;
            btnEliminarMat.Location = new Point(97, 444);
            btnEliminarMat.Name = "btnEliminarMat";
            btnEliminarMat.Size = new Size(93, 36);
            btnEliminarMat.TabIndex = 14;
            btnEliminarMat.Text = "Eliminar";
            btnEliminarMat.UseVisualStyleBackColor = true;
            btnEliminarMat.Click += btnEliminarMat_Click;
            // 
            // btnEditarMat
            // 
            btnEditarMat.ForeColor = Color.Orange;
            btnEditarMat.Location = new Point(149, 370);
            btnEditarMat.Name = "btnEditarMat";
            btnEditarMat.Size = new Size(104, 51);
            btnEditarMat.TabIndex = 13;
            btnEditarMat.Text = "Editar";
            btnEditarMat.UseVisualStyleBackColor = true;
            btnEditarMat.Click += btnEditarMat_Click;
            // 
            // btnBuscarMat
            // 
            btnBuscarMat.ForeColor = SystemColors.ActiveCaption;
            btnBuscarMat.Location = new Point(491, 91);
            btnBuscarMat.Name = "btnBuscarMat";
            btnBuscarMat.Size = new Size(66, 29);
            btnBuscarMat.TabIndex = 12;
            btnBuscarMat.Text = "Buscar";
            btnBuscarMat.UseVisualStyleBackColor = true;
            btnBuscarMat.Click += btnBuscarMat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(157, 40);
            label1.TabIndex = 11;
            label1.Text = "MATERIAS";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RoyalBlue;
            groupBox1.Controls.Add(dNumUv);
            groupBox1.Controls.Add(btnGuardarMat);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCodMateria);
            groupBox1.Controls.Add(btnEliminarMat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnEditarMat);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrerequisito);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreMateria);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(652, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 518);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "CRUD";
            // 
            // dNumUv
            // 
            dNumUv.Location = new Point(37, 211);
            dNumUv.Name = "dNumUv";
            dNumUv.Size = new Size(87, 27);
            dNumUv.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.RoyalBlue;
            label7.ForeColor = Color.White;
            label7.Location = new Point(37, 61);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 32;
            label7.Text = "CÓDIGO MATERIA:";
            // 
            // txtCodMateria
            // 
            txtCodMateria.Cursor = Cursors.IBeam;
            txtCodMateria.Location = new Point(37, 92);
            txtCodMateria.Name = "txtCodMateria";
            txtCodMateria.Size = new Size(134, 27);
            txtCodMateria.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, 188);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 30;
            label5.Text = "UV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 252);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 27;
            label3.Text = "PREREQUISITOS:";
            // 
            // txtPrerequisito
            // 
            txtPrerequisito.Cursor = Cursors.IBeam;
            txtPrerequisito.Location = new Point(37, 283);
            txtPrerequisito.Name = "txtPrerequisito";
            txtPrerequisito.Size = new Size(197, 27);
            txtPrerequisito.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 122);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 25;
            label2.Text = "NOMBRE:";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Cursor = Cursors.IBeam;
            txtNombreMateria.Location = new Point(37, 153);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(197, 27);
            txtNombreMateria.TabIndex = 24;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(574, 89);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(72, 31);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 627);
            Controls.Add(btnLimpiar);
            Controls.Add(groupBox1);
            Controls.Add(txtMateriaBuscar);
            Controls.Add(dgvMaterias);
            Controls.Add(btnVolverMat);
            Controls.Add(btnBuscarMat);
            Controls.Add(label1);
            Name = "frmMateria";
            Text = "Materia";
            Load += frmMateria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dNumUv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarMat;
        private TextBox txtMateriaBuscar;
        private DataGridView dgvMaterias;
        private Button btnVolverMat;
        private Button btnEliminarMat;
        private Button btnEditarMat;
        private Button btnBuscarMat;
        private Label label1;
        private GroupBox groupBox1;
        private NumericUpDown dNumUv;
        private Label label7;
        private TextBox txtCodMateria;
        private Label label5;
        private Label label3;
        private TextBox txtPrerequisito;
        private Label label2;
        private TextBox txtNombreMateria;
        private Button btnLimpiar;
    }
}