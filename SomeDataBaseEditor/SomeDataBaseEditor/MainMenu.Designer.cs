﻿namespace SomeDataBaseEditor
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Формы обучения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Реализуемые компетенции дисциплин";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Справочники";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Типы дисциплин";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(394, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Кафедры";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(200, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 34);
            this.button5.TabIndex = 3;
            this.button5.Text = "Формы контроля\r\nдисциплин в семестрах";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(394, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 34);
            this.button6.TabIndex = 4;
            this.button6.Text = "Квалификации";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 34);
            this.button7.TabIndex = 5;
            this.button7.Text = "Направления подготовки";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 59);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(188, 34);
            this.button8.TabIndex = 6;
            this.button8.Text = "Профили подготовки";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(200, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(188, 34);
            this.button9.TabIndex = 7;
            this.button9.Text = "Справочник Дисциплин";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 197);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(612, 33);
            this.button10.TabIndex = 5;
            this.button10.Text = "Учебные планы";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 283);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
    }
}