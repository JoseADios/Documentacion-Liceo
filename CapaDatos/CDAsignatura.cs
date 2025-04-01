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
    public class CDAsignatura
    {
        private int dIDAsignatura, dHorasSemanales;
        private string dAsignatura, dEstado;

        // Constructor vacio
        public CDAsignatura()
        {

        }

        // Constructor con parametros
        public CDAsignatura(int pIDAsignatura,
            int pHorasSemanales,
            string pAsignatura,
            string pEstado)
        {
            dIDAsignatura = pIDAsignatura;
            dHorasSemanales = pHorasSemanales;
            dAsignatura = pAsignatura;
            dEstado = pEstado;
        }

        #region Metodos Get y Set
        public int IdAsignatura
        {
            get { return dIDAsignatura; }
            set { dIDAsignatura = value; }
        }
        public int HorasSemanales
        {
            get { return dHorasSemanales; }
            set { dHorasSemanales = value; }
        }
        public string Asignatura
        {
            get { return dAsignatura; }
            set { dAsignatura = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion

        public string Insertar(CDAsignatura objAsignatura)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("AsignaturaInsertar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pAsignatura", objAsignatura.Asignatura);
                miComando.Parameters.AddWithValue("@pHorasSemanales", objAsignatura.HorasSemanales);
                miComando.Parameters.AddWithValue("@Estado", objAsignatura.Estado);
                mensaje = miComando.ExecuteNonQuery() == 1 ? "Insercion de datos exitosa" : "No se pudo insertar correctamente los datos";

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
        public string Actualizar(CDAsignatura objAsignatura)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("AsignaturaActualizar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIDAsignatura", objAsignatura.IdAsignatura);
                miComando.Parameters.AddWithValue("@pAsignatura", objAsignatura.Asignatura);
                miComando.Parameters.AddWithValue("@pHorasSemanales", objAsignatura.HorasSemanales);
                miComando.Parameters.AddWithValue("@pEstado", objAsignatura.Estado);
                mensaje = miComando.ExecuteNonQuery() == 1 ? "Actualización completada correctamente" : "No se pudo Actualizar correctamente los datos del Suplidor!";

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
        public DataTable AsignaturaMostrarTodo()
        {
            DataTable dtAsignatura = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "AsignaturaMostrarTodo";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                leerDatos = sqlCmd.ExecuteReader();
                dtAsignatura.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtAsignatura = null;
            }
            return dtAsignatura;
        }
        public DataTable AsignaturaMostrarConFiltro(string miparametro)
        {
            DataTable dtAsignatura = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "AsignaturaMostrarFiltrado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dtAsignatura.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtAsignatura = null;
            }
            return dtAsignatura;
        }
    }
}
