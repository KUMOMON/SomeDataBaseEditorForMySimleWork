using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomeDataBaseEditor.GUI_DataTables.Working
{
    public partial class DisciplineInAcademicPlan : Form
    {
        const long someIDFromAcademicPlan = 0;
        const long someIDFromDisciplineAcademicPlan= 0;

        long _academicPlanID;

        public DisciplineInAcademicPlan():this(0){}

        public DisciplineInAcademicPlan(long academicPlanID)
        {
            _academicPlanID = academicPlanID;
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Working.DisciplineAcademicPlaneInSemester(someIDFromAcademicPlan,someIDFromDisciplineAcademicPlan))
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
