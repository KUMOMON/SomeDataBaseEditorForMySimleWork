namespace SomeDataBaseEditor.GUI_DataTables.Working
{
    partial class EditorAcademicPlans
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbBx__Profil = new System.Windows.Forms.ComboBox();
            this.cmbBx_kvalifikacia = new System.Windows.Forms.ComboBox();
            this.dtTmPcker_DateVerefic = new System.Windows.Forms.DateTimePicker();
            this.lbl_Profil = new System.Windows.Forms.Label();
            this.txtBx_NameVerefic = new System.Windows.Forms.TextBox();
            this.lbl_kvalifikacia = new System.Windows.Forms.Label();
            this.lbl_DateVerefic = new System.Windows.Forms.Label();
            this.lbl_NameVerefic = new System.Windows.Forms.Label();
            this.lbl_EduForm = new System.Windows.Forms.Label();
            this.cmbBx_EduForm = new System.Windows.Forms.ComboBox();
            this.lbl_Napravlenie = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbBx_Napravlenie = new System.Windows.Forms.ComboBox();
            this.uchPlanDataSet1 = new SomeDataBaseEditor.UchPlanDataSet();
            this.направленияПодготовкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.направления_подготовкиTableAdapter1 = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Направления_подготовкиTableAdapter();
            this.профилиПодготовкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.профили_подготовкиTableAdapter1 = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Профили_подготовкиTableAdapter();
            this.квалификацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.квалификацииTableAdapter1 = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.КвалификацииTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.направленияПодготовкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.профилиПодготовкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.квалификацииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(21, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(233, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbBx__Profil
            // 
            this.cmbBx__Profil.DataSource = this.профилиПодготовкиBindingSource;
            this.cmbBx__Profil.DisplayMember = "Имя";
            this.cmbBx__Profil.FormattingEnabled = true;
            this.cmbBx__Profil.Location = new System.Drawing.Point(21, 67);
            this.cmbBx__Profil.Name = "cmbBx__Profil";
            this.cmbBx__Profil.Size = new System.Drawing.Size(354, 21);
            this.cmbBx__Profil.TabIndex = 2;
            this.cmbBx__Profil.ValueMember = "Код";
            // 
            // cmbBx_kvalifikacia
            // 
            this.cmbBx_kvalifikacia.DataSource = this.квалификацииBindingSource;
            this.cmbBx_kvalifikacia.DisplayMember = "Имя";
            this.cmbBx_kvalifikacia.FormattingEnabled = true;
            this.cmbBx_kvalifikacia.Location = new System.Drawing.Point(21, 109);
            this.cmbBx_kvalifikacia.Name = "cmbBx_kvalifikacia";
            this.cmbBx_kvalifikacia.Size = new System.Drawing.Size(354, 21);
            this.cmbBx_kvalifikacia.TabIndex = 3;
            this.cmbBx_kvalifikacia.ValueMember = "Код";
            // 
            // dtTmPcker_DateVerefic
            // 
            this.dtTmPcker_DateVerefic.Location = new System.Drawing.Point(239, 167);
            this.dtTmPcker_DateVerefic.MaxDate = new System.DateTime(2998, 12, 31, 0, 0, 0, 0);
            this.dtTmPcker_DateVerefic.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtTmPcker_DateVerefic.Name = "dtTmPcker_DateVerefic";
            this.dtTmPcker_DateVerefic.Size = new System.Drawing.Size(136, 20);
            this.dtTmPcker_DateVerefic.TabIndex = 4;
            // 
            // lbl_Profil
            // 
            this.lbl_Profil.AutoSize = true;
            this.lbl_Profil.Location = new System.Drawing.Point(18, 51);
            this.lbl_Profil.Name = "lbl_Profil";
            this.lbl_Profil.Size = new System.Drawing.Size(114, 13);
            this.lbl_Profil.TabIndex = 5;
            this.lbl_Profil.Text = "Профиль подготовки";
            // 
            // txtBx_NameVerefic
            // 
            this.txtBx_NameVerefic.Location = new System.Drawing.Point(21, 167);
            this.txtBx_NameVerefic.Name = "txtBx_NameVerefic";
            this.txtBx_NameVerefic.Size = new System.Drawing.Size(191, 20);
            this.txtBx_NameVerefic.TabIndex = 6;
            // 
            // lbl_kvalifikacia
            // 
            this.lbl_kvalifikacia.AutoSize = true;
            this.lbl_kvalifikacia.Location = new System.Drawing.Point(22, 93);
            this.lbl_kvalifikacia.Name = "lbl_kvalifikacia";
            this.lbl_kvalifikacia.Size = new System.Drawing.Size(82, 13);
            this.lbl_kvalifikacia.TabIndex = 7;
            this.lbl_kvalifikacia.Text = "Квалификация";
            // 
            // lbl_DateVerefic
            // 
            this.lbl_DateVerefic.AutoSize = true;
            this.lbl_DateVerefic.Location = new System.Drawing.Point(238, 151);
            this.lbl_DateVerefic.Name = "lbl_DateVerefic";
            this.lbl_DateVerefic.Size = new System.Drawing.Size(102, 13);
            this.lbl_DateVerefic.TabIndex = 8;
            this.lbl_DateVerefic.Text = "Дата утверждения";
            // 
            // lbl_NameVerefic
            // 
            this.lbl_NameVerefic.AutoSize = true;
            this.lbl_NameVerefic.Location = new System.Drawing.Point(22, 151);
            this.lbl_NameVerefic.Name = "lbl_NameVerefic";
            this.lbl_NameVerefic.Size = new System.Drawing.Size(103, 13);
            this.lbl_NameVerefic.TabIndex = 9;
            this.lbl_NameVerefic.Text = "Утвердившее лицо";
            // 
            // lbl_EduForm
            // 
            this.lbl_EduForm.AutoSize = true;
            this.lbl_EduForm.Location = new System.Drawing.Point(22, 197);
            this.lbl_EduForm.Name = "lbl_EduForm";
            this.lbl_EduForm.Size = new System.Drawing.Size(93, 13);
            this.lbl_EduForm.TabIndex = 11;
            this.lbl_EduForm.Text = "Форма обучения";
            // 
            // cmbBx_EduForm
            // 
            this.cmbBx_EduForm.DisplayMember = "Код";
            this.cmbBx_EduForm.FormattingEnabled = true;
            this.cmbBx_EduForm.Location = new System.Drawing.Point(21, 213);
            this.cmbBx_EduForm.Name = "cmbBx_EduForm";
            this.cmbBx_EduForm.Size = new System.Drawing.Size(354, 21);
            this.cmbBx_EduForm.TabIndex = 10;
            this.cmbBx_EduForm.ValueMember = "Код";
            // 
            // lbl_Napravlenie
            // 
            this.lbl_Napravlenie.AutoSize = true;
            this.lbl_Napravlenie.Location = new System.Drawing.Point(18, 5);
            this.lbl_Napravlenie.Name = "lbl_Napravlenie";
            this.lbl_Napravlenie.Size = new System.Drawing.Size(116, 13);
            this.lbl_Napravlenie.TabIndex = 13;
            this.lbl_Napravlenie.Text = "Фильтр направления";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 21);
            this.button3.TabIndex = 14;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbBx_Napravlenie
            // 
            this.cmbBx_Napravlenie.DataSource = this.направленияПодготовкиBindingSource;
            this.cmbBx_Napravlenie.DisplayMember = "Имя";
            this.cmbBx_Napravlenie.FormattingEnabled = true;
            this.cmbBx_Napravlenie.Location = new System.Drawing.Point(21, 21);
            this.cmbBx_Napravlenie.Name = "cmbBx_Napravlenie";
            this.cmbBx_Napravlenie.Size = new System.Drawing.Size(319, 21);
            this.cmbBx_Napravlenie.TabIndex = 12;
            this.cmbBx_Napravlenie.ValueMember = "Код";
            this.cmbBx_Napravlenie.SelectedValueChanged += new System.EventHandler(this.cmbBx_Napravlenie_SelectedValueChanged);
            // 
            // uchPlanDataSet1
            // 
            this.uchPlanDataSet1.DataSetName = "UchPlanDataSet";
            this.uchPlanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // направленияПодготовкиBindingSource
            // 
            this.направленияПодготовкиBindingSource.DataMember = "Направления подготовки";
            this.направленияПодготовкиBindingSource.DataSource = this.uchPlanDataSet1;
            // 
            // направления_подготовкиTableAdapter1
            // 
            this.направления_подготовкиTableAdapter1.ClearBeforeFill = true;
            // 
            // профилиПодготовкиBindingSource
            // 
            this.профилиПодготовкиBindingSource.DataMember = "Профили подготовки";
            this.профилиПодготовкиBindingSource.DataSource = this.uchPlanDataSet1;
            // 
            // профили_подготовкиTableAdapter1
            // 
            this.профили_подготовкиTableAdapter1.ClearBeforeFill = true;
            // 
            // квалификацииBindingSource
            // 
            this.квалификацииBindingSource.DataMember = "Квалификации";
            this.квалификацииBindingSource.DataSource = this.uchPlanDataSet1;
            // 
            // квалификацииTableAdapter1
            // 
            this.квалификацииTableAdapter1.ClearBeforeFill = true;
            // 
            // EditorAcademicPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 321);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_Napravlenie);
            this.Controls.Add(this.cmbBx_Napravlenie);
            this.Controls.Add(this.lbl_EduForm);
            this.Controls.Add(this.cmbBx_EduForm);
            this.Controls.Add(this.lbl_NameVerefic);
            this.Controls.Add(this.lbl_DateVerefic);
            this.Controls.Add(this.lbl_kvalifikacia);
            this.Controls.Add(this.txtBx_NameVerefic);
            this.Controls.Add(this.lbl_Profil);
            this.Controls.Add(this.dtTmPcker_DateVerefic);
            this.Controls.Add(this.cmbBx_kvalifikacia);
            this.Controls.Add(this.cmbBx__Profil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditorAcademicPlans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditorAcademicPlans";
            this.Load += new System.EventHandler(this.EditorAcademicPlans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.направленияПодготовкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.профилиПодготовкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.квалификацииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbBx__Profil;
        private System.Windows.Forms.ComboBox cmbBx_kvalifikacia;
        private System.Windows.Forms.DateTimePicker dtTmPcker_DateVerefic;
        private System.Windows.Forms.Label lbl_Profil;
        private System.Windows.Forms.TextBox txtBx_NameVerefic;
        private System.Windows.Forms.Label lbl_kvalifikacia;
        private System.Windows.Forms.Label lbl_DateVerefic;
        private System.Windows.Forms.Label lbl_NameVerefic;
        private System.Windows.Forms.Label lbl_EduForm;
        private System.Windows.Forms.ComboBox cmbBx_EduForm;
        private UchPlanDataSet uchPlanDataSet;
        private UchPlanDataSetTableAdapters.Профили_подготовкиTableAdapter профили_подготовкиTableAdapter;
        private System.Windows.Forms.Label lbl_Napravlenie;
        private UchPlanDataSetTableAdapters.Направления_подготовкиTableAdapter направления_подготовкиTableAdapter;
        private System.Windows.Forms.Button button3;
        private UchPlanDataSetTableAdapters.КвалификацииTableAdapter квалификацииTableAdapter;
        private System.Windows.Forms.ComboBox cmbBx_Napravlenie;
        private UchPlanDataSetTableAdapters.Формы_обученияTableAdapter формы_обученияTableAdapter;
        private UchPlanDataSet uchPlanDataSet1;
        private System.Windows.Forms.BindingSource направленияПодготовкиBindingSource;
        private UchPlanDataSetTableAdapters.Направления_подготовкиTableAdapter направления_подготовкиTableAdapter1;
        private System.Windows.Forms.BindingSource профилиПодготовкиBindingSource;
        private UchPlanDataSetTableAdapters.Профили_подготовкиTableAdapter профили_подготовкиTableAdapter1;
        private System.Windows.Forms.BindingSource квалификацииBindingSource;
        private UchPlanDataSetTableAdapters.КвалификацииTableAdapter квалификацииTableAdapter1;
    }
}