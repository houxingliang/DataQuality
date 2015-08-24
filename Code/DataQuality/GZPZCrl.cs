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
    public partial class GZPZCrl : UserControl
    {
        public GZPZCrl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体的加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GZPZCrl_Load(object sender, EventArgs e)
        {
            this.guiZeTableAdapter.Fill(this.settingDataSet3.GuiZe);
        }
        /// <summary>
        /// 新增规则配置
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GZPZFrm gzpzFrm = new GZPZFrm();
            gzpzFrm.ShowDialog();
            if(gzpzFrm.DialogResult==DialogResult.OK)
            {
                this.guiZeTableAdapter.Fill(this.settingDataSet3.GuiZe);
            }
        }
        /// <summary>
        /// 修改规则配置
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectRow = (int)dataGridView1.SelectedRows[0].Cells[0].Value; 
            if(selectRow>0)
            {
                GZPZFrm gzpzFrm = new GZPZFrm();
                gzpzFrm.GZID = selectRow;
                gzpzFrm.ShowDialog();
                if (gzpzFrm.DialogResult == DialogResult.OK)
                {
                    this.guiZeTableAdapter.Fill(this.settingDataSet3.GuiZe);
                }
            }
            
        }
        /// <summary>
        /// 删除规则配置项
        /// </summary>
        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "删除选定数据", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                AccessHelper ah = new AccessHelper();
                string sql = "delete from GuiZe where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + "";
                if (ah.ExecuteSQLNonquery(sql))
                {
                    MessageBox.Show("删除成功");
                    this.guiZeTableAdapter.Fill(this.settingDataSet3.GuiZe);
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
                ah.Close();
            }
        }
    }
}
