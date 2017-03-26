namespace SomeDataBaseEditor.GUI_DataTables.Working
{
    partial class Semesters
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
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодУчебногоПланаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ковоНедельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обязательныхЭкзаменовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обязательныхКурсовыхРаботDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обязательныхЗачетовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обязательныхКурсовыхПроектовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семестрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.numUpDwn_SemesterNum = new System.Windows.Forms.NumericUpDown();
            this.lbl_SemesterNum = new System.Windows.Forms.Label();
            this.lbl_countWeeks = new System.Windows.Forms.Label();
            this.numUpDwn_countWeeks = new System.Windows.Forms.NumericUpDown();
            this.lbl_hoursOfSport = new System.Windows.Forms.Label();
            this.numUpDwn_hoursOfSport = new System.Windows.Forms.NumericUpDown();
            this.lbl_CountExam = new System.Windows.Forms.Label();
            this.numUpDwn_CountExam = new System.Windows.Forms.NumericUpDown();
            this.lbl_CountCourseWork = new System.Windows.Forms.Label();
            this.numUpDwn_CountCourseWork = new System.Windows.Forms.NumericUpDown();
            this.lbl_CountCourseProj = new System.Windows.Forms.Label();
            this.numUpDwn_CountCourseProj = new System.Windows.Forms.NumericUpDown();
            this.lbl_CountOffset = new System.Windows.Forms.Label();
            this.numUpDwn_CountOffset = new System.Windows.Forms.NumericUpDown();
            this.семестрыTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.СеместрыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.семестрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_SemesterNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_countWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursOfSport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CountExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CountCourseWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CountCourseProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CountOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AllowUserToAddRows = false;
            this.dtGrdVw.AllowUserToDeleteRows = false;
            this.dtGrdVw.AutoGenerateColumns = false;
            this.dtGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrdVw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.кодУчебногоПланаDataGridViewTextBoxColumn,
            this.номерDataGridViewTextBoxColumn,
            this.ковоНедельDataGridViewTextBoxColumn,
            this.обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn,
            this.обязательныхЭкзаменовDataGridViewTextBoxColumn,
            this.обязательныхКурсовыхРаботDataGridViewTextBoxColumn,
            this.обязательныхЗачетовDataGridViewTextBoxColumn,
            this.обязательныхКурсовыхПроектовDataGridViewTextBoxColumn});
            this.dtGrdVw.DataSource = this.семестрыBindingSource;
            this.dtGrdVw.Location = new System.Drawing.Point(12, 12);
            this.dtGrdVw.MultiSelect = false;
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.ReadOnly = true;
            this.dtGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVw.Size = new System.Drawing.Size(713, 168);
            this.dtGrdVw.TabIndex = 0;
            this.dtGrdVw.SelectionChanged += new System.EventHandler(this.dtGrdVw_SelectionChanged);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Visible = false;
            this.кодDataGridViewTextBoxColumn.Width = 51;
            // 
            // кодУчебногоПланаDataGridViewTextBoxColumn
            // 
            this.кодУчебногоПланаDataGridViewTextBoxColumn.DataPropertyName = "Код учебного плана";
            this.кодУчебногоПланаDataGridViewTextBoxColumn.HeaderText = "Код учебного плана";
            this.кодУчебногоПланаDataGridViewTextBoxColumn.Name = "кодУчебногоПланаDataGridViewTextBoxColumn";
            this.кодУчебногоПланаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодУчебногоПланаDataGridViewTextBoxColumn.Visible = false;
            this.кодУчебногоПланаDataGridViewTextBoxColumn.Width = 132;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            this.номерDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерDataGridViewTextBoxColumn.Width = 66;
            // 
            // ковоНедельDataGridViewTextBoxColumn
            // 
            this.ковоНедельDataGridViewTextBoxColumn.DataPropertyName = "Ко-во недель";
            this.ковоНедельDataGridViewTextBoxColumn.HeaderText = "Ко-во недель";
            this.ковоНедельDataGridViewTextBoxColumn.Name = "ковоНедельDataGridViewTextBoxColumn";
            this.ковоНедельDataGridViewTextBoxColumn.ReadOnly = true;
            this.ковоНедельDataGridViewTextBoxColumn.Width = 91;
            // 
            // обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn
            // 
            this.обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn.DataPropertyName = "Обязательных часов физкультуры в неделя";
            this.обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn.HeaderText = "Обязательных часов физкультуры в неделя";
            this.обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn.Name = "обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn";
            this.обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn.ReadOnly = true;
            this.обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn.Width = 200;
            // 
            // обязательныхЭкзаменовDataGridViewTextBoxColumn
            // 
            this.обязательныхЭкзаменовDataGridViewTextBoxColumn.DataPropertyName = "Обязательных экзаменов";
            this.обязательныхЭкзаменовDataGridViewTextBoxColumn.HeaderText = "Обязательных экзаменов";
            this.обязательныхЭкзаменовDataGridViewTextBoxColumn.Name = "обязательныхЭкзаменовDataGridViewTextBoxColumn";
            this.обязательныхЭкзаменовDataGridViewTextBoxColumn.ReadOnly = true;
            this.обязательныхЭкзаменовDataGridViewTextBoxColumn.Width = 150;
            // 
            // обязательныхКурсовыхРаботDataGridViewTextBoxColumn
            // 
            this.обязательныхКурсовыхРаботDataGridViewTextBoxColumn.DataPropertyName = "Обязательных курсовых работ";
            this.обязательныхКурсовыхРаботDataGridViewTextBoxColumn.HeaderText = "Обязательных курсовых работ";
            this.обязательныхКурсовыхРаботDataGridViewTextBoxColumn.Name = "обязательныхКурсовыхРаботDataGridViewTextBoxColumn";
            this.обязательныхКурсовыхРаботDataGridViewTextBoxColumn.ReadOnly = true;
            this.обязательныхКурсовыхРаботDataGridViewTextBoxColumn.Width = 146;
            // 
            // обязательныхЗачетовDataGridViewTextBoxColumn
            // 
            this.обязательныхЗачетовDataGridViewTextBoxColumn.DataPropertyName = "Обязательных зачетов";
            this.обязательныхЗачетовDataGridViewTextBoxColumn.HeaderText = "Обязательных зачетов";
            this.обязательныхЗачетовDataGridViewTextBoxColumn.Name = "обязательныхЗачетовDataGridViewTextBoxColumn";
            this.обязательныхЗачетовDataGridViewTextBoxColumn.ReadOnly = true;
            this.обязательныхЗачетовDataGridViewTextBoxColumn.Width = 136;
            // 
            // обязательныхКурсовыхПроектовDataGridViewTextBoxColumn
            // 
            this.обязательныхКурсовыхПроектовDataGridViewTextBoxColumn.DataPropertyName = "Обязательных курсовых проектов";
            this.обязательныхКурсовыхПроектовDataGridViewTextBoxColumn.HeaderText = "Обязательных курсовых проектов";
            this.обязательныхКурсовыхПроектовDataGridViewTextBoxColumn.Name = "обязательныхКурсовыхПроектовDataGridViewTextBoxColumn";
            this.обязательныхКурсовыхПроектовDataGridViewTextBoxColumn.ReadOnly = true;
            this.обязательныхКурсовыхПроектовDataGridViewTextBoxColumn.Width = 146;
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
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(653, 190);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(72, 25);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(653, 221);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(72, 24);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(653, 251);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(72, 31);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Remove";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // numUpDwn_SemesterNum
            // 
            this.numUpDwn_SemesterNum.Location = new System.Drawing.Point(114, 193);
            this.numUpDwn_SemesterNum.Name = "numUpDwn_SemesterNum";
            this.numUpDwn_SemesterNum.Size = new System.Drawing.Size(44, 20);
            this.numUpDwn_SemesterNum.TabIndex = 4;
            // 
            // lbl_SemesterNum
            // 
            this.lbl_SemesterNum.AutoSize = true;
            this.lbl_SemesterNum.Location = new System.Drawing.Point(12, 195);
            this.lbl_SemesterNum.Name = "lbl_SemesterNum";
            this.lbl_SemesterNum.Size = new System.Drawing.Size(96, 13);
            this.lbl_SemesterNum.TabIndex = 5;
            this.lbl_SemesterNum.Text = "Номер семестра:";
            // 
            // lbl_countWeeks
            // 
            this.lbl_countWeeks.AutoSize = true;
            this.lbl_countWeeks.Location = new System.Drawing.Point(12, 220);
            this.lbl_countWeeks.Name = "lbl_countWeeks";
            this.lbl_countWeeks.Size = new System.Drawing.Size(80, 13);
            this.lbl_countWeeks.TabIndex = 7;
            this.lbl_countWeeks.Text = "Кол-во недель";
            // 
            // numUpDwn_countWeeks
            // 
            this.numUpDwn_countWeeks.Location = new System.Drawing.Point(114, 218);
            this.numUpDwn_countWeeks.Name = "numUpDwn_countWeeks";
            this.numUpDwn_countWeeks.Size = new System.Drawing.Size(44, 20);
            this.numUpDwn_countWeeks.TabIndex = 6;
            // 
            // lbl_hoursOfSport
            // 
            this.lbl_hoursOfSport.AutoSize = true;
            this.lbl_hoursOfSport.Location = new System.Drawing.Point(405, 259);
            this.lbl_hoursOfSport.Name = "lbl_hoursOfSport";
            this.lbl_hoursOfSport.Size = new System.Drawing.Size(192, 13);
            this.lbl_hoursOfSport.TabIndex = 9;
            this.lbl_hoursOfSport.Text = "Обязательных часов физ-ры (в нед.)";
            // 
            // numUpDwn_hoursOfSport
            // 
            this.numUpDwn_hoursOfSport.Location = new System.Drawing.Point(603, 257);
            this.numUpDwn_hoursOfSport.Name = "numUpDwn_hoursOfSport";
            this.numUpDwn_hoursOfSport.Size = new System.Drawing.Size(44, 20);
            this.numUpDwn_hoursOfSport.TabIndex = 8;
            // 
            // lbl_CountExam
            // 
            this.lbl_CountExam.AutoSize = true;
            this.lbl_CountExam.Location = new System.Drawing.Point(184, 194);
            this.lbl_CountExam.Name = "lbl_CountExam";
            this.lbl_CountExam.Size = new System.Drawing.Size(140, 13);
            this.lbl_CountExam.TabIndex = 11;
            this.lbl_CountExam.Text = "Обязательных экзаменов";
            // 
            // numUpDwn_CountExam
            // 
            this.numUpDwn_CountExam.Location = new System.Drawing.Point(330, 194);
            this.numUpDwn_CountExam.Name = "numUpDwn_CountExam";
            this.numUpDwn_CountExam.Size = new System.Drawing.Size(44, 20);
            this.numUpDwn_CountExam.TabIndex = 10;
            // 
            // lbl_CountCourseWork
            // 
            this.lbl_CountCourseWork.AutoSize = true;
            this.lbl_CountCourseWork.Location = new System.Drawing.Point(418, 227);
            this.lbl_CountCourseWork.Name = "lbl_CountCourseWork";
            this.lbl_CountCourseWork.Size = new System.Drawing.Size(164, 13);
            this.lbl_CountCourseWork.TabIndex = 13;
            this.lbl_CountCourseWork.Text = "Обязательных курсовых работ\r\n";
            // 
            // numUpDwn_CountCourseWork
            // 
            this.numUpDwn_CountCourseWork.Location = new System.Drawing.Point(603, 225);
            this.numUpDwn_CountCourseWork.Name = "numUpDwn_CountCourseWork";
            this.numUpDwn_CountCourseWork.Size = new System.Drawing.Size(44, 20);
            this.numUpDwn_CountCourseWork.TabIndex = 12;
            // 
            // lbl_CountCourseProj
            // 
            this.lbl_CountCourseProj.AutoSize = true;
            this.lbl_CountCourseProj.Location = new System.Drawing.Point(405, 199);
            this.lbl_CountCourseProj.Name = "lbl_CountCourseProj";
            this.lbl_CountCourseProj.Size = new System.Drawing.Size(182, 13);
            this.lbl_CountCourseProj.TabIndex = 15;
            this.lbl_CountCourseProj.Text = "Обязательных курсовых проектов\r\n";
            // 
            // numUpDwn_CountCourseProj
            // 
            this.numUpDwn_CountCourseProj.Location = new System.Drawing.Point(603, 192);
            this.numUpDwn_CountCourseProj.Name = "numUpDwn_CountCourseProj";
            this.numUpDwn_CountCourseProj.Size = new System.Drawing.Size(44, 20);
            this.numUpDwn_CountCourseProj.TabIndex = 14;
            // 
            // lbl_CountOffset
            // 
            this.lbl_CountOffset.AutoSize = true;
            this.lbl_CountOffset.Location = new System.Drawing.Point(184, 225);
            this.lbl_CountOffset.Name = "lbl_CountOffset";
            this.lbl_CountOffset.Size = new System.Drawing.Size(124, 13);
            this.lbl_CountOffset.TabIndex = 17;
            this.lbl_CountOffset.Text = "Обязательных зачетов";
            // 
            // numUpDwn_CountOffset
            // 
            this.numUpDwn_CountOffset.Location = new System.Drawing.Point(330, 221);
            this.numUpDwn_CountOffset.Name = "numUpDwn_CountOffset";
            this.numUpDwn_CountOffset.Size = new System.Drawing.Size(44, 20);
            this.numUpDwn_CountOffset.TabIndex = 16;
            // 
            // семестрыTableAdapter
            // 
            this.семестрыTableAdapter.ClearBeforeFill = true;
            // 
            // Semesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 290);
            this.Controls.Add(this.lbl_CountOffset);
            this.Controls.Add(this.numUpDwn_CountOffset);
            this.Controls.Add(this.lbl_CountCourseProj);
            this.Controls.Add(this.numUpDwn_CountCourseProj);
            this.Controls.Add(this.lbl_CountCourseWork);
            this.Controls.Add(this.numUpDwn_CountCourseWork);
            this.Controls.Add(this.lbl_CountExam);
            this.Controls.Add(this.numUpDwn_CountExam);
            this.Controls.Add(this.lbl_hoursOfSport);
            this.Controls.Add(this.numUpDwn_hoursOfSport);
            this.Controls.Add(this.lbl_countWeeks);
            this.Controls.Add(this.numUpDwn_countWeeks);
            this.Controls.Add(this.lbl_SemesterNum);
            this.Controls.Add(this.numUpDwn_SemesterNum);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dtGrdVw);
            this.Name = "Semesters";
            this.Text = "Semesters";
            this.Load += new System.EventHandler(this.Semesters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.семестрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_SemesterNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_countWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_hoursOfSport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CountExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CountCourseWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CountCourseProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CountOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVw;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.NumericUpDown numUpDwn_SemesterNum;
        private System.Windows.Forms.Label lbl_SemesterNum;
        private System.Windows.Forms.Label lbl_countWeeks;
        private System.Windows.Forms.NumericUpDown numUpDwn_countWeeks;
        private System.Windows.Forms.Label lbl_hoursOfSport;
        private System.Windows.Forms.NumericUpDown numUpDwn_hoursOfSport;
        private System.Windows.Forms.Label lbl_CountExam;
        private System.Windows.Forms.NumericUpDown numUpDwn_CountExam;
        private System.Windows.Forms.Label lbl_CountCourseWork;
        private System.Windows.Forms.NumericUpDown numUpDwn_CountCourseWork;
        private System.Windows.Forms.Label lbl_CountCourseProj;
        private System.Windows.Forms.NumericUpDown numUpDwn_CountCourseProj;
        private System.Windows.Forms.Label lbl_CountOffset;
        private System.Windows.Forms.NumericUpDown numUpDwn_CountOffset;
        private UchPlanDataSet uchPlanDataSet;
        private System.Windows.Forms.BindingSource семестрыBindingSource;
        private UchPlanDataSetTableAdapters.СеместрыTableAdapter семестрыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодУчебногоПланаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ковоНедельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обязательныхЧасовФизкультурыВНеделяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обязательныхЭкзаменовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обязательныхКурсовыхРаботDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обязательныхЗачетовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обязательныхКурсовыхПроектовDataGridViewTextBoxColumn;
    }
}