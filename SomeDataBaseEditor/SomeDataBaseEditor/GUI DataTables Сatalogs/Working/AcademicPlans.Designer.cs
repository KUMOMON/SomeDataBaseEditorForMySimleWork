namespace SomeDataBaseEditor.GUI_DataTables.Working
{
    partial class AcademicPlans
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.профильПодогтовкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квалификацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКвалификацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаУтвержденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ктоУтвердилDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодФормыОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.учебныеПланыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учебные_планыTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Учебные_планыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебныеПланыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.профильПодогтовкиDataGridViewTextBoxColumn,
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn,
            this.квалификацияDataGridViewTextBoxColumn,
            this.кодКвалификацииDataGridViewTextBoxColumn,
            this.датаУтвержденияDataGridViewTextBoxColumn,
            this.ктоУтвердилDataGridViewTextBoxColumn,
            this.формаОбученияDataGridViewTextBoxColumn,
            this.кодФормыОбученияDataGridViewTextBoxColumn,
            this.срокОбученияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.учебныеПланыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(927, 352);
            this.dataGridView1.TabIndex = 0;
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
            // профильПодогтовкиDataGridViewTextBoxColumn
            // 
            this.профильПодогтовкиDataGridViewTextBoxColumn.DataPropertyName = "Профиль подогтовки";
            this.профильПодогтовкиDataGridViewTextBoxColumn.HeaderText = "Профиль подогтовки";
            this.профильПодогтовкиDataGridViewTextBoxColumn.Name = "профильПодогтовкиDataGridViewTextBoxColumn";
            this.профильПодогтовкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.профильПодогтовкиDataGridViewTextBoxColumn.Width = 127;
            // 
            // кодПрофиляПодготовкиDataGridViewTextBoxColumn
            // 
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn.DataPropertyName = "Код профиля подготовки";
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn.HeaderText = "Код профиля подготовки";
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn.Name = "кодПрофиляПодготовкиDataGridViewTextBoxColumn";
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn.Visible = false;
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn.Width = 145;
            // 
            // квалификацияDataGridViewTextBoxColumn
            // 
            this.квалификацияDataGridViewTextBoxColumn.DataPropertyName = "Квалификация";
            this.квалификацияDataGridViewTextBoxColumn.HeaderText = "Квалификация";
            this.квалификацияDataGridViewTextBoxColumn.Name = "квалификацияDataGridViewTextBoxColumn";
            this.квалификацияDataGridViewTextBoxColumn.ReadOnly = true;
            this.квалификацияDataGridViewTextBoxColumn.Width = 107;
            // 
            // кодКвалификацииDataGridViewTextBoxColumn
            // 
            this.кодКвалификацииDataGridViewTextBoxColumn.DataPropertyName = "Код квалификации";
            this.кодКвалификацииDataGridViewTextBoxColumn.HeaderText = "Код квалификации";
            this.кодКвалификацииDataGridViewTextBoxColumn.Name = "кодКвалификацииDataGridViewTextBoxColumn";
            this.кодКвалификацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодКвалификацииDataGridViewTextBoxColumn.Visible = false;
            this.кодКвалификацииDataGridViewTextBoxColumn.Width = 117;
            // 
            // датаУтвержденияDataGridViewTextBoxColumn
            // 
            this.датаУтвержденияDataGridViewTextBoxColumn.DataPropertyName = "Дата утверждения";
            this.датаУтвержденияDataGridViewTextBoxColumn.HeaderText = "Дата утверждения";
            this.датаУтвержденияDataGridViewTextBoxColumn.Name = "датаУтвержденияDataGridViewTextBoxColumn";
            this.датаУтвержденияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаУтвержденияDataGridViewTextBoxColumn.Width = 116;
            // 
            // ктоУтвердилDataGridViewTextBoxColumn
            // 
            this.ктоУтвердилDataGridViewTextBoxColumn.DataPropertyName = "Кто утвердил";
            this.ктоУтвердилDataGridViewTextBoxColumn.HeaderText = "Кто утвердил";
            this.ктоУтвердилDataGridViewTextBoxColumn.Name = "ктоУтвердилDataGridViewTextBoxColumn";
            this.ктоУтвердилDataGridViewTextBoxColumn.ReadOnly = true;
            this.ктоУтвердилDataGridViewTextBoxColumn.Width = 91;
            // 
            // формаОбученияDataGridViewTextBoxColumn
            // 
            this.формаОбученияDataGridViewTextBoxColumn.DataPropertyName = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.Name = "формаОбученияDataGridViewTextBoxColumn";
            this.формаОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.формаОбученияDataGridViewTextBoxColumn.Width = 108;
            // 
            // кодФормыОбученияDataGridViewTextBoxColumn
            // 
            this.кодФормыОбученияDataGridViewTextBoxColumn.DataPropertyName = "Код формы обучения";
            this.кодФормыОбученияDataGridViewTextBoxColumn.HeaderText = "Код формы обучения";
            this.кодФормыОбученияDataGridViewTextBoxColumn.Name = "кодФормыОбученияDataGridViewTextBoxColumn";
            this.кодФормыОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодФормыОбученияDataGridViewTextBoxColumn.Visible = false;
            this.кодФормыОбученияDataGridViewTextBoxColumn.Width = 127;
            // 
            // срокОбученияDataGridViewTextBoxColumn
            // 
            this.срокОбученияDataGridViewTextBoxColumn.DataPropertyName = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.HeaderText = "Срок обучения";
            this.срокОбученияDataGridViewTextBoxColumn.Name = "срокОбученияDataGridViewTextBoxColumn";
            this.срокОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            this.срокОбученияDataGridViewTextBoxColumn.Width = 97;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(864, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Семестры";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(713, 370);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Дисциплины в уч. плана";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // uchPlanDataSet
            // 
            this.uchPlanDataSet.DataSetName = "UchPlanDataSet";
            this.uchPlanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учебныеПланыBindingSource
            // 
            this.учебныеПланыBindingSource.DataMember = "Учебные планы";
            this.учебныеПланыBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // учебные_планыTableAdapter
            // 
            this.учебные_планыTableAdapter.ClearBeforeFill = true;
            // 
            // AcademicPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 474);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AcademicPlans";
            this.Text = "Academic_plans";
            this.Load += new System.EventHandler(this.AcademicPlans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебныеПланыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn профильПодогтовкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПрофиляПодготовкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn квалификацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКвалификацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаУтвержденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ктоУтвердилDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодФормыОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокОбученияDataGridViewTextBoxColumn;
        private UchPlanDataSet uchPlanDataSet;
        private System.Windows.Forms.BindingSource учебныеПланыBindingSource;
        private UchPlanDataSetTableAdapters.Учебные_планыTableAdapter учебные_планыTableAdapter;
    }
}