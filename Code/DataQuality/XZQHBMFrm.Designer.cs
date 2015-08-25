namespace DataQuality
{
    partial class XZQHBMFrm
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
            this.tbQHBM = new System.Windows.Forms.TextBox();
            this.tbQHMC = new System.Windows.Forms.TextBox();
            this.tbFJQHBM = new System.Windows.Forms.TextBox();
            this.tbSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "行政区划编码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "行政区划名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "父级区划编码：";
            // 
            // tbQHBM
            // 
            this.tbQHBM.Location = new System.Drawing.Point(107, 10);
            this.tbQHBM.Name = "tbQHBM";
            this.tbQHBM.Size = new System.Drawing.Size(165, 21);
            this.tbQHBM.TabIndex = 1;
            // 
            // tbQHMC
            // 
            this.tbQHMC.Location = new System.Drawing.Point(107, 64);
            this.tbQHMC.Name = "tbQHMC";
            this.tbQHMC.Size = new System.Drawing.Size(165, 21);
            this.tbQHMC.TabIndex = 2;
            // 
            // tbFJQHBM
            // 
            this.tbFJQHBM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbFJQHBM.Location = new System.Drawing.Point(107, 118);
            this.tbFJQHBM.Name = "tbFJQHBM";
            this.tbFJQHBM.ReadOnly = true;
            this.tbFJQHBM.Size = new System.Drawing.Size(165, 21);
            this.tbFJQHBM.TabIndex = 11;
            // 
            // tbSave
            // 
            this.tbSave.Location = new System.Drawing.Point(74, 161);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(143, 23);
            this.tbSave.TabIndex = 3;
            this.tbSave.Text = "保存";
            this.tbSave.UseVisualStyleBackColor = true;
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // XZQHBMFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbFJQHBM);
            this.Controls.Add(this.tbQHMC);
            this.Controls.Add(this.tbQHBM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XZQHBMFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "行政区划编码";
            this.Load += new System.EventHandler(this.XZQHBMFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQHBM;
        private System.Windows.Forms.TextBox tbQHMC;
        private System.Windows.Forms.TextBox tbFJQHBM;
        private System.Windows.Forms.Button tbSave;
    }
}