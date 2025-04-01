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
    public partial class FormBuscarTiposDoc : Form
    {
        public int vidTipoDoc = 0, vtieneParametro = 0, indice = 1;
        public string valorParametro = "", mensaje = "";

        //Boton aceptar
        private void btnVolver_Click(object sender, EventArgs e)
        {
        }

        private void panelInferior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormConsultaTiposDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
                "Mensaje de DocumentacionLic",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        CNTiposDocumentaciones objTiposDoc = new CNTiposDocumentaciones();

        private void dataGridDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridDatos.CurrentRow != null)
                indice = dataGridDatos.CurrentRow.Index;
        }

        private void FormConsultaTiposDoc_Load_1(object sender, EventArgs e)
        {
            valorParametro = "";
            vtieneParametro = 0;
            Program.vMatricula = 0;
            mostrarDatos();
            textBoxBusqueda.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void FormConsultaTiposDoc_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            btnVolver_Click(sender, e);
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {

            if (btnBuscar2.Text != String.Empty)
            {
                vtieneParametro = 1;
                valorParametro = "%" + textBoxBusqueda.Text.Trim() + "%";
            }
            else
            {
                vtieneParametro = 0;
                valorParametro = "";
            }
            mostrarDatos();
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {

            if (dataGridDatos.CurrentRow != null)
            {
                Program.modificar = true;
                Program.vidTipoDoc = Convert.ToInt32(dataGridDatos.CurrentRow.Cells[0].Value);
            }
            Close();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {

            Program.modificar = false;
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

            if (indice > 0)
            {
                indice--;
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

        public FormBuscarTiposDoc()
        {
            InitializeComponent();
        }

        private void FormConsultaTiposDoc_Load(object sender, EventArgs e)
        {
            

        }

        private void mostrarDatos()
        {
            if(vtieneParametro == 0)
            {
                dataGridDatos.DataSource = objTiposDoc.ObtenerTiposDoc();
            }
            else
            {
                if (objTiposDoc.ObtenerTiposDocConFiltro(vtieneParametro, valorParametro) != null)
                {
                    dataGridDatos.DataSource = objTiposDoc.ObtenerTiposDocConFiltro(vtieneParametro, valorParametro);
                }
                else
                {
                    MessageBox.Show("No se retornó ningún valor!");
                }
                //dataGridDatos.DataSource = objTiposDoc.ObtenerTiposDocConFiltro(vtieneParametro, valorParametro);
            }


            dataGridDatos.Refresh();
            labelNumTiposDoc.Text = Convert.ToString(dataGridDatos.RowCount-1);

            if (dataGridDatos.RowCount <= 0)
            {
                MessageBox.Show("Ningún dato que mostrar!");
            }
            else
            {
                dataGridDatos.Columns[0].Width = 80;    //IDTipoDocumento
                dataGridDatos.Columns[1].Width = 200;    //TipoDocumento
                dataGridDatos.Columns[2].Width = 100;    //estado

            }
            dataGridDatos.Refresh();

        }
    }
}
