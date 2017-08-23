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

        public static DataTable Buscar(string RutEmpleado)
        {
            return new DSupervisor().Buscar(RutEmpleado);
        }
    }
}
