using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataQuality
{
    public partial class CGWJPZCrl : UserControl
    {
        public CGWJPZCrl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 新增成果文件配置
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CGWJPZFrm cgwjpzFrm = new CGWJPZFrm();
            cgwjpzFrm.ShowDialog();
            if(cgwjpzFrm.DialogResult==DialogResult.OK)
            {
               this. wenJianTableAdapter.Fill(this.settingDataSet.WenJian);
            }
        }
        /// <summary>
        /// 修改成果文件配置
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            CGWJPZFrm cgwjpzFrm = new CGWJPZFrm();
            cgwjpzFrm.CGWJID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            cgwjpzFrm.ShowDialog();
            if (cgwjpzFrm.DialogResult == DialogResult.OK)
            {
                this.wenJianTableAdapter.Fill(this.settingDataSet.WenJian);
            }
        }
        /// <summary>
        /// 删除成果文件配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "删除选定数据", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                AccessHelper ah = new AccessHelper();
                string sql = "delete from WenJian where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value;
                if (ah.ExecuteSQLNonquery(sql))
                {
                    this.wenJianTableAdapter.Fill(this.settingDataSet.WenJian);
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
        /// <summary>
        /// 成果文件配置 窗体加载事件
        /// </summary>
        private void CGWJPZCrl_Load(object sender, EventArgs e)
        {
            this.wenJianTableAdapter.Fill(this.settingDataSet.WenJian);
        }
    }
}
