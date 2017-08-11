using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCalibraItem
    {

        private int _Id  ;
        private int _Id_Instrumento  ;
        private int _Id_Identidad  ;
        private int _Id_Calibracion  ;
        private int _Id_Item  ;
        private string _Metodo ;
        private string _Unidad ;
        private decimal _Rango  ;
        private decimal _Resolucion  ;
        private decimal _Criterio ;
        private decimal _MediObtenida ;
        private decimal _DiferObtenida ;
        private string _Estado;
        private string _Seleccionado ;


        public int Id { get => _Id; set => _Id = value; }
        public int Id_Instrumento { get => _Id_Instrumento; set => _Id_Instrumento = value; }
        public int Id_Identidad { get => _Id_Identidad; set => _Id_Identidad = value; }
        public int Id_Calibracion { get => _Id_Calibracion; set => _Id_Calibracion = value; }
        public int Id_Item { get => _Id_Item; set => _Id_Item = value; }
        public string Metodo { get => _Metodo; set => _Metodo = value; }
        public string Unidad { get => _Unidad; set => _Unidad = value; }
        public decimal Rango { get => _Rango; set => _Rango = value; }
        public decimal Resolucion { get => _Resolucion; set => _Resolucion = value; }
        public decimal Criterio { get => _Criterio; set => _Criterio = value; }
        public decimal MediObtenida { get => _MediObtenida; set => _MediObtenida = value; }
        public decimal DiferObtenida { get => _DiferObtenida; set => _DiferObtenida = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Seleccionado { get => _Seleccionado; set => _Seleccionado = value; }

        public DCalibraItem()
        {
        }

        public DCalibraItem(int Id, int Id_Instrumento, int Id_Identidad, int Id_Calibracion, int Id_Item, string Metodo, string Unidad, decimal Rango, decimal Resolucion, decimal Criterio, decimal MediObtenida, decimal DiferObtenida, string Estado, string Seleccionado)
        {
            _Id = Id;
            _Id_Instrumento = Id_Instrumento;
            _Id_Identidad = Id_Identidad;
            _Id_Calibracion = Id_Calibracion;
            _Id_Item = Id_Item;
            _Metodo = Metodo;
            _Unidad = Unidad;
            _Rango = Rango;
            _Resolucion = Resolucion;
            _Criterio = Criterio;
            _MediObtenida = MediObtenida;
            _DiferObtenida = DiferObtenida;
            _Estado = Estado;
            _Seleccionado = Seleccionado;
        }

        public string Insertar(int Id, DCalibraItem CalibraItem,
           ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand()
                {
                    Connection = SqlCon,
                    Transaction = SqlTra,
                    CommandText = "SpCalibra_ItemInsertar",
                    CommandType = CommandType.StoredProcedure
                };
                SqlCmd.Parameters.AddWithValue("@id",Id);
                SqlCmd.Parameters.AddWithValue("@id_Instrumento", CalibraItem.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@id_Identidad", CalibraItem.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@id_Calibracion", CalibraItem.Id_Calibracion);
                SqlCmd.Parameters.AddWithValue("@id_Item", CalibraItem.Id_Item);
                SqlCmd.Parameters.AddWithValue("@Metodo", CalibraItem.Metodo);
                SqlCmd.Parameters.AddWithValue("@Unidad", CalibraItem.Unidad);
                SqlCmd.Parameters.AddWithValue("@Rango", CalibraItem.Rango);
                SqlCmd.Parameters.AddWithValue("@Resolucion" , CalibraItem.Resolucion);
                SqlCmd.Parameters.AddWithValue("@Criterio", CalibraItem.Criterio);
                SqlCmd.Parameters.AddWithValue("@MediObtenida", CalibraItem.MediObtenida);
                SqlCmd.Parameters.AddWithValue("@DiferObtenida", CalibraItem.DiferObtenida);
                SqlCmd.Parameters.AddWithValue("@Estado", CalibraItem.Estado);
                SqlCmd.Parameters.AddWithValue("@Seleccionado", CalibraItem.Seleccionado);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }

        public string Actualizar(DCalibraItem CalibraItem,
          ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand()
                {
                    Connection = SqlCon,
                    Transaction = SqlTra,
                    CommandText = "SpCalibra_ItemActualizar",
                    CommandType = CommandType.StoredProcedure
                };
                SqlCmd.Parameters.AddWithValue("@id_Instrumento", CalibraItem.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@id_Identidad", CalibraItem.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@id_Calibracion", CalibraItem.Id_Calibracion);
                SqlCmd.Parameters.AddWithValue("@id_Item", CalibraItem.Id_Item);
                SqlCmd.Parameters.AddWithValue("@Metodo", CalibraItem.Metodo);
                SqlCmd.Parameters.AddWithValue("@Unidad", CalibraItem.Unidad);
                SqlCmd.Parameters.AddWithValue("@Rango", CalibraItem.Rango);
                SqlCmd.Parameters.AddWithValue("@Resolucion", CalibraItem.Resolucion);
                SqlCmd.Parameters.AddWithValue("@Criterio", CalibraItem.Criterio);
                SqlCmd.Parameters.AddWithValue("@MediObtenida", CalibraItem.MediObtenida);
                SqlCmd.Parameters.AddWithValue("@DiferObtenida", CalibraItem.DiferObtenida);
                SqlCmd.Parameters.AddWithValue("@Estado", CalibraItem.Estado);
                SqlCmd.Parameters.AddWithValue("@Seleccionado", CalibraItem.Seleccionado);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }
    }
}
