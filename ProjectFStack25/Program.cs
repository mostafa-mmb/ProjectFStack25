using Microsoft.EntityFrameworkCore;
using System;

namespace ProjectFStack25
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

            using (var fStack = new FStack25())
            {
                fStack.Database.Migrate();
            }

            Application.Run(new Form1());
        }
    }
}