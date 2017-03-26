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
    public partial class Kvalifikacii : Form
    {
        public Kvalifikacii()
        {
            InitializeComponent();
        }

        private void Kvalifikacii_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Квалификации". При необходимости она может быть перемещена или удалена.
            this.квалификацииTableAdapter.Fill(this.uchPlanDataSet.Квалификации);
            updateDataGridView();
        }

        private void dtGrdVw_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGrdVw.SelectedRows.Count > 0)
            {
                txtBx_name.Text = Convert.ToString(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[1].Value).Trim();
                numUpDwn_years.Value = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[2].Value);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                квалификацииTableAdapter.Insert(txtBx_name.Text, Convert.ToInt32(numUpDwn_years.Value));
            }catch(System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }

        private void updateDataGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Квалификации". При необходимости она может быть перемещена или удалена.
            this.квалификацииTableAdapter.Fill(this.uchPlanDataSet.Квалификации);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Int32 curID = Convert.ToInt32(dtGrdVw.Rows[dtGrdVw.CurrentRow.Index].Cells[0].Value);
            try
            {
                квалификацииTableAdapter.Delete(curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
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
                квалификацииTableAdapter.Update(txtBx_name.Text, Convert.ToInt32(numUpDwn_years.Value), curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateDataGridView();
        }
    }
}
