using System.Windows.Forms;

namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    public partial class RealizuemyKompetenciiDisciplin : Form
    {
        public RealizuemyKompetenciiDisciplin()
        {
            InitializeComponent();
        }

        private void RealizuemyKompetenciiDisciplin_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Реализуемые_компетенции". При необходимости она может быть перемещена или удалена.
            this.реализуемые_компетенцииTableAdapter.Fill(this.uchPlanDataSet.Реализуемые_компетенции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Реализуемые_компетенции_дисциплин". При необходимости она может быть перемещена или удалена.
            this.реализуемые_компетенции_дисциплинTableAdapter.Fill(this.uchPlanDataSet.Реализуемые_компетенции_дисциплин);

        }
    }
}