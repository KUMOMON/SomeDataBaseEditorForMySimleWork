namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    partial class FormControlDisciplinInSevestr
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
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формыКонтроляBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.формы_контроляTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Формы_контроляTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.формыКонтроляBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(295, 376);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 44);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(152, 376);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(69, 44);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 376);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(69, 44);
            this.btn_insert.TabIndex = 13;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(12, 350);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(352, 20);
            this.txtBx.TabIndex = 12;
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AllowUserToAddRows = false;
            this.dtGrdVw.AllowUserToDeleteRows = false;
            this.dtGrdVw.AutoGenerateColumns = false;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn});
            this.dtGrdVw.DataSource = this.формыКонтроляBindingSource;
            this.dtGrdVw.Location = new System.Drawing.Point(12, 12);
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.ReadOnly = true;
            this.dtGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVw.Size = new System.Drawing.Size(352, 332);
            this.dtGrdVw.TabIndex = 11;
            this.dtGrdVw.SelectionChanged += new System.EventHandler(this.dtGrdVw_SelectionChanged);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // формыКонтроляBindingSource
            // 
            this.формыКонтроляBindingSource.DataMember = "Формы контроля";
            this.формыКонтроляBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // uchPlanDataSet
            // 
            this.uchPlanDataSet.DataSetName = "UchPlanDataSet";
            this.uchPlanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // формы_контроляTableAdapter
            // 
            this.формы_контроляTableAdapter.ClearBeforeFill = true;
            // 
            // FormControlDisciplinInSevestr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 436);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.dtGrdVw);
            this.Name = "FormControlDisciplinInSevestr";
            this.Text = "FormControlDisciplinInSevestr";
            this.Load += new System.EventHandler(this.FormControlDisciplinInSevestr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.формыКонтроляBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource формыКонтроляBindingSource;
        private UchPlanDataSetTableAdapters.Формы_контроляTableAdapter формы_контроляTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
    }
}