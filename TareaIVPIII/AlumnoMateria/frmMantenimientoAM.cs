using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaIVPIII.AlumnoMateria
{
    public partial class frmMantenimientoAM : Form
    {
        public frmMantenimientoAM()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumno frm = new frmAlumno();
            frm.Show();
            this.Hide();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            frmMateria frmMateria = new frmMateria();
            frmMateria.Show();
            this.Hide();

        }
    }
}
