using System;
using System.Windows.Forms;

namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    public partial class RealizuemyKompetenciiDisciplin : Form
    {
        public RealizuemyKompetenciiDisciplin()
        {
            InitializeComponent();
        }

        private void RealizuemyKompetenciiDisciplin_Load(object sender, System.EventArgs e)
        {
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Реализуемые_компетенции". При необходимости она может быть перемещена или удалена.
            this.реализуемые_компетенцииTableAdapter.Fill(this.uchPlanDataSet.Реализуемые_компетенции);
        }

        private void dtGrdVw_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dtGrdVw.SelectedRows.Count > 0)
                txtBx.Text = Convert.ToString(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[1].Value).Trim();
        }
        /// <summary>
        /// Вставка
        /// </summary>
        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                реализуемые_компетенцииTableAdapter.Insert(txtBx.Text);
            }
            catch(System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            UpdateDataGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Int32 curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
            try
            {
                реализуемые_компетенцииTableAdapter.Update(txtBx.Text,curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            UpdateDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Int32 curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
            try
            {
                реализуемые_компетенцииTableAdapter.Delete(curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            UpdateDataGridView();
        }
    }
}