using System;
using System.Windows.Forms;

namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    public partial class typeDiscipliny : Form
    {
        public typeDiscipliny()
        {
            InitializeComponent();
        }

        private void typeDiscipliny_Load(object sender, System.EventArgs e)
        {
            UpdateDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, System.EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
                textBox1.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value).Trim();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                типы_дисциплинTableAdapter.Insert(textBox1.Text);
            }
            catch(System.Data.SqlClient.SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            UpdateDataGridView();



        }

        private void UpdateDataGridView()
        {
            dataGridView1.Update();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Типы_дисциплин". При необходимости она может быть перемещена или удалена.
            this.типы_дисциплинTableAdapter.Fill(this.uchPlanDataSet.Типы_дисциплин);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                типы_дисциплинTableAdapter.Update(textBox1.Text,
                    Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));
            }
            catch (System.Data.SqlClient.SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            UpdateDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                типы_дисциплинTableAdapter.Delete(
                    Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value));
            }
            catch (System.Data.SqlClient.SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            UpdateDataGridView();
        }
    }
}