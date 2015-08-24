using DataQuality.DataSet;
namespace DataQuality
{
    partial class GZPZCrl
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
            this.guiZeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDataSet3 = new DataQuality.DataSet.SettingDataSet3();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.guiZeTableAdapter = new DataQuality.DataSet.SettingDataSet3TableAdapters.GuiZeTableAdapter();
            this.clXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规则类型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规则编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规则子编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规则名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.错误描述DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.严重程度DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.校验类型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.表达式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.表名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.字段名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否检查DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiZeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clXH,
            this.规则类型DataGridViewTextBoxColumn,
            this.规则编号DataGridViewTextBoxColumn,
            this.规则子编号DataGridViewTextBoxColumn,
            this.规则名称DataGridViewTextBoxColumn,
            this.错误描述DataGridViewTextBoxColumn,
            this.严重程度DataGridViewTextBoxColumn,
            this.校验类型DataGridViewTextBoxColumn,
            this.表达式DataGridViewTextBoxColumn,
            this.表名DataGridViewTextBoxColumn,
            this.字段名DataGridViewTextBoxColumn,
            this.是否检查DataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.guiZeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 633);
            this.dataGridView1.TabIndex = 1;
            // 
            // guiZeBindingSource
            // 
            this.guiZeBindingSource.DataMember = "GuiZe";
            this.guiZeBindingSource.DataSource = this.settingDataSet3;
            // 
            // settingDataSet3
            // 
            this.settingDataSet3.DataSetName = "SettingDataSet3";
            this.settingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(907, 639);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(822, 639);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(741, 639);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guiZeTableAdapter
            // 
            this.guiZeTableAdapter.ClearBeforeFill = true;
            // 
            // clXH
            // 
            this.clXH.DataPropertyName = "ID";
            this.clXH.HeaderText = "序号";
            this.clXH.Name = "clXH";
            this.clXH.ReadOnly = true;
            this.clXH.Width = 60;
            // 
            // 规则类型DataGridViewTextBoxColumn
            // 
            this.规则类型DataGridViewTextBoxColumn.DataPropertyName = "规则类型";
            this.规则类型DataGridViewTextBoxColumn.HeaderText = "规则类型";
            this.规则类型DataGridViewTextBoxColumn.Name = "规则类型DataGridViewTextBoxColumn";
            // 
            // 规则编号DataGridViewTextBoxColumn
            // 
            this.规则编号DataGridViewTextBoxColumn.DataPropertyName = "规则编号";
            this.规则编号DataGridViewTextBoxColumn.HeaderText = "规则编号";
            this.规则编号DataGridViewTextBoxColumn.Name = "规则编号DataGridViewTextBoxColumn";
            // 
            // 规则子编号DataGridViewTextBoxColumn
            // 
            this.规则子编号DataGridViewTextBoxColumn.DataPropertyName = "规则子编号";
            this.规则子编号DataGridViewTextBoxColumn.HeaderText = "规则子编号";
            this.规则子编号DataGridViewTextBoxColumn.Name = "规则子编号DataGridViewTextBoxColumn";
            // 
            // 规则名称DataGridViewTextBoxColumn
            // 
            this.规则名称DataGridViewTextBoxColumn.DataPropertyName = "规则名称";
            this.规则名称DataGridViewTextBoxColumn.HeaderText = "规则名称";
            this.规则名称DataGridViewTextBoxColumn.Name = "规则名称DataGridViewTextBoxColumn";
            // 
            // 错误描述DataGridViewTextBoxColumn
            // 
            this.错误描述DataGridViewTextBoxColumn.DataPropertyName = "错误描述";
            this.错误描述DataGridViewTextBoxColumn.HeaderText = "错误描述";
            this.错误描述DataGridViewTextBoxColumn.Name = "错误描述DataGridViewTextBoxColumn";
            // 
            // 严重程度DataGridViewTextBoxColumn
            // 
            this.严重程度DataGridViewTextBoxColumn.DataPropertyName = "严重程度";
            this.严重程度DataGridViewTextBoxColumn.HeaderText = "严重程度";
            this.严重程度DataGridViewTextBoxColumn.Name = "严重程度DataGridViewTextBoxColumn";
            // 
            // 校验类型DataGridViewTextBoxColumn
            // 
            this.校验类型DataGridViewTextBoxColumn.DataPropertyName = "校验类型";
            this.校验类型DataGridViewTextBoxColumn.HeaderText = "校验类型";
            this.校验类型DataGridViewTextBoxColumn.Name = "校验类型DataGridViewTextBoxColumn";
            // 
            // 表达式DataGridViewTextBoxColumn
            // 
            this.表达式DataGridViewTextBoxColumn.DataPropertyName = "表达式";
            this.表达式DataGridViewTextBoxColumn.HeaderText = "表达式";
            this.表达式DataGridViewTextBoxColumn.Name = "表达式DataGridViewTextBoxColumn";
            // 
            // 表名DataGridViewTextBoxColumn
            // 
            this.表名DataGridViewTextBoxColumn.DataPropertyName = "表名";
            this.表名DataGridViewTextBoxColumn.HeaderText = "表名";
            this.表名DataGridViewTextBoxColumn.Name = "表名DataGridViewTextBoxColumn";
            // 
            // 字段名DataGridViewTextBoxColumn
            // 
            this.字段名DataGridViewTextBoxColumn.DataPropertyName = "字段名";
            this.字段名DataGridViewTextBoxColumn.HeaderText = "字段名";
            this.字段名DataGridViewTextBoxColumn.Name = "字段名DataGridViewTextBoxColumn";
            // 
            // 是否检查DataGridViewCheckBoxColumn
            // 
            this.是否检查DataGridViewCheckBoxColumn.DataPropertyName = "是否检查";
            this.是否检查DataGridViewCheckBoxColumn.HeaderText = "是否检查";
            this.是否检查DataGridViewCheckBoxColumn.Name = "是否检查DataGridViewCheckBoxColumn";
            // 
            // GZPZCrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GZPZCrl";
            this.Size = new System.Drawing.Size(985, 672);
            this.Load += new System.EventHandler(this.GZPZCrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiZeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource guiZeBindingSource;
        private SettingDataSet3 settingDataSet3;
        private DataQuality.DataSet.SettingDataSet3TableAdapters.GuiZeTableAdapter guiZeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规则类型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规则编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规则子编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规则名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 错误描述DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 严重程度DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 校验类型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 表达式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 表名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 字段名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 是否检查DataGridViewCheckBoxColumn;
    }
}
