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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Направления_подготовки". При необходимости она может быть перемещена или удалена.
            this.направления_подготовкиTableAdapter.Fill(this.uchPlanDataSet.Направления_подготовки);
            dataGridView1.AutoResizeColumns();

        }
    }
}
