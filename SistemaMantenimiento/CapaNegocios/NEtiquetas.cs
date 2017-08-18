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

        public static string Insertar(int id_Instrumento, string Codigo, string Descripcion, int id_Identidad, int id_Calibracion, DateTime Fec_Calibracion, DateTime Fec_Proxima, string id_Trab, string Trabajador, int id)
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

            return Obj.Insertar(Obj);
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
