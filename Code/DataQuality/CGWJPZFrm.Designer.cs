
using DataQuality.DataSet;
namespace DataQuality
{
    partial class CGWJPZFrm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.muLuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDataSet = new DataQuality.DataSet.SettingDataSet();
            this.lbWJKZM = new System.Windows.Forms.Label();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.muLuTableAdapter = new DataQuality.DataSet.SettingDataSetTableAdapters.MuLuTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.muLuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件开始字符：";
            // 
            // cbAction
            // 
            this.cbAction.DataSource = this.muLuBindingSource;
            this.cbAction.DisplayMember = "目录名称";
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Location = new System.Drawing.Point(121, 26);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(307, 20);
            this.cbAction.TabIndex = 1;
            this.cbAction.ValueMember = "ID";
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
            // lbWJKZM
            // 
            this.lbWJKZM.AutoSize = true;
            this.lbWJKZM.Location = new System.Drawing.Point(144, 95);
            this.lbWJKZM.Name = "lbWJKZM";
            this.lbWJKZM.Size = new System.Drawing.Size(0, 12);
            this.lbWJKZM.TabIndex = 0;
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(121, 69);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(307, 21);
            this.tbEnd.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "mdb";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(146, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(42, 16);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "dbf";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(283, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(42, 16);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "prj";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lbWJKZM);
            this.groupBox1.Location = new System.Drawing.Point(28, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件扩展名";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(146, 64);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(42, 16);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "shx";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(283, 64);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(72, 16);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "xls,xlsx";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(9, 95);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(72, 16);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "doc,docx";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(9, 64);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(42, 16);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "shp";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "文件类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "是否必填：";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(121, 252);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(307, 21);
            this.tbType.TabIndex = 10;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(121, 296);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(35, 16);
            this.rbYes.TabIndex = 11;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "是";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(222, 296);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(35, 16);
            this.rbNo.TabIndex = 12;
            this.rbNo.Text = "否";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // muLuTableAdapter
            // 
            this.muLuTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件结束字符：";
            // 
            // CGWJPZFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 376);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CGWJPZFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "成果文件配置";
            this.Load += new System.EventHandler(this.CGWJPZFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muLuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Label lbWJKZM;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Button btnSave;
        private SettingDataSet settingDataSet;
        private System.Windows.Forms.BindingSource muLuBindingSource;
        private DataQuality.DataSet.SettingDataSetTableAdapters.MuLuTableAdapter muLuTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}