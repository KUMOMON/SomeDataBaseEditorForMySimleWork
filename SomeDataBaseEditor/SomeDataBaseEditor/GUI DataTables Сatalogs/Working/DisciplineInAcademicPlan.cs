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

        public DisciplineInAcademicPlan() : this(0) { }

        public DisciplineInAcademicPlan(int academicPlanID)
        {

            InitializeComponent();
            _academicPlanID = academicPlanID;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var DisciplineID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[3].Value);
            using (var form = new GUI_DataTables.Working.DisciplineAcademicPlaneInSemester(_academicPlanID, DisciplineID))
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
            #region query
            /*
             * [0][Дисциплина как часть учебного плана].Код
             * [1][Дисциплина как часть учебного плана].[Код учебного плана]
             * [2]Дисциплины.Имя
             * [3][Дисциплина как часть учебного плана].[Код дисциплины]
             * [4][Дисциплина как часть учебного плана].[Кодовое обозначение дисциплины]
             * [5]Кафедры.Имя
             * [6][Дисциплина как часть учебного плана].[Код кафедры]
             * [7][Типы дисциплин].Тип
             * [8][Дисциплина как часть учебного плана].[Код Тип Дисциплины]
             * [9][Дисциплина как часть учебного плана].[Часы аудиторные]
             * [10][Дисциплина как часть учебного плана].КСР
             * [11][Дисциплина как часть учебного плана].[Часы Самостоятельные]
             * [12][Дисциплина как часть учебного плана].[Всего ЗЕТ]
             */
            var query = "SELECT [Дисциплина как часть учебного плана].Код, [Дисциплина как часть учебного плана].[Код учебного плана], Дисциплины.Имя AS[Имя Дисциплины], [Дисциплина как часть учебного плана].[Код дисциплины], "
                         + " [Дисциплина как часть учебного плана].[Кодовое обозначение дисциплины], Кафедры.Имя AS[Имя кафедры], [Дисциплина как часть учебного плана].[Код кафедры], [Типы дисциплин].Тип AS[Тип дисциплины], "
                         + " [Дисциплина как часть учебного плана].[Код Тип Дисциплины], [Дисциплина как часть учебного плана].[Часы аудиторные], [Дисциплина как часть учебного плана].КСР, [Дисциплина как часть учебного плана].[Часы Самостоятельные], "
                         + " [Дисциплина как часть учебного плана].[Всего ЗЕТ] "
                         + " FROM[Дисциплина как часть учебного плана] "
                         + " INNER JOIN Дисциплины ON[Дисциплина как часть учебного плана].[Код дисциплины] = Дисциплины.Код "
                         + " INNER JOIN [Типы дисциплин] ON[Дисциплина как часть учебного плана].[Код Тип Дисциплины] = [Типы дисциплин].Код "
                         + " INNER JOIN Кафедры ON[Дисциплина как часть учебного плана].[Код кафедры] = Кафедры.Код "
                         + " WHERE([Дисциплина как часть учебного плана].[Код учебного плана] = " + _academicPlanID + ")";
            #endregion

            DataTable dt = helpers.GetDataTable(query);

            dtGrdVw.DataSource = dt;

            foreach (int i in new int[] {0,1,3,6,8})
                dtGrdVw.Columns[i].Visible = false;

            dtGrdVw.AutoResizeColumns();

            //данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Кафедры". При необходимости она может быть перемещена или удалена.
            this.кафедрыTableAdapter.Fill(this.uchPlanDataSet.Кафедры);
            //данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Типы_дисциплин". При необходимости она может быть перемещена или удалена.
            this.типы_дисциплинTableAdapter.Fill(this.uchPlanDataSet.Типы_дисциплин);
            //данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.uchPlanDataSet.Дисциплины);

            if (dtGrdVw.Rows.Count > 0)
                dtGrdVw.Select();
        }

        private void dtGrdVw_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGrdVw.SelectedRows.Count > 0)
            {
                //дисциплина, тип, код и кафедра
                cmbBx_nameDiscipline.SelectedValue = (dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[3].Value);
                cmbBx_typeDiscipline.SelectedValue = (dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[8].Value);
                cmbBx_kafedra.SelectedValue = (dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[6].Value);
                txtBx_shifrDiscipline.Text = Convert.ToString(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[4].Value);

                //расчасовка
                numUpDwn_hoursAuditor.Value = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[9].Value);
                numUpDwn_hoursKSR.Value = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[10].Value);
                numUpDwn_hoursSamost.Value = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[11].Value);
                numUpDwn_vsegoZet.Value = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[12].Value);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            var DisciplineID = Convert.ToInt32(cmbBx_nameDiscipline.SelectedValue);
            var DisciplineShifr = txtBx_shifrDiscipline.Text;
            var KafedraID = Convert.ToInt32(cmbBx_kafedra.SelectedValue);
            var typeDisciplineID = Convert.ToInt32(cmbBx_typeDiscipline.SelectedValue);
            var hoursAuditor = Convert.ToInt16(numUpDwn_hoursAuditor.Value);
            var hoursKSR = Convert.ToInt16(numUpDwn_hoursKSR.Value);
            var hoursSamost = Convert.ToInt16(numUpDwn_hoursSamost.Value);
            var vsegoZet = Convert.ToInt16(numUpDwn_vsegoZet.Value);

            try
            {
                дисциплина_как_часть_учебного_планаTableAdapter
                    .Insert(DisciplineID, _academicPlanID, DisciplineShifr, KafedraID, typeDisciplineID, hoursAuditor, hoursKSR, hoursSamost, vsegoZet);
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
            var DisciplineShifr = Convert.ToString(txtBx_shifrDiscipline.Text);
            var KafedraID = Convert.ToInt32(cmbBx_kafedra.SelectedValue);
            var typeDisciplineID = Convert.ToInt32(cmbBx_typeDiscipline.SelectedValue);
            var hoursAuditor = Convert.ToInt16(numUpDwn_hoursAuditor.Value);
            var hoursKSR = Convert.ToInt16(numUpDwn_hoursKSR.Value);
            var hoursSamost = Convert.ToInt16(numUpDwn_hoursSamost.Value);
            var vsegoZet = Convert.ToInt16(numUpDwn_vsegoZet.Value);

            try
            {
                дисциплина_как_часть_учебного_планаTableAdapter
                    .Update(DisciplineID, _academicPlanID, DisciplineShifr, KafedraID, typeDisciplineID, hoursAuditor, hoursKSR, hoursSamost, vsegoZet, curID);
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

        private void fillByUsed1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.дисциплина_как_часть_учебного_планаTableAdapter.FillByUsed1(this.uchPlanDataSet.Дисциплина_как_часть_учебного_плана);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
