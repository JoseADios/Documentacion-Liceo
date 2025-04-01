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
    public partial class FBuscarEstudiante : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";
        CNEstudiante CnEstudiante = new CNEstudiante();

        private void FBuscarEstudiante_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vMatricula = 0; 
            MostrarDatos(); 
            tbBuscar.Focus();
        }

        private void FBuscarEstudiante_FormClosing(object sender, FormClosingEventArgs e)
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

        public FBuscarEstudiante()
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

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false; 
            Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) 
            {
                Program.modificar = true;
                Program.vMatricula = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
            }
            Close();
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BAntenior_Click(object sender, EventArgs e)
        {
            if (indice > 0) 
            {
                indice = indice - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) 
            {
                indice = DGVDatos.Rows.Count - 1; 
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            BAceptar_Click(sender, e);
        }

        private void BBuscarDato_Click(object sender, EventArgs e)
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
        }

        private void MostrarDatos()
        {
            if (vtieneparametro == 0) 
            {
                DGVDatos.DataSource = CnEstudiante.ObtenerEstudiante();
            }
            else
            {
                if (CnEstudiante.ObtenerEstudianteConFiltro(vtieneparametro, valorparametro) != null)
                {
                    DGVDatos.DataSource = CnEstudiante.ObtenerEstudianteConFiltro(vtieneparametro, valorparametro);
                }
                else
                {
                    MessageBox.Show("No se retornó ningún valor!");
                }
            }

            DGVDatos.Refresh(); 
            if (DGVDatos.RowCount <= 0) 
            {
                MessageBox.Show("Ningún dato que mostrar!"); 
            }
            else 
            {
                DGVDatos.Columns[0].Width = 80; //Matricula
                DGVDatos.Columns[1].Width = 200; //Nombres
                DGVDatos.Columns[2].Width = 225; //Apellidos
                DGVDatos.Columns[3].Width = 100; //Direccion
                DGVDatos.Columns[4].Width = 125; //Telefono
                DGVDatos.Columns[5].Width = 125; //Sexo
                DGVDatos.Columns[6].Width = 150; //FehcaNacimiento
                DGVDatos.Columns[7].Width = 100; //Estado
                DGVDatos.Columns[8].Width = 90; //IDCursoActual
            }

            DGVDatos.Refresh();


        }
    }
}
