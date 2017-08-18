using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEtiquetas
    {

        private int _Id_Instrumento ;
        private string _Codigo ;
        private string _Descripcion;
        private int _Id_Identidad ;
        private int _Id_Calibracion ;
        private DateTime _Fec_Calibracion ;
        private DateTime _Fec_Proxima  ;
        private string _Id_Trab ;
        private string _Trabajador ;
        private int _Id = 0;

        public int Id_Instrumento { get => _Id_Instrumento; set => _Id_Instrumento = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Id_Identidad { get => _Id_Identidad; set => _Id_Identidad = value; }
        public int Id_Calibracion { get => _Id_Calibracion; set => _Id_Calibracion = value; }
        public DateTime Fec_Calibracion { get => _Fec_Calibracion; set => _Fec_Calibracion = value; }
        public DateTime Fec_Proxima { get => _Fec_Proxima; set => _Fec_Proxima = value; }
        public string Id_Trab { get => _Id_Trab; set => _Id_Trab = value; }
        public string Trabajador { get => _Trabajador; set => _Trabajador = value; }
        public int Id { get => _Id; set => _Id = value; }

        public DEtiquetas()
        {

        }

        public DEtiquetas(int id_Instrumento, string Codigo, string Descripcion, int id_Identidad, int id_Calibracion, DateTime Fec_Calibracion, DateTime Fec_Proxima, string id_Trab, string Trabajador, int id)
        {
            _Id_Instrumento = id_Instrumento;
            _Codigo = Codigo;
            _Descripcion = Descripcion;
            _Id_Identidad = id_Identidad;
            _Id_Calibracion = id_Calibracion;
            _Fec_Calibracion = Fec_Calibracion;
            _Fec_Proxima = Fec_Proxima;
            _Id_Trab = id_Trab;
            _Trabajador = Trabajador;
            _Id = id;

        }

        public string Insertar(DEtiquetas Etiqueta)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpEtiquetasInsertar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.AddWithValue("@id_Instrumento", Etiqueta.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@Codigo", Etiqueta.Codigo);
                SqlCmd.Parameters.AddWithValue("@Descripcion", Etiqueta.Descripcion);
                SqlCmd.Parameters.AddWithValue("@id_Identidad", Etiqueta.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@id_Calibracion", Etiqueta.Id_Calibracion);
                SqlCmd.Parameters.AddWithValue("@Fec_Calibracion", Etiqueta.Fec_Calibracion);
                SqlCmd.Parameters.AddWithValue("@Fec_Proxima", Etiqueta.Fec_Proxima);
                SqlCmd.Parameters.AddWithValue("@id_Trab", Etiqueta.Id_Trab);
                SqlCmd.Parameters.AddWithValue("@Trabajador", Etiqueta.Trabajador);
                SqlCmd.Parameters.AddWithValue("@id", Etiqueta.Id);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }

        public string Eliminar()
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpEtiquetasEliminar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }

        public DataTable Listar()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpEtiquetasListar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch
            {
                DtResultado = null;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }
            return DtResultado;

        }

    }
}
