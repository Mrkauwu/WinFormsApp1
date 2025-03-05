using System.Windows.Forms;
using WinFormsApp1._Repositories;
using WinFormsApp1.Models;
using WinFormsApp1.Views;

namespace WinFormsApp1
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
            string sqlConnectionString = "";
            IPetView view = new PetView();
            IPetRepository repository = new PetRepository(sqlConnectionString);
            Application.Run((Form)view);
            
        }
    }
}