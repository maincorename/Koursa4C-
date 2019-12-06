using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursa4TPI70
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1izd());
        }
    }

    static class Data
    {
        public static string loginCh { get; set; }
        public static string passCh { get; set; }
        public static string loginAdd { get; set; }
        public static string passAdd { get; set; }
        public static int idUser { get; set; }
    }
}
