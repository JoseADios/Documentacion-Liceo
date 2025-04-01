using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ReporteSolicitudes : Form
    {
        public ReporteSolicitudes()
        {
            InitializeComponent();
        }

        private void ReporteSolicitudes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetSolicitudes.Solicitud_documentacion' Puede moverla o quitarla según sea necesario.
            this.Solicitud_documentacionTableAdapter.Fill(this.DataSetSolicitudes.Solicitud_documentacion);

            this.reportViewer1.RefreshReport();
        }
    }
}
