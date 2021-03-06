﻿namespace SomeDataBaseEditor.GUI_DataTables.Working
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
            this.uchPlanDataSet1 = new SomeDataBaseEditor.UchPlanDataSet();
            this.cmbBx_kvalifikacia = new System.Windows.Forms.ComboBox();
            this.квалификацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtTmPcker_DateVerefic = new System.Windows.Forms.DateTimePicker();
            this.lbl_Profil = new System.Windows.Forms.Label();
            this.txtBx_NameVerefic = new System.Windows.Forms.TextBox();
            this.lbl_kvalifikacia = new System.Windows.Forms.Label();
            this.lbl_DateVerefic = new System.Windows.Forms.Label();
            this.lbl_NameVerefic = new System.Windows.Forms.Label();
            this.lbl_EduForm = new System.Windows.Forms.Label();
            this.cmbBx_EduForm = new System.Windows.Forms.ComboBox();
            this.формыОбученияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.квалификацииTableAdapter1 = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.КвалификацииTableAdapter();
            this.формы_обученияTableAdapter1 = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Формы_обученияTableAdapter();
            this.профили_подготовкиTableAdapter = new SomeDataBaseEditor.UchPlanDataSetTableAdapters.Профили_подготовкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uchPlanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.квалификацииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.формыОбученияBindingSource)).BeginInit();
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
            this.cmbBx__Profil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBx__Profil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBx__Profil.DisplayMember = "Код";
            this.cmbBx__Profil.FormattingEnabled = true;
            this.cmbBx__Profil.Location = new System.Drawing.Point(21, 67);
            this.cmbBx__Profil.Name = "cmbBx__Profil";
            this.cmbBx__Profil.Size = new System.Drawing.Size(354, 21);
            this.cmbBx__Profil.TabIndex = 2;
            this.cmbBx__Profil.ValueMember = "Код";
            // 
            // uchPlanDataSet1
            // 
            this.uchPlanDataSet1.DataSetName = "UchPlanDataSet";
            this.uchPlanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBx_kvalifikacia
            // 
            this.cmbBx_kvalifikacia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBx_kvalifikacia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBx_kvalifikacia.DataSource = this.квалификацииBindingSource;
            this.cmbBx_kvalifikacia.DisplayMember = "Имя";
            this.cmbBx_kvalifikacia.FormattingEnabled = true;
            this.cmbBx_kvalifikacia.Location = new System.Drawing.Point(21, 109);
            this.cmbBx_kvalifikacia.Name = "cmbBx_kvalifikacia";
            this.cmbBx_kvalifikacia.Size = new System.Drawing.Size(354, 21);
            this.cmbBx_kvalifikacia.TabIndex = 3;
            this.cmbBx_kvalifikacia.ValueMember = "Код";
            // 
            // квалификацииBindingSource
            // 
            this.квалификацииBindingSource.DataMember = "Квалификации";
            this.квалификацииBindingSource.DataSource = this.uchPlanDataSet1;
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
            this.cmbBx_EduForm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBx_EduForm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBx_EduForm.DataSource = this.формыОбученияBindingSource;
            this.cmbBx_EduForm.DisplayMember = "Имя";
            this.cmbBx_EduForm.FormattingEnabled = true;
            this.cmbBx_EduForm.Location = new System.Drawing.Point(21, 213);
            this.cmbBx_EduForm.Name = "cmbBx_EduForm";
            this.cmbBx_EduForm.Size = new System.Drawing.Size(354, 21);
            this.cmbBx_EduForm.TabIndex = 10;
            this.cmbBx_EduForm.ValueMember = "Код";
            // 
            // формыОбученияBindingSource
            // 
            this.формыОбученияBindingSource.DataMember = "Формы обучения";
            this.формыОбученияBindingSource.DataSource = this.uchPlanDataSet1;
            // 
            // квалификацииTableAdapter1
            // 
            this.квалификацииTableAdapter1.ClearBeforeFill = true;
            // 
            // формы_обученияTableAdapter1
            // 
            this.формы_обученияTableAdapter1.ClearBeforeFill = true;
            // 
            // профили_подготовкиTableAdapter
            // 
            this.профили_подготовкиTableAdapter.ClearBeforeFill = true;
            // 
            // EditorAcademicPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 307);
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
            ((System.ComponentModel.ISupportInitialize)(this.квалификацииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.формыОбученияBindingSource)).EndInit();
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
        private UchPlanDataSetTableAdapters.Направления_подготовкиTableAdapter направления_подготовкиTableAdapter;
        private UchPlanDataSetTableAdapters.КвалификацииTableAdapter квалификацииTableAdapter;
        private UchPlanDataSetTableAdapters.Формы_обученияTableAdapter формы_обученияTableAdapter;
        private UchPlanDataSet uchPlanDataSet1;
        private System.Windows.Forms.BindingSource квалификацииBindingSource;
        private UchPlanDataSetTableAdapters.КвалификацииTableAdapter квалификацииTableAdapter1;
        private System.Windows.Forms.BindingSource формыОбученияBindingSource;
        private UchPlanDataSetTableAdapters.Формы_обученияTableAdapter формы_обученияTableAdapter1;
        private UchPlanDataSetTableAdapters.Профили_подготовкиTableAdapter профили_подготовкиTableAdapter;
    }
}