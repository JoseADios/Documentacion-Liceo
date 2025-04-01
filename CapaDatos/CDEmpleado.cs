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
    public class CDEmpleado
    {
        private int dIDEmpleado;
        private string dNombre, dApellido, dDireccion, dSexo, dTelefono,
                        dCargo, dDepartamento, dEstado;

        public CDEmpleado()
        {

        }
        
        public CDEmpleado(int pIDEmpleado, 
            string pNombre, 
            string pApellido, 
            string pDireccion,
            string pSexo, 
            string pTelefono,
            string pCargo, 
            string pDepartamento,
            string pEstado )
        {
            dIDEmpleado = pIDEmpleado;
            dNombre = pNombre;
            dApellido = pApellido;
            dDireccion = pDireccion;
            dSexo = pSexo;
            dTelefono = pTelefono;
            dCargo = pCargo;
            dDepartamento = pDepartamento;
            dEstado = pEstado;

        }

        #region para los métodos Get y Set

        public int IDEmpleado
        {
            get { return dIDEmpleado; }
            set { dIDEmpleado = value; }
        }
        
        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        
        public string Apellido
        {
            get { return dApellido; }
            set { dApellido = value; }
        }
        
        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion= value; }
        }
        
        public string Sexo
        {
            get { return dSexo; }
            set { dSexo = value; }
        }
        
        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }
        
        public string Cargo
        {
            get { return dCargo; }
            set { dCargo = value; }
        }
        
        public string Departamento
        {
            get { return dDepartamento; }
            set { dDepartamento = value; }
        }
        
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }

        #endregion

        public string Insertar(CDEmpleado objEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("EmpleadoInsertar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pNombres", objEmpleado.Nombre);
                miComando.Parameters.AddWithValue("@pApellidos", objEmpleado.Apellido);
                miComando.Parameters.AddWithValue("@pDireccion", objEmpleado.Direccion);
                miComando.Parameters.AddWithValue("@pSexo", objEmpleado.Sexo);
                miComando.Parameters.AddWithValue("@pTelefono", objEmpleado.Telefono);
                miComando.Parameters.AddWithValue("@pCargo", objEmpleado.Cargo);
                miComando.Parameters.AddWithValue("@pDepartamento", objEmpleado.Departamento);
                miComando.Parameters.AddWithValue("@pEstado", objEmpleado.Estado);
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
        
        public string Actualizar(CDEmpleado objEmpleado)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("EmpleadoActualizar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pIDEmpleado", objEmpleado.IDEmpleado);
                miComando.Parameters.AddWithValue("@pNombres", objEmpleado.Nombre);
                miComando.Parameters.AddWithValue("@pApellidos", objEmpleado.Apellido);
                miComando.Parameters.AddWithValue("@pDireccion", objEmpleado.Direccion); 
                miComando.Parameters.AddWithValue("@pSexo", objEmpleado.Sexo);
                miComando.Parameters.AddWithValue("@pTelefono", objEmpleado.Telefono);
                miComando.Parameters.AddWithValue("@pCargo", objEmpleado.Cargo);
                miComando.Parameters.AddWithValue("@pDepartamento", objEmpleado.Departamento);
                miComando.Parameters.AddWithValue("@pEstado", objEmpleado.Estado);
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

        public DataTable EmpleadoMostrarTodo()
        {
            DataTable dtEmpleado = new DataTable();     // Creamos un DataTable que tomará los datos de los Suplidores

            SqlDataReader leerDatos;           //Creamos el DataReader 

            try
            {
                SqlCommand sqlCmd = new SqlCommand();                                   //Se establece el comando
                sqlCmd.Connection = new DocumentacionConexion().dbconection;            //Conexión que va a usar el comando
                sqlCmd.Connection.Open();                                               //Se abre la conexión
                sqlCmd.CommandText = "EmpleadoMostrarTodo";                             //nombre del procedimiento almacenado
                sqlCmd.CommandType = CommandType.StoredProcedure;                       //tipo de procedimiento
                leerDatos = sqlCmd.ExecuteReader();                                     //Se llena el SqlDataReader con los datos resultantes
                dtEmpleado.Load(leerDatos);                                             //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close();                                              //se cierra la conexion
            }

            catch(Exception ex)             //si ocurre algun error se captura
            {
                dtEmpleado = null;          //si ocurre algun error se anula
            }

            return dtEmpleado;              //Se retorna el DataTable segun lo ocurrido arriba

        }   //Fin del método EmpleadoMostrarTodo

        public DataTable EmpleadoMostrarConFiltro(string miparametro)
        {
            DataTable dtEmpleado = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "EmpleadoMostrarFiltrado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dtEmpleado.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch(Exception ex)
            {
                dtEmpleado = null;
            }

            return dtEmpleado;
        } //Fin del metodo EmpleadoMostrarConFiltro


    }
}
