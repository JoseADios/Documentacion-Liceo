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
    public class CNCurso
    {
        public static string Insertar(
            int pIdCurso,
            string pCurso,
            string pGrado,
            string pSeccion,
            string pTanda,
            string pEstado)
        {
            CDCurso objCurso= new CDCurso();

            objCurso.IdCurso = pIdCurso;
            objCurso.Curso = pCurso;
            objCurso.Grado = pGrado;
            objCurso.Seccion = pSeccion;
            objCurso.Tanda = pTanda;
            objCurso.Estado = pEstado;

            return objCurso.Insertar(objCurso);
        }

        public static string Actualizar(
            int pIdCurso,
            string pCurso,
            string pGrado,
            string pSeccion,
            string pTanda,
            string pEstado)
        {
            CDCurso objCurso = new CDCurso();

            objCurso.IdCurso = pIdCurso;
            objCurso.Curso = pCurso;
            objCurso.Grado = pGrado;
            objCurso.Seccion = pSeccion;
            objCurso.Tanda = pTanda;
            objCurso.Estado = pEstado;

            return objCurso.Actualizar(objCurso);
        }

        public DataTable ObtenerCurso()
        {
            string msg = "";
            CDCurso objCurso = new CDCurso();
            DataTable dt = new DataTable();
            dt = objCurso.CursoMostrarTodo();
            return dt;
        }
        public DataTable ObtenerCursoConFiltro(int TieneParametro, string Parametro)
        {
            string msg = "";
            CDCurso objCurso = new CDCurso();
            DataTable dt = new DataTable();
            dt = objCurso.CursoMostrarConFiltro(Parametro);
            return dt;
        }
    }
}
