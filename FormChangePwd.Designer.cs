﻿namespace SQLServerTest
{
    partial class FormChangePwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOldPwd = new System.Windows.Forms.TextBox();
            this.textBoxNewPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewPwd2 = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入旧密码";
            // 
            // textBoxOldPwd
            // 
            this.textBoxOldPwd.Location = new System.Drawing.Point(205, 37);
            this.textBoxOldPwd.Name = "textBoxOldPwd";
            this.textBoxOldPwd.Size = new System.Drawing.Size(164, 25);
            this.textBoxOldPwd.TabIndex = 1;
            // 
            // textBoxNewPwd
            // 
            this.textBoxNewPwd.Location = new System.Drawing.Point(205, 123);
            this.textBoxNewPwd.Name = "textBoxNewPwd";
            this.textBoxNewPwd.Size = new System.Drawing.Size(167, 25);
            this.textBoxNewPwd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "输入新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "再次输入新密码";
            // 
            // textBoxNewPwd2
            // 
            this.textBoxNewPwd2.Location = new System.Drawing.Point(205, 195);
            this.textBoxNewPwd2.Name = "textBoxNewPwd2";
            this.textBoxNewPwd2.Size = new System.Drawing.Size(167, 25);
            this.textBoxNewPwd2.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(205, 262);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(129, 32);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "提交";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 315);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxNewPwd2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNewPwd);
            this.Controls.Add(this.textBoxOldPwd);
            this.Controls.Add(this.label1);
            this.Name = "FormChangePwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOldPwd;
        private System.Windows.Forms.TextBox textBoxNewPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewPwd2;
        private System.Windows.Forms.Button buttonSubmit;
    }
}