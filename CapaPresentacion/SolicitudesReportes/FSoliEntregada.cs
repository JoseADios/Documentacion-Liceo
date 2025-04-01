using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.SolicitudesReportes
{
    public partial class FSoliEntregada : Form
    {
        public FSoliEntregada()
        {
            InitializeComponent();
        }

        private void FSoliEntrgada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetSolicitudes.DataTableSoliEntregadas' Puede moverla o quitarla según sea necesario.
            this.dataTableSoliEntregadasTableAdapter.Fill(this.dataSetSolicitudes.DataTableSoliEntregadas);

            this.reportViewer1.RefreshReport();
        }
    }
}
