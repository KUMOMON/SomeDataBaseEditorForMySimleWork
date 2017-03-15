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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new System.Data.SqlClient.SqlConnection())
            {
                con.ConnectionString = "Data Source=.\\SQLEXPRESS2014;Initial Catalog=UchPlan;"
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
