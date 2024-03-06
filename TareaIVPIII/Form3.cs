using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TareaIVPIII
{
    public partial class Form3 : Form
    {

        //variables
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        public Form3()
        {
            InitializeComponent();

            conexion cn = new conexion();
            conn = cn.cadena;
        }

        //llenar dinámicamente combobox
        public void llenar()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT id_Cliente FROM CLIENTES", conn);
            da.Fill(ds, "CLIENTES");
            cbCliente.DataSource = ds.Tables[0].DefaultView;
            cbCliente.ValueMember = "id_Cliente";

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numero;
            if (!Int32.TryParse(this.cbCliente.Text, out numero))
            {

            }
            else
            {
                try
                {

                    conn.Open();
                    int num1 = int.Parse(cbCliente.Text);
                    string seleccion;
                    seleccion = "SELECT * FROM CLIENTES WHERE Id_Cliente = " +
                        num1;
                    da1 = new SqlDataAdapter(seleccion, conn);
                    SqlParameter prm = new SqlParameter("Id_Cliente", SqlDbType.Int);


                    prm.Value = num1;
                    da1.SelectCommand.Parameters.Add(prm);
                    dr1 = da1.SelectCommand.ExecuteReader();
                    while (dr1.Read())
                    {
                        lblNombreC.Visible = true;
                        lblNombreC.Text = dr1["NombreCliente"].ToString().Trim();

                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
                if (dr1 != null)
                {
                    dr1.Close();
                }
            }
        }

        private void btnIngresarP_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                string insertPedido;
                insertPedido = "INSERT INTO PEDIDOS(id_Cliente, CantidadPedido, FechaPedido)";
                insertPedido += "VALUES (@id_Cliente, @CantidadPedido, @FechaPedido)";

                insert1 = new SqlCommand(insertPedido, conn);
                insert1.Parameters.Add(new SqlParameter("@id_Cliente", SqlDbType.Int));
                insert1.Parameters["@id_Cliente"].Value = cbCliente.Text;
                insert1.Parameters.Add(new SqlParameter("@CantidadPedido", SqlDbType.Int));
                insert1.Parameters["@CantidadPedido"].Value = nUDcant.Value;
                insert1.Parameters.Add(new SqlParameter("@FechaPedido", SqlDbType.VarChar, 200));
                insert1.Parameters["@FechaPedido"].Value = dTime1.Text;
                insert1.ExecuteNonQuery();

                cbCliente.Text = "";
                nUDcant.Value = 0;
                dTime1.Text = "";

                MessageBox.Show("Registro agregado...",
                                "Pedido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("El Registro No fué agregado...",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            cbCliente.Text = "";
            nUDcant.Value = 0;
            dTime1.Text = "";
            lblNombreC.Text = "";
        }

        private void btnVolverP_Click(object sender, EventArgs e)
        {
            Form1 formu1 = new Form1();
            formu1.Show();
            this.Hide();
        }
    }
}
