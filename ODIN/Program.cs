// Program.cs
using ODIN.Models;
using System;
using System.Windows.Forms;

namespace ODIN
{
    internal static class Program
    {
        // Propiedad estática para guardar el usuario logueado
        public static Usuario? UsuarioActual { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciamos con el Login
            Application.Run(new FrmLogin());
        }
    }
}