namespace DataQuality
{
    partial class GZPZFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDJLX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGZLX = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGZBH = new System.Windows.Forms.TextBox();
            this.tbGZZBH = new System.Windows.Forms.TextBox();
            this.tbGZMC = new System.Windows.Forms.TextBox();
            this.tbCWMS = new System.Windows.Forms.TextBox();
            this.rbZQX = new System.Windows.Forms.RadioButton();
            this.rbQQX = new System.Windows.Forms.RadioButton();
            this.cbXYLX = new System.Windows.Forms.ComboBox();
            this.tbBDS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbZDM = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.rbCheck_No = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登记类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "规则编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "规则名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "错误描述：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "严重程度：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "校验类型：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "表达式：";
            // 
            // cbDJLX
            // 
            this.cbDJLX.FormattingEnabled = true;
            this.cbDJLX.Items.AddRange(new object[] {
            "--请选择--",
            "总登记(A)",
            "初始登记(B)",
            "变更登记(C)",
            "注销登记(D)",
            "更正登记(E)",
            "遗失补证登记(F)",
            "抵押登记(G)",
            "抵押变更登记(H)",
            "抵押注销登记(I)",
            "查封登记(J)",
            "解封登记(K)",
            "预告登记(L)",
            "预告注销登记(M)",
            "异议登记(N)",
            "异议注销登记(O)",
            "地役登记(P)",
            "地役变更登记(Q)",
            "地役注销登记(R)"});
            this.cbDJLX.Location = new System.Drawing.Point(85, 10);
            this.cbDJLX.Name = "cbDJLX";
            this.cbDJLX.Size = new System.Drawing.Size(121, 20);
            this.cbDJLX.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "规则类型：";
            // 
            // cbGZLX
            // 
            this.cbGZLX.FormattingEnabled = true;
            this.cbGZLX.Items.AddRange(new object[] {
            "--请选择--",
            "结构符合性",
            "基础指标",
            "逻辑检查",
            "图形检查"});
            this.cbGZLX.Location = new System.Drawing.Point(324, 10);
            this.cbGZLX.Name = "cbGZLX";
            this.cbGZLX.Size = new System.Drawing.Size(121, 20);
            this.cbGZLX.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "规则子编号：";
            // 
            // tbGZBH
            // 
            this.tbGZBH.Location = new System.Drawing.Point(85, 48);
            this.tbGZBH.Name = "tbGZBH";
            this.tbGZBH.Size = new System.Drawing.Size(121, 21);
            this.tbGZBH.TabIndex = 3;
            // 
            // tbGZZBH
            // 
            this.tbGZZBH.Location = new System.Drawing.Point(324, 48);
            this.tbGZZBH.Name = "tbGZZBH";
            this.tbGZZBH.Size = new System.Drawing.Size(121, 21);
            this.tbGZZBH.TabIndex = 4;
            // 
            // tbGZMC
            // 
            this.tbGZMC.Location = new System.Drawing.Point(85, 86);
            this.tbGZMC.Name = "tbGZMC";
            this.tbGZMC.Size = new System.Drawing.Size(360, 21);
            this.tbGZMC.TabIndex = 5;
            // 
            // tbCWMS
            // 
            this.tbCWMS.Location = new System.Drawing.Point(85, 124);
            this.tbCWMS.Name = "tbCWMS";
            this.tbCWMS.Size = new System.Drawing.Size(360, 21);
            this.tbCWMS.TabIndex = 6;
            // 
            // rbZQX
            // 
            this.rbZQX.AutoSize = true;
            this.rbZQX.Location = new System.Drawing.Point(85, 163);
            this.rbZQX.Name = "rbZQX";
            this.rbZQX.Size = new System.Drawing.Size(59, 16);
            this.rbZQX.TabIndex = 7;
            this.rbZQX.Text = "重缺陷";
            this.rbZQX.UseVisualStyleBackColor = true;
            // 
            // rbQQX
            // 
            this.rbQQX.AutoSize = true;
            this.rbQQX.Checked = true;
            this.rbQQX.Location = new System.Drawing.Point(150, 163);
            this.rbQQX.Name = "rbQQX";
            this.rbQQX.Size = new System.Drawing.Size(59, 16);
            this.rbQQX.TabIndex = 8;
            this.rbQQX.TabStop = true;
            this.rbQQX.Text = "轻缺陷";
            this.rbQQX.UseVisualStyleBackColor = true;
            // 
            // cbXYLX
            // 
            this.cbXYLX.FormattingEnabled = true;
            this.cbXYLX.Items.AddRange(new object[] {
            "--请选择--",
            "SQL",
            "EXPR",
            "DICTNAME"});
            this.cbXYLX.Location = new System.Drawing.Point(324, 162);
            this.cbXYLX.Name = "cbXYLX";
            this.cbXYLX.Size = new System.Drawing.Size(121, 20);
            this.cbXYLX.TabIndex = 9;
            // 
            // tbBDS
            // 
            this.tbBDS.Location = new System.Drawing.Point(84, 200);
            this.tbBDS.Name = "tbBDS";
            this.tbBDS.Size = new System.Drawing.Size(360, 21);
            this.tbBDS.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "表名：";
            // 
            // tbBM
            // 
            this.tbBM.Location = new System.Drawing.Point(84, 238);
            this.tbBM.Name = "tbBM";
            this.tbBM.Size = new System.Drawing.Size(121, 21);
            this.tbBM.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "字段名：";
            // 
            // tbZDM
            // 
            this.tbZDM.Location = new System.Drawing.Point(324, 238);
            this.tbZDM.Name = "tbZDM";
            this.tbZDM.Size = new System.Drawing.Size(121, 21);
            this.tbZDM.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "是否检查：";
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.Checked = true;
            this.rbCheck.Location = new System.Drawing.Point(6, 6);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(35, 16);
            this.rbCheck.TabIndex = 13;
            this.rbCheck.TabStop = true;
            this.rbCheck.Text = "是";
            this.rbCheck.UseVisualStyleBackColor = true;
            // 
            // rbCheck_No
            // 
            this.rbCheck_No.AutoSize = true;
            this.rbCheck_No.Location = new System.Drawing.Point(71, 6);
            this.rbCheck_No.Name = "rbCheck_No";
            this.rbCheck_No.Size = new System.Drawing.Size(35, 16);
            this.rbCheck_No.TabIndex = 14;
            this.rbCheck_No.Text = "否";
            this.rbCheck_No.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbCheck);
            this.panel1.Controls.Add(this.rbCheck_No);
            this.panel1.Location = new System.Drawing.Point(85, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 26);
            this.panel1.TabIndex = 99;
            // 
            // GZPZFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbQQX);
            this.Controls.Add(this.rbZQX);
            this.Controls.Add(this.tbGZZBH);
            this.Controls.Add(this.tbBDS);
            this.Controls.Add(this.tbCWMS);
            this.Controls.Add(this.tbGZMC);
            this.Controls.Add(this.tbZDM);
            this.Controls.Add(this.tbBM);
            this.Controls.Add(this.tbGZBH);
            this.Controls.Add(this.cbGZLX);
            this.Controls.Add(this.cbXYLX);
            this.Controls.Add(this.cbDJLX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GZPZFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "规则配置";
            this.Load += new System.EventHandler(this.GZPZFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDJLX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGZLX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGZBH;
        private System.Windows.Forms.TextBox tbGZZBH;
        private System.Windows.Forms.TextBox tbGZMC;
        private System.Windows.Forms.TextBox tbCWMS;
        private System.Windows.Forms.RadioButton rbZQX;
        private System.Windows.Forms.RadioButton rbQQX;
        private System.Windows.Forms.ComboBox cbXYLX;
        private System.Windows.Forms.TextBox tbBDS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbZDM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.RadioButton rbCheck_No;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
    }
}