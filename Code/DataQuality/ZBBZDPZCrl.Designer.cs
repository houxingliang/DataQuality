using DataQuality.DataSet;
namespace DataQuality
{
    partial class ZBBZDPZCrl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zhiBiaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDataSet = new DataQuality.DataSet.SettingDataSet();
            this.zhiBiaoTableAdapter = new DataQuality.DataSet.SettingDataSetTableAdapters.ZhiBiaoTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.clXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSJLXBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSJLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSJCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSJJD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhiBiaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clXH,
            this.clBM,
            this.clLM,
            this.clLMS,
            this.clSJLXBM,
            this.clSJLX,
            this.clSJCD,
            this.clSJJD});
            this.dataGridView1.DataSource = this.zhiBiaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 633);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // zhiBiaoBindingSource
            // 
            this.zhiBiaoBindingSource.DataMember = "ZhiBiao";
            this.zhiBiaoBindingSource.DataSource = this.settingDataSet;
            // 
            // settingDataSet
            // 
            this.settingDataSet.DataSetName = "SettingDataSet";
            this.settingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zhiBiaoTableAdapter
            // 
            this.zhiBiaoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(741, 639);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(822, 639);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(903, 639);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // clXH
            // 
            this.clXH.DataPropertyName = "ID";
            this.clXH.HeaderText = "序号";
            this.clXH.Name = "clXH";
            this.clXH.Width = 60;
            // 
            // clBM
            // 
            this.clBM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clBM.DataPropertyName = "表名";
            this.clBM.HeaderText = "表名";
            this.clBM.Name = "clBM";
            // 
            // clLM
            // 
            this.clLM.DataPropertyName = "列名";
            this.clLM.HeaderText = "列名";
            this.clLM.Name = "clLM";
            // 
            // clLMS
            // 
            this.clLMS.DataPropertyName = "列描述";
            this.clLMS.HeaderText = "列描述";
            this.clLMS.Name = "clLMS";
            this.clLMS.Width = 300;
            // 
            // clSJLXBM
            // 
            this.clSJLXBM.DataPropertyName = "数据类型编码";
            this.clSJLXBM.HeaderText = "数据类型编码";
            this.clSJLXBM.Name = "clSJLXBM";
            // 
            // clSJLX
            // 
            this.clSJLX.DataPropertyName = "数据类型";
            this.clSJLX.HeaderText = "数据类型";
            this.clSJLX.Name = "clSJLX";
            // 
            // clSJCD
            // 
            this.clSJCD.DataPropertyName = "数据长度";
            this.clSJCD.HeaderText = "数据长度";
            this.clSJCD.Name = "clSJCD";
            // 
            // clSJJD
            // 
            this.clSJJD.DataPropertyName = "数据精度";
            this.clSJJD.HeaderText = "数据精度";
            this.clSJJD.Name = "clSJJD";
            // 
            // ZBBZDPZCrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ZBBZDPZCrl";
            this.Size = new System.Drawing.Size(985, 672);
            this.Load += new System.EventHandler(this.ZBBZDPZCrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhiBiaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zhiBiaoBindingSource;
        private SettingDataSet settingDataSet;
        private DataQuality.DataSet.SettingDataSetTableAdapters.ZhiBiaoTableAdapter zhiBiaoTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSJLXBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSJLX;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSJCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSJJD;
    }
}
