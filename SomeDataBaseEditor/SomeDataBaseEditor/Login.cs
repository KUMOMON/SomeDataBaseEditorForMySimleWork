using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomeDataBaseEditor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void conn_btn1_Click(object sender, EventArgs e)
        {
            bool loginResult = Settings.connectToServer(txtBx_ServerAddress.Text, null, null);

            if (loginResult)
            {
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
                MessageBox.Show("Ошибка.","Параметры авторизации заданы не верно.",MessageBoxButtons.OK);
        }
    }
}
