using air_3550.Database;

namespace air_3550
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
            DatabaseManager db = DatabaseManager.Instance;
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}