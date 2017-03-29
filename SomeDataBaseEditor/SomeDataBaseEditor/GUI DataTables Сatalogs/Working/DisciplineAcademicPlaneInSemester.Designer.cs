namespace SomeDataBaseEditor.GUI_DataTables.Working
{
    partial class DisciplineAcademicPlaneInSemester
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
            this.dtGrdVw = new System.Windows.Forms.DataGridView();
            this.cmbBx_SemesterNum = new System.Windows.Forms.ComboBox();
            this.семестрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.lbl_SemesterNum = new System.Windows.Forms.Label();
            this.cmbBx_FormControl = new System.Windows.Forms.ComboBox();
            this.формыКонтроляBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBx_Hours = new System.Windows.Forms.GroupBox();
            this.numUpDwn_hoursLab = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_hoursKSR = new System.Windows.Forms.NumericUpDown();
            this.lbl_hoursLab = new System.Windows.Forms.Label();
            this.numUpDwn_hoursPract = new System.Windows.Forms.NumericUpDown();
            this.numUpDwn_hoursAuditor = new System.Windows.Forms.NumericUpDown();
            this.lbl_hoursKSR = new System.Windows.Forms.Label();
            this.lbl_hoursPract = new System.Windows.Forms.Label();
            this.lbl_hoursAuditor = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.семестрыTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.СеместрыTableAdapter();
            this.формы_контроляTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Формы_контроляTableAdapter();
            this.lstBx_ControlInSemestr = new System.Windows.Forms.ListBox();
            this.формы_Контроля_В_СеместреTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Формы_Контроля_В_СеместреTableAdapter();
            this.btn_addFormControl = new System.Windows.Forms.Button();
            this.btn_delFormControl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.дисциплина_как_часть_семестраTableAdapter1 = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Дисциплина_как_часть_семестраTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.семестрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.формыКонтроляBindingSource)).BeginInit();
            this.groupBx_Hours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursKSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursPract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursAuditor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AllowUserToAddRows = false;
            this.dtGrdVw.AllowUserToDeleteRows = false;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Location = new System.Drawing.Point(12, 12);
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.ReadOnly = true;
            this.dtGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVw.Size = new System.Drawing.Size(441, 150);
            this.dtGrdVw.TabIndex = 27;
            this.dtGrdVw.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // cmbBx_SemesterNum
            // 
            this.cmbBx_SemesterNum.DataSource = this.семестрыBindingSource;
            this.cmbBx_SemesterNum.DisplayMember = "Номер";
            this.cmbBx_SemesterNum.FormattingEnabled = true;
            this.cmbBx_SemesterNum.Location = new System.Drawing.Point(12, 189);
            this.cmbBx_SemesterNum.Name = "cmbBx_SemesterNum";
            this.cmbBx_SemesterNum.Size = new System.Drawing.Size(68, 21);
            this.cmbBx_SemesterNum.TabIndex = 23;
            this.cmbBx_SemesterNum.ValueMember = "Код";
            // 
            // семестрыBindingSource
            // 
            this.семестрыBindingSource.DataMember = "Семестры";
            this.семестрыBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // uchPlanDataSet
            // 
            this.uchPlanDataSet.DataSetName = "UchPlanDataSet";
            this.uchPlanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_SemesterNum
            // 
            this.lbl_SemesterNum.AutoSize = true;
            this.lbl_SemesterNum.Location = new System.Drawing.Point(9, 173);
            this.lbl_SemesterNum.Name = "lbl_SemesterNum";
            this.lbl_SemesterNum.Size = new System.Drawing.Size(51, 13);
            this.lbl_SemesterNum.TabIndex = 24;
            this.lbl_SemesterNum.Text = "Семестр";
            // 
            // cmbBx_FormControl
            // 
            this.cmbBx_FormControl.DataSource = this.формыКонтроляBindingSource;
            this.cmbBx_FormControl.DisplayMember = "Имя";
            this.cmbBx_FormControl.FormattingEnabled = true;
            this.cmbBx_FormControl.Location = new System.Drawing.Point(6, 126);
            this.cmbBx_FormControl.Name = "cmbBx_FormControl";
            this.cmbBx_FormControl.Size = new System.Drawing.Size(140, 21);
            this.cmbBx_FormControl.TabIndex = 25;
            this.cmbBx_FormControl.ValueMember = "Код";
            // 
            // формыКонтроляBindingSource
            // 
            this.формыКонтроляBindingSource.DataMember = "Формы контроля";
            this.формыКонтроляBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // groupBx_Hours
            // 
            this.groupBx_Hours.Controls.Add(this.numUpDwn_hoursLab);
            this.groupBx_Hours.Controls.Add(this.numUpDwn_hoursKSR);
            this.groupBx_Hours.Controls.Add(this.lbl_hoursLab);
            this.groupBx_Hours.Controls.Add(this.numUpDwn_hoursPract);
            this.groupBx_Hours.Controls.Add(this.numUpDwn_hoursAuditor);
            this.groupBx_Hours.Controls.Add(this.lbl_hoursKSR);
            this.groupBx_Hours.Controls.Add(this.lbl_hoursPract);
            this.groupBx_Hours.Controls.Add(this.lbl_hoursAuditor);
            this.groupBx_Hours.Location = new System.Drawing.Point(17, 216);
            this.groupBx_Hours.Name = "groupBx_Hours";
            this.groupBx_Hours.Size = new System.Drawing.Size(251, 142);
            this.groupBx_Hours.TabIndex = 28;
            this.groupBx_Hours.TabStop = false;
            this.groupBx_Hours.Text = "Часы";
            // 
            // numUpDwn_hoursLab
            // 
            this.numUpDwn_hoursLab.Location = new System.Drawing.Point(168, 51);
            this.numUpDwn_hoursLab.Name = "numUpDwn_hoursLab";
            this.numUpDwn_hoursLab.Size = new System.Drawing.Size(73, 20);
            this.numUpDwn_hoursLab.TabIndex = 7;
            // 
            // numUpDwn_hoursKSR
            // 
            this.numUpDwn_hoursKSR.Location = new System.Drawing.Point(168, 111);
            this.numUpDwn_hoursKSR.Name = "numUpDwn_hoursKSR";
            this.numUpDwn_hoursKSR.Size = new System.Drawing.Size(73, 20);
            this.numUpDwn_hoursKSR.TabIndex = 5;
            // 
            // lbl_hoursLab
            // 
            this.lbl_hoursLab.AutoSize = true;
            this.lbl_hoursLab.Location = new System.Drawing.Point(6, 45);
            this.lbl_hoursLab.Name = "lbl_hoursLab";
            this.lbl_hoursLab.Size = new System.Drawing.Size(82, 26);
            this.lbl_hoursLab.TabIndex = 6;
            this.lbl_hoursLab.Text = "лабораторных \r\nработ";
            // 
            // numUpDwn_hoursPract
            // 
            this.numUpDwn_hoursPract.Location = new System.Drawing.Point(168, 82);
            this.numUpDwn_hoursPract.Name = "numUpDwn_hoursPract";
            this.numUpDwn_hoursPract.Size = new System.Drawing.Size(73, 20);
            this.numUpDwn_hoursPract.TabIndex = 4;
            // 
            // numUpDwn_hoursAuditor
            // 
            this.numUpDwn_hoursAuditor.Location = new System.Drawing.Point(168, 18);
            this.numUpDwn_hoursAuditor.Name = "numUpDwn_hoursAuditor";
            this.numUpDwn_hoursAuditor.Size = new System.Drawing.Size(73, 20);
            this.numUpDwn_hoursAuditor.TabIndex = 3;
            // 
            // lbl_hoursKSR
            // 
            this.lbl_hoursKSR.AutoSize = true;
            this.lbl_hoursKSR.Location = new System.Drawing.Point(6, 108);
            this.lbl_hoursKSR.Name = "lbl_hoursKSR";
            this.lbl_hoursKSR.Size = new System.Drawing.Size(123, 26);
            this.lbl_hoursKSR.TabIndex = 2;
            this.lbl_hoursKSR.Text = "Контрольно-срезовые \r\nработ";
            // 
            // lbl_hoursPract
            // 
            this.lbl_hoursPract.AutoSize = true;
            this.lbl_hoursPract.Location = new System.Drawing.Point(7, 84);
            this.lbl_hoursPract.Name = "lbl_hoursPract";
            this.lbl_hoursPract.Size = new System.Drawing.Size(56, 13);
            this.lbl_hoursPract.TabIndex = 1;
            this.lbl_hoursPract.Text = "Практики";
            // 
            // lbl_hoursAuditor
            // 
            this.lbl_hoursAuditor.AutoSize = true;
            this.lbl_hoursAuditor.Location = new System.Drawing.Point(6, 20);
            this.lbl_hoursAuditor.Name = "lbl_hoursAuditor";
            this.lbl_hoursAuditor.Size = new System.Drawing.Size(45, 13);
            this.lbl_hoursAuditor.TabIndex = 0;
            this.lbl_hoursAuditor.Text = "Лекций";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 364);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(56, 26);
            this.btn_insert.TabIndex = 29;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(185, 364);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(56, 26);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(397, 364);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 26);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // семестрыTableAdapter
            // 
            this.семестрыTableAdapter.ClearBeforeFill = true;
            // 
            // формы_контроляTableAdapter
            // 
            this.формы_контроляTableAdapter.ClearBeforeFill = true;
            // 
            // lstBx_ControlInSemestr
            // 
            this.lstBx_ControlInSemestr.FormattingEnabled = true;
            this.lstBx_ControlInSemestr.Location = new System.Drawing.Point(6, 19);
            this.lstBx_ControlInSemestr.Name = "lstBx_ControlInSemestr";
            this.lstBx_ControlInSemestr.Size = new System.Drawing.Size(140, 95);
            this.lstBx_ControlInSemestr.TabIndex = 32;
            // 
            // формы_Контроля_В_СеместреTableAdapter
            // 
            this.формы_Контроля_В_СеместреTableAdapter.ClearBeforeFill = true;
            // 
            // btn_addFormControl
            // 
            this.btn_addFormControl.Location = new System.Drawing.Point(3, 154);
            this.btn_addFormControl.Name = "btn_addFormControl";
            this.btn_addFormControl.Size = new System.Drawing.Size(63, 23);
            this.btn_addFormControl.TabIndex = 34;
            this.btn_addFormControl.Text = "+";
            this.btn_addFormControl.UseVisualStyleBackColor = true;
            this.btn_addFormControl.Click += new System.EventHandler(this.btn_addFormControl_Click);
            // 
            // btn_delFormControl
            // 
            this.btn_delFormControl.Location = new System.Drawing.Point(83, 154);
            this.btn_delFormControl.Name = "btn_delFormControl";
            this.btn_delFormControl.Size = new System.Drawing.Size(63, 23);
            this.btn_delFormControl.TabIndex = 35;
            this.btn_delFormControl.Text = "x";
            this.btn_delFormControl.UseVisualStyleBackColor = true;
            this.btn_delFormControl.Click += new System.EventHandler(this.btn_delFormControl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBx_ControlInSemestr);
            this.groupBox1.Controls.Add(this.btn_delFormControl);
            this.groupBox1.Controls.Add(this.cmbBx_FormControl);
            this.groupBox1.Controls.Add(this.btn_addFormControl);
            this.groupBox1.Location = new System.Drawing.Point(300, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 185);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формы контроля";
            // 
            // дисциплина_как_часть_семестраTableAdapter1
            // 
            this.дисциплина_как_часть_семестраTableAdapter1.ClearBeforeFill = true;
            // 
            // DisciplineAcademicPlaneInSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.groupBx_Hours);
            this.Controls.Add(this.dtGrdVw);
            this.Controls.Add(this.cmbBx_SemesterNum);
            this.Controls.Add(this.lbl_SemesterNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DisciplineAcademicPlaneInSemester";
            this.Text = "Часы и контроль дисциплины в учебном плане";
            this.Load += new System.EventHandler(this.DisciplineAcademicPlaneInSemester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.семестрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.формыКонтроляBindingSource)).EndInit();
            this.groupBx_Hours.ResumeLayout(false);
            this.groupBx_Hours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursKSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursPract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursAuditor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVw;
        private System.Windows.Forms.ComboBox cmbBx_SemesterNum;
        private System.Windows.Forms.Label lbl_SemesterNum;
        private System.Windows.Forms.ComboBox cmbBx_FormControl;
        private System.Windows.Forms.GroupBox groupBx_Hours;
        private System.Windows.Forms.NumericUpDown numUpDwn_hoursKSR;
        private System.Windows.Forms.NumericUpDown numUpDwn_hoursPract;
        private System.Windows.Forms.NumericUpDown numUpDwn_hoursAuditor;
        private System.Windows.Forms.Label lbl_hoursKSR;
        private System.Windows.Forms.Label lbl_hoursPract;
        private System.Windows.Forms.Label lbl_hoursAuditor;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодУчебногоПланаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСеместраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДисциплиныDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часыЛекцийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часыПрактикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часыКСРDataGridViewTextBoxColumn;
        private UchPlanDataSet uchPlanDataSet;
        private System.Windows.Forms.BindingSource семестрыBindingSource;
        private UchPlanDataSetTableAdapters.СеместрыTableAdapter семестрыTableAdapter;
        private System.Windows.Forms.BindingSource формыКонтроляBindingSource;
        private UchPlanDataSetTableAdapters.Формы_контроляTableAdapter формы_контроляTableAdapter;
        private System.Windows.Forms.ListBox lstBx_ControlInSemestr;
        private UchPlanDataSetTableAdapters.Формы_Контроля_В_СеместреTableAdapter формы_Контроля_В_СеместреTableAdapter;
        private System.Windows.Forms.Button btn_addFormControl;
        private System.Windows.Forms.Button btn_delFormControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private UchPlanDataSetTableAdapters.Дисциплина_как_часть_семестраTableAdapter дисциплина_как_часть_семестраTableAdapter1;
        private System.Windows.Forms.NumericUpDown numUpDwn_hoursLab;
        private System.Windows.Forms.Label lbl_hoursLab;
    }
}