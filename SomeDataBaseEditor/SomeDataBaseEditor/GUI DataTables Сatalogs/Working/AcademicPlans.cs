﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*
 * 2- код профиля подготовки
 * 4- код квалификации
 * 8- код формы обучения
 */

namespace SomeDataBaseEditor.GUI_DataTables.Working
{
    public partial class AcademicPlans : Form
    {

        public AcademicPlans()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Открывает семестры учебного плана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            using (var form = new GUI_DataTables.Working.Semesters(curID))
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            using (var form = new GUI_DataTables.Working.DisciplineInAcademicPlan(curID))
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void AcademicPlans_Load(object sender, EventArgs e)
        { 
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Columns.Clear();
            var query = "SELECT [Учебные планы].Код, [Профили подготовки].Имя AS [Профиль подогтовки], Квалификации.Имя AS Квалификация, Квалификации.[Срок обучения], [Учебные планы].[Дата утверждения],"
                         + " [Учебные планы].[Кто утвердил], [Формы обучения].Имя AS [Форма обучения], [Учебные планы].[Код профиля подготовки], [Учебные планы].[Код квалификации],"
                         + " [Учебные планы].[Код формы обучения]"
                         + " FROM [Учебные планы] "
                         + " INNER JOIN [Профили подготовки] ON [Учебные планы].[Код профиля подготовки] = [Профили подготовки].Код "
                         + " INNER JOIN [Формы обучения] ON [Учебные планы].[Код формы обучения] = [Формы обучения].Код "
                         + " INNER JOIN Квалификации ON [Учебные планы].[Код квалификации] = Квалификации.Код";

            var table = helpers.GetDataTable(query);

            dataGridView1.DataSource = table;

            foreach(int i in new int[] {0,7,8,9})
                dataGridView1.Columns[i].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var profilID=-1;
            var kvalificaziyaID =-1;
            var dateVerefication = DateTime.Now;
            var nameVerefication = "";
            var formEduID = -1;

            using (var form = new SomeDataBaseEditor.GUI_DataTables.Working.EditorAcademicPlans())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();

                if (form.DialogResult == DialogResult.OK)
                {
                    profilID = Convert.ToInt32(form.curProfilID);
                    kvalificaziyaID = Convert.ToInt32(form.curKvalifikaciaID);
                    dateVerefication = form.curDateVerefic;
                    nameVerefication = form.curNameVerefic;
                    formEduID = Convert.ToInt32(form.curEduForm);
                }
                else return;
            }
            try
            {
                учебные_планыTableAdapter.Insert(profilID, kvalificaziyaID, dateVerefication, nameVerefication, formEduID);
                UpdateDataGridView();
            }
            catch(System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            var profilID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value);
            var kvalificaziyaID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value);
            var dateVerefication = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
            var nameVerefication = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value);
            var formEduID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value);
           
            using (var form = new SomeDataBaseEditor.GUI_DataTables.Working.EditorAcademicPlans())
            {
                form.curProfilID = profilID;
                form.curKvalifikaciaID = kvalificaziyaID;
                form.curDateVerefic = dateVerefication;
                form.curNameVerefic = nameVerefication.Trim();
                form.curEduForm = formEduID;

                this.Hide();
                form.ShowDialog();
                this.Show();

                if (form.DialogResult == DialogResult.OK)
                {
                    profilID = Convert.ToInt32(form.curProfilID);
                    kvalificaziyaID = Convert.ToInt32(form.curKvalifikaciaID);
                    dateVerefication = form.curDateVerefic;
                    nameVerefication = form.curNameVerefic.Trim();
                    formEduID = Convert.ToInt32(form.curEduForm);
                }
                else return;
            }
            try
            {
                учебные_планыTableAdapter.Update(profilID, kvalificaziyaID, dateVerefication, nameVerefication, formEduID,curID);
                UpdateDataGridView();
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var curID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            try
            {
                учебные_планыTableAdapter.Delete(curID);
                UpdateDataGridView();
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
        }
    }
}
