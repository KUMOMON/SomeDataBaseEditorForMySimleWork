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
    public partial class EditorAcademicPlans : Form
    {
        public EditorAcademicPlans()
        {
            InitializeComponent();
            dtTmPcker_DateVerefic.Value = DateTime.Today;
        }

        public object curProfilID
        {
            get { return cmbBx__Profil.SelectedValue; }
            set { cmbBx__Profil.SelectedValue = (value) ?? value; }
        }

        public object curKvalifikaciaID
        {
            get { return cmbBx_kvalifikacia.SelectedValue; }
            set { cmbBx_kvalifikacia.SelectedValue = (value) ?? value; }
        }

        public DateTime curDateVerefic
        {
            get { return dtTmPcker_DateVerefic.Value; }
            set { dtTmPcker_DateVerefic.Value = value; }
        }

        public string curNameVerefic
        {
            get { return txtBx_NameVerefic.Text; }
            set { txtBx_NameVerefic.Text = (value) ?? value; }
        }

        public object curEduForm
        {
            get { return cmbBx_EduForm.SelectedValue; }
            set { cmbBx_EduForm.SelectedValue = (value) ?? value; }
        }

        private void EditorAcademicPlans_Load(object sender, EventArgs e)
        {
            updateDataBaseInfo();
        }

        private void updateDataBaseInfo()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet1.Квалификации". При необходимости она может быть перемещена или удалена.
            this.квалификацииTableAdapter1.Fill(this.uchPlanDataSet1.Квалификации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet1.Профили_подготовки". При необходимости она может быть перемещена или удалена.
            this.профили_подготовкиTableAdapter1.Fill(this.uchPlanDataSet1.Профили_подготовки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet1.Направления_подготовки". При необходимости она может быть перемещена или удалена.
            this.направления_подготовкиTableAdapter1.Fill(this.uchPlanDataSet1.Направления_подготовки);
        }

        private void cmbBx_Napravlenie_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbBx_Napravlenie.SelectedValue!=null)
            профилиПодготовкиBindingSource.Filter = "[Код направления подготовки] = " + cmbBx_Napravlenie.SelectedValue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            профилиПодготовкиBindingSource.Filter = "";
        }
    }
}
