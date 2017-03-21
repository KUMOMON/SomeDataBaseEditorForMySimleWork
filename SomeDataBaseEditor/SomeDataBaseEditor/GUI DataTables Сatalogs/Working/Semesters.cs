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
        int _academicPlanId;

        public Semesters():this(0){}

        public Semesters(int academicPlanId)
        {
            _academicPlanId = academicPlanId;
            InitializeComponent();
            семестрыBindingSource.Filter = "[Код учебного плана]=" + academicPlanId;
        }

        private void Semesters_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }
        private void updateDataGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Семестры". При необходимости она может быть перемещена или удалена.
            this.семестрыTableAdapter.Fill(this.uchPlanDataSet.Семестры);
        }

        private void dtGrdVw_SelectionChanged(object sender, EventArgs e)
        {
            if(dtGrdVw.SelectedRows.Count>0)
            {
                numUpDwn_SemesterNum.Value
                    = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[2].Value);
                numUpDwn_countWeeks.Value
                    = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[3].Value);
                numUpDwn_CountExam.Value
                    = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[5].Value);
                numUpDwn_CountOffset.Value
                    = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[7].Value);
                numUpDwn_CountCourseWork.Value
                    = Convert.ToUInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[6].Value);
                numUpDwn_CountCourseProj.Value
                    = Convert.ToUInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[8].Value);
                numUpDwn_hoursOfSport.Value
                    = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[4].Value);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            var NumberOfSemestr = Convert.ToInt32(numUpDwn_SemesterNum.Value);
            var countWeeks = Convert.ToInt16(numUpDwn_countWeeks.Value);
            var hoursSportInWeek = Convert.ToInt16(numUpDwn_hoursOfSport.Value);
            var countExam = Convert.ToInt16(numUpDwn_CountExam.Value);
            var CountCourseWork = Convert.ToInt16(numUpDwn_CountCourseWork.Value);
            var CountOffset = Convert.ToInt16(numUpDwn_CountOffset.Value);
            var CountCourseProj = Convert.ToInt16(numUpDwn_CountCourseProj.Value);

            try
            {
                семестрыTableAdapter.Insert(_academicPlanId,NumberOfSemestr,countWeeks,hoursSportInWeek,countExam,CountCourseWork,CountOffset,CountCourseProj);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value));
            var NumberOfSemestr = Convert.ToInt32(numUpDwn_SemesterNum.Value);
            var countWeeks = Convert.ToInt16(numUpDwn_countWeeks.Value);
            var hoursSportInWeek = Convert.ToInt16(numUpDwn_hoursOfSport.Value);
            var countExam = Convert.ToInt16(numUpDwn_CountExam.Value);
            var CountCourseWork = Convert.ToInt16(numUpDwn_CountCourseWork.Value);
            var CountOffset = Convert.ToInt16(numUpDwn_CountOffset.Value);
            var CountCourseProj = Convert.ToInt16(numUpDwn_CountCourseProj.Value);

            try
            {
                семестрыTableAdapter.Update(_academicPlanId, NumberOfSemestr,hoursSportInWeek,countExam,CountCourseWork,CountOffset,CountCourseProj,countWeeks,curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value));

            try
            {
                семестрыTableAdapter.Delete(curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }

            updateDataGridView();
        }
    }
}
