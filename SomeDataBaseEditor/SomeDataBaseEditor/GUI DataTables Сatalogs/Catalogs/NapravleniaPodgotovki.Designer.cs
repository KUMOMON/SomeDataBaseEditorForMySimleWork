namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    partial class NapravleniaPodgotovki
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
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направленияПодготовкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.направления_подготовкиTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Направления_подготовкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.направленияПодготовкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AutoGenerateColumns = false;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn});
            this.dtGrdVw.DataSource = this.направленияПодготовкиBindingSource;
            this.dtGrdVw.Location = new System.Drawing.Point(12, 12);
            this.dtGrdVw.MultiSelect = false;
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.ReadOnly = true;
            this.dtGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVw.Size = new System.Drawing.Size(416, 332);
            this.dtGrdVw.TabIndex = 0;
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
            // направленияПодготовкиBindingSource
            // 
            this.направленияПодготовкиBindingSource.DataMember = "Направления подготовки";
            this.направленияПодготовкиBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // uchPlanDataSet
            // 
            this.uchPlanDataSet.DataSetName = "UchPlanDataSet";
            this.uchPlanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(12, 350);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(416, 20);
            this.txtBx.TabIndex = 2;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(12, 376);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 44);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(184, 376);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 44);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(353, 376);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 44);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // направления_подготовкиTableAdapter
            // 
            this.направления_подготовкиTableAdapter.ClearBeforeFill = true;
            // 
            // NapravleniaPodgotovki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 427);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.dtGrdVw);
            this.Name = "NapravleniaPodgotovki";
            this.Text = "Направления подготовки";
            this.Load += new System.EventHandler(this.NapravleniaPodgotovki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.направленияПодготовкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVw;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private UchPlanDataSet uchPlanDataSet;
        private System.Windows.Forms.BindingSource направленияПодготовкиBindingSource;
        private UchPlanDataSetTableAdapters.Направления_подготовкиTableAdapter направления_подготовкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
    }
}