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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Профили_подготовки". При необходимости она может быть перемещена или удалена.
            this.профили_подготовкиTableAdapter.Fill(this.uchPlanDataSet.Профили_подготовки);

        }
    }
}
