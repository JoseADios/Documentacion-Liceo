using System;
using System.IO;
using System.Collections;
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
    public partial class FormMantenientoTipoDoc : Form
    {
        //variables globales
        public string valorParametro = "", mensaje = "";

        public FormMantenientoTipoDoc()
        {
            InitializeComponent();
        }
        //TODO: poner el nombre del proyecto

        private void FormMantenientoTipoDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Salir?", "Mensaje de DocumetacionLic",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void FormMantenientoTipoDoc_Load(object sender, EventArgs e)
        {
            Program.nuevo = false; //Valores de las variables globales nuevo y modificar
            Program.modificar = false;
            HabilitaBotones(); //Se habilitarán los objetos y los botones necesarios.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }

        //Método propio para limpiar los objetos del formulario

        public void limpiaObjetos()
        {
            textBoxIDTipoDoc.Clear();
            textBoxTipoDoc.Clear();
            cmbbEstado.SelectedIndex = 0;
        }

        //Habilita / inhabilita los objetos del formulario segun lo indicado por el parámetro valor
        private void HabilitaControles(bool valor)
        {
            textBoxIDTipoDoc.ReadOnly = true;
            textBoxTipoDoc.Enabled = valor;
            cmbbEstado.Enabled = valor;

            if (Program.nuevo)
                cmbbEstado.SelectedIndex = 0;
        } // fin del metodo

        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true); //Llamada al método para habilitar los objetos
                btnNuevo2.Enabled = false;
                btnEditar2.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar2.Enabled = true;
                btnBuscar2.Enabled = false;
            }
            else
            {
                HabilitaControles(false); //Llamada al método para inhabilitar los objetos
                btnNuevo2.Enabled = true;
                btnEditar2.Enabled = false;
                btnGuardar.Enabled = false;
                btnCancelar2.Enabled = false;
                btnBuscar2.Enabled = true;
            }
        }
        //TODO: cambiar el estilo de activacion de los botones como el del video


        private void btnNuevo_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(textBoxTipoDoc.Text == String.Empty)  //Si el textbox está vacío mostrar un error y ubicar 
            {
                MessageBox.Show("Debe indicar el nombre del tipo de documento!");
                textBoxTipoDoc.Focus();
                //TODO: hacer que el cuadro muestre un borde rojo que se quite luego de 2 segs
            }
            else if (cmbbEstado.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar el estado del documento!");
                cmbbEstado.Focus();
            }
            else
            {
                if (Program.nuevo)
                {
                    mensaje = CNTiposDocumentaciones.Insertar(Program.vidTipoDoc, textBoxTipoDoc.Text, cmbbEstado.Text);
                }
                else //Actualizamos
                {
                    mensaje = CNTiposDocumentaciones.Actualizar(Program.vidTipoDoc, textBoxTipoDoc.Text, cmbbEstado.Text);
                }
                //TODO: nombre del programa cambiar
                MessageBox.Show(mensaje, "Mensage de DocumentacionLic", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                limpiaObjetos();

            } //fin del else para validar los datos

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        }

        private void FormMantenientoTipoDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidTipoDoc.ToString();
            CNTiposDocumentaciones cNTiposDocs = new CNTiposDocumentaciones();
            DataTable dt = new DataTable();
            dt = cNTiposDocs.ObtenerTiposDocConFiltro(1, vparametro);   //revisar

            foreach(DataRow row in dt.Rows)
            {
                textBoxIDTipoDoc.Text = row["IDTipoDocumento"].ToString();
                textBoxTipoDoc.Text = row["TipoDocumento"].ToString();
                cmbbEstado.Text = row["estado"].ToString();
            }
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            FormBuscarTiposDoc formBuscarTiposDoc = new FormBuscarTiposDoc();
            formBuscarTiposDoc.ShowDialog();

            if (Program.modificar)
            {
                RecuperaDatos();
                btnEditar_Click(sender, e); //llamada al metodo del boton editar
            }
            else
            {
                limpiaObjetos();
                btnBuscar2.Focus();
            }// fin del metodo

        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        {

            limpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            textBoxTipoDoc.Focus();
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {

            if (!textBoxIDTipoDoc.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un un tipo de documento para poder Modificar sus datos!");
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones(); //Habilita los objetos y botones correspondientes
            limpiaObjetos(); //Llama al método LimpiaObjetos
        }

        private void cmbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
