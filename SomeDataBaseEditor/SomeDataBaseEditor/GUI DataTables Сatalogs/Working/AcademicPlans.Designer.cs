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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.учебныеПланыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учебные_планыTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Учебные_планыTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКвалификацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаУтвержденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ктоУтвердилDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодФормыОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебныеПланыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn,
            this.кодКвалификацииDataGridViewTextBoxColumn,
            this.датаУтвержденияDataGridViewTextBoxColumn,
            this.ктоУтвердилDataGridViewTextBoxColumn,
            this.кодФормыОбученияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.учебныеПланыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Семестры";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(539, 328);
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
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодПрофиляПодготовкиDataGridViewTextBoxColumn
            // 
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn.DataPropertyName = "Код профиля подготовки";
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn.HeaderText = "Код профиля подготовки";
            this.кодПрофиляПодготовкиDataGridViewTextBoxColumn.Name = "кодПрофиляПодготовкиDataGridViewTextBoxColumn";
            // 
            // кодКвалификацииDataGridViewTextBoxColumn
            // 
            this.кодКвалификацииDataGridViewTextBoxColumn.DataPropertyName = "Код квалификации";
            this.кодКвалификацииDataGridViewTextBoxColumn.HeaderText = "Код квалификации";
            this.кодКвалификацииDataGridViewTextBoxColumn.Name = "кодКвалификацииDataGridViewTextBoxColumn";
            // 
            // датаУтвержденияDataGridViewTextBoxColumn
            // 
            this.датаУтвержденияDataGridViewTextBoxColumn.DataPropertyName = "Дата утверждения";
            this.датаУтвержденияDataGridViewTextBoxColumn.HeaderText = "Дата утверждения";
            this.датаУтвержденияDataGridViewTextBoxColumn.Name = "датаУтвержденияDataGridViewTextBoxColumn";
            // 
            // ктоУтвердилDataGridViewTextBoxColumn
            // 
            this.ктоУтвердилDataGridViewTextBoxColumn.DataPropertyName = "Кто утвердил";
            this.ктоУтвердилDataGridViewTextBoxColumn.HeaderText = "Кто утвердил";
            this.ктоУтвердилDataGridViewTextBoxColumn.Name = "ктоУтвердилDataGridViewTextBoxColumn";
            // 
            // кодФормыОбученияDataGridViewTextBoxColumn
            // 
            this.кодФормыОбученияDataGridViewTextBoxColumn.DataPropertyName = "Код формы обучения";
            this.кодФормыОбученияDataGridViewTextBoxColumn.HeaderText = "Код формы обучения";
            this.кодФормыОбученияDataGridViewTextBoxColumn.Name = "кодФормыОбученияDataGridViewTextBoxColumn";
            // 
            // AcademicPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 362);
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
        private UchPlanDataSet uchPlanDataSet;
        private System.Windows.Forms.BindingSource учебныеПланыBindingSource;
        private UchPlanDataSetTableAdapters.Учебные_планыTableAdapter учебные_планыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПрофиляПодготовкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКвалификацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаУтвержденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ктоУтвердилDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодФормыОбученияDataGridViewTextBoxColumn;
    }
}