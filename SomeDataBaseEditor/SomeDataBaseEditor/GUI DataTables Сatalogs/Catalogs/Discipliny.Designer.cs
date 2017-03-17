namespace SomeDataBaseEditor.GUI_DataTables.Catalogs
{
    partial class Discipliny
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.dtGrdVw = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.дисциплиныTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.ДисциплиныTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(12, 341);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(352, 20);
            this.txtBx.TabIndex = 7;
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AutoGenerateColumns = false;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn});
            this.dtGrdVw.DataSource = this.дисциплиныBindingSource;
            this.dtGrdVw.Location = new System.Drawing.Point(12, 3);
            this.dtGrdVw.MultiSelect = false;
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.ReadOnly = true;
            this.dtGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVw.Size = new System.Drawing.Size(352, 332);
            this.dtGrdVw.TabIndex = 6;
            this.dtGrdVw.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // дисциплиныTableAdapter
            // 
            this.дисциплиныTableAdapter.ClearBeforeFill = true;
            // 
            // Discipliny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 430);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.dtGrdVw);
            this.Name = "Discipliny";
            this.Text = "Справочник дисциплин";
            this.Load += new System.EventHandler(this.Discipliny_Load);
            this.Shown += new System.EventHandler(this.Discipliny_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.DataGridView dtGrdVw;
        private UchPlanDataSet uchPlanDataSet;
        private System.Windows.Forms.BindingSource дисциплиныBindingSource;
        private UchPlanDataSetTableAdapters.ДисциплиныTableAdapter дисциплиныTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
    }
}