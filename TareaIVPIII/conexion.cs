using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaIVPIII
{
     class conexion
    {

        public SqlConnection cadena = new SqlConnection(@"server=SRSDELLI5; Database=DB_Avanzada; integrated security =True; TrustServerCertificate=True");

        public SqlConnection AbrirConexion()
        {
            if (cadena.State == ConnectionState.Closed)
                cadena.Open();
            return cadena;
        }

        public SqlConnection CerrarConexion()
        {
            if (cadena.State == ConnectionState.Open)
                cadena.Close();
            return cadena;
        }
    }
}
