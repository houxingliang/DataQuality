using DataQuality.DataSet;
namespace DataQuality
{
    partial class XZQHBMCrl
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
            this.clXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXZQBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXZQMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFJBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quHuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDataSet = new DataQuality.DataSet.SettingDataSet();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.quHuaTableAdapter = new DataQuality.DataSet.SettingDataSetTableAdapters.QuHuaTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.行政区编码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.行政区名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.父级编码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quHuaBindingSource)).BeginInit();
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
            this.clXZQBM,
            this.clXZQMC,
            this.clFJBM,
            this.iDDataGridViewTextBoxColumn,
            this.行政区编码DataGridViewTextBoxColumn,
            this.行政区名称DataGridViewTextBoxColumn,
            this.父级编码DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quHuaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 550);
            this.dataGridView1.TabIndex = 2;
            // 
            // clXH
            // 
            this.clXH.DataPropertyName = "ID";
            this.clXH.HeaderText = "序号";
            this.clXH.Name = "clXH";
            this.clXH.ReadOnly = true;
            this.clXH.Width = 60;
            // 
            // clXZQBM
            // 
            this.clXZQBM.DataPropertyName = "行政区编码";
            this.clXZQBM.HeaderText = "行政区编码";
            this.clXZQBM.Name = "clXZQBM";
            this.clXZQBM.ReadOnly = true;
            this.clXZQBM.Width = 200;
            // 
            // clXZQMC
            // 
            this.clXZQMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clXZQMC.DataPropertyName = "行政区名称";
            this.clXZQMC.HeaderText = "行政区名称";
            this.clXZQMC.Name = "clXZQMC";
            this.clXZQMC.ReadOnly = true;
            // 
            // clFJBM
            // 
            this.clFJBM.DataPropertyName = "父级编码";
            this.clFJBM.HeaderText = "父级编码";
            this.clFJBM.Name = "clFJBM";
            this.clFJBM.ReadOnly = true;
            this.clFJBM.Width = 200;
            // 
            // quHuaBindingSource
            // 
            this.quHuaBindingSource.DataMember = "QuHua";
            this.quHuaBindingSource.DataSource = this.settingDataSet;
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
            this.btnEdit.Location = new System.Drawing.Point(829, 556);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(743, 556);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // quHuaTableAdapter
            // 
            this.quHuaTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 行政区编码DataGridViewTextBoxColumn
            // 
            this.行政区编码DataGridViewTextBoxColumn.DataPropertyName = "行政区编码";
            this.行政区编码DataGridViewTextBoxColumn.HeaderText = "行政区编码";
            this.行政区编码DataGridViewTextBoxColumn.Name = "行政区编码DataGridViewTextBoxColumn";
            this.行政区编码DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 行政区名称DataGridViewTextBoxColumn
            // 
            this.行政区名称DataGridViewTextBoxColumn.DataPropertyName = "行政区名称";
            this.行政区名称DataGridViewTextBoxColumn.HeaderText = "行政区名称";
            this.行政区名称DataGridViewTextBoxColumn.Name = "行政区名称DataGridViewTextBoxColumn";
            this.行政区名称DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 父级编码DataGridViewTextBoxColumn
            // 
            this.父级编码DataGridViewTextBoxColumn.DataPropertyName = "父级编码";
            this.父级编码DataGridViewTextBoxColumn.HeaderText = "父级编码";
            this.父级编码DataGridViewTextBoxColumn.Name = "父级编码DataGridViewTextBoxColumn";
            this.父级编码DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // XZQHBMCrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "XZQHBMCrl";
            this.Size = new System.Drawing.Size(985, 590);
            this.Load += new System.EventHandler(this.XZQHBMCrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quHuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource quHuaBindingSource;
        private SettingDataSet settingDataSet;
        private DataQuality.DataSet.SettingDataSetTableAdapters.QuHuaTableAdapter quHuaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXZQBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXZQMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFJBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 行政区编码DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 行政区名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 父级编码DataGridViewTextBoxColumn;
    }
}
