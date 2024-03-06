using System.Data.SqlClient;

namespace TareaIVPIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //La conexión a usar con autenticación de Windows 
            //Indicando la base de datos master
            SqlConnection cnn = new SqlConnection(@"server=SRSDELLI5; Database=master; integrated security =True; TrustServerCertificate=True");

            //La orden T-SQL para crear la base de datos es 
            string CrearDB = "CREATE DATABASE " + "DB_Avanzada";

            //--------- Creación de la tabla clientes 
            string tClientes = "USE DB_Avanzada;" +
                                "CREATE TABLE CLIENTES(" +
                                                        "id_Cliente int IDENTITY(1,1)," +
                                                        "NombreCliente varchar(40)" +
                                                        "CONSTRAINT PK_cliente PRIMARY KEY(id_Cliente));";

            //--------- Creación de la tabla Pedidos 
            string tPedidos = "USE DB_Avanzada;" +
                                "CREATE TABLE PEDIDOS (" +
                                                        "id_Pedido int IDENTITY(1,1)," +
                                                        "id_Cliente int not null, " +
                                                        "CantidadPedido int," +
                                                        "FechaPedido varchar(70)," +
                                                        "CONSTRAINT PK_pedido PRIMARY KEY(id_Pedido)," +
                                                        "CONSTRAINT FK_Cliente FOREIGN KEY(id_Cliente)" +
                                                        "REFERENCES CLIENTES (id_Cliente));";

            //--------- Creación de la tabla Libros 
            string tLibros = "USE DB_Avanzada;" +
                                "CREATE TABLE LIBROS (" +
                                                        "id_Libro int IDENTITY(1,1)," +
                                                        "NombreLibro varchar(70)," +
                                                        "CONSTRAINT PK_libro PRIMARY KEY(id_Libro));";

            SqlCommand cmd = new SqlCommand(CrearDB, cnn);
            SqlCommand cmd1 = new SqlCommand(tClientes, cnn);
            SqlCommand cmd2 = new SqlCommand(tPedidos, cnn);
            SqlCommand cmd3 = new SqlCommand(tLibros, cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Base de datos" +
                                "\nCreada correctamente...", "Generar",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                "Error al crear la Base de Datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form2 formu1 = new Form2();
            formu1.ShowDialog();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Form3 formu1 = new Form3();
            formu1.Show();
            this.Hide();
        }
    }
}