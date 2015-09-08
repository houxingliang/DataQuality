namespace DataQuality
{
    partial class EditPasswordFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPasswordFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEdit = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbOldPwd = new System.Windows.Forms.TextBox();
            this.tbNewPwd = new System.Windows.Forms.TextBox();
            this.tbRePwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "原密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "重复密码：";
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(66, 169);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(157, 23);
            this.tbEdit.TabIndex = 5;
            this.tbEdit.Text = "修改";
            this.tbEdit.UseVisualStyleBackColor = true;
            this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUserName.Location = new System.Drawing.Point(104, 16);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(157, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // tbOldPwd
            // 
            this.tbOldPwd.Location = new System.Drawing.Point(104, 51);
            this.tbOldPwd.Name = "tbOldPwd";
            this.tbOldPwd.Size = new System.Drawing.Size(157, 21);
            this.tbOldPwd.TabIndex = 2;
            this.tbOldPwd.UseSystemPasswordChar = true;
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.Location = new System.Drawing.Point(104, 86);
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.Size = new System.Drawing.Size(157, 21);
            this.tbNewPwd.TabIndex = 3;
            this.tbNewPwd.UseSystemPasswordChar = true;
            // 
            // tbRePwd
            // 
            this.tbRePwd.Location = new System.Drawing.Point(104, 128);
            this.tbRePwd.Name = "tbRePwd";
            this.tbRePwd.Size = new System.Drawing.Size(157, 21);
            this.tbRePwd.TabIndex = 4;
            this.tbRePwd.UseSystemPasswordChar = true;
            // 
            // EditPasswordFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.Controls.Add(this.tbRePwd);
            this.Controls.Add(this.tbNewPwd);
            this.Controls.Add(this.tbOldPwd);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPasswordFrm";
            this.Text = "修改密码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditPasswordFrm_FormClosed);
            this.Load += new System.EventHandler(this.EditPasswordFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button tbEdit;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbOldPwd;
        private System.Windows.Forms.TextBox tbNewPwd;
        private System.Windows.Forms.TextBox tbRePwd;
    }
}