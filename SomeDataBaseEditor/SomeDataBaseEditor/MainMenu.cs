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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Кнопки открывает окно с направлениями подготовки
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {
            using (var form = new NapravleniaPodgotovki())
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
            using (var form = new ProfiliPodgotovki())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (var form = new)
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
