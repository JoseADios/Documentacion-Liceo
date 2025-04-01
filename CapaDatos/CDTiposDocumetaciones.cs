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
    public class CDTiposDocumetaciones
    {
        private int dIDTipoDocumento;
        private string dTipoDocumento, destado;

        public CDTiposDocumetaciones()
        {

        }

        public CDTiposDocumetaciones(int pIDTipoDocumento,
                                     string pTipoDocumento,
                                     string pestado)
        {
            dIDTipoDocumento = pIDTipoDocumento;
            dTipoDocumento = pTipoDocumento;
            destado = pestado;

        }

        #region para los metodos get y set

        public int IDTipoDocumento { get => dIDTipoDocumento; set => dIDTipoDocumento = value; }
        public string TipoDocumento { get => dTipoDocumento; set => dTipoDocumento = value; }
        public string estado { get => destado; set => destado = value; }
        
        #endregion

        public string Insertar(CDTiposDocumetaciones objTiposDocs)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("TiposDocInsertar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIDTipoDocumento", objTiposDocs.IDTipoDocumento);
                miComando.Parameters.AddWithValue("@pTipoDocumento", objTiposDocs.TipoDocumento);
                miComando.Parameters.AddWithValue("@pEstado", objTiposDocs.estado);
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

        public string Actualizar(CDTiposDocumetaciones objTiposDocs)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("TiposDocActualizar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIDTipoDocumento", objTiposDocs.IDTipoDocumento);
                miComando.Parameters.AddWithValue("@pTipoDocumento", objTiposDocs.TipoDocumento);
                miComando.Parameters.AddWithValue("@pEstado", objTiposDocs.estado);
                mensaje = miComando.ExecuteNonQuery() == 1 ? "Actualización de datos exitosa!" :
                                                              "No se pudieron actualizar correctamente los datos!";

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

        public DataTable TiposDocMostrarTodo()
        {
            DataTable dtTiposDoc = new DataTable();     // Creamos un DataTable que tomará los datos de los Suplidores

            SqlDataReader leerDatos;           //Creamos el DataReader 

            try
            {
                SqlCommand sqlCmd = new SqlCommand();                                   //Se establece el comando
                sqlCmd.Connection = new DocumentacionConexion().dbconection;            //Conexión que va a usar el comando
                sqlCmd.Connection.Open();                                               //Se abre la conexión
                sqlCmd.CommandText = "TiposDocMostrarTodo";                             //nombre del procedimiento almacenado
                sqlCmd.CommandType = CommandType.StoredProcedure;                       //tipo de procedimiento
                leerDatos = sqlCmd.ExecuteReader();                                     //Se llena el SqlDataReader con los datos resultantes
                dtTiposDoc.Load(leerDatos);                                             //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close();                                              //se cierra la conexion
            }

            catch (Exception ex)             //si ocurre algun error se captura
            {
                dtTiposDoc = null;          //si ocurre algun error se anula
            }

            return dtTiposDoc;              //Se retorna el DataTable segun lo ocurrido arriba

        }   //Fin del método TiposDocMostrarTodo

        public DataTable TiposDocMostrarConFiltro(string miparametro)
        {
            DataTable dtTiposDoc = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "TiposDocMostrarFiltrado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dtTiposDoc.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtTiposDoc = null;
            }

            return dtTiposDoc;
        } //Fin del metodo EmpleadoMostrarConFiltro



    }


}
