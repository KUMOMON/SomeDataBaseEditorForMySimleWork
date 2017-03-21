namespace SomeDataBaseEditor.GUI_DataTables.Working
{
    partial class RealizCompetenceDiscipline
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
            this.lstBx = new System.Windows.Forms.ListBox();
            this.cmbBx = new System.Windows.Forms.ComboBox();
            this.реализуемыеКомпетенцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchPlanDataSet = new SomeDataBaseEditor.UchPlanDataSet();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.реализуемые_компетенцииTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Реализуемые_компетенцииTableAdapter();
            this.реализуемые_компетенции_дисциплинTableAdapter1 = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Реализуемые_компетенции_дисциплинTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.реализуемыеКомпетенцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBx
            // 
            this.lstBx.FormattingEnabled = true;
            this.lstBx.Location = new System.Drawing.Point(12, 12);
            this.lstBx.Name = "lstBx";
            this.lstBx.Size = new System.Drawing.Size(420, 199);
            this.lstBx.TabIndex = 0;
            // 
            // cmbBx
            // 
            this.cmbBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBx.DataSource = this.реализуемыеКомпетенцииBindingSource;
            this.cmbBx.DisplayMember = "Название";
            this.cmbBx.FormattingEnabled = true;
            this.cmbBx.Location = new System.Drawing.Point(12, 227);
            this.cmbBx.Name = "cmbBx";
            this.cmbBx.Size = new System.Drawing.Size(420, 21);
            this.cmbBx.TabIndex = 1;
            this.cmbBx.ValueMember = "Код";
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
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 255);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(176, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(256, 255);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(176, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // реализуемые_компетенцииTableAdapter
            // 
            this.реализуемые_компетенцииTableAdapter.ClearBeforeFill = true;
            // 
            // реализуемые_компетенции_дисциплинTableAdapter1
            // 
            this.реализуемые_компетенции_дисциплинTableAdapter1.ClearBeforeFill = true;
            // 
            // RealizCompetenceDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 292);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmbBx);
            this.Controls.Add(this.lstBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RealizCompetenceDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Реализуемые компетенции дисциплин";
            this.Load += new System.EventHandler(this.RealizCompetenceDiscipline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.реализуемыеКомпетенцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBx;
        private System.Windows.Forms.ComboBox cmbBx;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private UchPlanDataSet uchPlanDataSet;
        private System.Windows.Forms.BindingSource реализуемыеКомпетенцииBindingSource;
        private UchPlanDataSetTableAdapters.Реализуемые_компетенцииTableAdapter реализуемые_компетенцииTableAdapter;
        private UchPlanDataSetTableAdapters.Реализуемые_компетенции_дисциплинTableAdapter реализуемые_компетенции_дисциплинTableAdapter1;
    }
}