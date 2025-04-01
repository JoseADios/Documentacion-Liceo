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
    public partial class FormConsultarTiposDocs : Form
    {
        public int vidTipoDoc = 0, vtieneParametro = 0, indice = 1;
        public string valorParametro = "", mensaje = "";
        CNTiposDocumentaciones objTiposDoc = new CNTiposDocumentaciones();

        public FormConsultarTiposDocs()
        {
            InitializeComponent();
        }

        private void dataGridDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridDatos.CurrentRow != null)
                indice = dataGridDatos.CurrentRow.Index;
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {

            if (textBoxBusqueda.Text != String.Empty)
            {
                vtieneParametro = 1;
                valorParametro = "%" + textBoxBusqueda.Text.Trim() + "%";
            }
            else
            {
                vtieneParametro = 0;
                valorParametro = "";
            }
            MostrarDatos();
            textBoxBusqueda.Focus();
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUltimo2_Click(object sender, EventArgs e)
        {

            if (indice < dataGridDatos.RowCount - 1)
            {
                indice = dataGridDatos.Rows.Count - 1;
                dataGridDatos.CurrentCell = dataGridDatos.Rows[indice].Cells[dataGridDatos.CurrentCell.ColumnIndex];
            }
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

            ReporteTiposDocs InstanciaReporte = new ReporteTiposDocs();
            InstanciaReporte.ShowDialog();
        }

        private void FormConsultarTiposDocs_Load(object sender, EventArgs e)
        {
            valorParametro = "";
            vtieneParametro = 0;
            MostrarDatos();
            textBoxBusqueda.Focus();
        }

        private void FormConsultarTiposDocs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?", "Mensaje de SIGEMP",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void MostrarDatos()
        {
            if(vtieneParametro == 0)
            {
                dataGridDatos.DataSource = objTiposDoc.ObtenerTiposDoc();
            }
            else
            {
                dataGridDatos.DataSource = objTiposDoc.ObtenerTiposDocConFiltro(vtieneParametro, valorParametro);
            }
            dataGridDatos.Refresh();
            labelNumTiposDoc.Text = Convert.ToString(dataGridDatos.RowCount-1);

            if (dataGridDatos.RowCount <= 0)
            {
                MessageBox.Show("Ningún dato que mostrar!");
            }
        }


    }
}
