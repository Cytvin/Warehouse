using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Presenters;
using Warehouse.Fasades;

namespace Warehouse
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainPresenter mainPresenter = new MainPresenter(new MainForm(), new ProductFacade(), new DocumentFacade());
            mainPresenter.Run();
        }
    }
}
