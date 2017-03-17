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
    public partial class AcademicPlans : Form
    {
        const long someIDFromAcademicPlan = 0;

        public AcademicPlans()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Открывает семестры учебного плана
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Working.Semesters(someIDFromAcademicPlan))
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Working.DisciplineInAcademicPlan(someIDFromAcademicPlan))
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void AcademicPlans_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Учебные_планы". При необходимости она может быть перемещена или удалена.
            this.учебные_планыTableAdapter.Fill(this.uchPlanDataSet.Учебные_планы);

        }
    }
}
