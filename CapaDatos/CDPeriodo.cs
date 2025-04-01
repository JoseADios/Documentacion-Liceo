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
    public class CDPeriodo
    {
        private int dIdPeriodo;
        private string dPeriodo, dSlogan, dEstado;
        private DateTime dFechaInicio, dFechaTermino;

        public CDPeriodo()
        {

        }

        public CDPeriodo(
            int pIdPeriodo,
            string pPeriodo,
            DateTime pFechaInicio,
            DateTime pFechaTermino,
            string pSlogan,
            string pEstado)
        {
            dIdPeriodo = pIdPeriodo;
            dPeriodo = pPeriodo;
            dFechaInicio = pFechaInicio;
            dFechaTermino = pFechaTermino;
            dSlogan = pSlogan;
            dEstado = pEstado;
        }

        #region Metodos get y set

        public int IdPeriodo
        {
            get { return dIdPeriodo; }
            set { dIdPeriodo = value; }
        }

        public string Periodo
        {
            get { return dPeriodo; }
            set { dPeriodo = value; }
        }

        public DateTime FechaInicio
        {
            get { return dFechaInicio; }
            set { dFechaInicio = value; }
        }

        public DateTime FechaTermino
        {
            get { return dFechaTermino; }
            set { dFechaTermino = value; }
        }

        public string Slogan
        {
            get { return dSlogan; }
            set { dSlogan = value; }
        }

        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion

        public string Insertar(CDPeriodo objPeriodo)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("PeriodoInsertar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pPeriodo", objPeriodo.Periodo);
                miComando.Parameters.AddWithValue("@dFechaInicio", objPeriodo.FechaInicio);
                miComando.Parameters.AddWithValue("@dFechaTermino", objPeriodo.FechaTermino);
                miComando.Parameters.AddWithValue("@dSlogan", objPeriodo.Slogan);
                miComando.Parameters.AddWithValue("@dEstado", objPeriodo.Estado);
                mensaje = miComando.ExecuteNonQuery() == 1 ? "Insercción de datos exitosa!" :
                                                              "No se pudo insertar correctamente los datos!";

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

        public string Actualizar(CDPeriodo objPeriodo)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("PeriodoActualizar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIdPeriodo", objPeriodo.IdPeriodo);
                miComando.Parameters.AddWithValue("@pPeriodo", objPeriodo.Periodo);
                miComando.Parameters.AddWithValue("@dFechaInicio", objPeriodo.FechaInicio);
                miComando.Parameters.AddWithValue("@dFechaTermino", objPeriodo.FechaTermino);
                miComando.Parameters.AddWithValue("@dSlogan", objPeriodo.Slogan);
                miComando.Parameters.AddWithValue("@dEstado", objPeriodo.Estado);
                mensaje = miComando.ExecuteNonQuery() == 1 ? "Actualización completada correctamente" :
                                                              "No se pudo Actualizar correctamente los datos del Suplidor!";

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

        public DataTable PeriodoMostrarTodo()
        {
            DataTable dtPeriodo = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "PeriodoMostrarTodo";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                leerDatos = sqlCmd.ExecuteReader();
                dtPeriodo.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtPeriodo = null;
            }
            return dtPeriodo;
        }

        public DataTable PeriodoMostrarConFiltro(string miparametro)
        {
            DataTable dtPeriodo = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "PeriodoMostrarFiltrado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dtPeriodo.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtPeriodo = null;
            }
            return dtPeriodo;
        }


    }

}
