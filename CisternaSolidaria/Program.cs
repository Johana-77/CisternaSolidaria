using System;
using System.Threading;
using System.Windows.Forms;

namespace CisternaSolidaria
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Red de seguridad: si algún error no se atrapó, se avisa y la app NO se cierra
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += ErrorInesperado;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormIngreso());
        }

        private static void ErrorInesperado(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Ocurrió un error inesperado: " + e.Exception.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
