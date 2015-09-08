using DataQuality.DataSet;
namespace DataQuality
{
    partial class CGWJPZCrl
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
            this.wenJianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDataSet = new DataQuality.DataSet.SettingDataSet();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.wenJianTableAdapter = new DataQuality.DataSet.SettingDataSetTableAdapters.WenJianTableAdapter();
            this.clXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGZLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGZBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLGZZBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGZMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCWMS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wenJianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clXH,
            this.clGZLX,
            this.clGZBH,
            this.clLGZZBH,
            this.clGZMC,
            this.clCWMS});
            this.dataGridView1.DataSource = this.wenJianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 550);
            this.dataGridView1.TabIndex = 2;
            // 
            // wenJianBindingSource
            // 
            this.wenJianBindingSource.DataMember = "WenJian";
            this.wenJianBindingSource.DataSource = this.settingDataSet;
            // 
            // settingDataSet
            // 
            this.settingDataSet.DataSetName = "SettingDataSet";
            this.settingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(910, 556);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(828, 556);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(741, 556);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // wenJianTableAdapter
            // 
            this.wenJianTableAdapter.ClearBeforeFill = true;
            // 
            // clXH
            // 
            this.clXH.DataPropertyName = "ID";
            this.clXH.HeaderText = "序号";
            this.clXH.Name = "clXH";
            this.clXH.ReadOnly = true;
            this.clXH.Width = 60;
            // 
            // clGZLX
            // 
            this.clGZLX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGZLX.DataPropertyName = "文件开始字符";
            this.clGZLX.HeaderText = "文件开始字符";
            this.clGZLX.Name = "clGZLX";
            this.clGZLX.ReadOnly = true;
            // 
            // clGZBH
            // 
            this.clGZBH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGZBH.DataPropertyName = "文件结束字符";
            this.clGZBH.HeaderText = "文件结束字符";
            this.clGZBH.Name = "clGZBH";
            this.clGZBH.ReadOnly = true;
            // 
            // clLGZZBH
            // 
            this.clLGZZBH.DataPropertyName = "文件扩展名";
            this.clLGZZBH.HeaderText = "文件扩展名";
            this.clLGZZBH.Name = "clLGZZBH";
            this.clLGZZBH.ReadOnly = true;
            // 
            // clGZMC
            // 
            this.clGZMC.DataPropertyName = "文件类型";
            this.clGZMC.HeaderText = "文件类型";
            this.clGZMC.Name = "clGZMC";
            this.clGZMC.ReadOnly = true;
            // 
            // clCWMS
            // 
            this.clCWMS.DataPropertyName = "是否必填";
            this.clCWMS.HeaderText = "是否必填";
            this.clCWMS.Name = "clCWMS";
            this.clCWMS.ReadOnly = true;
            this.clCWMS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clCWMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CGWJPZCrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CGWJPZCrl";
            this.Size = new System.Drawing.Size(985, 590);
            this.Load += new System.EventHandler(this.CGWJPZCrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wenJianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource wenJianBindingSource;
        private SettingDataSet settingDataSet;
        private DataQuality.DataSet.SettingDataSetTableAdapters.WenJianTableAdapter wenJianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGZLX;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGZBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLGZZBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGZMC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCWMS;
    }
}
