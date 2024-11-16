using System;
using System.Windows.Forms;

namespace MascotContest
{
    internal static class SysConMasc
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MdiApp());
        }//End-Method
    }//End-Class
}//End-namespace
