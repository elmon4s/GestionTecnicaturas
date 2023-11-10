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

            FrmLogin loginForm = new FrmLogin();
            Application.Run(loginForm);
            if (loginForm.CredencialesValidas)
                Application.Run(new FrmPrincipal());
        }
    }
}