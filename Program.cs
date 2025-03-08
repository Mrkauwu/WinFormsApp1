using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using WinFormsApp1._Repositories;
using WinFormsApp1.Models;
using WinFormsApp1.Presenters;
using WinFormsApp1.Views;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Load configuration from appsettings.json using AppContext.BaseDirectory
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory) // Use BaseDirectory instead
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Read the connection string
            string sqlConnectionString = config.GetConnectionString("DefaultConnection");

            // Initialize views and repositories
            IMainView view = new MainView();
            IPetRepository repository = new PetRepository(sqlConnectionString);
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
