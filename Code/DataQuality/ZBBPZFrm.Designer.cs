namespace DataQuality
{
    partial class ZBBPZFrm
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
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbColName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbColRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDataLen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDataProcision = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "表名：";
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(99, 12);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(100, 21);
            this.tbTableName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "列名：";
            // 
            // tbColName
            // 
            this.tbColName.Location = new System.Drawing.Point(99, 53);
            this.tbColName.Name = "tbColName";
            this.tbColName.Size = new System.Drawing.Size(100, 21);
            this.tbColName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "列描述：";
            // 
            // tbColRemark
            // 
            this.tbColRemark.Location = new System.Drawing.Point(99, 94);
            this.tbColRemark.Name = "tbColRemark";
            this.tbColRemark.Size = new System.Drawing.Size(100, 21);
            this.tbColRemark.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "数据类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "数据长度：";
            // 
            // tbDataLen
            // 
            this.tbDataLen.Location = new System.Drawing.Point(99, 176);
            this.tbDataLen.Name = "tbDataLen";
            this.tbDataLen.Size = new System.Drawing.Size(100, 21);
            this.tbDataLen.TabIndex = 5;
            this.tbDataLen.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "数据精度：";
            // 
            // tbDataProcision
            // 
            this.tbDataProcision.Location = new System.Drawing.Point(99, 217);
            this.tbDataProcision.Name = "tbDataProcision";
            this.tbDataProcision.Size = new System.Drawing.Size(100, 21);
            this.tbDataProcision.TabIndex = 6;
            this.tbDataProcision.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "--请选择--",
            "Int",
            "Char",
            "Double",
            "Date"});
            this.cbType.Location = new System.Drawing.Point(99, 135);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 20);
            this.cbType.TabIndex = 4;
            // 
            // ZBBPZFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 293);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDataProcision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDataLen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbColRemark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbColName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTableName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZBBPZFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "指标表配置";
            this.Load += new System.EventHandler(this.ZBBPZFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbColName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbColRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDataLen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDataProcision;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbType;
    }
}