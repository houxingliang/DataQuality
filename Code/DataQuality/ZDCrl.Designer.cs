using DataQuality.DataSet;
namespace DataQuality
{
    partial class ZDCrl
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
            this.ziDianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDataSet1 = new DataQuality.DataSet.SettingDataSet1();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ziDianTableAdapter = new DataQuality.DataSet.SettingDataSet1TableAdapters.ZiDianTableAdapter();
            this.clXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLXBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLXMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLZDDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clZDMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ziDianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clXH,
            this.clLXBM,
            this.clLXMC,
            this.clLZDDM,
            this.clZDMC,
            this.clPX});
            this.dataGridView1.DataSource = this.ziDianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 633);
            this.dataGridView1.TabIndex = 1;
            // 
            // ziDianBindingSource
            // 
            this.ziDianBindingSource.DataMember = "ZiDian";
            this.ziDianBindingSource.DataSource = this.settingDataSet1;
            // 
            // settingDataSet1
            // 
            this.settingDataSet1.DataSetName = "SettingDataSet1";
            this.settingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(907, 639);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(826, 639);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(741, 639);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ziDianTableAdapter
            // 
            this.ziDianTableAdapter.ClearBeforeFill = true;
            // 
            // clXH
            // 
            this.clXH.DataPropertyName = "ID";
            this.clXH.HeaderText = "序号";
            this.clXH.Name = "clXH";
            this.clXH.ReadOnly = true;
            this.clXH.Width = 60;
            // 
            // clLXBM
            // 
            this.clLXBM.DataPropertyName = "类型编码";
            this.clLXBM.HeaderText = "类型编码";
            this.clLXBM.Name = "clLXBM";
            this.clLXBM.Width = 150;
            // 
            // clLXMC
            // 
            this.clLXMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLXMC.DataPropertyName = "类型名称";
            this.clLXMC.HeaderText = "类型名称";
            this.clLXMC.Name = "clLXMC";
            // 
            // clLZDDM
            // 
            this.clLZDDM.DataPropertyName = "字典代码";
            this.clLZDDM.HeaderText = "字典代码";
            this.clLZDDM.Name = "clLZDDM";
            this.clLZDDM.Width = 150;
            // 
            // clZDMC
            // 
            this.clZDMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clZDMC.DataPropertyName = "字典名称";
            this.clZDMC.HeaderText = "字典名称";
            this.clZDMC.Name = "clZDMC";
            // 
            // clPX
            // 
            this.clPX.DataPropertyName = "排序";
            this.clPX.HeaderText = "排序";
            this.clPX.Name = "clPX";
            // 
            // ZDCrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ZDCrl";
            this.Size = new System.Drawing.Size(985, 672);
            this.Load += new System.EventHandler(this.ZDCrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ziDianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource ziDianBindingSource;
        private SettingDataSet1 settingDataSet1;
        private DataQuality.DataSet.SettingDataSet1TableAdapters.ZiDianTableAdapter ziDianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLXBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLXMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLZDDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clZDMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPX;
    }
}
