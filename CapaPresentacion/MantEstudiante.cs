using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MatnEstudiante : Form
    {
        public string valorparametro = "", mensaje = "";

        public MatnEstudiante()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private DataTable GetCursoActual()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\JoSoft\AppConsola\CapaDatos\DBDocumentacion.mdf;Integrated Security=True"))
                {
                    string sql =
                      "SELECT IdCurso, (Grado + ' ' + Seccion) AS NombreCurso FROM Curso";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("Curso");

                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void MatnEstudiante_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void LimpiaObjetos()
        {
            tbMatricula.Clear();
            tbNombres.Clear();
            tbApellidos.Clear();
            tbDireccion.Clear();
            tbTelefono.Clear();
            cbSexo.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
        }

        private void HabilitaControles(bool valor)
        {
            tbMatricula.ReadOnly = true;
            tbNombres.Enabled = valor;
            tbApellidos.Enabled = valor;
            tbDireccion.Enabled = valor;
            tbTelefono.Enabled = valor;
            cbSexo.Enabled = valor;
            dtpFechaNacimiento.Enabled = valor;
            cbEstado.Enabled = valor;
            CBCursoActual.Enabled = valor;

            if (Program.nuevo)
            {
                cbEstado.SelectedIndex = 0;
            }
        }


        private void MatnEstudiante_Load(object sender, EventArgs e)
        {
            Program.nuevo = false; 
            Program.modificar = false;
            HabilitaBotones();

            try
            {
                CBCursoActual.DataSource = GetCursoActual();
                CBCursoActual.DisplayMember = "NombreCurso";
                CBCursoActual.ValueMember = "IdCurso";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void MatnEstudiante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vMatricula.ToString();
            CNEstudiante CnEstudiante = new CNEstudiante();
            DataTable dt = new DataTable();
            dt = CnEstudiante.ObtenerEstudianteConFiltro(1, vparametro);

            foreach (DataRow row in dt.Rows)
            {
                tbMatricula.Text = row["Matricula"].ToString();
                tbNombres.Text = row["Nombres"].ToString();
                tbApellidos.Text = row["Apellidos"].ToString();
                tbDireccion.Text = row["Dirección"].ToString();
                tbTelefono.Text = row["Telefono"].ToString();
                cbSexo.Text = row["Sexo"].ToString();
                dtpFechaNacimiento.Text = row["FechaNacimiento"].ToString();
                cbEstado.Text = row["Estado"].ToString();
                CBCursoActual.SelectedValue = row["IDCursoActual"].ToString();
            }
        }

        private void BNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbMatricula.Focus();
        }

        private void BGuardar_Click_1(object sender, EventArgs e)
        {
            if (tbNombres.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del estudiante!");
                tbNombres.Focus();
            }
            else if (tbApellidos.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar los apellidos del estudiante!");
                tbApellidos.Focus();
            }
            else if (tbDireccion.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la direccion del estudiante!");
                tbDireccion.Focus();
            }
            else if (tbTelefono.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el telefono del estudiante!");
                tbTelefono.Focus();
            }
            else if (cbSexo.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el sexo del/la estudiante!");
                cbSexo.Focus();
            }
            else if (dtpFechaNacimiento.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la fehca de nacimiento del estudiante!");
                dtpFechaNacimiento.Focus();
            }
            else if (cbEstado.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el estado del estudiante!");
                cbEstado.Focus();
            }
            else if (CBCursoActual.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el id del curso actual del estudiante!");
                CBCursoActual.Focus();
            }
            else
            {
                int intIdCursoActual = Convert.ToInt32(CBCursoActual.SelectedValue);
                DateTime FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
                if (Program.nuevo)
                {
                    mensaje = CNEstudiante.Insertar(Program.vMatricula, tbNombres.Text, tbApellidos.Text, tbDireccion.Text, tbTelefono.Text, cbSexo.Text, FechaNacimiento, cbEstado.Text, intIdCursoActual);
                }
                else
                {
                    mensaje = CNEstudiante.Actualizar(Program.vMatricula, tbNombres.Text, tbApellidos.Text, tbDireccion.Text, tbTelefono.Text, cbSexo.Text, FechaNacimiento, cbEstado.Text, intIdCursoActual);
                }

                MessageBox.Show(mensaje, "Mensage de Documentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }
        }

        private void BEditar_Click_1(object sender, EventArgs e)
        {
            if (!tbMatricula.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Estudiante para poder Modificar sus datos!");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBuscar_Click_1(object sender, EventArgs e)
        {
            FBuscarEstudiante fBuscarEstudiante = new FBuscarEstudiante();
            fBuscarEstudiante.ShowDialog();
            if (Program.modificar)
            {
                RecuperaDatos();
                BEditar_Click_1(sender, e);
            }
            else
            {
                LimpiaObjetos();
                BBuscar.Focus();
            }
        }

        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true);
                BNuevo.Enabled = false;
                BGuardar.Enabled = true;
                BEditar.Enabled = false;
                BBuscar.Enabled = false;
                BCancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false);
                BNuevo.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = false;
                BBuscar.Enabled = true;
                BCancelar.Enabled = false;
            }
        }
    }
}
