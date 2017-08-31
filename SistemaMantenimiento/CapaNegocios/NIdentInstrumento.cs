using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NIdentInstrumento
    {

        public static string Insertar(int id_instrumento, int id_indivual, int Calib_Num, DateTime Ultima_Calib, DateTime Ingreso
                                    , string Estado, DateTime Prox_Calib, string Cod_Trab, string Nom_Trab, string Certificado
                                    , string Marca, string Adicional)
        {
            DIdentInstrumento Obj = new DIdentInstrumento()
            {
                Id_instrumento = id_instrumento,
                Id_indivual = id_indivual,
                Calib_Num = Calib_Num,
                Ultima_Calib = Ultima_Calib,
                Ingreso = Ingreso,
                Estado = Estado,
                Prox_Calib = Prox_Calib,
                Cod_Trab = Cod_Trab,
                Nom_Trab = Nom_Trab,
                Certificado = Certificado,
                Marca = Marca,
                Adicional = Adicional
            };
            return Obj.Insertar(Obj);
        }

        //Método Actualizar que llama al método Actualizar de la clase DIdentInstrumento
        //de la CapaDatos
        public static string Actualizar(int id ,int id_instrumento, int id_indivual, int Calib_Num, DateTime Ultima_Calib, DateTime Ingreso, string Estado, DateTime Prox_Calib, string Cod_Trab, string Nom_Trab, string Certificado, string Marca, string Adicional)
        {
            DIdentInstrumento Obj = new DIdentInstrumento()
            {
                Id = id,
                Id_instrumento = id_instrumento,
                Id_indivual = id_indivual,
                Calib_Num = Calib_Num,
                Ultima_Calib = Ultima_Calib,
                Ingreso = Ingreso,
                Estado = Estado,
                Prox_Calib = Prox_Calib,
                Cod_Trab = Cod_Trab,
                Nom_Trab = Nom_Trab,
                Certificado = Certificado,
                Marca = Marca,
                Adicional = Adicional
            };
            return Obj.Actualizar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DIdentInstrumento
        //de la CapaDatos
        public static string Eliminar(int id_instrumento, int id_indivual)
        {
            DIdentInstrumento Obj = new DIdentInstrumento()
            {
                Id_instrumento = id_instrumento,
                Id_indivual = id_indivual
            };
            return Obj.Eliminar(Obj);
        }

        //Método Listar que llama al método Listar de la clase DIdentInstrumento
        //de la CapaDatos
        public static DataTable Listar(int Id_Instrumento)
        {

            DIdentInstrumento Obj = new DIdentInstrumento()
            {
                Id_instrumento = Id_Instrumento
            };
            return new DIdentInstrumento().Listar(Obj);
        }

        //Método Listar que llama al método Buscar de la clase DIdentInstrumento
        //de la CapaDatos
        public static DataTable Buscar(int Id_Instrumento, int Id_Individual)
        {
            DIdentInstrumento Obj = new DIdentInstrumento()
            {
                Id_instrumento = Id_Instrumento,
                Id_indivual = Id_Individual
            };
            return new DIdentInstrumento().Buscar(Obj);
        }

        public static DataTable Consultar(DateTime Fecha, String Condicion)
        {
            return new DIdentInstrumento().Consultar(Fecha,Condicion);
        }

        public static int ProximoCodigoIndividual(int Id_Instrumento)
        {
            DIdentInstrumento Obj = new DIdentInstrumento()
            {
                Id_instrumento = Id_Instrumento
            };
            return new DIdentInstrumento().ProximoCodigoIndividual(Obj);
        }

    }
}
