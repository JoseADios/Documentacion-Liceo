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
    public class CNPeriodo
    {
        public static string Insertar(
            int pIdPeriodo,
            string pPeriodo,
            DateTime pFechaInicio,
            DateTime pFechaTermino,
            string pSlogan,
            string pEstado)
        {
            CDPeriodo objPeriodo = new CDPeriodo();

            objPeriodo.IdPeriodo = pIdPeriodo;
            objPeriodo.Periodo = pPeriodo;
            objPeriodo.FechaInicio = pFechaInicio;
            objPeriodo.FechaTermino = pFechaTermino;
            objPeriodo.Slogan = pSlogan;
            objPeriodo.Estado = pEstado;

            return objPeriodo.Insertar(objPeriodo);
        }

        public static string Actualizar(
            int pIdPeriodo,
            string pPeriodo,
            DateTime pFechaInicio,
            DateTime pFechaTermino,
            string pSlogan,
            string pEstado)
        {
            CDPeriodo objPeriodo = new CDPeriodo();

            objPeriodo.IdPeriodo = pIdPeriodo;
            objPeriodo.Periodo = pPeriodo;
            objPeriodo.FechaInicio = pFechaInicio;
            objPeriodo.FechaTermino = pFechaTermino;
            objPeriodo.Slogan = pSlogan;
            objPeriodo.Estado = pEstado;

            return objPeriodo.Actualizar(objPeriodo);
        }

        public DataTable ObtenerPeriodo()
        {
            string msg = "";
            CDPeriodo objPeriodo = new CDPeriodo();
            DataTable dt = new DataTable();
            dt = objPeriodo.PeriodoMostrarTodo();
            return dt;
        }
        public DataTable ObtenerPeriodoConFiltro(int TieneParametro, string Parametro)
        {
            string msg = "";
            CDPeriodo objPeriodo = new CDPeriodo();
            DataTable dt = new DataTable();
            dt = objPeriodo.PeriodoMostrarConFiltro(Parametro);
            return dt;
        }

    }
}
