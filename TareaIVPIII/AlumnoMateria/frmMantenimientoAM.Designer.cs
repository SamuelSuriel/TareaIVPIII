namespace TareaIVPIII.AlumnoMateria
{
    partial class frmMantenimientoAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoAM));
            btnMaterias = new PictureBox();
            btnAlumnos = new PictureBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)btnMaterias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAlumnos).BeginInit();
            SuspendLayout();
            // 
            // btnMaterias
            // 
            btnMaterias.Cursor = Cursors.Hand;
            btnMaterias.Image = (Image)resources.GetObject("btnMaterias.Image");
            btnMaterias.Location = new Point(436, 88);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(288, 240);
            btnMaterias.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaterias.TabIndex = 0;
            btnMaterias.TabStop = false;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Cursor = Cursors.Hand;
            btnAlumnos.Image = (Image)resources.GetObject("btnAlumnos.Image");
            btnAlumnos.Location = new Point(68, 88);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(288, 240);
            btnAlumnos.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAlumnos.TabIndex = 1;
            btnAlumnos.TabStop = false;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // groupBox1
            // 
            groupBox1.ForeColor = Color.Gray;
            groupBox1.Location = new Point(45, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 346);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "SELECCIONE:";
            // 
            // frmMantenimientoAM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlumnos);
            Controls.Add(btnMaterias);
            Controls.Add(groupBox1);
            Name = "frmMantenimientoAM";
            Text = "Mantenimiento Al. Mat.";
            ((System.ComponentModel.ISupportInitialize)btnMaterias).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnMaterias;
        private PictureBox btnAlumnos;
        private GroupBox groupBox1;
    }
}