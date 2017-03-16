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
    }
}
