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
    public class CNSolicitud_Documentacion
    {
        public static string Insertar(int pIdSolicitudDocumentacion,
            int pIdPeriodo,
            DateTime pFechaSolicitud,
            int pMatricula,
            int pIdEmpleado,
            int pIDTipoDocumento,
            string pSolicitante,
            string pEstado,
            string pObservacion)
        {
            CDSolicitud_Documentacion objSolicitudDoc = new CDSolicitud_Documentacion();

            objSolicitudDoc.IdSolicitudDocumentacion = pIdSolicitudDocumentacion;
            objSolicitudDoc.IdPeriodo = pIdPeriodo;
            objSolicitudDoc.FechaSolicitud = pFechaSolicitud;
            objSolicitudDoc.Matricula = pMatricula;
            objSolicitudDoc.IdEmpleado = pIdEmpleado;
            objSolicitudDoc.IDTipoDocumento = pIDTipoDocumento;
            objSolicitudDoc.Solicitante = pSolicitante;
            objSolicitudDoc.Estado = pEstado;
            objSolicitudDoc.Observacion = pObservacion;

            return objSolicitudDoc.Insertar(objSolicitudDoc);
        }

        public static string Actualizar(int pIdSolicitudDocumentacion,
            int pIdPeriodo,
            DateTime pFechaSolicitud,
            int pMatricula,
            int pIdEmpleado,
            int pIDTipoDocumento,
            string pSolicitante,
            string pEstado,
            string pObservacion)
        {
            CDSolicitud_Documentacion objSolicitudDoc = new CDSolicitud_Documentacion();

            objSolicitudDoc.IdSolicitudDocumentacion = pIdSolicitudDocumentacion;
            objSolicitudDoc.IdPeriodo = pIdPeriodo;
            objSolicitudDoc.FechaSolicitud = pFechaSolicitud;
            objSolicitudDoc.Matricula = pMatricula;
            objSolicitudDoc.IdEmpleado = pIdEmpleado;
            objSolicitudDoc.IDTipoDocumento = pIDTipoDocumento;
            objSolicitudDoc.Solicitante = pSolicitante;
            objSolicitudDoc.Estado = pEstado;
            objSolicitudDoc.Observacion = pObservacion;

            return objSolicitudDoc.Actualizar(objSolicitudDoc);
        }

        public DataTable ObtenerSolicitudDoc()
        {
            string msg = "";
            CDSolicitud_Documentacion objSolDoc = new CDSolicitud_Documentacion();
            DataTable dt = new DataTable();
            dt = objSolDoc.SolicitudDocMostrarTodo();
            return dt;
        }
        public DataTable ObtenerEstudianteConFiltro(int TieneParametro, string Parametro)
        {
            string msg = "";
            CDSolicitud_Documentacion objEstudiante = new CDSolicitud_Documentacion();
            DataTable dt = new DataTable();
            dt = objEstudiante.SolicitudoDocMostrarConFiltro(Parametro);
            return dt;
        }
    }
}
