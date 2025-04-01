using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;

namespace CapaNegocio
{
    public class CNAsignatura
    {
        public static string Insertar(
            int pIdAsignatura,
            string pAsignatura,
            int pHorasSemanales,
            string pEstado)
        {
            CDAsignatura objAsignatura = new CDAsignatura();

            objAsignatura.IdAsignatura = pIdAsignatura;
            objAsignatura.Asignatura = pAsignatura;
            objAsignatura.HorasSemanales = pHorasSemanales;
            objAsignatura.Estado = pEstado;

            return objAsignatura.Insertar(objAsignatura);
        }

        public static string Actualizar(
            int pIdAsignatura,
            string pAsignatura,
            int pHorasSemanales,
            string pEstado)
        {
            CDAsignatura objAsignatura = new CDAsignatura();

            objAsignatura.IdAsignatura = pIdAsignatura;
            objAsignatura.Asignatura = pAsignatura;
            objAsignatura.HorasSemanales = pHorasSemanales;
            objAsignatura.Estado = pEstado;

            return objAsignatura.Actualizar(objAsignatura);
        }
        public DataTable ObtenerAsignatura()
        {
            string msg = "";
            CDAsignatura objAsignatura = new CDAsignatura();
            DataTable dt = new DataTable();
            dt = objAsignatura.AsignaturaMostrarTodo();
            return dt;
        }
        public DataTable ObtenerAsignaturaConFiltro(int TieneParametro, string Parametro)
        {
            string msg = "";
            CDAsignatura objAsignatura = new CDAsignatura();
            DataTable dt = new DataTable();
            dt = objAsignatura.AsignaturaMostrarConFiltro(Parametro);
            return dt;
        }
    }
}
