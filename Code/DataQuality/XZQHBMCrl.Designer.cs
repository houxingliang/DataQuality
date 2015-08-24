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
            this.quHuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDataSet = new DataQuality.DataSet.SettingDataSet();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.quHuaTableAdapter = new DataQuality.DataSet.SettingDataSetTableAdapters.QuHuaTableAdapter();
            this.clXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXZQBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXZQMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFJBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quHuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clXH,
            this.clXZQBM,
            this.clXZQMC,
            this.clFJBM});
            this.dataGridView1.DataSource = this.quHuaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(985, 633);
            this.dataGridView1.TabIndex = 2;
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
            this.btnDel.Location = new System.Drawing.Point(908, 639);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(827, 639);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(741, 639);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // quHuaTableAdapter
            // 
            this.quHuaTableAdapter.ClearBeforeFill = true;
            // 
            // clXH
            // 
            this.clXH.HeaderText = "序号";
            this.clXH.Name = "clXH";
            this.clXH.ReadOnly = true;
            this.clXH.Width = 60;
            // 
            // clXZQBM
            // 
            this.clXZQBM.HeaderText = "行政区编码";
            this.clXZQBM.Name = "clXZQBM";
            this.clXZQBM.Width = 200;
            // 
            // clXZQMC
            // 
            this.clXZQMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clXZQMC.HeaderText = "行政区名称";
            this.clXZQMC.Name = "clXZQMC";
            // 
            // clFJBM
            // 
            this.clFJBM.HeaderText = "父级编码";
            this.clFJBM.Name = "clFJBM";
            this.clFJBM.Width = 200;
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
            this.Size = new System.Drawing.Size(985, 672);
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
    }
}
