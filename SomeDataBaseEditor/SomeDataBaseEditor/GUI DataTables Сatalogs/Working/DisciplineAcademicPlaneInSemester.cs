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
    public partial class DisciplineAcademicPlaneInSemester : Form
    {
        long _academicPlanID;
        long _DisciplineIDInAcademicPlan;

        public DisciplineAcademicPlaneInSemester():this(0,0){}
        public DisciplineAcademicPlaneInSemester(long academicPlan, long DisciplineIDInAcademicPlan)
        {
            _academicPlanID = academicPlan;
            _DisciplineIDInAcademicPlan = DisciplineIDInAcademicPlan;
            InitializeComponent();
        }

        private void DisciplineAcademicPlaneInSemester_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Дисциплина_как_часть_семестра". При необходимости она может быть перемещена или удалена.
            this.дисциплина_как_часть_семестраTableAdapter.Fill(this.uchPlanDataSet.Дисциплина_как_часть_семестра);

        }
    }
}
