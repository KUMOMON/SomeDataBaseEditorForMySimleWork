using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomeDataBaseEditor
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Справочник реализуемых компетенций дисциплинами
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Catalogs.RealizuemyKompetenciiDisciplin())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Кнопки открывает окно с направлениями подготовки
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Catalogs.NapravleniaPodgotovki())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
        /// <summary>
        /// Открывает окно с профилями подготовки
        /// </summary>
        private void button8_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Catalogs.ProfiliPodgotovki())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Открывает учебные планы
        /// </summary>
        private void button10_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Working.AcademicPlans())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Открывает справочник дисциплин
        /// </summary>
        private void button9_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Catalogs.Discipliny())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Открывает справочник типов дисциплин
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Catalogs.typeDiscipliny())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// открывает справочник доступных форм контроля
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Catalogs.FormControlDisciplinInSevestr())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Справочник квалификаций
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Catalogs.Kvalifikacii())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Справочник форм обучения
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Catalogs.FormyObucheniya())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// справочник кафедр
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            using (var form = new GUI_DataTables.Catalogs.kafedry())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
