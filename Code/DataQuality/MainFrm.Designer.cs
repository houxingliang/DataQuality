namespace DataQuality
{
    partial class MainFrm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCD = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmZBBZDPZ = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmZDPZ = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGZPZ = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCGMLPZ = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCGWJPZ = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXZQHBM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCGJC = new System.Windows.Forms.ToolStripMenuItem();
            this.xzqhbmCrl1 = new DataQuality.XZQHBMCrl();
            this.cgwjpzCrl1 = new DataQuality.CGWJPZCrl();
            this.cgmlpzCrl1 = new DataQuality.CGMLPZCrl();
            this.gzpzCrl1 = new DataQuality.GZPZCrl();
            this.zdCrl1 = new DataQuality.ZDCrl();
            this.zbbzdpzCrl1 = new DataQuality.ZBBZDPZCrl();
            this.mainCrl1 = new DataQuality.MainCrl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCD});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmCD
            // 
            this.tsmCD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCGJC,
            this.tsmZBBZDPZ,
            this.tsmZDPZ,
            this.tsmGZPZ,
            this.tsmCGMLPZ,
            this.tsmCGWJPZ,
            this.tsmXZQHBM});
            this.tsmCD.Image = ((System.Drawing.Image)(resources.GetObject("tsmCD.Image")));
            this.tsmCD.Name = "tsmCD";
            this.tsmCD.Size = new System.Drawing.Size(60, 21);
            this.tsmCD.Text = "菜单";
            // 
            // tsmZBBZDPZ
            // 
            this.tsmZBBZDPZ.Image = ((System.Drawing.Image)(resources.GetObject("tsmZBBZDPZ.Image")));
            this.tsmZBBZDPZ.Name = "tsmZBBZDPZ";
            this.tsmZBBZDPZ.Size = new System.Drawing.Size(160, 22);
            this.tsmZBBZDPZ.Text = "指标表字段配置";
            this.tsmZBBZDPZ.Click += new System.EventHandler(this.tsmZBBZDPZ_Click);
            // 
            // tsmZDPZ
            // 
            this.tsmZDPZ.Image = ((System.Drawing.Image)(resources.GetObject("tsmZDPZ.Image")));
            this.tsmZDPZ.Name = "tsmZDPZ";
            this.tsmZDPZ.Size = new System.Drawing.Size(160, 22);
            this.tsmZDPZ.Text = "字典配置";
            this.tsmZDPZ.Click += new System.EventHandler(this.tsmZDPZ_Click);
            // 
            // tsmGZPZ
            // 
            this.tsmGZPZ.Image = ((System.Drawing.Image)(resources.GetObject("tsmGZPZ.Image")));
            this.tsmGZPZ.Name = "tsmGZPZ";
            this.tsmGZPZ.Size = new System.Drawing.Size(160, 22);
            this.tsmGZPZ.Text = "规则配置";
            this.tsmGZPZ.Click += new System.EventHandler(this.tsmGZPZ_Click);
            // 
            // tsmCGMLPZ
            // 
            this.tsmCGMLPZ.Image = ((System.Drawing.Image)(resources.GetObject("tsmCGMLPZ.Image")));
            this.tsmCGMLPZ.Name = "tsmCGMLPZ";
            this.tsmCGMLPZ.Size = new System.Drawing.Size(160, 22);
            this.tsmCGMLPZ.Text = "成果目录配置";
            this.tsmCGMLPZ.Click += new System.EventHandler(this.tsmCGMLPZ_Click);
            // 
            // tsmCGWJPZ
            // 
            this.tsmCGWJPZ.Image = ((System.Drawing.Image)(resources.GetObject("tsmCGWJPZ.Image")));
            this.tsmCGWJPZ.Name = "tsmCGWJPZ";
            this.tsmCGWJPZ.Size = new System.Drawing.Size(160, 22);
            this.tsmCGWJPZ.Text = "成果文件配置";
            this.tsmCGWJPZ.Click += new System.EventHandler(this.tsmCGWJPZ_Click);
            // 
            // tsmXZQHBM
            // 
            this.tsmXZQHBM.Image = ((System.Drawing.Image)(resources.GetObject("tsmXZQHBM.Image")));
            this.tsmXZQHBM.Name = "tsmXZQHBM";
            this.tsmXZQHBM.Size = new System.Drawing.Size(160, 22);
            this.tsmXZQHBM.Text = "行政区划编码";
            this.tsmXZQHBM.Click += new System.EventHandler(this.tsmXZQHBM_Click);
            // 
            // tsmCGJC
            // 
            this.tsmCGJC.Image = ((System.Drawing.Image)(resources.GetObject("tsmCGJC.Image")));
            this.tsmCGJC.Name = "tsmCGJC";
            this.tsmCGJC.Size = new System.Drawing.Size(160, 22);
            this.tsmCGJC.Text = "成果检查";
            this.tsmCGJC.Click += new System.EventHandler(this.tsmCGJC_Click);
            // 
            // xzqhbmCrl1
            // 
            this.xzqhbmCrl1.Location = new System.Drawing.Point(11, 45);
            this.xzqhbmCrl1.Name = "xzqhbmCrl1";
            this.xzqhbmCrl1.Size = new System.Drawing.Size(985, 672);
            this.xzqhbmCrl1.TabIndex = 7;
            this.xzqhbmCrl1.Visible = false;
            // 
            // cgwjpzCrl1
            // 
            this.cgwjpzCrl1.Location = new System.Drawing.Point(11, 45);
            this.cgwjpzCrl1.Name = "cgwjpzCrl1";
            this.cgwjpzCrl1.Size = new System.Drawing.Size(985, 672);
            this.cgwjpzCrl1.TabIndex = 6;
            this.cgwjpzCrl1.Visible = false;
            // 
            // cgmlpzCrl1
            // 
            this.cgmlpzCrl1.Location = new System.Drawing.Point(11, 45);
            this.cgmlpzCrl1.Name = "cgmlpzCrl1";
            this.cgmlpzCrl1.Size = new System.Drawing.Size(985, 672);
            this.cgmlpzCrl1.TabIndex = 5;
            this.cgmlpzCrl1.Visible = false;
            // 
            // gzpzCrl1
            // 
            this.gzpzCrl1.Location = new System.Drawing.Point(11, 45);
            this.gzpzCrl1.Name = "gzpzCrl1";
            this.gzpzCrl1.Size = new System.Drawing.Size(985, 672);
            this.gzpzCrl1.TabIndex = 4;
            this.gzpzCrl1.Visible = false;
            // 
            // zdCrl1
            // 
            this.zdCrl1.Location = new System.Drawing.Point(11, 45);
            this.zdCrl1.Name = "zdCrl1";
            this.zdCrl1.Size = new System.Drawing.Size(985, 672);
            this.zdCrl1.TabIndex = 3;
            this.zdCrl1.Visible = false;
            // 
            // zbbzdpzCrl1
            // 
            this.zbbzdpzCrl1.Location = new System.Drawing.Point(11, 45);
            this.zbbzdpzCrl1.Name = "zbbzdpzCrl1";
            this.zbbzdpzCrl1.Size = new System.Drawing.Size(985, 672);
            this.zbbzdpzCrl1.TabIndex = 2;
            this.zbbzdpzCrl1.Visible = false;
            // 
            // mainCrl1
            // 
            this.mainCrl1.Location = new System.Drawing.Point(11, 45);
            this.mainCrl1.Name = "mainCrl1";
            this.mainCrl1.Size = new System.Drawing.Size(985, 672);
            this.mainCrl1.TabIndex = 1;
            this.mainCrl1.Load += new System.EventHandler(this.mainCrl1_Load);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.xzqhbmCrl1);
            this.Controls.Add(this.cgwjpzCrl1);
            this.Controls.Add(this.cgmlpzCrl1);
            this.Controls.Add(this.gzpzCrl1);
            this.Controls.Add(this.zdCrl1);
            this.Controls.Add(this.zbbzdpzCrl1);
            this.Controls.Add(this.mainCrl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "存量数据质检软件";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCD;
        private MainCrl mainCrl1;
        private ZBBZDPZCrl zbbzdpzCrl1;
        private ZDCrl zdCrl1;
        private GZPZCrl gzpzCrl1;
        private CGMLPZCrl cgmlpzCrl1;
        private CGWJPZCrl cgwjpzCrl1;
        private XZQHBMCrl xzqhbmCrl1;
        private System.Windows.Forms.ToolStripMenuItem tsmZBBZDPZ;
        private System.Windows.Forms.ToolStripMenuItem tsmZDPZ;
        private System.Windows.Forms.ToolStripMenuItem tsmGZPZ;
        private System.Windows.Forms.ToolStripMenuItem tsmCGMLPZ;
        private System.Windows.Forms.ToolStripMenuItem tsmCGWJPZ;
        private System.Windows.Forms.ToolStripMenuItem tsmXZQHBM;
        private System.Windows.Forms.ToolStripMenuItem tsmCGJC;
    }
}

