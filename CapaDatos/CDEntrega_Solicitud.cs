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
    public class CDEntrega_Solicitud
    {
        private int dIdEntregaDocumentacion;
        private DateTime dFechaEntrega;
        private int dIdEmpleado;
        private int dIdSolicitudDocumentacion;
        private string dReciboPor;
        private string dObservacion;

        //constructor vacio
        public CDEntrega_Solicitud()
        {

        }

        //constructor que recibe parametros
        public CDEntrega_Solicitud(int pIdEntregaDocumentacion,
        DateTime pFechaEntrega,
        int pIdEmpleado,
        int pIdSolicitudDocumentacion,
        string pReciboPor,
        string pObservacion)
        {
            dIdEntregaDocumentacion = pIdEntregaDocumentacion;
            dFechaEntrega = pFechaEntrega;
            dIdEmpleado = pIdEmpleado;
            dIdSolicitudDocumentacion = pIdSolicitudDocumentacion;
            dReciboPor = pReciboPor;
            dObservacion = pObservacion;

        }

        #region para los métodos Get y Set

        public int IdEntregaDocumentacion
        {
            get { return dIdEntregaDocumentacion; }
            set { dIdEntregaDocumentacion = value; }
        }

        public DateTime FechaEntrega
        {
            get { return dFechaEntrega; }
            set { dFechaEntrega = value; }
        }

        public int IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
        }

        public int IdSolicitudDocumentacion
        {
            get { return dIdSolicitudDocumentacion; }
            set { dIdSolicitudDocumentacion = value; }
        }
        
        public string ReciboPor
        {
            get { return dReciboPor; }
            set { dReciboPor = value; }
        }
        
        public string Observacion
        {
            get { return dObservacion; }
            set { dObservacion = value; }
        }

        #endregion

        public string Insertar(CDEntrega_Solicitud objEntregaSol)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("Entrega_SolInsertar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pFechaEntrega", objEntregaSol.FechaEntrega);
                miComando.Parameters.AddWithValue("@pIdEmpleado", objEntregaSol.IdEmpleado);
                miComando.Parameters.AddWithValue("@pIdSolicitudDocumentacion", objEntregaSol.IdSolicitudDocumentacion);
                miComando.Parameters.AddWithValue("@pReciboPor", objEntregaSol.ReciboPor);
                miComando.Parameters.AddWithValue("@pObservacion", objEntregaSol.Observacion);
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
                {
                    sqlCon.Close();
                }
            }

            return mensaje;
        }
        
        public string Actualizar(CDEntrega_Solicitud objEntregaSol)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("Entrega_SolActualizar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIdEntregaDocumentacion", objEntregaSol.IdEntregaDocumentacion);
                miComando.Parameters.AddWithValue("@pFechaEntrega", objEntregaSol.FechaEntrega);
                miComando.Parameters.AddWithValue("@pIdEmpleado", objEntregaSol.IdEmpleado);
                miComando.Parameters.AddWithValue("@pIdSolicitudDocumentacion", objEntregaSol.IdSolicitudDocumentacion);
                miComando.Parameters.AddWithValue("@pReciboPor", objEntregaSol.ReciboPor);
                miComando.Parameters.AddWithValue("@pObservacion", objEntregaSol.Observacion);
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
                {
                    sqlCon.Close();
                }
            }

            return mensaje;
        }

        public DataTable EntregaSolMostrarTodo()
        {
            DataTable dtEntregaSol = new DataTable();
            
            SqlDataReader leerDatos;           //Creamos el DataReader 

            try
            {
                SqlCommand sqlCmd = new SqlCommand();                                   //Se establece el comando
                sqlCmd.Connection = new DocumentacionConexion().dbconection;            //Conexión que va a usar el comando
                sqlCmd.Connection.Open();                                               //Se abre la conexión
                sqlCmd.CommandText = "Entrega_SolMostrarTodo";                             //nombre del procedimiento almacenado
                sqlCmd.CommandType = CommandType.StoredProcedure;                       //tipo de procedimiento
                leerDatos = sqlCmd.ExecuteReader();                                     //Se llena el SqlDataReader con los datos resultantes
                dtEntregaSol.Load(leerDatos);                                             //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close();                                              //se cierra la conexion
            }

            catch (Exception ex)             //si ocurre algun error se captura
            {
                dtEntregaSol = null;          //si ocurre algun error se anula
            }

            return dtEntregaSol;              //Se retorna el DataTable segun lo ocurrido arriba
        }


        public DataTable EntregaSolMostrarConFiltro(string miparametro)
        {
            DataTable dtEntregaSol = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "Entrega_SolMostrarFiltrado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dtEntregaSol.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtEntregaSol = null;
            }

            return dtEntregaSol;
        } //Fin del metodo EmpleadoMostrarConFiltro


    }

}
