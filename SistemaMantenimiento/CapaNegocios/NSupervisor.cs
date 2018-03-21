using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace CapaNegocios
{
    public static class NSupervisor
    {
        public static DataTable DtSupervisor = new DataTable();
        public static DSupervisor Supervisor = new DSupervisor();

        public static DataTable Buscar(string RutEmpleado)
        {
            return new DSupervisor().Buscar(RutEmpleado);
        }

        public static string Insertar(int index)
        {
            DSupervisor Obj = new DSupervisor();
            Obj.Area = DtSupervisor.Rows[index][0].ToString();
            Obj.Rut = DtSupervisor.Rows[index][1].ToString();
            Obj.Nombre = DtSupervisor.Rows[index][2].ToString();

            return Obj.Insertar(Obj);
        }

        public static string Insertar2(string Nombre,string Rut,string Area)
        {
            DSupervisor Obj = new DSupervisor();
            Obj.Area = Area;
            Obj.Rut = Rut;
            Obj.Nombre = Nombre;

            return Obj.Insertar(Obj);
        }

        public static string Eliminar()
        {
            DSupervisor Obj = new DSupervisor();
            return Obj.Eliminar();
        }
    }
}
