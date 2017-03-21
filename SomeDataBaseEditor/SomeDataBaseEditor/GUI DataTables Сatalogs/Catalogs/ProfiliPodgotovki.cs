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
    public partial class ProfiliPodgotovki : Form
    {
        public ProfiliPodgotovki()
        {
            InitializeComponent();
        }

        private void ProfiliPodgotovki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet1.Направления_подготовки". При необходимости она может быть перемещена или удалена.
            this.направления_подготовкиTableAdapter.Fill(this.uchPlanDataSet.Направления_подготовки);
            UpdateDataInDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //id направления (unvisible)


           var curNaprID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[dataGridView1.Columns.Count-1].Value);
           txtBx.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value).Trim();
            
           cmbBx.SelectedValue = curNaprID;
        }

        private void UpdateDataInDataGridView()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Учебные_планы". При необходимости она может быть перемещена или удалена.
            this.учебные_планыTableAdapter.Fill(this.uchPlanDataSet.Учебные_планы);
            dataGridView1.DataSource = null;
            dataGridView1.Update();
            профилиПодготовкиBindingSource.DataSource = профили_подготовкиTableAdapter1.GetDataByViaNapravleniye();
            dataGridView1.DataSource = профили_подготовкиTableAdapter1.GetDataByViaNapravleniye();
            dataGridView1.Columns.RemoveAt(2);
            dataGridView1.Update();
            dataGridView1.AutoResizeColumns();

            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                профили_подготовкиTableAdapter1.Insert(txtBx.Text, Convert.ToInt32(cmbBx.SelectedValue));
            }
            catch(System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            UpdateDataInDataGridView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            try
            {
                профили_подготовкиTableAdapter1.Update(txtBx.Text, Convert.ToInt32(cmbBx.SelectedValue),curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            UpdateDataInDataGridView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            try
            {
                профили_подготовкиTableAdapter1.Delete(curID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            UpdateDataInDataGridView();
        }
    }
}
