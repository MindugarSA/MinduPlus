using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDatos;

namespace CapaNegocios
{
    public class NEtiquetas
    {
        public static DataTable DtEtiquetas = new DataTable();
        public static BindingSource BsEtiquetas = new BindingSource();

        public static string Insertar(int id_Instrumento, string Codigo, string Descripcion, int id_Identidad, int id_Calibracion, DateTime Fec_Calibracion, DateTime Fec_Proxima, string id_Trab, string Trabajador, int id, double Resolucion)
        {
            DEtiquetas Obj = new DEtiquetas();
            Obj.Id_Instrumento = id_Instrumento;
            Obj.Codigo = Codigo;
            Obj.Descripcion = Descripcion;
            Obj.Id_Identidad = id_Identidad;
            Obj.Id_Calibracion = id_Calibracion;
            Obj.Fec_Calibracion = Fec_Calibracion;
            Obj.Fec_Proxima = Fec_Proxima;
            Obj.Id_Trab = id_Trab;
            Obj.Trabajador = Trabajador;
            Obj.Id = id;
            Obj.Resolucion = Resolucion;

            return Obj.Insertar(Obj);
        }

        public static void InsertarDTtoDB()
        {
            NEtiquetas.Eliminar();
            if(DtEtiquetas.Rows.Count>0)
                foreach (DataRow row in NEtiquetas.DtEtiquetas.Rows)
                {
                    if(row.RowState != DataRowState.Deleted)
                    {
                        NEtiquetas.Insertar(Convert.ToInt32(row[0])
                                       , Convert.ToString(row[1])
                                       , Convert.ToString(row[2])
                                       , Convert.ToInt32(row[3])
                                       , Convert.ToInt32(row[4])
                                       , Convert.ToDateTime(row[5])
                                       , Convert.ToDateTime(row[6])
                                       , Convert.ToString(row[7])
                                       , Convert.ToString(row[8])
                                       , Convert.ToInt32(row[9])
                                       , Convert.ToDouble(row[10]));
                    }
                }
        }

        public static string Eliminar()
        {
            DEtiquetas Obj = new DEtiquetas();
            return Obj.Eliminar();
        }

        public static DataTable Listar()
        {
            return new DEtiquetas().Listar();
        }
    }
}
