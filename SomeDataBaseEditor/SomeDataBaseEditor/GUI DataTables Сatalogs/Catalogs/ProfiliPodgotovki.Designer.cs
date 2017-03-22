namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    partial class ProfiliPodgotovki
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.cmbBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.направленияПодготовкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.направления_подготовкиTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Направления_подготовкиTableAdapter();
            this.профили_подготовкиTableAdapter1 = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Профили_подготовкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.направленияПодготовкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(531, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(468, 266);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 31);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(468, 306);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 31);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(468, 343);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 31);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(13, 277);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(449, 20);
            this.txtBx.TabIndex = 4;
            // 
            // cmbBx
            // 
            this.cmbBx.DataSource = this.направленияПодготовкиBindingSource;
            this.cmbBx.DisplayMember = "Имя";
            this.cmbBx.FormattingEnabled = true;
            this.cmbBx.Location = new System.Drawing.Point(13, 322);
            this.cmbBx.Name = "cmbBx";
            this.cmbBx.Size = new System.Drawing.Size(449, 21);
            this.cmbBx.TabIndex = 5;
            this.cmbBx.ValueMember = "Код";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Направление подготовки";
            // 
            // uchPlanDataSet
            // 
            this.uchPlanDataSet.DataSetName = "UchPlanDataSet";
            this.uchPlanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // направленияПодготовкиBindingSource
            // 
            this.направленияПодготовкиBindingSource.DataMember = "Направления подготовки";
            this.направленияПодготовкиBindingSource.DataSource = this.uchPlanDataSet;
            // 
            // направления_подготовкиTableAdapter
            // 
            this.направления_подготовкиTableAdapter.ClearBeforeFill = true;
            // 
            // профили_подготовкиTableAdapter1
            // 
            this.профили_подготовкиTableAdapter1.ClearBeforeFill = true;
            // 
            // ProfiliPodgotovki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBx);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProfiliPodgotovki";
            this.Text = "Профили подготовки";
            this.Load += new System.EventHandler(this.ProfiliPodgotovki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.направленияПодготовкиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.ComboBox cmbBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеПодготовкиDataGridViewTextBoxColumn;
        private UchPlanDataSet uchPlanDataSet;
        private System.Windows.Forms.BindingSource направленияПодготовкиBindingSource;
        private UchPlanDataSetTableAdapters.Направления_подготовкиTableAdapter направления_подготовкиTableAdapter;
        private UchPlanDataSetTableAdapters.Профили_подготовкиTableAdapter профили_подготовкиTableAdapter1;
    }
}