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

namespace CapaPresentacion
{
    public partial class ConsultGeneralEstudiante : Form
    {
        public int vmatricula = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "", mensaje = "";
        CNEstudiante objEstudiante = new CNEstudiante();

        private void ConsultGeneralEstudiante_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void ConsultGeneralEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario!\n Seguro que desea hacerlo?", "Mensaje de Documentacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        public ConsultGeneralEstudiante()
        {
            InitializeComponent();
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)
            {
                indice = DGVDatos.CurrentRow.Index;
            }
        }

        private void PBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BPrimero_Click_1(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BAnterior_Click_1(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice = indice - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BUltimo_Click_1(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BImprimir_Click_1(object sender, EventArgs e)
        {
            ReporteEstudiantes reporte_est = new ReporteEstudiantes();
            reporte_est.ShowDialog();
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BConsultar_Click_1(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty)
            {
                vtieneparametro = 1;
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else
            {
                vtieneparametro = 0;
                valorparametro = "";
            }
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MostrarDatos()
        {
            if (vtieneparametro == 0) 
            {
                DGVDatos.DataSource = objEstudiante.ObtenerEstudiante(); 
            }
            else 
            {
                DGVDatos.DataSource = objEstudiante.ObtenerEstudianteConFiltro(vtieneparametro, valorparametro);
            }
            DGVDatos.Refresh(); 
            LCantEstudiante.Text = Convert.ToString(DGVDatos.RowCount - 1); 
            if (DGVDatos.RowCount <= 0)
            {
                MessageBox.Show("Ningún dato que mostrar!");
            }
        }
    }
}
