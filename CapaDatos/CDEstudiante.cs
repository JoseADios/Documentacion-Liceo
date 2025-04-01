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
    public class CDEstudiante
    {
        private int dMatricula;
        private string dNombres;
        private string dApellidos;
        private string dDireccion;
        private string dTelefono;
        private string dSexo;
        private DateTime dFechaNacimiento;
        private string dEstado;
        private int dIDCursoActual;

        //constructor vacio
        public CDEstudiante()
        {

        }

        //constructor que recibe parametros
        public CDEstudiante(int pMatricula, 
            string pNombres, 
            string pApellidos, 
            string pDireccion,
            string pTelefono, 
            string pSexo, 
            DateTime pFechaNacimiento, 
            string pEstado,
            int pIDCursoActual)
        {
            dMatricula = pMatricula;
            dNombres = pNombres;
            dApellidos = pApellidos;
            dDireccion = pDireccion;
            dTelefono = pTelefono;
            dSexo = pSexo;
            dFechaNacimiento = pFechaNacimiento;
            dEstado = pEstado;
            dIDCursoActual = pIDCursoActual;
        }

        #region para los métodos Get y Set

        public int Matricula
        {
            get { return dMatricula; }
            set { dMatricula = value; }
        }

        public string Nombres
        {
            get { return dNombres; }
            set { dNombres = value; }
        }
       
        public string Apellidos
        {
            get { return dApellidos; }
            set { dApellidos = value; }
        }

        public string Direccion
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }

        public string Telefono
        {
            get { return dTelefono; }
            set { dTelefono = value; }
        }
        
        public string Sexo
        {
            get { return dSexo; }
            set { dSexo = value; }
        }
        
        public DateTime FechaNacimiento
        {
            get { return dFechaNacimiento; }
            set { dFechaNacimiento = value; }
        }
        
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        
        public int IDCursoActual
        {
            get { return dIDCursoActual; }
            set { dIDCursoActual = value; }
        }


        #endregion

        public string Insertar(CDEstudiante objEstudiante)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("EstudianteInsertar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pNombres", objEstudiante.Nombres);
                miComando.Parameters.AddWithValue("@pApellidos", objEstudiante.Apellidos);
                miComando.Parameters.AddWithValue("@pDireccion", objEstudiante.Direccion);
                miComando.Parameters.AddWithValue("@pTelefono", objEstudiante.Telefono);
                miComando.Parameters.AddWithValue("@pSexo", objEstudiante.Sexo);
                miComando.Parameters.AddWithValue("@pFechaNacimiento", objEstudiante.FechaNacimiento);
                miComando.Parameters.AddWithValue("@pEstado", objEstudiante.Estado);
                miComando.Parameters.AddWithValue("@pIDCursoActual", objEstudiante.IDCursoActual);
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

        public string Actualizar(CDEstudiante objEstudiante)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = DocumentacionConexion.miConexion;
                SqlCommand miComando = new SqlCommand("EstudianteActualizar", sqlCon);
                sqlCon.Open();
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.AddWithValue("@pMatricula", objEstudiante.Matricula);
                miComando.Parameters.AddWithValue("@pNombres", objEstudiante.Nombres);
                miComando.Parameters.AddWithValue("@pApellidos", objEstudiante.Apellidos);
                miComando.Parameters.AddWithValue("@pDireccion", objEstudiante.Direccion);
                miComando.Parameters.AddWithValue("@pTelefono", objEstudiante.Telefono);
                miComando.Parameters.AddWithValue("@pSexo", objEstudiante.Sexo);
                miComando.Parameters.AddWithValue("@pFechaNacimiento", objEstudiante.FechaNacimiento);
                miComando.Parameters.AddWithValue("@pIDCursoActual", objEstudiante.IDCursoActual);
                miComando.Parameters.AddWithValue("@pEstado", objEstudiante.Estado);
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

        public DataTable EstudianteMostrarTodo()
        {
            DataTable dtEstudiante = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "EstudianteMostrarTodo";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                leerDatos = sqlCmd.ExecuteReader();
                dtEstudiante.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtEstudiante = null;
            }
            return dtEstudiante;
        }
        public DataTable EstudianteMostrarConFiltro(string miparametro)
        {
            DataTable dtEstudiante = new DataTable();
            SqlDataReader leerDatos;

            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new DocumentacionConexion().dbconection;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "EstudianteMostrarFiltrado";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro);
                leerDatos = sqlCmd.ExecuteReader();
                dtEstudiante.Load(leerDatos);
                sqlCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                dtEstudiante = null;
            }
            return dtEstudiante;
        }
    }
}
