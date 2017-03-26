using System;
using System.Windows.Forms;

namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    public partial class kafedry : Form
    {
        public kafedry()
        {
            InitializeComponent();
        }

        private void kafedry_Load(object sender, System.EventArgs e)
        {
            updateDataGridView();
        }

        private void dtGrdVw_SelectionChanged(object sender, System.EventArgs e)
        {
            if(dtGrdVw.SelectedRows.Count>0)
                cmbBx.Text = Convert.ToString(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[1].Value);
        }

        private void updateDataGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Кафедры". При необходимости она может быть перемещена или удалена.
            this.кафедрыTableAdapter.Fill(this.uchPlanDataSet.Кафедры);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                кафедрыTableAdapter.Insert(cmbBx.Text);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Int32 curID= Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
            try
            {
                кафедрыTableAdapter.Update(cmbBx.Text,curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Int32 curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
            try
            {
                кафедрыTableAdapter.Delete(curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }
    }
}