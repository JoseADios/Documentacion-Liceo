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
    public class CDSolicitud_Documentacion
    {
        private int dIdSolicitudDocumentacion;
        private int dIdPeriodo;
        private DateTime dFechaSolicitud;
        private int dMatricula;
        private int dIdEmpleado;
        private int dIDTipoDocumento;
        private string dSolicitante;
        private string dEstado;
        private string dObservacion;

        //constructor vacio
        public CDSolicitud_Documentacion()
        {

        }

        //constructor que recibe parametros
        public CDSolicitud_Documentacion(int pIdSolicitudDocumentacion,
        int pIdPeriodo,
        DateTime pFechaSolicitud,
        int pMatricula,
        int pIdEmpleado,
        int pIDTipoDocumento,
        string pSolicitante,
        string pEstado,
        string pObservacion)
        {
            dIdSolicitudDocumentacion = pIdSolicitudDocumentacion;
            dIdPeriodo = pIdPeriodo;
            dFechaSolicitud = pFechaSolicitud;
            dMatricula = pMatricula;
            dIdEmpleado = pIdEmpleado;
            dIDTipoDocumento = pIDTipoDocumento;
            dSolicitante = pSolicitante;
            dEstado = pEstado;
            dObservacion = pObservacion;

        }
        #region para los metodos get y sey

        public int IdSolicitudDocumentacion
        {
            get { return dIdSolicitudDocumentacion; }
            set { dIdSolicitudDocumentacion = value; }
        }
        
        public int IdPeriodo
        {
            get { return dIdPeriodo; }
            set { dIdPeriodo = value; }
        }
        
        public DateTime FechaSolicitud
        {
            get { return dFechaSolicitud; }
            set { dFechaSolicitud = value; }
        }
        
        public int Matricula
        {
            get { return dMatricula; }
            set { dMatricula = value; }
        }
        
        public int IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
        }
        
        public int IDTipoDocumento
        {
            get { return dIDTipoDocumento; }
            set { dIDTipoDocumento = value; }
        }
        
        public string Solicitante
        {
            get { return dSolicitante; }
            set { dSolicitante = value; }
        }
        
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        
        public string Observacion
        {
            get { return dObservacion; }
            set { dObservacion = value; }
        }

        #endregion

        //metodo para insertar
        public string Insertar(CDSolicitud_Documentacion objSolicitudDoc)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("Solicitud_DocInsertar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIdPeriodo", objSolicitudDoc.IdPeriodo);
                miComando.Parameters.AddWithValue("@pFechaSolicitud", objSolicitudDoc.FechaSolicitud);
                miComando.Parameters.AddWithValue("@pMatricula", objSolicitudDoc.Matricula);
                miComando.Parameters.AddWithValue("@pIdEmpleado", objSolicitudDoc.IdEmpleado);
                miComando.Parameters.AddWithValue("@pIDTipoDocumentacion", objSolicitudDoc.IDTipoDocumento);
                miComando.Parameters.AddWithValue("@pSolicitante", objSolicitudDoc.Solicitante);
                miComando.Parameters.AddWithValue("@pEstado", objSolicitudDoc.Estado);
                miComando.Parameters.AddWithValue("@pObservacion", objSolicitudDoc.Observacion);
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

        
        //metodo para insertar
        public string Actualizar(CDSolicitud_Documentacion objSolicitudDoc)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("Solicitud_DActualizar", sqlCon);
                sqlCon.Open();
                miComando.Parameters.AddWithValue("@pIdSolicitudDocumentacion", objSolicitudDoc.IdSolicitudDocumentacion);
                miComando.Parameters.AddWithValue("@pIdPeriodo", objSolicitudDoc.IdPeriodo);
                miComando.Parameters.AddWithValue("@pFechaSolicitud", objSolicitudDoc.FechaSolicitud);
                miComando.Parameters.AddWithValue("@pMatricula", objSolicitudDoc.Matricula);
                miComando.Parameters.AddWithValue("@pIdEmpleado", objSolicitudDoc.IdEmpleado);
                miComando.Parameters.AddWithValue("@pTipoDocumentacion", objSolicitudDoc.IDTipoDocumento);
                miComando.Parameters.AddWithValue("@pSolicitante", objSolicitudDoc.Solicitante);
                miComando.Parameters.AddWithValue("@pEstado", objSolicitudDoc.Estado);
                miComando.Parameters.AddWithValue("@pObservacion", objSolicitudDoc.Observacion);
                mensaje = miComando.ExecuteNonQuery() == 1 ? "Actualización de datos exitosa!" :
                                                              "No se pudo actualizar correctamente los datos!";

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


        public DataTable SolicitudDocMostrarTodo()
        {
            DataTable dtSolDoc = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "Solicitud_DocMostrarTodo";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                leerDatos = sqlCmd.ExecuteReader();
                dtSolDoc.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtSolDoc = null;
            }
            return dtSolDoc;
        }
        public DataTable SolicitudoDocMostrarConFiltro(string miparametro)
        {
            DataTable dtSolDoc = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "Solicitud_DocMostrarFiltrado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dtSolDoc.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtSolDoc = null;
            }
            return dtSolDoc;
        }

    }
}
