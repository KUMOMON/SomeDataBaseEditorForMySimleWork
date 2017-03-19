using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    public partial class FormControlDisciplinInSevestr : Form
    {
        public FormControlDisciplinInSevestr()
        {
            InitializeComponent();
        }

        private void FormControlDisciplinInSevestr_Load(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void dtGrdVw_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGrdVw.SelectedRows.Count > 0)
                txtBx.Text = Convert.ToString(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[1].Value);
        }

        private void updateDataGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Формы_контроля". При необходимости она может быть перемещена или удалена.
            this.формы_контроляTableAdapter.Fill(this.uchPlanDataSet.Формы_контроля);
            dtGrdVw.AutoResizeColumns();
            dtGrdVw.Update();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                формы_контроляTableAdapter.Insert(txtBx.Text);
            }
            catch(System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Int32 curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
            try
            {
                формы_контроляTableAdapter.Update(txtBx.Text,curID);
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
                формы_контроляTableAdapter.Delete(curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }
    }
}
