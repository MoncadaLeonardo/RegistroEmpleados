using System;
using System.Windows.Forms;
using SistemaEmpleadosColegioBautista.Vistas; 

namespace SistemaEmpleadosColegioBautista
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin()); // Abre el formulario de Login
        }
    }
}
