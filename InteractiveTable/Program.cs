using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InteractiveTable
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //AccidentObj.CreateTable();
            //AccidentObj.UploadTable("Accident1.csv");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            

        }
    }
}
