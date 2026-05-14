using System;
using System.Windows.Forms;

namespace pryBarbero_BDAcces
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                // Habilita estilos visuales y ejecuta el formulario principal de la aplicación.
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmPrincipal());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al iniciar el programa:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
