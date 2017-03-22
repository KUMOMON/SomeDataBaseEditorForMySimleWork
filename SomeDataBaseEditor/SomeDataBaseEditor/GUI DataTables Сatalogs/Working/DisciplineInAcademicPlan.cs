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
        int _academicPlanID;

        public DisciplineInAcademicPlan():this(0){}

        public DisciplineInAcademicPlan(int academicPlanID)
        {
            
            InitializeComponent();
            _academicPlanID = academicPlanID;
            дисциплинаКакЧастьУчебногоПланаBindingSource.Filter = "[Код учебного плана]="+_academicPlanID;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var DisciplineID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[3].Value);
            using (var form = new GUI_DataTables.Working.DisciplineAcademicPlaneInSemester(_academicPlanID,DisciplineID))
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            
        }

        private void DisciplineInAcademicPlan_Load(object sender, EventArgs e)
        {

            updateDataGridView();
        }

        private void updateDataGridView()
        {
            //данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Дисциплина_как_часть_учебного_плана". При необходимости она может быть перемещена или удалена.
            this.дисциплина_как_часть_учебного_планаTableAdapter.Fill(this.uchPlanDataSet.Дисциплина_как_часть_учебного_плана);
            //данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Кафедры". При необходимости она может быть перемещена или удалена.
            this.кафедрыTableAdapter.Fill(this.uchPlanDataSet.Кафедры);
            //данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Типы_дисциплин". При необходимости она может быть перемещена или удалена.
            this.типы_дисциплинTableAdapter.Fill(this.uchPlanDataSet.Типы_дисциплин);
            //данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.uchPlanDataSet.Дисциплины);
        }

        private void dtGrdVw_SelectionChanged(object sender, EventArgs e)
        {
            if(dtGrdVw.SelectedRows.Count>0)
            {
                //дисциплина, тип, код и кафедра
                cmbBx_nameDiscipline.SelectedValue = (dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[3].Value);
                cmbBx_typeDiscipline.SelectedValue = (dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[5].Value);
                cmbBx_kafedra.SelectedValue = (dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[8].Value);
                txtBx_shifrDiscipline.Text = Convert.ToString(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[6].Value);

                //расчасовка
                numUpDwn_hoursAuditor.Value = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[9].Value);
                numUpDwn_hoursSamost.Value = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[10].Value);
                numUpDwn_vsegoZet.Value = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[11].Value);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            var DisciplineID = Convert.ToInt32(cmbBx_nameDiscipline.SelectedValue);
            var DisciplineShifr = txtBx_shifrDiscipline.Text;
            var KafedraID = Convert.ToInt32(cmbBx_kafedra.SelectedValue);
            var typeDisciplineID = Convert.ToInt32(cmbBx_typeDiscipline.SelectedValue);
            var hoursAuditor = Convert.ToInt16(numUpDwn_hoursAuditor.Value);
            var hoursSamost = Convert.ToInt16(numUpDwn_hoursSamost.Value);
            var vsegoZet = Convert.ToInt16(numUpDwn_vsegoZet.Value);

            try
            {
                дисциплина_как_часть_учебного_планаTableAdapter
                    .Insert(DisciplineID,_academicPlanID,DisciplineShifr,KafedraID,typeDisciplineID,hoursAuditor,hoursSamost,vsegoZet);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {

                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);

            var DisciplineID = Convert.ToInt32(cmbBx_nameDiscipline.SelectedValue);
            var DisciplineShifr = Convert.ToString(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[6].Value);
            var KafedraID = Convert.ToInt32(cmbBx_kafedra.SelectedValue);
            var typeDisciplineID = Convert.ToInt32(cmbBx_typeDiscipline.SelectedValue);
            var hoursAuditor = Convert.ToInt16(numUpDwn_hoursAuditor.Value);
            var hoursSamost = Convert.ToInt16(numUpDwn_hoursSamost.Value);
            var vsegoZet = Convert.ToInt16(numUpDwn_vsegoZet.Value);

            try
            {
                дисциплина_как_часть_учебного_планаTableAdapter
                    .Update(DisciplineID,_academicPlanID,DisciplineShifr,KafedraID,typeDisciplineID,hoursAuditor,hoursSamost,vsegoZet,curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }

            updateDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
            try
            {
                дисциплина_как_часть_учебного_планаTableAdapter.Delete(curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {

                MessageBox.Show(sqlEx.Message);
            }

            updateDataGridView();
        }

        private void btn_realizKompetenc_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);

            using (var form = new GUI_DataTables.Working.RealizCompetenceDiscipline(curID))
                form.ShowDialog();

        }
    }
}
