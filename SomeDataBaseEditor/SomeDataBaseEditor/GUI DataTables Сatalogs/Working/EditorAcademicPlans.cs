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
            #region Заполнение профили_подготовки comboBox
            var query = "SELECT Код, Имя, [Код направления подготовки] FROM[Профили подготовки]";
            var dt = helpers.GetDataTable(query);

            cmbBx__Profil.DataSource = dt;
            cmbBx__Profil.DisplayMember = "Имя";
            cmbBx__Profil.ValueMember = "Код"; 
            #endregion



            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet1.Формы_обучения". При необходимости она может быть перемещена или удалена.
            this.формы_обученияTableAdapter1.Fill(this.uchPlanDataSet1.Формы_обучения);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet1.Квалификации". При необходимости она может быть перемещена или удалена.
            this.квалификацииTableAdapter1.Fill(this.uchPlanDataSet1.Квалификации);






        }

    }
}
