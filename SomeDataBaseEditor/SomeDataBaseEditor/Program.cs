using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SomeDataBaseEditor
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
            using (var logForm = new Login())
            {
                Application.Run(logForm);
                if (logForm.DialogResult == DialogResult.Yes)
                {
                    using (var formMenu = new MainMenu())
                        formMenu.ShowDialog();

                    Settings.disconectServer();
                }
            }
                
            
        }
    }
}
