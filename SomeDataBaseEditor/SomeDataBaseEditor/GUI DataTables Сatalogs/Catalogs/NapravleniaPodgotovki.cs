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
    public partial class NapravleniaPodgotovki : Form
    {
        public NapravleniaPodgotovki()
        {
            InitializeComponent();
        }

        private void NapravleniaPodgotovki_Load(object sender, EventArgs e)
        {
            updateTableInfo();
        }

        private void updateTableInfo()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Направления_подготовки". При необходимости она может быть перемещена или удалена.
            this.направления_подготовкиTableAdapter.Fill(this.uchPlanDataSet.Направления_подготовки);
            dtGrdVw.AutoResizeColumns();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                направления_подготовкиTableAdapter.Insert(txtBx.Text.Trim());
            }catch(System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateTableInfo();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Int32 SetID = Convert.ToInt32(dtGrdVw.SelectedRows[0].Cells[0].Value);
            try
            {
                направления_подготовкиTableAdapter.Update(txtBx.Text.Trim(),SetID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateTableInfo();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Int32 SetID = Convert.ToInt32(dtGrdVw.SelectedRows[0].Cells[0].Value);
            try
            {
                
                направления_подготовкиTableAdapter.Delete(SetID);
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            updateTableInfo();
        }

        private void dtGrdVw_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGrdVw.SelectedRows.Count > 0)
                txtBx.Text = Convert.ToString(dtGrdVw.SelectedRows[0].Cells[1].Value);
        }
    }
}
