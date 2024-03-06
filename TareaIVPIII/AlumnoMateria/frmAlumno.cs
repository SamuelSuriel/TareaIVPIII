using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaIVPIII.AlumnoMateria
{
    public partial class frmAlumno : Form
    {
        private conexion conexion = new conexion();

        private string? _codigoAlum = null;
        private bool EsEditar = false;
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnVolverAlum_Click(object sender, EventArgs e)
        {
            frmMantenimientoAM frmMantenimiento = new frmMantenimientoAM();
            frmMantenimiento.Show();
            this.Hide();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {

            LlenarDgvAlumnos("");
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtCodAlumno.Text = "";
            txtNombreAlum.Text = "";
            txtPrimerApell.Text = "";
            txtSegundoApell.Text = "";
            numEdad.Value = 0;
            txtDireccion.Text = "";
        }

        private void LlenarDgvAlumnos(string? criterio)
        {
            try
            {
                conexion conexion1 = new conexion();
                SqlCommand comando = new SqlCommand();
                DataTable tabla = new DataTable();

                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = "prc_MostrarAlumnos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@criterio", criterio);
                comando.ExecuteNonQuery();

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();

                conexion1.CerrarConexion();

                dgvAlumnos.DataSource = tabla;
            }
            catch
            {
                MessageBox.Show("Hubo un error cargando los alumnos...",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscarAlum_Click(object sender, EventArgs e)
        {
            string crt = txtBuscarAlum.Text;
            LlenarDgvAlumnos(crt);
        }

        private void btnGuardarAlum_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {
                string cod = txtCodAlumno.Text;
                string Nombre = txtNombreAlum.Text;
                string PrimerAp = txtPrimerApell.Text;
                string SegundoAp = txtSegundoApell.Text;
                int edad = (int)numEdad.Value;
                string Direccion = txtDireccion.Text;

                if (EsEditar == false)
                {
                    try
                    {
                        comando.Connection = conexion.AbrirConexion();
                        comando.CommandText = "prc_GuardarAlumno";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@cod", cod);
                        comando.Parameters.AddWithValue("@Nombre", Nombre);
                        comando.Parameters.AddWithValue("@PrimerAp", PrimerAp);
                        comando.Parameters.AddWithValue("@SegundoAp", SegundoAp);
                        comando.Parameters.AddWithValue("@edad", edad);
                        comando.Parameters.AddWithValue("@Direccion", Direccion);

                        comando.ExecuteNonQuery();
                        comando.Parameters.Clear();
                        conexion.CerrarConexion();

                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarControles();
                        LlenarDgvAlumnos("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo realizar la operación: " + ex);
                    }
                }

                if (EsEditar == true)
                {
                    try
                    {
                        string? codigo = _codigoAlum;

                        comando.Connection = conexion.AbrirConexion();
                        comando.CommandText = "prc_EditarAlumno";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@cod", codigo);
                        comando.Parameters.AddWithValue("@Nombre", Nombre);
                        comando.Parameters.AddWithValue("@PrimerAp", PrimerAp);
                        comando.Parameters.AddWithValue("@SegundoAp", SegundoAp);
                        comando.Parameters.AddWithValue("@edad", edad);
                        comando.Parameters.AddWithValue("@Direccion", Direccion);

                        comando.ExecuteNonQuery();
                        comando.Parameters.Clear();
                        conexion.CerrarConexion();

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarControles();
                        LlenarDgvAlumnos("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo realizar la operación: " + ex);
                    }
                }
            }
        }

        private void btnEditarAlum_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtCodAlumno.Text = dgvAlumnos.CurrentRow.Cells["Código"].Value.ToString();
                txtNombreAlum.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPrimerApell.Text = dgvAlumnos.CurrentRow.Cells["Primer Apellido"].Value.ToString();
                txtSegundoApell.Text = dgvAlumnos.CurrentRow.Cells["Segundo Apellido"].Value.ToString();
                numEdad.Value = (int)dgvAlumnos.CurrentRow.Cells["Edad"].Value;
                txtDireccion.Text = dgvAlumnos.CurrentRow.Cells["Dirección"].Value.ToString();

                _codigoAlum = dgvAlumnos.CurrentRow.Cells["Código"].Value.ToString();
            }
        }

        private void btnEliminarAlum_Click(object sender, EventArgs e)
        {

            if (dgvAlumnos.SelectedCells.Count > 0)
            {
                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    _codigoAlum = dgvAlumnos.CurrentRow.Cells["Código"].Value.ToString();

                    try
                    {
                        comando.Connection = conexion.AbrirConexion();
                        comando.CommandText = "prc_EliminarAlumno";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@codigoAlum", _codigoAlum);
                        comando.ExecuteNonQuery();

                        comando.Parameters.Clear();
                        conexion.CerrarConexion();

                        MessageBox.Show("Se eliminó correctamente!");
                        LlenarDgvAlumnos("");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un error eliminando el alumno...",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        private bool EsValido()
        {
            bool uno = txtCodAlumno.Text != "";
            bool dos = txtNombreAlum.Text != "";
            bool tres = txtPrimerApell.Text != "";
            bool cuatro = txtSegundoApell.Text != "";
            bool cinco = numEdad.Value > 0;
            bool seis = txtDireccion.Text != "";

            if (uno && dos && tres && cuatro && cinco && seis)
                return true;
            else
                return false;
        }
    }
}
