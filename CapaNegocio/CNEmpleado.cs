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
    public class CNEmpleado
    {
        public static string Insertar(int pIDEmpleado,
            string pNombre,
            string pApellido,
            string pDireccion,
            string pSexo,
            string pTelefono,
            string pCargo,
            string pDepartamento,
            string pEstado)
        {
            CDEmpleado objEmpleado = new CDEmpleado();

            objEmpleado.IDEmpleado = pIDEmpleado;
            objEmpleado.Nombre = pNombre;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Sexo= pSexo;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.Cargo = pCargo;
            objEmpleado.Departamento = pDepartamento;
            objEmpleado.Estado = pEstado;

            return objEmpleado.Insertar(objEmpleado);
        }

        public static string Actualizar(int pIDEmpleado,
            string pNombre,
            string pApellido,
            string pDireccion,
            string pSexo,
            string pTelefono,
            string pCargo,
            string pDepartamento,
            string pEstado)
        {
            CDEmpleado objEmpleado = new CDEmpleado();

            objEmpleado.IDEmpleado = pIDEmpleado;
            objEmpleado.Nombre = pNombre;
            objEmpleado.Apellido = pApellido;
            objEmpleado.Direccion = pDireccion;
            objEmpleado.Sexo = pSexo;
            objEmpleado.Telefono = pTelefono;
            objEmpleado.Cargo = pCargo;
            objEmpleado.Departamento = pDepartamento;
            objEmpleado.Estado = pEstado;

            return objEmpleado.Actualizar(objEmpleado);

        }

        public DataTable ObtenerEmpleado()
        {
            string msg = "";
            CDEmpleado objEmpleado = new CDEmpleado();      //creamos un nuevo objeto de la clase Empleado
            DataTable dt = new DataTable();                 //creamos un nuevo DataTable
            dt = objEmpleado.EmpleadoMostrarTodo();         //El DataTable se llena con todos los datos devueltos
            return dt;                                      //Se retorna el DataTable con los datos adquiridos 
        }//fin del metodo


        public DataTable ObtenerEmpleadoConFiltro(int TieneParametro, string Parametro)
        {
            string msg = "";
            CDEmpleado objEmpleado = new CDEmpleado();                           //creamos un nuevo objeto de la clase Empleado
            DataTable dt = new DataTable();                                     //creamos un nuevo DataTable
            dt = objEmpleado.EmpleadoMostrarConFiltro(Parametro);              //El DataTable se llena con todos los datos devueltos
            return dt;                                                        //Se retorna el DataTable con los datos adquiridos 

        }//fin del metodo
    }
}
