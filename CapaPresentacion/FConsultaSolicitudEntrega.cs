using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using CapaPresentacion.SolicitudesReportes;

namespace CapaPresentacion
{
    public partial class FConsultaSolicitudEntrega : Form
    {
        static string conexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\JoSoft\AppConsola\CapaDatos\DBDocumentacion.mdf;Integrated Security=True";
        private int indice = 1, opcion = 1;

        public FConsultaSolicitudEntrega()
        {
            InitializeComponent();
        }

        private void FConsultaSolicitudEntrega_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?", "Mensaje de SIGEMP",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void FConsultaSolicitudEntrega_Load(object sender, EventArgs e)
        {
            //cmbbBuscar.DisplayMember = "Todas las Solicitudes";
            cmbbBuscar.SelectedItem = 0;
            cmbbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridDatos.DataSource = GetSolicitudes();
            dataGridDatos.Refresh();
            labelNumTiposDoc.Text = Convert.ToString(dataGridDatos.RowCount);

        }

        private DataTable GetSolicitudes()
        {
            try
            {

                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    //DataRow renglon;
                    string sql =
                      @"
                        select 	
                        	s.IdSolicitudDocumentacion as ID_Solicitud,
                        	s.FechaSolicitud,
                        	CONCAT_WS(' ', est.Nombres, est.Apellidos) AS Estudiante,
                        	t.TipoDocumento,
                        	s.Solicitante,
                        	e.IdEntregaDocumentacion as ID_Entrega,
                        	e.FechaEntrega as Fecha_Entrega,
                        	e.ReciboPor as Empleado
                        from
                        	Estudiante as est
                        		inner join
                        	Solicitud_documentacion as s on est.Matricula = s.Matricula
                        		left join
                        	Entrega_solicitud as e on s.IdSolicitudDocumentacion = e.IdSolicitudDocumentacion
                        		inner join
                        	TiposDocumentaciones as t on s.IDTipoDocumentacion = t.IDTipoDocumento
                        ;";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("TiposDocumentaciones");

                    dt.Columns.Add(new DataColumn("ID_Solicitud"));
                    dt.Columns.Add(new DataColumn("FechaSolicitud"));
                    dt.Columns.Add(new DataColumn("Estudiante"));
                    dt.Columns.Add(new DataColumn("TipoDocumento"));
                    dt.Columns.Add(new DataColumn("Solicitante"));
                    dt.Columns.Add(new DataColumn("ID_Entrega"));
                    dt.Columns.Add(new DataColumn("Fecha_Entrega"));
                    dt.Columns.Add(new DataColumn("Empleado"));

                    //renglon = dt.NewRow();

                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        private DataTable GetSolicitudesEntregadas()
        {
            try
            {

                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    
                    string sql =
                        @"
                        
                        select 	
                        	s.IdSolicitudDocumentacion as ID_Solicitud,
                        	s.FechaSolicitud,
                        	CONCAT_WS(' ', est.Nombres, est.Apellidos) AS Estudiante,
                        	t.TipoDocumento,
                        	s.Solicitante,
                        	e.IdEntregaDocumentacion as ID_Entrega,
                        	e.FechaEntrega as Fecha_Entrega,
                        	e.ReciboPor as Empleado
                        from
                        	Estudiante as est
                        		inner join
                        	Solicitud_documentacion as s on est.Matricula = s.Matricula
                        		inner join
                        	Entrega_solicitud as e on s.IdSolicitudDocumentacion = e.IdSolicitudDocumentacion
                        		inner join
                        	TiposDocumentaciones as t on s.IDTipoDocumentacion = t.IDTipoDocumento
                        ;";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("TiposDocumentaciones");

                    dt.Columns.Add(new DataColumn("ID_Solicitud"));
                    dt.Columns.Add(new DataColumn("FechaSolicitud"));
                    dt.Columns.Add(new DataColumn("Estudiante"));
                    dt.Columns.Add(new DataColumn("TipoDocumento"));
                    dt.Columns.Add(new DataColumn("Solicitante"));
                    dt.Columns.Add(new DataColumn("ID_Entrega"));
                    dt.Columns.Add(new DataColumn("Fecha_Entrega"));
                    dt.Columns.Add(new DataColumn("Empleado"));


                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        private DataTable GetDatosSolicitudes()
        {
            try
            {

                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    
                    string sql =
                        @"
                        select
                        	*
                        from
                        	Solicitud_documentacion
                        ;";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("TiposDocumentaciones");

                    dt.Columns.Add(new DataColumn("IDSolicitudDocumentacion"));
                    dt.Columns.Add(new DataColumn("IdPeriodo"));
                    dt.Columns.Add(new DataColumn("FechaSolicitud"));
                    dt.Columns.Add(new DataColumn("Matricula"));
                    dt.Columns.Add(new DataColumn("IdEmpleado"));
                    dt.Columns.Add(new DataColumn("IDTipoDocumento"));
                    dt.Columns.Add(new DataColumn("Solicitante"));
                    dt.Columns.Add(new DataColumn("Estado"));
                    dt.Columns.Add(new DataColumn("Observacion"));


                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private DataTable GetDatosEntregaSol()
        {
            try
            {

                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    
                    string sql =
                        @"
                        select
                        	*
                        from
                        	Entrega_solicitud
                        ;";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("TiposDocumentaciones");

                    dt.Columns.Add(new DataColumn("IdEntregaDocumentacion"));
                    dt.Columns.Add(new DataColumn("FechaEntrega"));
                    dt.Columns.Add(new DataColumn("IdEmpleado"));
                    dt.Columns.Add(new DataColumn("IdSolicitudDocumentacion"));
                    dt.Columns.Add(new DataColumn("ReciboPor"));
                    dt.Columns.Add(new DataColumn("Observacion"));

                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {

            if (cmbbBuscar.Text == "Todas las Solicitudes")
            {
                dataGridDatos.DataSource = GetSolicitudes();
                dataGridDatos.Refresh();
                labelNumTiposDoc.Text = Convert.ToString(dataGridDatos.RowCount);
                opcion = 1;
            }
            else if (cmbbBuscar.Text == "Solicitudes entregadas")
            {
                dataGridDatos.DataSource = GetSolicitudesEntregadas();
                dataGridDatos.Refresh();
                labelNumTiposDoc.Text = Convert.ToString(dataGridDatos.RowCount);
                opcion = 2;

            }
            else if (cmbbBuscar.Text == "Tabla de Solicitudes")
            {
                dataGridDatos.DataSource = GetDatosSolicitudes();
                dataGridDatos.Refresh();
                labelNumTiposDoc.Text = Convert.ToString(dataGridDatos.RowCount);
                opcion = 3;

            }
            else if (cmbbBuscar.Text == "Tabla de entregas")
            {
                dataGridDatos.DataSource = GetDatosEntregaSol();
                dataGridDatos.Refresh();
                labelNumTiposDoc.Text = Convert.ToString(dataGridDatos.RowCount);
                opcion = 4;

            }
        }

        private void dataGridDatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridDatos.Columns[e.ColumnIndex].Name == "ID_Entrega")
            {
                if (Convert.ToString(e.Value) == "")
                {
                    e.CellStyle.BackColor = Color.DarkOrange;
                    e.Value = "No entregada";
                }
                else
                {
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }

        private void btnUltimo2_Click(object sender, EventArgs e)
        {
            if (indice < dataGridDatos.RowCount - 1)
            {
                indice = dataGridDatos.Rows.Count - 1;
                dataGridDatos.CurrentCell = dataGridDatos.Rows[indice].Cells[dataGridDatos.CurrentCell.ColumnIndex];
            }
        }

        private void dataGridDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridDatos.CurrentRow != null)
                indice = dataGridDatos.CurrentRow.Index;
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            if (indice < dataGridDatos.RowCount - 1)
            {
                indice++;
                dataGridDatos.CurrentCell = dataGridDatos.Rows[indice].Cells[dataGridDatos.CurrentCell.ColumnIndex];
            }
        }

        private void btnAnterior2_Click(object sender, EventArgs e)
        {

            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {
                indice = indice - 1;
                dataGridDatos.CurrentCell = dataGridDatos.Rows[indice].Cells[dataGridDatos.CurrentCell.ColumnIndex];
            }
        }

        private void btnPrimero2_Click(object sender, EventArgs e)
        {

            if (dataGridDatos.Rows.Count > 1)
            {
                indice = 0;
                dataGridDatos.CurrentCell = dataGridDatos.Rows[indice].Cells[dataGridDatos.CurrentCell.ColumnIndex];
            }
        }

        private void btnImprimir2_Click(object sender, EventArgs e)
        {
            CreaReporte();
        }


        private void CreaReporte()
        {

            if (opcion == 1)
            {
                FReporteSoliRelacion fReporteSoliRelacion = new FReporteSoliRelacion();
                fReporteSoliRelacion.ShowDialog();

            }
            else if (opcion == 2)
            {
                FSoliEntregada fSoliEntregada = new FSoliEntregada();
                fSoliEntregada.ShowDialog();
            }
            else if (opcion == 3)
            {
                ReporteSolicitudes reporteSolicitudes = new ReporteSolicitudes();
                reporteSolicitudes.ShowDialog();

            }
            else if (opcion == 4)
            {
                FRepEntregaDoc fRepEntregaDoc = new FRepEntregaDoc();
                fRepEntregaDoc.ShowDialog();
            }
        }
    }
}
