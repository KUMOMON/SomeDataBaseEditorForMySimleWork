namespace SomeDataBaseEditor.GUI_DataTables.Working
{
    partial class DisciplineInAcademicPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbBx_nameDiscipline = new System.Windows.Forms.ComboBox();
            this.дисциплиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.lbl_nameDiscipline = new System.Windows.Forms.Label();
            this.txtBx_shifrDiscipline = new System.Windows.Forms.TextBox();
            this.lbl_shifrDiscipline = new System.Windows.Forms.Label();
            this.cmbBx_kafedra = new System.Windows.Forms.ComboBox();
            this.кафедрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_kafedra = new System.Windows.Forms.Label();
            this.lbl_typeDiscipline = new System.Windows.Forms.Label();
            this.cmbBx_typeDiscipline = new System.Windows.Forms.ComboBox();
            this.типыДисциплинBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_hoursAuditor = new System.Windows.Forms.Label();
            this.numUpDwn_hoursAuditor = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_hoursSamost = new System.Windows.Forms.NumericUpDown();
            this.lbl_hoursSamost = new System.Windows.Forms.Label();
            this.numUpDwn_vsegoZet = new System.Windows.Forms.NumericUpDown();
            this.lbl_vsegoZet = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUpDwn_hoursKSR = new System.Windows.Forms.NumericUpDown();
            this.lbl_hoursKSR = new System.Windows.Forms.Label();
            this.btn_go_semesters = new System.Windows.Forms.Button();
            this.dtGrdVw = new System.Windows.Forms.DataGridView();
            this.дисциплиныTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.ДисциплиныTableAdapter();
            this.типы_дисциплинTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Типы_дисциплинTableAdapter();
            this.кафедрыTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.КафедрыTableAdapter();
            this.btn_realizKompetenc = new System.Windows.Forms.Button();
            this.дисциплина_как_часть_учебного_планаTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Дисциплина_как_часть_учебного_планаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кафедрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыДисциплинBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursAuditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursSamost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_vsegoZet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursKSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBx_nameDiscipline
            // 
            this.cmbBx_nameDiscipline.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBx_nameDiscipline.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBx_nameDiscipline.DataSource = this.дисциплиныBindingSource;
            this.cmbBx_nameDiscipline.DisplayMember = "Имя";
            this.cmbBx_nameDiscipline.FormattingEnabled = true;
            this.cmbBx_nameDiscipline.Location = new System.Drawing.Point(12, 379);
            this.cmbBx_nameDiscipline.Name = "cmbBx_nameDiscipline";
            this.cmbBx_nameDiscipline.Size = new System.Drawing.Size(330, 21);
            this.cmbBx_nameDiscipline.TabIndex = 1;
            this.cmbBx_nameDiscipline.ValueMember = "Код";
            // 
            // дисциплиныBindingSource
            // 
            this.дисциплиныBindingSource.DataMember = "Дисциплины";
            this.дисциплиныBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // uchPlanDataSet
            // 
            this.uchPlanDataSet.DataSetName = "UchPlanDataSet";
            this.uchPlanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_nameDiscipline
            // 
            this.lbl_nameDiscipline.AutoSize = true;
            this.lbl_nameDiscipline.Location = new System.Drawing.Point(11, 363);
            this.lbl_nameDiscipline.Name = "lbl_nameDiscipline";
            this.lbl_nameDiscipline.Size = new System.Drawing.Size(70, 13);
            this.lbl_nameDiscipline.TabIndex = 2;
            this.lbl_nameDiscipline.Text = "Дисциплина";
            // 
            // txtBx_shifrDiscipline
            // 
            this.txtBx_shifrDiscipline.Location = new System.Drawing.Point(145, 423);
            this.txtBx_shifrDiscipline.Name = "txtBx_shifrDiscipline";
            this.txtBx_shifrDiscipline.Size = new System.Drawing.Size(115, 20);
            this.txtBx_shifrDiscipline.TabIndex = 3;
            // 
            // lbl_shifrDiscipline
            // 
            this.lbl_shifrDiscipline.AutoSize = true;
            this.lbl_shifrDiscipline.Location = new System.Drawing.Point(142, 407);
            this.lbl_shifrDiscipline.Name = "lbl_shifrDiscipline";
            this.lbl_shifrDiscipline.Size = new System.Drawing.Size(118, 13);
            this.lbl_shifrDiscipline.TabIndex = 4;
            this.lbl_shifrDiscipline.Text = "Кодовое обозначение";
            // 
            // cmbBx_kafedra
            // 
            this.cmbBx_kafedra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBx_kafedra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBx_kafedra.DataSource = this.кафедрыBindingSource;
            this.cmbBx_kafedra.DisplayMember = "Имя";
            this.cmbBx_kafedra.FormattingEnabled = true;
            this.cmbBx_kafedra.Location = new System.Drawing.Point(15, 472);
            this.cmbBx_kafedra.Name = "cmbBx_kafedra";
            this.cmbBx_kafedra.Size = new System.Drawing.Size(245, 21);
            this.cmbBx_kafedra.TabIndex = 5;
            this.cmbBx_kafedra.ValueMember = "Код";
            // 
            // кафедрыBindingSource
            // 
            this.кафедрыBindingSource.DataMember = "Кафедры";
            this.кафедрыBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // lbl_kafedra
            // 
            this.lbl_kafedra.AutoSize = true;
            this.lbl_kafedra.Location = new System.Drawing.Point(12, 455);
            this.lbl_kafedra.Name = "lbl_kafedra";
            this.lbl_kafedra.Size = new System.Drawing.Size(52, 13);
            this.lbl_kafedra.TabIndex = 6;
            this.lbl_kafedra.Text = "Кафедра";
            // 
            // lbl_typeDiscipline
            // 
            this.lbl_typeDiscipline.AutoSize = true;
            this.lbl_typeDiscipline.Location = new System.Drawing.Point(12, 406);
            this.lbl_typeDiscipline.Name = "lbl_typeDiscipline";
            this.lbl_typeDiscipline.Size = new System.Drawing.Size(26, 13);
            this.lbl_typeDiscipline.TabIndex = 8;
            this.lbl_typeDiscipline.Text = "Тип";
            // 
            // cmbBx_typeDiscipline
            // 
            this.cmbBx_typeDiscipline.DataSource = this.типыДисциплинBindingSource;
            this.cmbBx_typeDiscipline.DisplayMember = "Тип";
            this.cmbBx_typeDiscipline.FormattingEnabled = true;
            this.cmbBx_typeDiscipline.Location = new System.Drawing.Point(15, 423);
            this.cmbBx_typeDiscipline.Name = "cmbBx_typeDiscipline";
            this.cmbBx_typeDiscipline.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_typeDiscipline.TabIndex = 7;
            this.cmbBx_typeDiscipline.ValueMember = "Код";
            // 
            // типыДисциплинBindingSource
            // 
            this.типыДисциплинBindingSource.DataMember = "Типы дисциплин";
            this.типыДисциплинBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // lbl_hoursAuditor
            // 
            this.lbl_hoursAuditor.AutoSize = true;
            this.lbl_hoursAuditor.Location = new System.Drawing.Point(15, 21);
            this.lbl_hoursAuditor.Name = "lbl_hoursAuditor";
            this.lbl_hoursAuditor.Size = new System.Drawing.Size(68, 13);
            this.lbl_hoursAuditor.TabIndex = 9;
            this.lbl_hoursAuditor.Text = "Аудиторные";
            // 
            // numUpDwn_hoursAuditor
            // 
            this.numUpDwn_hoursAuditor.Location = new System.Drawing.Point(133, 19);
            this.numUpDwn_hoursAuditor.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDwn_hoursAuditor.Name = "numUpDwn_hoursAuditor";
            this.numUpDwn_hoursAuditor.Size = new System.Drawing.Size(61, 20);
            this.numUpDwn_hoursAuditor.TabIndex = 10;
            // 
            // numUpDwn_hoursSamost
            // 
            this.numUpDwn_hoursSamost.Location = new System.Drawing.Point(133, 73);
            this.numUpDwn_hoursSamost.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDwn_hoursSamost.Name = "numUpDwn_hoursSamost";
            this.numUpDwn_hoursSamost.Size = new System.Drawing.Size(61, 20);
            this.numUpDwn_hoursSamost.TabIndex = 12;
            // 
            // lbl_hoursSamost
            // 
            this.lbl_hoursSamost.AutoSize = true;
            this.lbl_hoursSamost.Location = new System.Drawing.Point(15, 75);
            this.lbl_hoursSamost.Name = "lbl_hoursSamost";
            this.lbl_hoursSamost.Size = new System.Drawing.Size(99, 13);
            this.lbl_hoursSamost.TabIndex = 11;
            this.lbl_hoursSamost.Text = "самостоятельные";
            // 
            // numUpDwn_vsegoZet
            // 
            this.numUpDwn_vsegoZet.Location = new System.Drawing.Point(133, 99);
            this.numUpDwn_vsegoZet.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDwn_vsegoZet.Name = "numUpDwn_vsegoZet";
            this.numUpDwn_vsegoZet.Size = new System.Drawing.Size(61, 20);
            this.numUpDwn_vsegoZet.TabIndex = 14;
            // 
            // lbl_vsegoZet
            // 
            this.lbl_vsegoZet.AutoSize = true;
            this.lbl_vsegoZet.Location = new System.Drawing.Point(15, 101);
            this.lbl_vsegoZet.Name = "lbl_vsegoZet";
            this.lbl_vsegoZet.Size = new System.Drawing.Size(61, 13);
            this.lbl_vsegoZet.TabIndex = 13;
            this.lbl_vsegoZet.Text = "Всего ЗЕТ";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(715, 367);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(91, 32);
            this.btn_insert.TabIndex = 15;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(715, 443);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 32);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(715, 405);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 32);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numUpDwn_hoursKSR);
            this.groupBox2.Controls.Add(this.lbl_hoursKSR);
            this.groupBox2.Controls.Add(this.numUpDwn_vsegoZet);
            this.groupBox2.Controls.Add(this.lbl_vsegoZet);
            this.groupBox2.Controls.Add(this.lbl_hoursSamost);
            this.groupBox2.Controls.Add(this.numUpDwn_hoursSamost);
            this.groupBox2.Controls.Add(this.numUpDwn_hoursAuditor);
            this.groupBox2.Controls.Add(this.lbl_hoursAuditor);
            this.groupBox2.Location = new System.Drawing.Point(348, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 130);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расчасовка";
            // 
            // numUpDwn_hoursKSR
            // 
            this.numUpDwn_hoursKSR.Location = new System.Drawing.Point(133, 47);
            this.numUpDwn_hoursKSR.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUpDwn_hoursKSR.Name = "numUpDwn_hoursKSR";
            this.numUpDwn_hoursKSR.Size = new System.Drawing.Size(61, 20);
            this.numUpDwn_hoursKSR.TabIndex = 16;
            // 
            // lbl_hoursKSR
            // 
            this.lbl_hoursKSR.AutoSize = true;
            this.lbl_hoursKSR.Location = new System.Drawing.Point(15, 49);
            this.lbl_hoursKSR.Name = "lbl_hoursKSR";
            this.lbl_hoursKSR.Size = new System.Drawing.Size(28, 13);
            this.lbl_hoursKSR.TabIndex = 15;
            this.lbl_hoursKSR.Text = "КСР";
            // 
            // btn_go_semesters
            // 
            this.btn_go_semesters.Location = new System.Drawing.Point(715, 481);
            this.btn_go_semesters.Name = "btn_go_semesters";
            this.btn_go_semesters.Size = new System.Drawing.Size(91, 32);
            this.btn_go_semesters.TabIndex = 25;
            this.btn_go_semesters.Text = "По семестрам";
            this.btn_go_semesters.UseVisualStyleBackColor = true;
            this.btn_go_semesters.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AllowUserToAddRows = false;
            this.dtGrdVw.AllowUserToDeleteRows = false;
            this.dtGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Location = new System.Drawing.Point(10, 12);
            this.dtGrdVw.MultiSelect = false;
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.ReadOnly = true;
            this.dtGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVw.Size = new System.Drawing.Size(860, 345);
            this.dtGrdVw.TabIndex = 26;
            this.dtGrdVw.SelectionChanged += new System.EventHandler(this.dtGrdVw_SelectionChanged);
            // 
            // дисциплиныTableAdapter
            // 
            this.дисциплиныTableAdapter.ClearBeforeFill = true;
            // 
            // типы_дисциплинTableAdapter
            // 
            this.типы_дисциплинTableAdapter.ClearBeforeFill = true;
            // 
            // кафедрыTableAdapter
            // 
            this.кафедрыTableAdapter.ClearBeforeFill = true;
            // 
            // btn_realizKompetenc
            // 
            this.btn_realizKompetenc.Location = new System.Drawing.Point(575, 393);
            this.btn_realizKompetenc.Name = "btn_realizKompetenc";
            this.btn_realizKompetenc.Size = new System.Drawing.Size(120, 50);
            this.btn_realizKompetenc.TabIndex = 15;
            this.btn_realizKompetenc.Text = "Реализуемые компетенции дисциплины";
            this.btn_realizKompetenc.UseVisualStyleBackColor = true;
            this.btn_realizKompetenc.Click += new System.EventHandler(this.btn_realizKompetenc_Click);
            // 
            // дисциплина_как_часть_учебного_планаTableAdapter
            // 
            this.дисциплина_как_часть_учебного_планаTableAdapter.ClearBeforeFill = true;
            // 
            // DisciplineInAcademicPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 533);
            this.Controls.Add(this.btn_realizKompetenc);
            this.Controls.Add(this.dtGrdVw);
            this.Controls.Add(this.btn_go_semesters);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_typeDiscipline);
            this.Controls.Add(this.cmbBx_typeDiscipline);
            this.Controls.Add(this.lbl_kafedra);
            this.Controls.Add(this.cmbBx_kafedra);
            this.Controls.Add(this.lbl_shifrDiscipline);
            this.Controls.Add(this.txtBx_shifrDiscipline);
            this.Controls.Add(this.lbl_nameDiscipline);
            this.Controls.Add(this.cmbBx_nameDiscipline);
            this.Name = "DisciplineInAcademicPlan";
            this.Text = "Дисциплины учебного плана";
            this.Load += new System.EventHandler(this.DisciplineInAcademicPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кафедрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыДисциплинBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursAuditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursSamost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_vsegoZet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursKSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbBx_nameDiscipline;
        private System.Windows.Forms.Label lbl_nameDiscipline;
        private System.Windows.Forms.TextBox txtBx_shifrDiscipline;
        private System.Windows.Forms.Label lbl_shifrDiscipline;
        private System.Windows.Forms.ComboBox cmbBx_kafedra;
        private System.Windows.Forms.Label lbl_kafedra;
        private System.Windows.Forms.Label lbl_typeDiscipline;
        private System.Windows.Forms.ComboBox cmbBx_typeDiscipline;
        private System.Windows.Forms.Label lbl_hoursAuditor;
        private System.Windows.Forms.NumericUpDown numUpDwn_hoursAuditor;
        private System.Windows.Forms.NumericUpDown numUpDwn_hoursSamost;
        private System.Windows.Forms.Label lbl_hoursSamost;
        private System.Windows.Forms.NumericUpDown numUpDwn_vsegoZet;
        private System.Windows.Forms.Label lbl_vsegoZet;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_go_semesters;
        private System.Windows.Forms.DataGridView dtGrdVw;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяДисциплиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типДисциплиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяКафедрыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дисциплинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кафедраDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource дисциплиныBindingSource;
        private UchPlanDataSetTableAdapters.ДисциплиныTableAdapter дисциплиныTableAdapter;
        private System.Windows.Forms.BindingSource типыДисциплинBindingSource;
        private UchPlanDataSetTableAdapters.Типы_дисциплинTableAdapter типы_дисциплинTableAdapter;
        private System.Windows.Forms.BindingSource кафедрыBindingSource;
        private UchPlanDataSetTableAdapters.КафедрыTableAdapter кафедрыTableAdapter;
        private System.Windows.Forms.Button btn_realizKompetenc;
        private UchPlanDataSet uchPlanDataSet;
        private UchPlanDataSetTableAdapters.Дисциплина_как_часть_учебного_планаTableAdapter дисциплина_как_часть_учебного_планаTableAdapter;
        private System.Windows.Forms.NumericUpDown numUpDwn_hoursKSR;
        private System.Windows.Forms.Label lbl_hoursKSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}