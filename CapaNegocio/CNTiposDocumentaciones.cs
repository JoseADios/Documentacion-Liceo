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
    public class CNTiposDocumentaciones
    {
        public static string Insertar(int pIDTipoDocumento,
                                      string pTipoDocumento,
                                      string pestado)
        {
            CDTiposDocumetaciones objTiposDoc = new CDTiposDocumetaciones();

            objTiposDoc.IDTipoDocumento = pIDTipoDocumento;
            objTiposDoc.TipoDocumento = pTipoDocumento;
            objTiposDoc.estado = pestado;

            return objTiposDoc.Insertar(objTiposDoc);
        }

        public static string Actualizar(int pIDTipoDocumento,
                                      string pTipoDocumento,
                                      string pestado)
        {
            CDTiposDocumetaciones objTiposDoc = new CDTiposDocumetaciones();

            objTiposDoc.IDTipoDocumento = pIDTipoDocumento;
            objTiposDoc.TipoDocumento = pTipoDocumento;
            objTiposDoc.estado = pestado;

            return objTiposDoc.Actualizar(objTiposDoc);
        }

        public DataTable ObtenerTiposDoc()
        {
            string msg = "";
            CDTiposDocumetaciones objTiposDoc = new CDTiposDocumetaciones();      //creamos un nuevo objeto de la clase TiposDoc
            DataTable dt = new DataTable();                 //creamos un nuevo DataTable
            dt = objTiposDoc.TiposDocMostrarTodo();         //El DataTable se llena con todos los datos devueltos
            return dt;                                      //Se retorna el DataTable con los datos adquiridos 
        }//fin del metodo

        public DataTable ObtenerTiposDocConFiltro(int TieneParametro, string Parametro)
        {
            string msg = "";
            CDTiposDocumetaciones objTiposDoc = new CDTiposDocumetaciones();                           //creamos un nuevo objeto de la clase TiposDoc
            DataTable dt = new DataTable();                                     //creamos un nuevo DataTable
            dt = objTiposDoc.TiposDocMostrarConFiltro(Parametro);              //El DataTable se llena con todos los datos devueltos
            return dt;                                                        //Se retorna el DataTable con los datos adquiridos 

        }//fin del metodo

    }
}
