using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Threading;
using DevExpress.XtraEditors;

namespace ReportesDevExpress
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
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-DO");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-DO");
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Idioma);
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Idioma);
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Fluent;
            BonusSkins.Register();
            Application.Run(new ReporteForm());
            //Application.Run(new RibbonForm1());
        }
    }
}
