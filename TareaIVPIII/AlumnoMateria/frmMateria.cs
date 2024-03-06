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
    public partial class frmMateria : Form
    {
        private conexion conexion = new conexion();

        private string? _codigoMat = null;
        private bool EsEditar = false;
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public frmMateria()
        {
            InitializeComponent();

        }

        private void frmMateria_Load(object sender, EventArgs e)
        {
            LlenarDgvMateria("");
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtCodMateria.Text = "";
            txtNombreMateria.Text = "";
            txtMateriaBuscar.Text = "";
            txtPrerequisito.Text = "";
            dNumUv.Value = 0;
        }

        private void LlenarDgvMateria(string? criterio)
        {
            try
            {
                conexion conexion1 = new conexion();
                SqlCommand comando = new SqlCommand();
                DataTable tabla = new DataTable();

                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = "prc_MostrarMaterias";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@criterio", criterio);
                comando.ExecuteNonQuery();

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();

                conexion1.CerrarConexion();

                dgvMaterias.DataSource = tabla;
            }
            catch
            {
                MessageBox.Show("Hubo un error cargando las materias...",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnVolverMat_Click(object sender, EventArgs e)
        {
            frmMantenimientoAM frmMantenimiento = new frmMantenimientoAM();
            frmMantenimiento.Show();
            this.Hide();

        }

        private void btnBuscarMat_Click(object sender, EventArgs e)
        {
            string crt = txtMateriaBuscar.Text;
            LlenarDgvMateria(crt);
        }

        private void btnGuardarMat_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {
                string cod = txtCodMateria.Text;
                string Nombre = txtNombreMateria.Text;
                int uv = (int)dNumUv.Value;
                string prereq = txtPrerequisito.Text;

                if (EsEditar == false)
                {
                    try
                    {
                        comando.Connection = conexion.AbrirConexion();
                        comando.CommandText = "prc_GuardarMateria";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@cod", cod);
                        comando.Parameters.AddWithValue("@Nombre", Nombre);
                        comando.Parameters.AddWithValue("@UV", uv);
                        comando.Parameters.AddWithValue("@prerequisitos", prereq);

                        comando.ExecuteNonQuery();
                        comando.Parameters.Clear();
                        conexion.CerrarConexion();

                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarControles();
                        LlenarDgvMateria("");
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
                        string? codigo = _codigoMat;

                        comando.Connection = conexion.AbrirConexion();
                        comando.CommandText = "prc_EditarMateria";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@cod", codigo);
                        comando.Parameters.AddWithValue("@Nombre", Nombre);
                        comando.Parameters.AddWithValue("@UV", uv);
                        comando.Parameters.AddWithValue("@prerequisitos", prereq);

                        comando.ExecuteNonQuery();
                        comando.Parameters.Clear();
                        conexion.CerrarConexion();

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarControles();
                        LlenarDgvMateria("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo realizar la operación: " + ex);
                    }
                }
            }
        }

        private void btnEditarMat_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtCodMateria.Text = dgvMaterias.CurrentRow.Cells["Código"].Value.ToString();
                txtNombreMateria.Text = dgvMaterias.CurrentRow.Cells["Nombre"].Value.ToString();
                dNumUv.Value = (int)dgvMaterias.CurrentRow.Cells["UV"].Value;
                txtPrerequisito.Text = dgvMaterias.CurrentRow.Cells["PreRequisitos"].Value.ToString();

                _codigoMat = dgvMaterias.CurrentRow.Cells["Código"].Value.ToString();
            }
        }

        private void btnEliminarMat_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedCells.Count > 0)
            {
                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    _codigoMat = dgvMaterias.CurrentRow.Cells["Código"].Value.ToString();

                    try
                    {
                        comando.Connection = conexion.AbrirConexion();
                        comando.CommandText = "prc_EliminarMateria";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@codigoMat", _codigoMat);
                        comando.ExecuteNonQuery();

                        comando.Parameters.Clear();
                        conexion.CerrarConexion();

                        MessageBox.Show("Se eliminó correctamente!");
                        LlenarDgvMateria("");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un error eliminando la materia...",
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
            bool uno = txtCodMateria.Text != "";
            bool dos = txtNombreMateria.Text != "";
            bool tres = dNumUv.Value > 0;
            bool cuatro = txtPrerequisito.Text != "";

            if (uno && dos && tres && cuatro)
                return true;
            else
                return false;
        }
    }
}
