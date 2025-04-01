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
    public class CNEstudiante
    {
        public static string Insertar(
            int pMatricula,
            string pNombres,
            string pApellidos,
            string pDireccion,
            string pTelefono,
            string pSexo,
            DateTime pFechaNacimiento,
            string pEstado,
            int pIDCursoActual)
        {
            CDEstudiante objEstudiante = new CDEstudiante();

            objEstudiante.Matricula = pMatricula;
            objEstudiante.Nombres = pNombres;
            objEstudiante.Apellidos = pApellidos;
            objEstudiante.Direccion = pDireccion;
            objEstudiante.Telefono = pTelefono;
            objEstudiante.Sexo = pSexo;
            objEstudiante.FechaNacimiento = pFechaNacimiento;
            objEstudiante.Estado = pEstado;
            objEstudiante.IDCursoActual = pIDCursoActual;

            return objEstudiante.Insertar(objEstudiante);
        }

        public static string Actualizar(
            int pMatricula,
            string pNombres,
            string pApellidos,
            string pDireccion,
            string pTelefono,
            string pSexo,
            DateTime pFechaNacimiento,
            string pEstado,
            int pIDCursoActual)
        {
            CDEstudiante objEstudiante = new CDEstudiante();

            objEstudiante.Matricula = pMatricula;
            objEstudiante.Nombres = pNombres;
            objEstudiante.Apellidos = pApellidos;
            objEstudiante.Direccion = pDireccion;
            objEstudiante.Telefono = pTelefono;
            objEstudiante.Sexo = pSexo;
            objEstudiante.FechaNacimiento = pFechaNacimiento;
            objEstudiante.Estado = pEstado;
            objEstudiante.IDCursoActual = pIDCursoActual;

            return objEstudiante.Actualizar(objEstudiante);
        }

        public DataTable ObtenerEstudiante()
        {
            string msg = "";
            CDEstudiante objEstudiante = new CDEstudiante();
            DataTable dt = new DataTable();
            dt = objEstudiante.EstudianteMostrarTodo();
            return dt;
        }
        public DataTable ObtenerEstudianteConFiltro(int TieneParametro, string Parametro)
        {
            string msg = "";
            CDEstudiante objEstudiante = new CDEstudiante();
            DataTable dt = new DataTable();
            dt = objEstudiante.EstudianteMostrarConFiltro(Parametro);
            return dt;
        }
    }
}
