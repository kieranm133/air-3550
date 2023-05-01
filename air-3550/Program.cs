/*This program was designed to mimick an aircraft scheduling system. Customers are able to create their account
 and log in to schedule flights. They may also earn points that they may use to schedule flights as well.
Customers are also able to book, view, and cancel flights of their choosing. The system populates
with 6 months of flights that are the same for each day. The customer is also able to view their boarding pass for each flight 
as long as it is prior to 24 hours before the flight takes off. There are 4 other users as well that
are able to manpulate the aircraft system by adding or removing flights, setting the aircraft, 
checking flight manifests, and checking accounting information for the airport.
Authors: Kieran Miller, Brian Armstrong, Brandon Mercer.
5/1/2023
 */
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