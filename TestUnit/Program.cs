using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Handiness.Winform;
using System.Reflection;

namespace TestUnit
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Type type = typeof(AwesomeFont);
            var propertys = type.GetFields();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
