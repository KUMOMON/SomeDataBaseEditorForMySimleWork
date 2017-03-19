namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    partial class RealizuemyKompetenciiDisciplin
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.dtGrdVw = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.реализуемыеКомпетенцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.реализуемые_компетенцииTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Реализуемые_компетенцииTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализуемыеКомпетенцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(325, 376);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 44);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(167, 376);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(117, 44);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 376);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(117, 44);
            this.btn_insert.TabIndex = 13;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(12, 350);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(430, 20);
            this.txtBx.TabIndex = 12;
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AutoGenerateColumns = false;
            this.dtGrdVw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn});
            this.dtGrdVw.DataSource = this.реализуемыеКомпетенцииBindingSource;
            this.dtGrdVw.Location = new System.Drawing.Point(12, 12);
            this.dtGrdVw.MultiSelect = false;
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.ReadOnly = true;
            this.dtGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVw.Size = new System.Drawing.Size(430, 332);
            this.dtGrdVw.TabIndex = 11;
            this.dtGrdVw.SelectionChanged += new System.EventHandler(this.dtGrdVw_SelectionChanged);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Width = 51;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn.Width = 82;
            // 
            // реализуемыеКомпетенцииBindingSource
            // 
            this.реализуемыеКомпетенцииBindingSource.DataMember = "Реализуемые компетенции";
            this.реализуемыеКомпетенцииBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // uchPlanDataSet
            // 
            this.uchPlanDataSet.DataSetName = "UchPlanDataSet";
            this.uchPlanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // реализуемые_компетенцииTableAdapter
            // 
            this.реализуемые_компетенцииTableAdapter.ClearBeforeFill = true;
            // 
            // RealizuemyKompetenciiDisciplin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 431);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.dtGrdVw);
            this.Name = "RealizuemyKompetenciiDisciplin";
            this.Text = "Реализуемые компетенции";
            this.Load += new System.EventHandler(this.RealizuemyKompetenciiDisciplin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализуемыеКомпетенцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.DataGridView dtGrdVw;
        private UchPlanDataSet uchPlanDataSet;
        private System.Windows.Forms.BindingSource реализуемыеКомпетенцииBindingSource;
        private UchPlanDataSetTableAdapters.Реализуемые_компетенцииTableAdapter реализуемые_компетенцииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
    }
}