namespace SomeDataBaseEditor
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.conn_btn = new System.Windows.Forms.Button();
            this.txtBx_ServerAddress = new System.Windows.Forms.TextBox();
            this.txtBx_pass = new System.Windows.Forms.TextBox();
            this.lbl_ServerAddress = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txtBx_UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(12, 159);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(221, 23);
            this.conn_btn.TabIndex = 0;
            this.conn_btn.Text = "Connect";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn1_Click);
            // 
            // txtBx_ServerAddress
            // 
            this.txtBx_ServerAddress.Location = new System.Drawing.Point(12, 33);
            this.txtBx_ServerAddress.Name = "txtBx_ServerAddress";
            this.txtBx_ServerAddress.Size = new System.Drawing.Size(221, 20);
            this.txtBx_ServerAddress.TabIndex = 1;
            this.txtBx_ServerAddress.Text = ".\\SQLEXPRESS2014";
            // 
            // txtBx_pass
            // 
            this.txtBx_pass.Location = new System.Drawing.Point(12, 123);
            this.txtBx_pass.Name = "txtBx_pass";
            this.txtBx_pass.Size = new System.Drawing.Size(221, 20);
            this.txtBx_pass.TabIndex = 2;
            this.txtBx_pass.Visible = false;
            // 
            // lbl_ServerAddress
            // 
            this.lbl_ServerAddress.AutoSize = true;
            this.lbl_ServerAddress.Location = new System.Drawing.Point(12, 14);
            this.lbl_ServerAddress.Name = "lbl_ServerAddress";
            this.lbl_ServerAddress.Size = new System.Drawing.Size(76, 13);
            this.lbl_ServerAddress.TabIndex = 3;
            this.lbl_ServerAddress.Text = "ServerAddress";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 107);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password";
            this.lbl_pass.Visible = false;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(12, 64);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(29, 13);
            this.lbl_UserName.TabIndex = 6;
            this.lbl_UserName.Text = "User";
            this.lbl_UserName.Visible = false;
            // 
            // txtBx_UserName
            // 
            this.txtBx_UserName.Location = new System.Drawing.Point(12, 80);
            this.txtBx_UserName.Name = "txtBx_UserName";
            this.txtBx_UserName.Size = new System.Drawing.Size(221, 20);
            this.txtBx_UserName.TabIndex = 5;
            this.txtBx_UserName.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 221);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txtBx_UserName);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_ServerAddress);
            this.Controls.Add(this.txtBx_pass);
            this.Controls.Add(this.txtBx_ServerAddress);
            this.Controls.Add(this.conn_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.TextBox txtBx_ServerAddress;
        private System.Windows.Forms.TextBox txtBx_pass;
        private System.Windows.Forms.Label lbl_ServerAddress;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txtBx_UserName;
    }
}

