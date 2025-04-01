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
    public partial class FRepEntregaDoc : Form
    {
        public FRepEntregaDoc()
        {
            InitializeComponent();
        }

        private void FRepEntregaDoc_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetSolicitudes.Entrega_SolMostrarTodo' Puede moverla o quitarla según sea necesario.
            this.entrega_SolMostrarTodoTableAdapter.Fill(this.dataSetSolicitudes.Entrega_SolMostrarTodo);

            this.reportViewer1.RefreshReport();
        }
    }
}
