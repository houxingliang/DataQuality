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
    public partial class CGMLPZCrl : UserControl
    {
        public CGMLPZCrl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 新增成果目录配置
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CGMLPZFrm cgmlpzFrm = new CGMLPZFrm();
            cgmlpzFrm.ShowDialog();
            if(cgmlpzFrm.DialogResult==DialogResult.OK)
            {
                this.muLuTableAdapter.Fill(this.settingDataSet.MuLu);
            }
        }
        /// <summary>
        /// 修改成果目录配置
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            CGMLPZFrm cgmlpzFrm = new CGMLPZFrm();
            cgmlpzFrm.MLID=(int)dataGridView1.SelectedRows[0].Cells[0].Value;
            cgmlpzFrm.ShowDialog();
            if (cgmlpzFrm.DialogResult == DialogResult.OK)
            {
                this.muLuTableAdapter.Fill(this.settingDataSet.MuLu);
            }
        }
        /// <summary>
        /// 删除成果目录配置
        /// </summary>
        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "删除选定数据", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                AccessHelper ah = new AccessHelper();
                string sql = "delete from MuLu where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value;
                if (ah.ExecuteSQLNonquery(sql))
                {
                    this.muLuTableAdapter.Fill(this.settingDataSet.MuLu);
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void CGMLPZCrl_Load(object sender, EventArgs e)
        {
            //向datagridview填充数据
            this.muLuTableAdapter.Fill(this.settingDataSet.MuLu);
        }
    }
}
