using Front.Presentacion.Alumnos;

namespace Front
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new FrmGestorAlumno(0));

            //FrmLogin loginForm = new FrmLogin();
            //Application.Run(loginForm);
            //if (loginForm.CredencialesValidas)
                //Application.Run(new FrmPrincipal());
        }
    }
}