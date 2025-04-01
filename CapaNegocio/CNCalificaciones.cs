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
    public class CNCalificaciones
    {
        public static string Insertar(
            int pIDCalificaciones,
            int pIDPeriodo,
            DateTime pFecha,
            int pMatricula,
            int pIDAsignatura,
            float pPrimeraCalificacion,
            float pSegundaCalificacion,
            float pTerceraCalificacion,
            float pCuartaCalificacion,
            string pEstado)
        {
            CDCalificaciones objCalificaciones = new CDCalificaciones();

            objCalificaciones.IDCalificacion = pIDCalificaciones;
            objCalificaciones.IDPeriodo = pIDPeriodo;
            objCalificaciones.Fecha = pFecha;
            objCalificaciones.Matricula = pMatricula;
            objCalificaciones.IDAsignatura = pIDAsignatura;
            objCalificaciones.PrimeraCalificacion = pPrimeraCalificacion;
            objCalificaciones.SegundaCalificacion = pSegundaCalificacion;
            objCalificaciones.TerceraCalificacion = pTerceraCalificacion;
            objCalificaciones.CuartaCalificacion = pCuartaCalificacion;

            return objCalificaciones.Insertar(objCalificaciones);
        }

        public static string Actualizar(
            int pIDCalificaciones,
            int pIDPeriodo,
            DateTime pFecha,
            int pMatricula,
            int pIDAsignatura,
            float pPrimeraCalificacion,
            float pSegundaCalificacion,
            float pTerceraCalificacion,
            float pCuartaCalificacion,
            string pEstado)
        {
            CDCalificaciones objCalificaciones = new CDCalificaciones();

            objCalificaciones.IDCalificacion = pIDCalificaciones;
            objCalificaciones.IDPeriodo = pIDPeriodo;
            objCalificaciones.Fecha = pFecha;
            objCalificaciones.Matricula = pMatricula;
            objCalificaciones.IDAsignatura = pIDAsignatura;
            objCalificaciones.PrimeraCalificacion = pPrimeraCalificacion;
            objCalificaciones.SegundaCalificacion = pSegundaCalificacion;
            objCalificaciones.TerceraCalificacion = pTerceraCalificacion;
            objCalificaciones.CuartaCalificacion = pCuartaCalificacion;

            return objCalificaciones.Actualizar(objCalificaciones);
        }

        public DataTable ObtenerCalificaciones()
        {
            string msg = "";
            CDCalificaciones objCalificaciones = new CDCalificaciones();
            DataTable dt = new DataTable();
            dt = objCalificaciones.CalificacionesMostrarTodo();
            return dt;
        }
        public DataTable ObtenerCalificacionesConFiltro(int TieneParametro, string Parametro)
        {
            string msg = "";
            CDCalificaciones objCalificaciones = new CDCalificaciones();
            DataTable dt = new DataTable();
            dt = objCalificaciones.CalificacionesMostraConFiltros(Parametro);
            return dt;
        }

    }
}
