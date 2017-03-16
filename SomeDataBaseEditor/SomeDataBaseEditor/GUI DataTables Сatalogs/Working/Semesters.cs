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
    public partial class Semesters : Form
    {
        long _academicPlanId;

        public Semesters():this(0){}

        public Semesters(long academicPlanId)
        {
            _academicPlanId = academicPlanId;
            InitializeComponent();
        }
    }
}
