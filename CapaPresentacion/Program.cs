using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        // variables globales para el proyecto

        public static int vidAsignatura = 0;
        public static int vidCalificaciones = 0;
        public static int vidCurso = 0;
        public static int vidEmpleado = 0;
        public static int vidEntregaSol = 0;
        public static int vMatricula = 0;
        public static int vidPeriodo = 0;
        public static int vidSolicitudDoc = 0;
        public static int vidTipoDoc = 0;
        public static bool nuevo = false;
        public static bool modificar = false;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenuPrincipal());
        }
    }
}
