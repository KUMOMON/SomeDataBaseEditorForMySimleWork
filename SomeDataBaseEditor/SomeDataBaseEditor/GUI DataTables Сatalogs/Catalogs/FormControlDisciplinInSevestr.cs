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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Формы_контроля". При необходимости она может быть перемещена или удалена.
            this.формы_контроляTableAdapter.Fill(this.uchPlanDataSet.Формы_контроля);

        }
    }
}
