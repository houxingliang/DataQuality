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
    public partial class XZQHBMCrl : UserControl
    {
        public XZQHBMCrl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void XZQHBMCrl_Load(object sender, EventArgs e)
        {
            this.quHuaTableAdapter.Fill(this.settingDataSet.QuHua);
        }
        /// <summary>
        /// 新增行政区划
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            XZQHBMFrm xzqhbmFrm = new XZQHBMFrm();
            if(this.dataGridView1.SelectedRows.Count>0)
            {
                xzqhbmFrm.FJQHBM = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            else
            {
                xzqhbmFrm.FJQHBM = 0+"";
            }
            xzqhbmFrm.ShowDialog();
            if(xzqhbmFrm.DialogResult==DialogResult.OK)
            {
                this.quHuaTableAdapter.Fill(this.settingDataSet.QuHua);
            }
        }
        /// <summary>
        /// 修改行政区划
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            XZQHBMFrm xzqhbmFrm = new XZQHBMFrm();
            xzqhbmFrm.XZQHID = (int)this.dataGridView1.SelectedRows[0].Cells[0].Value;
            xzqhbmFrm.ShowDialog();
            if (xzqhbmFrm.DialogResult == DialogResult.OK)
            {
                this.quHuaTableAdapter.Fill(this.settingDataSet.QuHua);
            }
        }
        /// <summary>
        /// 删除行政区划
        /// </summary>
        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            if(dataGridView1.SelectedRows.Count>0)
            {
                DialogResult dr = MessageBox.Show("确定要删除吗?", "删除选定数据", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    AccessHelper ah = new AccessHelper();
                    string sql = "delete from QuHua where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value;
                    if (ah.ExecuteSQLNonquery(sql))
                    {
                        this.quHuaTableAdapter.Fill(this.settingDataSet.QuHua);
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
        }
    }
}
