using System.Windows.Forms;

namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    public partial class typeDiscipliny : Form
    {
        public typeDiscipliny()
        {
            InitializeComponent();
        }

        private void typeDiscipliny_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Типы_дисциплин". При необходимости она может быть перемещена или удалена.
            this.типы_дисциплинTableAdapter.Fill(this.uchPlanDataSet.Типы_дисциплин);

        }
    }
}