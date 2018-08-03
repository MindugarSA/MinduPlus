using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtrasAppsMindumas._1_Data_Layer
{
    class Conexion
    {
        public static string Cn = Properties.Settings.Default.SAC_MINDUGAR_conection;

        public static DataTable SelectDataTable(string stringSelect)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Cn))
            {
                SqlCommand cmd = new SqlCommand(stringSelect, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static bool ExecuteSql(string sql)
        {
            using (SqlConnection con = new SqlConnection(Cn))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch 
                {
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
