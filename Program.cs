

using LeQuocHung_BlackMobile.HeThong;
using LeQuocHung_BlackMobile.QuanLy;
using LeQuocHung_BlackMobile.ThongKeBaoCao;
using LeQuocHung_BlackMobile.TimKim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeQuocHung_BlackMobile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new Login());
        }
    }
}
