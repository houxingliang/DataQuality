using DataQuality.DataSet;
namespace DataQuality
{
    partial class CGMLPZCrl
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.目录名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.检查级别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muLuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDataSet = new DataQuality.DataSet.SettingDataSet();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.muLuTableAdapter = new DataQuality.DataSet.SettingDataSetTableAdapters.MuLuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muLuBindingSource)).BeginInit();
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
            this.iDDataGridViewTextBoxColumn,
            this.目录名称DataGridViewTextBoxColumn,
            this.检查级别DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.muLuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 550);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "序号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 目录名称DataGridViewTextBoxColumn
            // 
            this.目录名称DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.目录名称DataGridViewTextBoxColumn.DataPropertyName = "目录名称";
            this.目录名称DataGridViewTextBoxColumn.HeaderText = "目录名称";
            this.目录名称DataGridViewTextBoxColumn.Name = "目录名称DataGridViewTextBoxColumn";
            this.目录名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 检查级别DataGridViewTextBoxColumn
            // 
            this.检查级别DataGridViewTextBoxColumn.DataPropertyName = "检查级别";
            this.检查级别DataGridViewTextBoxColumn.HeaderText = "检查级别";
            this.检查级别DataGridViewTextBoxColumn.Name = "检查级别DataGridViewTextBoxColumn";
            this.检查级别DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // muLuBindingSource
            // 
            this.muLuBindingSource.DataMember = "MuLu";
            this.muLuBindingSource.DataSource = this.settingDataSet;
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
            this.btnEdit.Location = new System.Drawing.Point(827, 556);
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
            // muLuTableAdapter
            // 
            this.muLuTableAdapter.ClearBeforeFill = true;
            // 
            // CGMLPZCrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CGMLPZCrl";
            this.Size = new System.Drawing.Size(985, 590);
            this.Load += new System.EventHandler(this.CGMLPZCrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muLuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 目录名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 检查级别DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource muLuBindingSource;
        private DataQuality.DataSet.SettingDataSetTableAdapters.MuLuTableAdapter muLuTableAdapter;
        private SettingDataSet settingDataSet;
    }
}
