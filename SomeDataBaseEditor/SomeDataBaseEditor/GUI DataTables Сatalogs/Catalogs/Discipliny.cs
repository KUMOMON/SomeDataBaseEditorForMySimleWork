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
    public partial class Discipliny : Form
    {
        public Discipliny()
        {
            InitializeComponent();
        }

        private void Discipliny_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Дисциплины". При необходимости она может быть перемещена или удалена.
            this.дисциплиныTableAdapter.Fill(this.uchPlanDataSet.Дисциплины);
            dtGrdVw.AutoResizeColumns();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dtGrdVw.SelectedRows.Count>0)
                txtBx.Text = Convert.ToString(dtGrdVw.SelectedRows[0].Cells[1].Value).Trim();
        }

        /// <summary>
        /// Вставка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                дисциплиныTableAdapter.Insert(txtBx.Text);
            }
            catch(System.Data.SqlClient.SqlException sqlEX)
            {
                MessageBox.Show(sqlEX.Message);
            }
            дисциплиныTableAdapter.Fill(this.uchPlanDataSet.Дисциплины);
            dtGrdVw.AutoResizeColumns();
        }

        /// <summary>
        /// Обновление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Int32 setID = Convert.ToInt32(dtGrdVw.SelectedRows[0].Cells[0].Value);
            try
            {
                дисциплиныTableAdapter.Update(txtBx.Text.Trim(),setID);
            }
            catch (System.Data.SqlClient.SqlException sqlEX)
            {
                MessageBox.Show(sqlEX.Message);
            }
            дисциплиныTableAdapter.Fill(this.uchPlanDataSet.Дисциплины);
            dtGrdVw.AutoResizeColumns();
        }

        private void Discipliny_Shown(object sender, EventArgs e)
        {
            dtGrdVw.AutoResizeColumns();
        }

        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Int32 setID = Convert.ToInt32(dtGrdVw.SelectedRows[0].Cells[0].Value);
            try
            {
                дисциплиныTableAdapter.Delete(setID);
            }
            catch (System.Data.SqlClient.SqlException sqlEX)
            {
                MessageBox.Show(sqlEX.Message);
            }
            дисциплиныTableAdapter.Fill(this.uchPlanDataSet.Дисциплины);
            dtGrdVw.AutoResizeColumns();
        }
    }
}
