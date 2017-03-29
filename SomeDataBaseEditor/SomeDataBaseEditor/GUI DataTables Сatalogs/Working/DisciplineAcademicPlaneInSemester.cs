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
        int _currentDisciplineID;
        int _academicPlanID;

        public DisciplineAcademicPlaneInSemester() : this(0, 0) { }
        public DisciplineAcademicPlaneInSemester(int academicPlanID, int DisciplineID)
        {
            _currentDisciplineID = DisciplineID;
            _academicPlanID = academicPlanID;
            InitializeComponent();
            MyInitialize();
        }

        private void MyInitialize()
        {
            семестрыBindingSource.Filter = " [Код учебного плана] = " + _academicPlanID;
        }

        private void DisciplineAcademicPlaneInSemester_Load(object sender, EventArgs e)
        {
            // данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Формы_контроля". При необходимости она может быть перемещена или удалена.
            this.формы_контроляTableAdapter.Fill(this.uchPlanDataSet.Формы_контроля);
            // данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Семестры". При необходимости она может быть перемещена или удалена.
            this.семестрыTableAdapter.Fill(this.uchPlanDataSet.Семестры);
            updateDataGridView();
        }
        /// <summary>
        /// Выполняет загрузку и обновление данных в DataGridView
        /// </summary>
        private void updateDataGridView()
        {
            /*
            * Код
            * Номер семестра
            * Имя формы контроля
            * Код формы контроля
            * Код семестра
            * Часы лекций
            * Часы практики
            * Часы КСР
            */
            string query = "SELECT [Дисциплина как часть семестра].Код, Семестры.Номер AS [Номер семестра], [Дисциплина как часть семестра].[Код семестра], [Дисциплина как часть семестра].[Часы лекций],"
                         + " [Дисциплина как часть семестра].[Часы лабораторные],[Дисциплина как часть семестра].[Часы практики], [Дисциплина как часть семестра].[Часы КСР]"
                         + " FROM Семестры"
                         + " INNER JOIN [Дисциплина как часть семестра] ON Семестры.Код = [Дисциплина как часть семестра].[Код семестра]"
                         + " WHERE (Семестры.[Код учебного плана] = " + _academicPlanID + ") AND([Дисциплина как часть семестра].[Код Дисциплины] = " + _currentDisciplineID + ")";

            //очистим таблицу
            dtGrdVw.Columns.Clear();
            //и загрузим в нее результат запроса
            dtGrdVw.DataSource = helpers.GetDataTable(query);
            dtGrdVw.AutoResizeColumns();
            //отключим не информативные для пользователя колонки
            foreach (var i in new int[] { 0, 2 })
                if (i < dtGrdVw.Columns.Count)
                    dtGrdVw.Columns[i].Visible = false;

            if (dtGrdVw.Rows.Count>0)
                dtGrdVw.Select();
        }

        /// <summary>
        /// Обновляет информацию о формах контроля
        /// для выбранной дисциплины в семестре
        /// </summary>
        void updateListBoxFormsControls()
        {
            //Предусматриваем ситуацию с пустым списком
            if (!(dtGrdVw.SelectedRows.Count > 0))
                return;

            //узнаем код дисциплины в семестре конкретного учебного плана
            var cur = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);

            //Создаем запрос на формы контроля искомой дисциплины
            /*
             * Код
             * Имя формы контроля
             */
            var query = "SELECT [Формы контроля].Код, [Формы контроля].Имя AS[Имя формы контроля] "
                        + " FROM [Формы Контроля В Семестре] "
                        + " INNER JOIN [Формы контроля] ON[Формы Контроля В Семестре].[Код Формы контроля] = [Формы контроля].Код "
                        + " WHERE([Формы Контроля В Семестре].[Код ДС] = " + cur + ")";

            //Выполняем запрос и получаем таблицу
            var table = helpers.GetDataTable(query);
            //подключаем результаты как ресурс для списка форм котроля
            lstBx_ControlInSemestr.DataSource = table;
            lstBx_ControlInSemestr.DisplayMember = "Имя формы контроля";
            lstBx_ControlInSemestr.ValueMember = "Код";

        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            //Если есть выделенный объект
            if (dtGrdVw.SelectedRows.Count > 0)
            {//обновляем информацию об
                //Номере семестра
                cmbBx_SemesterNum.SelectedValue = dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[2].Value;
                //кол-ве часов аудиторных
                numUpDwn_hoursAuditor.Value = Convert.ToInt16(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[3].Value);
                //кол-ве часов лабораторных
                numUpDwn_hoursLab.Value = Convert.ToInt16(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[4].Value);
                //кол-ве часов практики
                numUpDwn_hoursPract.Value = Convert.ToInt16(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[5].Value);
                //кол-ве часов КСР (контрольные и самостаятельные работы)
                numUpDwn_hoursKSR.Value = Convert.ToInt16(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[6].Value);
                //формах контроля
                updateListBoxFormsControls();
            }
        }
        /// <summary>
        /// добавление формы контроля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addFormControl_Click(object sender, EventArgs e)
        {
            var curDisciplineInSemester = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
            var curSelectedFormControl = Convert.ToInt32(cmbBx_FormControl.SelectedValue);

            try
            {
                формы_Контроля_В_СеместреTableAdapter.Insert(curDisciplineInSemester, curSelectedFormControl);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Нелья дбавлять форму контроля дважды","Ошибка вставки",MessageBoxButtons.OK);
            }
            updateListBoxFormsControls();

        }
        /// <summary>
        /// удаление формы контроля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delFormControl_Click(object sender, EventArgs e)
        {
            if(cmbBx_SemesterNum.SelectedValue!=null&& dtGrdVw.SelectedRows.Count>0)
            {
                var curDisciplineInSemester = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
                var curSelectedFormControl = Convert.ToInt32(lstBx_ControlInSemestr.SelectedValue);
                try
                {
                    формы_Контроля_В_СеместреTableAdapter.Delete(curDisciplineInSemester, curSelectedFormControl);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Упс...", "ошибка удаления", MessageBoxButtons.OK);
                }
            }
            updateListBoxFormsControls();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            var SemesterID = Convert.ToInt32(cmbBx_SemesterNum.SelectedValue);
            var DisciplineID = Convert.ToInt32(_currentDisciplineID);
            var hoursAuditor = Convert.ToInt16(numUpDwn_hoursAuditor.Value);
            var hoursLab = Convert.ToInt16(numUpDwn_hoursLab.Value);
            var hoursPractic = Convert.ToInt16(numUpDwn_hoursPract.Value);
            var hoursKSR = Convert.ToInt16(numUpDwn_hoursKSR.Value);
            

            try
            {
                дисциплина_как_часть_семестраTableAdapter1
                    .Insert(SemesterID, DisciplineID, hoursAuditor, hoursPractic, hoursKSR,hoursLab);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Во время добавления записи произошла ошибка","Ошибка вставки",MessageBoxButtons.OK);
            }
            updateDataGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);

            var SemesterID = Convert.ToInt32(cmbBx_SemesterNum.SelectedValue);
            var DisciplineID = Convert.ToInt32(_currentDisciplineID);
            var hoursAuditor = Convert.ToInt16(numUpDwn_hoursAuditor.Value);
            var hoursLab = Convert.ToInt16(numUpDwn_hoursLab.Value);
            var hoursPractic = Convert.ToInt16(numUpDwn_hoursPract.Value);
            var hoursKSR = Convert.ToInt16(numUpDwn_hoursKSR.Value);

            try
            {
                дисциплина_как_часть_семестраTableAdapter1
                    .Update(SemesterID, DisciplineID, hoursAuditor, hoursPractic, hoursKSR,hoursLab, curID);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Во время обновления записи произошла ошибка", "Ошибка обновления", MessageBoxButtons.OK);
            }
            updateDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
            try
            {
                дисциплина_как_часть_семестраTableAdapter1.Delete(curID);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Во время удаления записи произошла ошибка", "Ошибка удаления", MessageBoxButtons.OK);
            }
            updateDataGridView();
        }
    }
}
