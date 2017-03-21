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
    public partial class RealizCompetenceDiscipline : Form
    {
        private Int32 _disciplineInAcademicPlanID;

        public RealizCompetenceDiscipline():this(0)
        {
         
        }
        public RealizCompetenceDiscipline(int disciplineInAcademicPlanID)
        {
            InitializeComponent();
            _disciplineInAcademicPlanID = disciplineInAcademicPlanID;
        }

        private void UpdateData()
        {
            /*
             * Код компетенции
             * Название компетенции
             * Код Дисциплины в плане
             */

            string query = "SELECT [Реализуемые компетенции].Код AS[Код компетенции], [Реализуемые компетенции].Название AS[Название компетенции], "
                         + "[Реализуемые компетенции дисциплин].[Код ДУП] AS[Код Дисциплины в плане] "
                         + "FROM [Реализуемые компетенции дисциплин] "
                         + "INNER JOIN [Реализуемые компетенции] ON [Реализуемые компетенции дисциплин].[Код реализуемой компетенции] = [Реализуемые компетенции].Код "
                         + "WHERE([Реализуемые компетенции дисциплин].[Код ДУП] = "+_disciplineInAcademicPlanID+")";

            var table = helpers.GetDataTable(query);
            lstBx.DataSource = table;
            lstBx.DisplayMember = "Название компетенции";
            lstBx.ValueMember = "Код компетенции";
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Реализуемые_компетенции". При необходимости она может быть перемещена или удалена.
            this.реализуемые_компетенцииTableAdapter.Fill(this.uchPlanDataSet.Реализуемые_компетенции);
        }

        private void RealizCompetenceDiscipline_Load(object sender, EventArgs e)
        {
            UpdateData();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            var competenceID = Convert.ToInt32(cmbBx.SelectedValue);
            try
            {
                реализуемые_компетенции_дисциплинTableAdapter1.Insert(_disciplineInAcademicPlanID, competenceID);

            }catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Невозможно реализовать одну компетенцию тм же предметом дважды.","Ошибка вставки.",MessageBoxButtons.OK);
            }
            UpdateData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var competenceID = Convert.ToInt32(lstBx.SelectedValue);
            try
            {
                реализуемые_компетенции_дисциплинTableAdapter1.Delete(_disciplineInAcademicPlanID, competenceID);

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Невозможно реализовать одну компетенцию тм же предметом дважды.", "Ошибка вставки.", MessageBoxButtons.OK);
            }
            UpdateData();
        }
    }
}
