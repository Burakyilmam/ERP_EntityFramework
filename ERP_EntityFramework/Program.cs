using ERP_EntityFramework.DataAccess.Context;
using ERP_EntityFramework.DataAccess.DALs;
using ERP_EntityFramework.DataAccess.Repositories;
using ERP_EntityFramework_Business.Managers;
using ERP_EntityFramework_Business.Services;
using ERP_EntityFramework_UI;
using ERP_EntityFramework_UI.Forms;
using ERP_EntityFramework_UI.UserForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace ERP_EntityFramework
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            services.AddSingleton<DataContext>();

            services.AddTransient<IUserDAL, UserRepository>();
            services.AddTransient<IUserService, UserManager>();

            services.AddTransient<ISessionDAL, SessionRepository>();
            services.AddTransient<ISessionService, SessionManager>();

            services.AddTransient<ICustomerDAL, CustomerRepository>();
            services.AddTransient<ICustomerService, CustomerManager>();

            services.AddTransient<frmLogin>();
            services.AddTransient<frmHome>();
            services.AddTransient<frmDashboard>();
            services.AddTransient<frmUser>();
            services.AddTransient<frmUserAdd>();
            services.AddTransient<frmCustomer>();
            services.AddTransient<frmCalendar>();

            var serviceProvider = services.BuildServiceProvider();

            var login = serviceProvider.GetRequiredService<frmLogin>();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(serviceProvider.GetRequiredService<frmHome>());
            }
        }
    }
}
