namespace TareaIVPIII.AlumnoMateria
{
    partial class frmAlumno
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
            btnBuscarAlum = new Button();
            btnEditarAlum = new Button();
            btnEliminarAlum = new Button();
            btnVolverAlum = new Button();
            dgvAlumnos = new DataGridView();
            txtBuscarAlum = new TextBox();
            btnGuardarAlum = new Button();
            txtNombreAlum = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrimerApell = new TextBox();
            label4 = new Label();
            txtSegundoApell = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtCodAlumno = new TextBox();
            numEdad = new NumericUpDown();
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(161, 40);
            label1.TabIndex = 0;
            label1.Text = "ALUMNOS";
            // 
            // btnBuscarAlum
            // 
            btnBuscarAlum.Cursor = Cursors.Hand;
            btnBuscarAlum.ForeColor = SystemColors.ActiveCaption;
            btnBuscarAlum.Location = new Point(501, 102);
            btnBuscarAlum.Name = "btnBuscarAlum";
            btnBuscarAlum.Size = new Size(66, 29);
            btnBuscarAlum.TabIndex = 4;
            btnBuscarAlum.Text = "Buscar";
            btnBuscarAlum.UseVisualStyleBackColor = true;
            btnBuscarAlum.Click += btnBuscarAlum_Click;
            // 
            // btnEditarAlum
            // 
            btnEditarAlum.Cursor = Cursors.Hand;
            btnEditarAlum.ForeColor = Color.Orange;
            btnEditarAlum.Location = new Point(811, 508);
            btnEditarAlum.Name = "btnEditarAlum";
            btnEditarAlum.Size = new Size(95, 41);
            btnEditarAlum.TabIndex = 5;
            btnEditarAlum.Text = "Editar";
            btnEditarAlum.UseVisualStyleBackColor = true;
            btnEditarAlum.Click += btnEditarAlum_Click;
            // 
            // btnEliminarAlum
            // 
            btnEliminarAlum.Cursor = Cursors.Hand;
            btnEliminarAlum.ForeColor = Color.Red;
            btnEliminarAlum.Location = new Point(763, 564);
            btnEliminarAlum.Name = "btnEliminarAlum";
            btnEliminarAlum.Size = new Size(95, 34);
            btnEliminarAlum.TabIndex = 6;
            btnEliminarAlum.Text = "Eliminar";
            btnEliminarAlum.UseVisualStyleBackColor = true;
            btnEliminarAlum.Click += btnEliminarAlum_Click;
            // 
            // btnVolverAlum
            // 
            btnVolverAlum.Cursor = Cursors.Hand;
            btnVolverAlum.Location = new Point(838, 616);
            btnVolverAlum.Name = "btnVolverAlum";
            btnVolverAlum.Size = new Size(95, 31);
            btnVolverAlum.TabIndex = 7;
            btnVolverAlum.Text = "Volver";
            btnVolverAlum.UseVisualStyleBackColor = true;
            btnVolverAlum.Click += btnVolverAlum_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.BackgroundColor = SystemColors.Control;
            dgvAlumnos.BorderStyle = BorderStyle.None;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(12, 135);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersVisible = false;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 29;
            dgvAlumnos.Size = new Size(671, 475);
            dgvAlumnos.TabIndex = 8;
            // 
            // txtBuscarAlum
            // 
            txtBuscarAlum.Cursor = Cursors.IBeam;
            txtBuscarAlum.Location = new Point(187, 102);
            txtBuscarAlum.Name = "txtBuscarAlum";
            txtBuscarAlum.Size = new Size(308, 27);
            txtBuscarAlum.TabIndex = 9;
            // 
            // btnGuardarAlum
            // 
            btnGuardarAlum.Cursor = Cursors.Hand;
            btnGuardarAlum.ForeColor = Color.Green;
            btnGuardarAlum.Location = new Point(709, 508);
            btnGuardarAlum.Name = "btnGuardarAlum";
            btnGuardarAlum.Size = new Size(95, 41);
            btnGuardarAlum.TabIndex = 10;
            btnGuardarAlum.Text = "Guardar";
            btnGuardarAlum.UseVisualStyleBackColor = true;
            btnGuardarAlum.Click += btnGuardarAlum_Click;
            // 
            // txtNombreAlum
            // 
            txtNombreAlum.Cursor = Cursors.IBeam;
            txtNombreAlum.Location = new Point(709, 192);
            txtNombreAlum.Name = "txtNombreAlum";
            txtNombreAlum.Size = new Size(197, 27);
            txtNombreAlum.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.ForeColor = Color.White;
            label2.Location = new Point(709, 161);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 12;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(709, 229);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 14;
            label3.Text = "PRIMER APELLIDO:";
            // 
            // txtPrimerApell
            // 
            txtPrimerApell.Cursor = Cursors.IBeam;
            txtPrimerApell.Location = new Point(709, 260);
            txtPrimerApell.Name = "txtPrimerApell";
            txtPrimerApell.Size = new Size(197, 27);
            txtPrimerApell.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.ForeColor = Color.White;
            label4.Location = new Point(709, 290);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 16;
            label4.Text = "SEGUNDO APELLIDO:";
            // 
            // txtSegundoApell
            // 
            txtSegundoApell.Cursor = Cursors.IBeam;
            txtSegundoApell.Location = new Point(709, 321);
            txtSegundoApell.Name = "txtSegundoApell";
            txtSegundoApell.Size = new Size(197, 27);
            txtSegundoApell.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.ForeColor = Color.White;
            label5.Location = new Point(709, 352);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 18;
            label5.Text = "EDAD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.RoyalBlue;
            label6.ForeColor = Color.White;
            label6.Location = new Point(709, 413);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 20;
            label6.Text = "DIRECCIÓN:";
            // 
            // txtDireccion
            // 
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Location = new Point(709, 444);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(197, 58);
            txtDireccion.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.RoyalBlue;
            label7.ForeColor = Color.White;
            label7.Location = new Point(709, 100);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 22;
            label7.Text = "CÓDIGO ALUMNO:";
            // 
            // txtCodAlumno
            // 
            txtCodAlumno.Cursor = Cursors.IBeam;
            txtCodAlumno.Location = new Point(20, 53);
            txtCodAlumno.Name = "txtCodAlumno";
            txtCodAlumno.Size = new Size(133, 27);
            txtCodAlumno.TabIndex = 21;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(710, 375);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(87, 27);
            numEdad.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RoyalBlue;
            groupBox1.Controls.Add(txtCodAlumno);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(689, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 532);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "CRUD";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(611, 100);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(72, 31);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 651);
            Controls.Add(btnLimpiar);
            Controls.Add(numEdad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSegundoApell);
            Controls.Add(label3);
            Controls.Add(txtPrimerApell);
            Controls.Add(label2);
            Controls.Add(txtNombreAlum);
            Controls.Add(btnGuardarAlum);
            Controls.Add(txtBuscarAlum);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnVolverAlum);
            Controls.Add(btnEliminarAlum);
            Controls.Add(btnEditarAlum);
            Controls.Add(btnBuscarAlum);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmAlumno";
            Text = "Alumno";
            Load += frmAlumno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBuscarAlum;
        private Button btnEditarAlum;
        private Button btnEliminarAlum;
        private Button btnVolverAlum;
        private DataGridView dgvAlumnos;
        private TextBox txtBuscarAlum;
        private Button btnGuardarAlum;
        private TextBox txtNombreAlum;
        private Label label2;
        private Label label3;
        private TextBox txtPrimerApell;
        private Label label4;
        private TextBox txtSegundoApell;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtCodAlumno;
        private NumericUpDown numEdad;
        private GroupBox groupBox1;
        private Button btnLimpiar;
    }
}