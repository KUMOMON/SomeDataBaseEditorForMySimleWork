﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    public partial class Kvalifikacii : Form
    {
        public Kvalifikacii()
        {
            InitializeComponent();
        }

        private void Kvalifikacii_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchPlanDataSet.Квалификации". При необходимости она может быть перемещена или удалена.
            this.квалификацииTableAdapter.Fill(this.uchPlanDataSet.Квалификации);

        }
    }
}
