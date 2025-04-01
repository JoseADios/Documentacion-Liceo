using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FRegistroEntrega : Form
    {
        public string mensaje = "";
        public int idEmpleado;
        public string ultimoIndice, nombreEmpleado, observacion;

        public FRegistroEntrega()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int vMsg, int wParan, int lParam);


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void iconButtonAceptar_Click(object sender, EventArgs e)
        {
            observacion = textBox1.Text;
            guardaEntrega();
        }


        private void guardaEntrega()
        {
            mensaje = CNEntrega_Solicitud.Insertar(Program.vidEntregaSol, DateTime.Now, idEmpleado, int.Parse(ultimoIndice), nombreEmpleado, observacion);
            MessageBox.Show(mensaje, "Mensage de Documentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
