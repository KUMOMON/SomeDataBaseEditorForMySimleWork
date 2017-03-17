using System.Windows.Forms;

namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    public partial class kafedry : Form
    {
        public kafedry()
        {
            InitializeComponent();
        }

        private void kafedry_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Кафедры". При необходимости она может быть перемещена или удалена.
            this.кафедрыTableAdapter.Fill(this.uchPlanDataSet.Кафедры);

        }
    }
}