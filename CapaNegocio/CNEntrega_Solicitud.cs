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
    public class CNEntrega_Solicitud
    {
        public static string Insertar(int pIdEntregaDocumentacion,
            DateTime pFechaEntrega,
            int pIdEmpleado,
            int pIdSolicitudDocumentacion,
            string pReciboPor,
            string pObservacion)
        {
            CDEntrega_Solicitud objEntregaSol = new CDEntrega_Solicitud();

            objEntregaSol.IdEntregaDocumentacion = pIdEntregaDocumentacion;
            objEntregaSol.FechaEntrega = pFechaEntrega;
            objEntregaSol.IdEmpleado = pIdEmpleado;
            objEntregaSol.IdSolicitudDocumentacion= pIdSolicitudDocumentacion;
            objEntregaSol.ReciboPor = pReciboPor;
            objEntregaSol.Observacion = pObservacion;

            return objEntregaSol.Insertar(objEntregaSol);

        }

        public static string Actualizar(int pIdEntregaDocumentacion,
            DateTime pFechaEntrega,
            int pIdEmpleado,
            int pIdSolicitudDocumentacion,
            string pReciboPor,
            string pObservacion)
        {
            CDEntrega_Solicitud objEntregaSol = new CDEntrega_Solicitud();

            objEntregaSol.IdEntregaDocumentacion = pIdEntregaDocumentacion;
            objEntregaSol.FechaEntrega = pFechaEntrega;
            objEntregaSol.IdEmpleado = pIdEmpleado;
            objEntregaSol.IdSolicitudDocumentacion = pIdSolicitudDocumentacion;
            objEntregaSol.ReciboPor = pReciboPor;
            objEntregaSol.Observacion = pObservacion;

            return objEntregaSol.Actualizar(objEntregaSol);
        }

        public DataTable ObtenerEntregaSol()
        {
            string msg = "";
            CDEntrega_Solicitud objEntregaSol = new CDEntrega_Solicitud();
            DataTable dt = new DataTable();
            dt = objEntregaSol.EntregaSolMostrarTodo();
            return dt;
        }
        public DataTable ObtenerEntregaSolConFiltro(int TieneParametro, string Parametro)
        {
            string msg = "";
            CDEntrega_Solicitud objEntregaSol = new CDEntrega_Solicitud();
            DataTable dt = new DataTable();
            dt = objEntregaSol.EntregaSolMostrarConFiltro(Parametro);
            return dt;
        }
    }
}
