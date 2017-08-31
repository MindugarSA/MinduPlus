using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NInstrumento
    {
        //Método Insertar que llama al método Insertar de la clase DIntrumento
        //de la CapaDatos
        public static string Insertar(string codigo, string descripcion, string frecuenciaNvo, string frecuenciaUsa, string estado)
        {
            DInstrumento Obj = new DInstrumento()
            {
                Codigo = codigo,
                Descripcion = descripcion,
                Frecuencia_Nvo = frecuenciaNvo,
                Frecuencia_Usa = frecuenciaUsa,
                Estado = estado,
                Fecha_Creacion = new DateTime(1900, 01, 01), // > new DateTime(1900,01,01) ? Instrumento.Fecha_Creacion  : new DateTime(1900, 01, 01)
                Usu_Creacion = "",
                Fecha_Modifi = new DateTime(1900, 01, 01),
                Usu_Modif = ""
            };
            return Obj.Insertar(Obj);
        }

        //Método Actualizar que llama al método Actualizar de la clase DIntrumento
        //de la CapaDatos
        public static string Actualizar(int idinstrumento, string codigo, string descripcion, string frecuenciaNvo, string frecuenciaUsa, string estado)
        {
            DInstrumento Obj = new DInstrumento()
            {
                Id = idinstrumento,
                Codigo = codigo,
                Descripcion = descripcion,
                Frecuencia_Nvo = frecuenciaNvo,
                Frecuencia_Usa = frecuenciaUsa,
                Estado = estado,
                Fecha_Creacion = new DateTime(1900, 01, 01), // > new DateTime(1900,01,01) ? Instrumento.Fecha_Creacion  : new DateTime(1900, 01, 01)
                Usu_Creacion = "",
                Fecha_Modifi = new DateTime(1900, 01, 01),
                Usu_Modif = ""
            };
            return Obj.Actualizar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DIntrumento
        //de la CapaDatos
        public static string Eliminar(int idinstrumento, string codigo)
        {
            DInstrumento Obj = new DInstrumento()
            {
                Id = idinstrumento,
                Codigo = codigo
            };
            return Obj.Eliminar(Obj);
        }

        //Método Listar que llama al método Listar de la clase DIntrumento
        //de la CapaDatos
        public static DataTable Listar()
        {
            return new DInstrumento().Listar();
        }

        public static DataTable ListarPorEmpleado(string Empleado)
        {
            return new DInstrumento().ListarPorEmpleado(Empleado);
        }

        public static DataTable Buscar(int idinstrumento)
        {
            DInstrumento Obj = new DInstrumento()
            {
                Id = idinstrumento
            };
            return new DInstrumento().Buscar(Obj);
        }
    }
}
