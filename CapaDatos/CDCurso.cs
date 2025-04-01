using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;


namespace CapaDatos
{
    public class CDCurso
    {
        private int dIdCurso;
        private string dCurso, dGrado, dSeccion, dTanda, dEstado;

        public CDCurso()
        {

        }

        public CDCurso(int pIdCurso,
            string pCurso,
            string pGrado,
            string pSeccion,
            string pTanda,
            string pEstado)
        {
            dIdCurso = pIdCurso;
            dCurso = pCurso;
            dGrado = pGrado;
            dSeccion = pSeccion;
            dTanda = pTanda;
            dEstado = pEstado;
        }

        #region Metodo Get y Set
        public int IdCurso
        {
            get { return dIdCurso; }
            set { dIdCurso = value; }
        }
        public string Curso
        {
            get { return dCurso; }
            set { dCurso = value; }
        }
        public string Grado
        {
            get { return dGrado; }
            set { dGrado = value; }
        }
        public string Seccion
        {
            get { return dSeccion; }
            set { dSeccion = value; }
        }
        public string Tanda
        {
            get { return dTanda; }
            set { dTanda = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion

        public string Insertar(CDCurso objCurso)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;

                SqlCommand miComando = new SqlCommand("CursoInsertar", sqlCon);
                sqlCon.Open();

                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pCurso", objCurso.Curso);
                miComando.Parameters.AddWithValue("@pGrado", objCurso.Grado);
                miComando.Parameters.AddWithValue("@pSeccion", objCurso.Seccion);
                miComando.Parameters.AddWithValue("@pTanda", objCurso.Tanda);
                miComando.Parameters.AddWithValue("@pEstado", objCurso.Estado);
                mensaje = miComando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente" : "No se pudo Insertar correctamente el nuevo Curso!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return mensaje;
        }
        public string Actualizar(CDCurso objCurso)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;

                SqlCommand miComando = new SqlCommand("CursoActualizar", sqlCon);
                sqlCon.Open();

                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIdCurso", objCurso.IdCurso);
                miComando.Parameters.AddWithValue("@pCurso", objCurso.Curso);
                miComando.Parameters.AddWithValue("@pGrado", objCurso.Grado);
                miComando.Parameters.AddWithValue("@pSeccion", objCurso.Seccion);
                miComando.Parameters.AddWithValue("@pTanda", objCurso.Tanda);
                miComando.Parameters.AddWithValue("@pEstado", objCurso.Estado);
                mensaje = miComando.ExecuteNonQuery() == 1 ? "Actualizacion completada correctamente" : "No se pudo Actualizar correctamente el nuevo Curso!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return mensaje;
        }

        public DataTable CursoMostrarTodo()
        {
            DataTable dtCurso = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "CursoMostrarTodo";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                leerDatos = sqlCmd.ExecuteReader();
                dtCurso.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtCurso = null;
            }
            return dtCurso;
        }
        public DataTable CursoMostrarConFiltro(string miparametro)
        {
            DataTable dtCurso = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "CursoMostrarFiltrado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dtCurso.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtCurso = null;
            }
            return dtCurso;
        }
    }
}
