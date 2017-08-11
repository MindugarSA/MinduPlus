using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NIdentBaja
    {

        public static string Insertar(int id_instrumento, int id_indivual, string Cod_Trab, string Nom_Trab, string Fec_Baja, string Observacion, string Cod_Localiza)
        {
            DIdentBaja Obj = new DIdentBaja();
            Obj.Id_instrumento = id_instrumento;
            Obj.Id_indivual = id_indivual;
            Obj.Cod_Trab = Cod_Trab;
            Obj.Nom_Trab = Nom_Trab;
            Obj.Fec_Baja = Fec_Baja;
            Obj.Fec_Registro = DateTime.Now.ToString();
            Obj.Observacion = Observacion;
            Obj.Cod_Localiza = Cod_Localiza;
            return Obj.Insertar(Obj);
        }

        public static string Actualizar(int id, int id_instrumento, int id_indivual, string Cod_Trab, string Nom_Trab, string Fec_Baja, string Observacion, string Cod_Localiza)
        {
            DIdentBaja Obj = new DIdentBaja();
            Obj.Id = id;
            Obj.Id_instrumento = id_instrumento;
            Obj.Id_indivual = id_indivual;
            Obj.Cod_Trab = Cod_Trab;
            Obj.Nom_Trab = Nom_Trab;
            Obj.Fec_Baja = Fec_Baja;
            Obj.Fec_Registro = DateTime.Now.ToString();
            Obj.Observacion = Observacion;
            Obj.Cod_Localiza = Cod_Localiza;
            return Obj.Actualizar(Obj);
        }

        public static DataTable Obtener(int Id_instrumento, int Id_indivual)
        {
            DIdentBaja  Obj = new DIdentBaja();
            Obj.Id_instrumento = Id_instrumento;
            Obj.Id_indivual = Id_indivual;
            return Obj.Obtener(Obj);
        }

    }
}
