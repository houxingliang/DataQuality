namespace DataQuality
{
    partial class ZDFrm
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
            this.tbLXBM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLXMC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbZDDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbZDMC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPX = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型编码：";
            // 
            // tbLXBM
            // 
            this.tbLXBM.Location = new System.Drawing.Point(92, 24);
            this.tbLXBM.Name = "tbLXBM";
            this.tbLXBM.Size = new System.Drawing.Size(100, 21);
            this.tbLXBM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "类型名称：";
            // 
            // tbLXMC
            // 
            this.tbLXMC.Location = new System.Drawing.Point(92, 66);
            this.tbLXMC.Name = "tbLXMC";
            this.tbLXMC.Size = new System.Drawing.Size(100, 21);
            this.tbLXMC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "字典代码：";
            // 
            // tbZDDM
            // 
            this.tbZDDM.Location = new System.Drawing.Point(92, 108);
            this.tbZDDM.Name = "tbZDDM";
            this.tbZDDM.Size = new System.Drawing.Size(100, 21);
            this.tbZDDM.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "字典名称：";
            // 
            // tbZDMC
            // 
            this.tbZDMC.Location = new System.Drawing.Point(92, 150);
            this.tbZDMC.Name = "tbZDMC";
            this.tbZDMC.Size = new System.Drawing.Size(100, 21);
            this.tbZDMC.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "排序：";
            // 
            // tbPX
            // 
            this.tbPX.Location = new System.Drawing.Point(92, 192);
            this.tbPX.Name = "tbPX";
            this.tbPX.Size = new System.Drawing.Size(100, 21);
            this.tbPX.TabIndex = 5;
            this.tbPX.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ZDFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 293);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPX);
            this.Controls.Add(this.tbZDMC);
            this.Controls.Add(this.tbLXMC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbZDDM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLXBM);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZDFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "字典配置";
            this.Load += new System.EventHandler(this.ZDFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLXBM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLXMC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbZDDM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbZDMC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPX;
        private System.Windows.Forms.Button btnSave;
    }
}