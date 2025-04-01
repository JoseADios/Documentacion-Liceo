using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class ReporteTiposDocs : Form
    {
        public ReporteTiposDocs()
        {
            InitializeComponent();
        }

        private void ReporteTiposDocs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTiposDoc.TiposDocumentaciones' Puede moverla o quitarla según sea necesario.
            this.tiposDocumentacionesTableAdapter.Fill(this.dataSetTiposDoc.TiposDocumentaciones);
            
            //ReportDataSource rds = new ReportDataSource();
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteTipoDocs.rdlc";

            this.reportViewer1.RefreshReport();
        }
    }
}
