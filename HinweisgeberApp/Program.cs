using HinweisgeberApp.Data;
using Microsoft.EntityFrameworkCore;

namespace HinweisgeberApp
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

            //// Configure DbContextOptions with the connection string
            //var optionsBuilder = new DbContextOptionsBuilder<DbHinweisContext>()
            //    .UseSqlServer("server=195.201.138.127; database = HWMainDB; user id = sa; password = 123Tobi123!; TrustServerCertificate=true;");

            //using (var context = new DbHinweisContext())
            //{
            //    context.ApplyMigrations();
            //}
            var context1 = new DbHinweisContext();
            Application.Run(new partnerhinzufuegenForm(context1));
        }
    }
}