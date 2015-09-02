namespace DataQuality
{
    partial class MainCrl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCrl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbBrowse = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbHZBG = new System.Windows.Forms.CheckBox();
            this.cbKJTX = new System.Windows.Forms.CheckBox();
            this.cbLJGLX = new System.Windows.Forms.CheckBox();
            this.cbJCZB = new System.Windows.Forms.CheckBox();
            this.cbJGFHX = new System.Windows.Forms.CheckBox();
            this.cbSJWZX = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCGMLJG = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tpJCJG = new System.Windows.Forms.TabPage();
            this.tpTXYL = new System.Windows.Forms.TabPage();
            this.tpRZ = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dgCheckResult = new System.Windows.Forms.DataGridView();
            this.cmXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmCGMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmGZLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmGZBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmGZMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmCWMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmCWDJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmJCRQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCGMLJG.SuspendLayout();
            this.tpJCJG.SuspendLayout();
            this.tpRZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检查类别";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(6, 29);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(188, 20);
            this.cmbType.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.tbBrowse);
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "成果数据所在目录";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(622, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbBrowse
            // 
            this.tbBrowse.Location = new System.Drawing.Point(6, 29);
            this.tbBrowse.Name = "tbBrowse";
            this.tbBrowse.ReadOnly = true;
            this.tbBrowse.Size = new System.Drawing.Size(598, 21);
            this.tbBrowse.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbHZBG);
            this.groupBox3.Controls.Add(this.cbKJTX);
            this.groupBox3.Controls.Add(this.cbLJGLX);
            this.groupBox3.Controls.Add(this.cbJCZB);
            this.groupBox3.Controls.Add(this.cbJGFHX);
            this.groupBox3.Controls.Add(this.cbSJWZX);
            this.groupBox3.Location = new System.Drawing.Point(3, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "检查内容";
            // 
            // cbHZBG
            // 
            this.cbHZBG.AutoSize = true;
            this.cbHZBG.Checked = true;
            this.cbHZBG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHZBG.Location = new System.Drawing.Point(557, 20);
            this.cbHZBG.Name = "cbHZBG";
            this.cbHZBG.Size = new System.Drawing.Size(72, 16);
            this.cbHZBG.TabIndex = 0;
            this.cbHZBG.Text = "汇总表格";
            this.cbHZBG.UseVisualStyleBackColor = true;
            // 
            // cbKJTX
            // 
            this.cbKJTX.AutoSize = true;
            this.cbKJTX.Location = new System.Drawing.Point(454, 20);
            this.cbKJTX.Name = "cbKJTX";
            this.cbKJTX.Size = new System.Drawing.Size(72, 16);
            this.cbKJTX.TabIndex = 0;
            this.cbKJTX.Text = "空间图形";
            this.cbKJTX.UseVisualStyleBackColor = true;
            // 
            // cbLJGLX
            // 
            this.cbLJGLX.AutoSize = true;
            this.cbLJGLX.Checked = true;
            this.cbLJGLX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLJGLX.Location = new System.Drawing.Point(339, 20);
            this.cbLJGLX.Name = "cbLJGLX";
            this.cbLJGLX.Size = new System.Drawing.Size(84, 16);
            this.cbLJGLX.TabIndex = 0;
            this.cbLJGLX.Text = "逻辑关联性";
            this.cbLJGLX.UseVisualStyleBackColor = true;
            // 
            // cbJCZB
            // 
            this.cbJCZB.AutoSize = true;
            this.cbJCZB.Checked = true;
            this.cbJCZB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJCZB.Location = new System.Drawing.Point(236, 20);
            this.cbJCZB.Name = "cbJCZB";
            this.cbJCZB.Size = new System.Drawing.Size(72, 16);
            this.cbJCZB.TabIndex = 0;
            this.cbJCZB.Text = "基础指标";
            this.cbJCZB.UseVisualStyleBackColor = true;
            // 
            // cbJGFHX
            // 
            this.cbJGFHX.AutoSize = true;
            this.cbJGFHX.Checked = true;
            this.cbJGFHX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJGFHX.Location = new System.Drawing.Point(121, 20);
            this.cbJGFHX.Name = "cbJGFHX";
            this.cbJGFHX.Size = new System.Drawing.Size(84, 16);
            this.cbJGFHX.TabIndex = 0;
            this.cbJGFHX.Text = "结构符合性";
            this.cbJGFHX.UseVisualStyleBackColor = true;
            // 
            // cbSJWZX
            // 
            this.cbSJWZX.AutoSize = true;
            this.cbSJWZX.Checked = true;
            this.cbSJWZX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSJWZX.Location = new System.Drawing.Point(6, 20);
            this.cbSJWZX.Name = "cbSJWZX";
            this.cbSJWZX.Size = new System.Drawing.Size(84, 16);
            this.cbSJWZX.TabIndex = 0;
            this.cbSJWZX.Text = "数据完整性";
            this.cbSJWZX.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox8);
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Location = new System.Drawing.Point(659, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 54);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "缺陷级别";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(126, 20);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(60, 16);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "轻缺陷";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(31, 20);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(60, 16);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "重缺陷";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCGMLJG);
            this.tabControl1.Controls.Add(this.tpJCJG);
            this.tabControl1.Controls.Add(this.tpTXYL);
            this.tabControl1.Controls.Add(this.tpRZ);
            this.tabControl1.Location = new System.Drawing.Point(3, 138);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 470);
            this.tabControl1.TabIndex = 4;
            // 
            // tpCGMLJG
            // 
            this.tpCGMLJG.Controls.Add(this.treeView1);
            this.tpCGMLJG.Location = new System.Drawing.Point(4, 22);
            this.tpCGMLJG.Name = "tpCGMLJG";
            this.tpCGMLJG.Padding = new System.Windows.Forms.Padding(3);
            this.tpCGMLJG.Size = new System.Drawing.Size(958, 444);
            this.tpCGMLJG.TabIndex = 0;
            this.tpCGMLJG.Text = "成果目录结构";
            this.tpCGMLJG.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(6, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(946, 434);
            this.treeView1.StateImageList = this.imageList1;
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "文件夹.png");
            this.imageList1.Images.SetKeyName(1, "文件.png");
            // 
            // tpJCJG
            // 
            this.tpJCJG.Controls.Add(this.dgCheckResult);
            this.tpJCJG.Location = new System.Drawing.Point(4, 22);
            this.tpJCJG.Name = "tpJCJG";
            this.tpJCJG.Padding = new System.Windows.Forms.Padding(3);
            this.tpJCJG.Size = new System.Drawing.Size(958, 444);
            this.tpJCJG.TabIndex = 1;
            this.tpJCJG.Text = "检查结果";
            this.tpJCJG.UseVisualStyleBackColor = true;
            // 
            // tpTXYL
            // 
            this.tpTXYL.Location = new System.Drawing.Point(4, 22);
            this.tpTXYL.Name = "tpTXYL";
            this.tpTXYL.Size = new System.Drawing.Size(958, 444);
            this.tpTXYL.TabIndex = 2;
            this.tpTXYL.Text = "图形预览";
            this.tpTXYL.UseVisualStyleBackColor = true;
            // 
            // tpRZ
            // 
            this.tpRZ.Controls.Add(this.rtbLog);
            this.tpRZ.Location = new System.Drawing.Point(4, 22);
            this.tpRZ.Name = "tpRZ";
            this.tpRZ.Size = new System.Drawing.Size(958, 444);
            this.tpRZ.TabIndex = 3;
            this.tpRZ.Text = "日志";
            this.tpRZ.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.rtbLog.Location = new System.Drawing.Point(2, 3);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(966, 460);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "准备打印文档....";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(900, 94);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "检查";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dgCheckResult
            // 
            this.dgCheckResult.AllowUserToAddRows = false;
            this.dgCheckResult.AllowUserToDeleteRows = false;
            this.dgCheckResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCheckResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmXH,
            this.cmCGMC,
            this.cmGZLX,
            this.cmGZBH,
            this.cmGZMC,
            this.cmCWMS,
            this.cmHH,
            this.cmCWDJ,
            this.cmJCRQ});
            this.dgCheckResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCheckResult.Location = new System.Drawing.Point(3, 3);
            this.dgCheckResult.Name = "dgCheckResult";
            this.dgCheckResult.ReadOnly = true;
            this.dgCheckResult.RowTemplate.Height = 23;
            this.dgCheckResult.Size = new System.Drawing.Size(952, 438);
            this.dgCheckResult.TabIndex = 0;
            // 
            // cmXH
            // 
            this.cmXH.HeaderText = "序号";
            this.cmXH.Name = "cmXH";
            this.cmXH.ReadOnly = true;
            this.cmXH.Width = 60;
            // 
            // cmCGMC
            // 
            this.cmCGMC.HeaderText = "成果名称";
            this.cmCGMC.Name = "cmCGMC";
            this.cmCGMC.ReadOnly = true;
            // 
            // cmGZLX
            // 
            this.cmGZLX.HeaderText = "规则类型";
            this.cmGZLX.Name = "cmGZLX";
            this.cmGZLX.ReadOnly = true;
            // 
            // cmGZBH
            // 
            this.cmGZBH.HeaderText = "规则编号";
            this.cmGZBH.Name = "cmGZBH";
            this.cmGZBH.ReadOnly = true;
            // 
            // cmGZMC
            // 
            this.cmGZMC.HeaderText = "规则名称";
            this.cmGZMC.Name = "cmGZMC";
            this.cmGZMC.ReadOnly = true;
            // 
            // cmCWMS
            // 
            this.cmCWMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmCWMS.HeaderText = "错误描述";
            this.cmCWMS.Name = "cmCWMS";
            this.cmCWMS.ReadOnly = true;
            // 
            // cmHH
            // 
            this.cmHH.HeaderText = "行号";
            this.cmHH.Name = "cmHH";
            this.cmHH.ReadOnly = true;
            this.cmHH.Width = 60;
            // 
            // cmCWDJ
            // 
            this.cmCWDJ.HeaderText = "错误等级";
            this.cmCWDJ.Name = "cmCWDJ";
            this.cmCWDJ.ReadOnly = true;
            // 
            // cmJCRQ
            // 
            this.cmJCRQ.HeaderText = "检查日期";
            this.cmJCRQ.Name = "cmJCRQ";
            this.cmJCRQ.ReadOnly = true;
            // 
            // MainCrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainCrl";
            this.Size = new System.Drawing.Size(985, 590);
            this.Load += new System.EventHandler(this.MainCrl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpCGMLJG.ResumeLayout(false);
            this.tpJCJG.ResumeLayout(false);
            this.tpRZ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCheckResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCGMLJG;
        private System.Windows.Forms.TabPage tpJCJG;
        private System.Windows.Forms.TabPage tpTXYL;
        private System.Windows.Forms.TabPage tpRZ;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.CheckBox cbHZBG;
        private System.Windows.Forms.CheckBox cbKJTX;
        private System.Windows.Forms.CheckBox cbLJGLX;
        private System.Windows.Forms.CheckBox cbJCZB;
        private System.Windows.Forms.CheckBox cbJGFHX;
        private System.Windows.Forms.CheckBox cbSJWZX;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbBrowse;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dgCheckResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCGMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmGZLX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmGZBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmGZMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCWMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmCWDJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmJCRQ;
    }
}
