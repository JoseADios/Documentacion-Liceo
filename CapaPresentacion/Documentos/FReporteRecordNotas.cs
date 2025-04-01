using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Documentos
{
    public partial class FReporteRecordNotas : Form
    {
        public FReporteRecordNotas()
        {
            InitializeComponent();
        }

        public int Matricula { get; set; }

        private void FReporteRecordNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetRecordNotas.RecordNotas' Puede moverla o quitarla según sea necesario.
            this.RecordNotasTableAdapter.Fill(this.DataSetRecordNotas.RecordNotas, Matricula);

            this.reportViewer1.RefreshReport();
        }
    }
}
