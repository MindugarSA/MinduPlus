using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DIdentBaja
    {
        private int _Id = 0;
        private int _Id_instrumento = 0;
        private int _Id_indivual = 0;
        private string _Cod_Trab  ;
        private string _Nom_Trab  ;
        private string _Fec_Baja  ;
        private string _Fec_Registro  ;
        private string _Observacion  ;
        private string _Cod_Localiza  ;
        private string _Nom_Localiza;
        private string _Ult_Estado;

        public string Nom_Localiza
        {
            get { return _Nom_Localiza; }
            set { _Nom_Localiza = value; }
        }

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

        public int Id_instrumento
        {
            get
            {
                return _Id_instrumento;
            }
            set
            {
                _Id_instrumento = value;
            }
        }

        public int Id_indivual
        {
            get
            {
                return _Id_indivual;
            }
            set
            {
                _Id_indivual = value;
            }
        }

        public String Cod_Trab
        {
            get
            {
                return _Cod_Trab;
            }
            set
            {
                _Cod_Trab = value;
            }
        }

        public String Nom_Trab
        {
            get
            {
                return _Nom_Trab;
            }
            set
            {
                _Nom_Trab = value;
            }
        }

        public String Fec_Baja
        {
            get
            {
                return _Fec_Baja;
            }
            set
            {
                _Fec_Baja = value;
            }
        }

        public String Fec_Registro
        {
            get
            {
                return _Fec_Registro;
            }
            set
            {
                _Fec_Registro = value;
            }
        }

        public String Observacion
        {
            get
            {
                return _Observacion;
            }
            set
            {
                _Observacion = value;
            }
        }

        public String Cod_Localiza
        {
            get
            {
                return _Cod_Localiza;
            }
            set
            {
                _Cod_Localiza = value;
            }
        }

        public string Ult_Estado { get => _Ult_Estado; set => _Ult_Estado = value; }

        public DIdentBaja()
        {
        }

        public DIdentBaja (  int id, int id_instrumento, int id_indivual, string Cod_Trab, string Nom_Trab, string Fec_Baja, string Fec_Registro, string Observacion, string Cod_Localiza, string Nom_Localiza, string Ult_Estado)
        {
		    _Id = Id;
            _Id_instrumento = Id_instrumento;
            _Id_indivual = Id_indivual;
            _Cod_Trab = Cod_Trab;
            _Nom_Trab = Nom_Trab;
            _Fec_Baja = Fec_Baja;
            _Fec_Registro = Fec_Registro;
            _Observacion = Observacion;
            _Cod_Localiza = Cod_Localiza;
            _Nom_Localiza = Nom_Localiza;
            _Ult_Estado = Ult_Estado;
        }

        public string Insertar(DIdentBaja Ident_Baja)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpIdent_BajaInsertar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.Add(new SqlParameter("@id_instrumento", Ident_Baja.Id_instrumento));
                SqlCmd.Parameters.Add(new SqlParameter("@id_indivual", Ident_Baja.Id_indivual));
                SqlCmd.Parameters.Add(new SqlParameter("@Cod_Trab", Ident_Baja.Cod_Trab));
                SqlCmd.Parameters.Add(new SqlParameter("@Nom_Trab", Ident_Baja.Nom_Trab));
                SqlCmd.Parameters.Add(new SqlParameter("@Fec_Baja", Ident_Baja.Fec_Baja));
                SqlCmd.Parameters.Add(new SqlParameter("@Fec_Registro", Ident_Baja.Fec_Registro));
                SqlCmd.Parameters.Add(new SqlParameter("@Observacion", Ident_Baja.Observacion));
                SqlCmd.Parameters.Add(new SqlParameter("@Cod_Localiza", Ident_Baja.Cod_Localiza));
                SqlCmd.Parameters.Add(new SqlParameter("@Nom_Localiza", Ident_Baja.Nom_Localiza));
                SqlCmd.Parameters.Add(new SqlParameter("@Ult_Estado", Ident_Baja.Ult_Estado));
                

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }

            return rpta;
        }

        public string Actualizar(DIdentBaja Ident_Baja)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpIdent_BajaActualizar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.Add(new SqlParameter("@ID", Ident_Baja.Id));
                SqlCmd.Parameters.Add(new SqlParameter("@id_instrumento", Ident_Baja.Id_instrumento));
                SqlCmd.Parameters.Add(new SqlParameter("@id_indivual", Ident_Baja.Id_indivual));
                SqlCmd.Parameters.Add(new SqlParameter("@Cod_Trab", Ident_Baja.Cod_Trab));
                SqlCmd.Parameters.Add(new SqlParameter("@Nom_Trab", Ident_Baja.Nom_Trab));
                SqlCmd.Parameters.Add(new SqlParameter("@Fec_Baja", Ident_Baja.Fec_Baja));
                SqlCmd.Parameters.Add(new SqlParameter("@Fec_Registro", Ident_Baja.Fec_Registro));
                SqlCmd.Parameters.Add(new SqlParameter("@Observacion", Ident_Baja.Observacion));
                SqlCmd.Parameters.Add(new SqlParameter("@Cod_Localiza", Ident_Baja.Cod_Localiza));
                SqlCmd.Parameters.Add(new SqlParameter("@Nom_Localiza", Ident_Baja.Nom_Localiza));
                SqlCmd.Parameters.Add(new SqlParameter("@Ult_Estado", Ident_Baja.Ult_Estado));

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Modifico el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }

            return rpta;
        }

        public DataTable Obtener(DIdentBaja Ident_Baja)
        {

            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpIdent_BajaObtener";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.SelectCommand.Parameters.Add(new SqlParameter("@id_instrumento", Ident_Baja.Id_instrumento));
                SqlDat.SelectCommand.Parameters.Add(new SqlParameter("@id_indivual", Ident_Baja.Id_indivual));

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
