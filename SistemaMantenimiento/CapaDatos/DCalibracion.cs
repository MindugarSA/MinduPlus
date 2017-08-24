using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCalibracion
    {

        int _Id;
        int _Id_Instrumento;
        int _Id_Identidad;
        int _Id_Calibracion;
        DateTime _Fec_Calibracion;
        string _Observacion;
        DateTime _Fec_Proxima;
        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public int Id_Instrumento
        {
            get
            {
                return _Id_Instrumento;
            }

            set
            {
                _Id_Instrumento = value;
            }
        }

        public int Id_Identidad
        {
            get
            {
                return _Id_Identidad;
            }

            set
            {
                _Id_Identidad = value;
            }
        }

        public int Id_Calibracion
        {
            get
            {
                return _Id_Calibracion;
            }

            set
            {
                _Id_Calibracion = value;
            }
        }

        public DateTime Fec_Calibracion
        {
            get
            {
                return _Fec_Calibracion;
            }

            set
            {
                _Fec_Calibracion = value;
            }
        }

        public string Observacion { get => _Observacion; set => _Observacion = value; }
        public DateTime Fec_Proxima { get => _Fec_Proxima; set => _Fec_Proxima = value; }

        public DCalibracion()
        {

        }

        public DCalibracion(int Id, int Id_Instrumento,int Id_Identidad, int Id_Calibracion , DateTime Fec_Calibracion, string Observacion, DateTime Fec_Proxima)
        {
            _Id = Id;
            _Id_Instrumento = Id_Instrumento;
            _Id_Identidad =  Id_Identidad;
            _Id_Calibracion = Id_Calibracion;
            _Fec_Calibracion = Fec_Calibracion;
            _Observacion = Observacion;
            _Fec_Proxima = Fec_Proxima;

        }

        public string Insertar(DCalibracion Calibracion, List<DCalibraItem> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionInsertar";
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer la trasacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                SqlCommand SqlCmd = new SqlCommand(sp, SqlCon)
                {
                    Transaction = SqlTra,
                    CommandType = CommandType.StoredProcedure
                };
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@ID_CALIBRACION", Calibracion.Id_Calibracion);
                SqlCmd.Parameters.AddWithValue("@FEC_CALIBRACION", Calibracion.Fec_Calibracion);
                SqlCmd.Parameters.AddWithValue("@Observacion", Calibracion.Observacion);
                SqlCmd.Parameters.AddWithValue("@Fec_Proxima", Calibracion.Fec_Proxima);


                SqlParameter retValue = new SqlParameter("@RETURN_VALUE", SqlDbType.Int)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                SqlCmd.Parameters.Add(retValue);

                //SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                //SqlDat.Fill(DtResultado);

                //using (SqlDataReader dr = cmd.ExecuteReader())
                //{
                //    Id = Convert.ToInt32(retValue.Value);
                //}

                rpta = SqlCmd.ExecuteNonQuery() >= 1 ? "OK" : "NO se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    int nId = Convert.ToInt32(retValue.Value);
                    foreach (DCalibraItem det in Detalle)
                    {
                        //Llamar al método insertar de la clase DCalibraItem
                        rpta = det.Insertar(nId, det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                            break;
                    }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        public string Actualizar(DCalibracion Calibracion, List<DCalibraItem> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionActualizar";

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer la trasacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                SqlCommand SqlCmd = new SqlCommand(sp, SqlCon)
                {
                    Transaction = SqlTra,
                    CommandType = CommandType.StoredProcedure
                };
                SqlCmd.Parameters.AddWithValue("@ID", Calibracion.Id);
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@ID_CALIBRACION", Calibracion.Id_Calibracion);
                SqlCmd.Parameters.AddWithValue("@FEC_CALIBRACION", Calibracion.Fec_Calibracion);
                SqlCmd.Parameters.AddWithValue("@Observacion", Calibracion.Observacion);
                SqlCmd.Parameters.AddWithValue("@Fec_Proxima", Calibracion.Fec_Proxima);

                rpta = SqlCmd.ExecuteNonQuery() >= 1 ? "OK" : "NO se Modifico el Registro";

                if (rpta.Equals("OK"))
                {
                    foreach (DCalibraItem det in Detalle)
                    {
                        //Llamar al método insertar de la clase DCalibraItem
                        rpta = det.Actualizar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                            break;
                    }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        public DataTable Listar(DCalibracion Calibracion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionListar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);

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

        public DataTable Buscar(DCalibracion Calibracion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionObtener";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@ID_CALIBRACION", Calibracion.Id_Calibracion);

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

        public DataTable BuscarDetalles(DCalibracion Calibracion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionObtenerDetalles";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_CALIBRACION", Calibracion.Id_Calibracion);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);

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

        public int ProximoCodigoCalibracion(DCalibracion Calibracion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionProximoCodigo";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);

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
            return Convert.ToInt32(DtResultado.Rows[0][0]);
        }

    }
}
