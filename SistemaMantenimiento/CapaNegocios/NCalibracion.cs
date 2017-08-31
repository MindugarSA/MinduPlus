using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NCalibracion
    {
        public static string Insertar(int Id_Instrumento, int Id_Identidad, int Id_Calibracion, DateTime Fec_Calibracion, string Observacion , DataTable dtDetalles, DateTime Fec_Proxima)
        {
            DCalibracion Obj = new DCalibracion()
            {
                Id_Instrumento = Id_Instrumento,
                Id_Identidad = Id_Identidad,
                Id_Calibracion = Id_Calibracion,
                Fec_Calibracion = Fec_Calibracion,
                Observacion = Observacion,
                Fec_Proxima = Fec_Proxima,

            };
            List<DCalibraItem> detalles = (List<DCalibraItem>)dtDetalles.ToList<DCalibraItem>();
            //List<DCalibraItem> detalles = new List<DCalibraItem>();
            //foreach (DataRow row in dtDetalles.Rows)
            //{
            //    DCalibraItem detalle = new DCalibraItem();
            //    detalle.Iddetalle_ingreso = Convert.ToInt32(row["iddetalle_ingreso"].ToString());
            //    detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
            //    detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
            //    detalle.Descuento = Convert.ToDecimal(row["descuento"].ToString());
            //    detalles.Add(detalle);
            //}

            return Obj.Insertar(Obj, detalles);
        }

        //Método Actualizar que llama al método Actualizar de la clase DIdentInstrumento
        //de la CapaDatos
        public static string Actualizar(int id, int Id_Instrumento, int Id_Identidad, int Id_Calibracion, DateTime Fec_Calibracion, string Observacion, DataTable dtDetalles, DateTime Fec_Proxima)
        {
            DCalibracion Obj = new DCalibracion()
            {
                Id = id,
                Id_Instrumento = Id_Instrumento,
                Id_Identidad = Id_Identidad,
                Id_Calibracion = Id_Calibracion,
                Fec_Calibracion = Fec_Calibracion,
                Observacion = Observacion,
                Fec_Proxima = Fec_Proxima,

            };
            List<DCalibraItem> detalles = (List<DCalibraItem>)dtDetalles.ToList<DCalibraItem>();

            return Obj.Actualizar(Obj, detalles);
        }


        //Método Listar que llama al método Listar de la clase DIdentInstrumento
        //de la CapaDatos
        public static DataTable Listar(int Id_Instrumento, int Id_Identidad)
        {

            DCalibracion Obj = new DCalibracion()
            {
                Id_Instrumento = Id_Instrumento,
                Id_Identidad = Id_Identidad
            };
            return new DCalibracion().Listar(Obj);
        }

        //Método Listar que llama al método Buscar de la clase DIdentInstrumento
        //de la CapaDatos
        public static DataTable Buscar(int Id_Instrumento, int Id_Identidad, int Id_Calibracion)
        {
            DCalibracion Obj = new DCalibracion()
            {
                Id_Instrumento = Id_Instrumento,
                Id_Identidad = Id_Identidad,
                Id_Calibracion = Id_Calibracion
            };
            return new DCalibracion().Buscar(Obj);
        }

        public static DataTable BuscarDetalles(int Id_Calibracion, int Id_Identidad, int Id_Instrumento)
        {
            DCalibracion Obj = new DCalibracion()
            {
                Id_Instrumento = Id_Instrumento,
                Id_Identidad = Id_Identidad,
                Id_Calibracion = Id_Calibracion
            };
            return new DCalibracion().BuscarDetalles(Obj);
        }

        public static int ProximoCodigoIndividual(int Id_Instrumento, int Id_Identidad)
        {
            DCalibracion Obj = new DCalibracion()
            {
                Id_Instrumento = Id_Instrumento,
                Id_Identidad = Id_Identidad
            };
            return new DCalibracion().ProximoCodigoCalibracion(Obj);
        }

    }
}
