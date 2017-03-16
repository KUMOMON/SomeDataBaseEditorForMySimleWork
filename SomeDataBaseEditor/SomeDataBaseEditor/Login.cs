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
            using (var con = new System.Data.SqlClient.SqlConnection())
            {
                con.ConnectionString = "Data Source="+txtBx_ServerAddress.Text.Trim()+";Initial Catalog=UchPlan;"
                                    + "Integrated Security=SSPI;Pooling=False";
                try
                {
                    con.Open();
                    MessageBox.Show("Open");
                    var ada = new System.Data.SqlClient.SqlDataAdapter();
                    con.Close();
                    MessageBox.Show("Close");
                }
                catch
                {
                    MessageBox.Show("Error");
                }

            }


                
        }
    }
}
