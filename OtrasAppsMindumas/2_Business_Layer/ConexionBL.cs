using OtrasAppsMindumas._1_Data_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtrasAppsMindumas
{
    public class ConexionBL
    {
        public SqlConnection sqlConexion { get ; set; } = new SqlConnection();
        public SqlCommand cmd { get; set; }

        public ConexionBL()
        {
            sqlConexion.ConnectionString = Conexion.Cn;
        }
    }
}
