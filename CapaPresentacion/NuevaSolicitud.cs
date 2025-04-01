using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using CapaNegocio;
using CapaPresentacion.Documentos;

namespace CapaPresentacion
{
    public partial class NuevaSolicitud : Form
    {
        static string conexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\JoSoft\AppConsola\CapaDatos\DBDocumentacion.mdf;Integrated Security=True";
        public string valorparametro = "", mensaje = "";


        public NuevaSolicitud()
        {
            InitializeComponent();
        }

        private void NuevaSolicitud_FormClosing(object sender, FormClosingEventArgs e)
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

        private DataTable GetPeriodo()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    string sql =
                      "SELECT IdPeriodo, Periodo FROM Periodo";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("Periodo");

                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private DataTable GetMatricula()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    string sql =
                      "SELECT Matricula FROM Estudiante";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("Estudiante");

                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //__---------------------------Para el reporte
        
        private string GetNombreEstudiante()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    string sql =
                        $"SELECT (Nombres + ' ' + Apellidos) AS NombreC FROM Estudiante where Matricula = {CBMatricula.Text}";
                    

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("Estudiante");

                    da.Fill(dt);

                    //string nombreCompletoE = Convert.ToString(dt.Rows[0]["String"]);
                    DataRow row = dt.Rows[0];
                    string nombreCompletoE = row["NombreC"].ToString(); ;

                    return nombreCompletoE;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //-------------Para guardar en entrega solicitud-------------
        private string GetUltimoIndiceSDoc()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    string sql =
                        $"select max(IdSolicitudDocumentacion) from Solicitud_documentacion;";


                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("Solicitud_Documentacion");

                    da.Fill(dt);

                    //string nombreCompletoE = Convert.ToString(dt.Rows[0]["String"]);
                    DataRow row = dt.Rows[0];
                    //int ultimoIndice = Convert.ToInt32(dt.Rows[0]["ultimo"]);
                    //int ultimoIndice = Convert.ToInt32(row["ultimo"]);
                    /*string*/
                    string ultimoIndice = row[0].ToString();

                    return ultimoIndice;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private DataTable GetEmpleado()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    string sql =
                      "SELECT IDEmpleado, (Nombres + ' ' + Apellidos) AS NombreCompleto FROM Empleado";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("Empleado");

                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private DataTable GetTipoDocumentacion()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(conexion))
                {
                    string sql =
                      "SELECT IDTipoDocumento, TipoDocumento FROM TiposDocumentaciones";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);

                    DataTable dt = new DataTable("TiposDocumentaciones");

                    da.Fill(dt);

                    return dt;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void NuevaSolicitud_Load(object sender, EventArgs e)
        {
            try
            {
                CBEstado.SelectedIndex = 0;

                CBPeriodo.DataSource = GetPeriodo();
                CBPeriodo.DisplayMember = "Periodo";
                CBPeriodo.ValueMember = "IdPeriodo";

                CBMatricula.DataSource = GetMatricula();
                CBMatricula.DisplayMember = "Matricula";
                CBMatricula.ValueMember = "Matricula";

                CBEmpleado.DataSource = GetEmpleado();
                CBEmpleado.DisplayMember = "NombreCompleto";
                CBEmpleado.ValueMember = "IDEmpleado";

                CBTipoDocumento.DataSource = GetTipoDocumentacion();
                CBTipoDocumento.DisplayMember = "TipoDocumento";
                CBTipoDocumento.ValueMember = "IDTipoDocumento";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click_1(object sender, EventArgs e)
        {
            if (CBPeriodo.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el preríodo!");
                CBPeriodo.Focus();
            }
            else if (DTPFecha.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la fecha!");
                DTPFecha.Focus();
            }
            else if (CBMatricula.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la matricula del/la estudiante!");
                CBMatricula.Focus();
            }
            else if (CBEmpleado.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el empleado!");
                CBEmpleado.Focus();
            }
            else if (CBTipoDocumento.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el ripo de documento!");
                CBTipoDocumento.Focus();
            }
            else if (TBSolicitante.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el solicitante!");
                TBSolicitante.Focus();
            }
            else if (CBEstado.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el estado!");
                CBEstado.Focus();
            }
            else
            {
                int intIdPeriodo = Convert.ToInt32(CBPeriodo.SelectedValue);
                DateTime Fecha = DateTime.Parse(DTPFecha.Text);
                int intMatricula = int.Parse(CBMatricula.Text);
                int intIdEmpleado = Convert.ToInt32(CBEmpleado.SelectedValue);
                int intTipoDocumento = Convert.ToInt32(CBTipoDocumento.SelectedValue);

                mensaje = CNSolicitud_Documentacion.Insertar(Program.vidTipoDoc, intIdPeriodo, Fecha, intMatricula, intIdEmpleado, intTipoDocumento, TBSolicitante.Text, CBEstado.Text, TBObservacion.Text);

                MessageBox.Show(mensaje, "Mensage de Documentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //BCancelar_Click(sender, e);
                TBSolicitante.Clear();
                CBEstado.SelectedIndex = 0;
                TBObservacion.Clear();

                if (CBTipoDocumento.Text == "Carta de recomendacion")
                {
                    pasaDatosReporteCartaRec();

                }
                else if (CBTipoDocumento.Text == "Record de Notas")
                {
                    FReporteRecordNotas instRecordNotas = new FReporteRecordNotas();
                    instRecordNotas.Matricula = intMatricula;
                    instRecordNotas.ShowDialog();
                }
            }
        }

        private void BCancelar_Click_1(object sender, EventArgs e)
        {
            CBPeriodo.SelectedIndex = 0;
            CBMatricula.SelectedIndex = 0;
            CBEmpleado.SelectedIndex = 0;
            CBTipoDocumento.SelectedIndex = 0;
            TBSolicitante.Clear();
            CBEstado.SelectedIndex = 0;
            TBObservacion.Clear();
        }

        private void BSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void pasaDatosReporteCartaRec()
        {

            FReporteCartaRec instanciaRepCRec = new FReporteCartaRec();
            instanciaRepCRec.NombreComp = GetNombreEstudiante();
            instanciaRepCRec.idEst = CBMatricula.Text;
            instanciaRepCRec.ultimoIndice =GetUltimoIndiceSDoc();
            instanciaRepCRec.idEmpleado = Convert.ToInt32(CBEmpleado.SelectedValue);
            instanciaRepCRec.nombreEmpleado = CBEmpleado.Text;
            instanciaRepCRec.ShowDialog();

        }



    }
}
