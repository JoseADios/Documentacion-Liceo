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
    public class CDCalificaciones
    {
        private int dIDCalificacion, dIDPeriodo, dMatricula, dIDAsignatura;

        private float dPrimeraCalificacion, dSegundaCalificacion,
                      dTerceraCalificacion, dCuartaCalificacion;

        private DateTime dFecha;
        private string dEstado;

        public CDCalificaciones()
        {

        }
        public CDCalificaciones(int pIDCalificacion,
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
            dIDCalificacion = pIDCalificacion;
            dIDPeriodo = pIDPeriodo;
            dFecha = pFecha;
            dMatricula = pMatricula;
            dIDAsignatura = pIDAsignatura;
            dPrimeraCalificacion = pPrimeraCalificacion;
            dSegundaCalificacion = pSegundaCalificacion;
            dTerceraCalificacion = pTerceraCalificacion;
            dCuartaCalificacion = pCuartaCalificacion;
            dEstado = pEstado;

        }
        #region para los metodos get y sey

        public int IDCalificacion
        {
            get { return dIDCalificacion; }
            set { dIDCalificacion = value; }
        }

        public int IDPeriodo
        {
            get { return dIDPeriodo; }
            set { dIDPeriodo = value; }
        }

        public DateTime Fecha
        {
            get { return dFecha; }
            set { dFecha = value; }
        }

        public int Matricula
        {
            get { return dMatricula; }
            set { dMatricula = value; }
        }

        public int IDAsignatura
        {
            get { return dIDAsignatura; }
            set { dIDAsignatura = value; }
        }

        public float PrimeraCalificacion
        {
            get { return dPrimeraCalificacion; }
            set { dPrimeraCalificacion = value; }
        }

        public float SegundaCalificacion
        {
            get { return dSegundaCalificacion; }
            set { dSegundaCalificacion = value; }
        }

        public float TerceraCalificacion
        {
            get { return dTerceraCalificacion; }
            set { dTerceraCalificacion = value; }
        }

        public float CuartaCalificacion
        {
            get { return dCuartaCalificacion; }
            set { dCuartaCalificacion = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        #endregion

        public string Insertar(CDCalificaciones objCalificaciones)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("CalificacionesInsertar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIDPeriodo", objCalificaciones.IDPeriodo);
                miComando.Parameters.AddWithValue("@pFecha", objCalificaciones.Fecha);
                miComando.Parameters.AddWithValue("@pMatricula", objCalificaciones.Matricula);
                miComando.Parameters.AddWithValue("@pIDAsignatura", objCalificaciones.IDAsignatura);
                miComando.Parameters.AddWithValue("@pPrimeraCalificacion", objCalificaciones.PrimeraCalificacion);
                miComando.Parameters.AddWithValue("@pSegundaCalificacion", objCalificaciones.SegundaCalificacion);
                miComando.Parameters.AddWithValue("@pTerceraCalificacion", objCalificaciones.TerceraCalificacion);
                miComando.Parameters.AddWithValue("@pCuartaCalificacion", objCalificaciones.CuartaCalificacion);
                miComando.Parameters.AddWithValue("@pEstado", objCalificaciones.Estado);
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

        public string Actualizar(CDCalificaciones objCalificaciones)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("CalificacionesActualizar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIDPeriodo", objCalificaciones.IDPeriodo);
                miComando.Parameters.AddWithValue("@pFecha", objCalificaciones.Fecha);
                miComando.Parameters.AddWithValue("@pMatricula", objCalificaciones.Matricula);
                miComando.Parameters.AddWithValue("@pIDAsignatura", objCalificaciones.IDAsignatura);
                miComando.Parameters.AddWithValue("@pPrimeraCalificacion", objCalificaciones.PrimeraCalificacion);
                miComando.Parameters.AddWithValue("@pSegundaCalificacion", objCalificaciones.SegundaCalificacion);
                miComando.Parameters.AddWithValue("@pTerceraCalificacion", objCalificaciones.TerceraCalificacion);
                miComando.Parameters.AddWithValue("@pCuartaCalificacion", objCalificaciones.CuartaCalificacion);
                miComando.Parameters.AddWithValue("@pEstado", objCalificaciones.Estado);
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

        public DataTable CalificacionesMostrarTodo()
        {
            DataTable dtCalificaciones = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "CalificacionesMostrarTodo";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                leerDatos = sqlCmd.ExecuteReader();
                dtCalificaciones.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtCalificaciones = null;
            }
            return dtCalificaciones;
        }

        public DataTable CalificacionesMostraConFiltros(string miparametro)
        {
            DataTable dtCalificaciones = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "CalificacionesMostrarFiltrado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dtCalificaciones.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtCalificaciones = null;
            }
            return dtCalificaciones;
        }

    }
}
