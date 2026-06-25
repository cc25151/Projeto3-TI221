// Integrantes:
// Gabriel Bellini Camargo - 25131
// Pedro Henrique Sakamoto Mendes - 25151

namespace apCalculadora
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
            Application.Run(new FrmCalculadora());
        }
    }
}