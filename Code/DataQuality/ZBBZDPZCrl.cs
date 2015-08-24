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
    public partial class ZBBZDPZCrl : UserControl
    {
        public ZBBZDPZCrl()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void ZBBZDPZCrl_Load(object sender, EventArgs e)
        {
            this.zhiBiaoTableAdapter.Fill(this.settingDataSet.ZhiBiao);
        }
        /// <summary>
        /// dataGridView的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value + "");
            
        }
        /// <summary>
        /// 新增一条指标配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ZBBPZFrm zbbpzForm = new ZBBPZFrm();
            zbbpzForm.ShowDialog();
            if(zbbpzForm.DialogResult==DialogResult.OK)
            {
                this.zhiBiaoTableAdapter.Fill(this.settingDataSet.ZhiBiao);
            }
        }
        /// <summary>
        /// 修改选定的指标配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //选中数据的主键ID
            int SelectedRow = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            if(SelectedRow>0)
            {
                ZBBPZFrm zbbpzForm = new ZBBPZFrm();
                zbbpzForm.IntZhiBiaoId = SelectedRow;
                zbbpzForm.ShowDialog();
                if (zbbpzForm.DialogResult == DialogResult.OK)
                {
                    this.zhiBiaoTableAdapter.Fill(this.settingDataSet.ZhiBiao);
                }
            }
        }
        /// <summary>
        /// 删除选定的指标配置
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
                string sql = "delete from ZhiBiao where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + "";
                if (ah.ExecuteSQLNonquery(sql))
                {
                    MessageBox.Show("删除成功");
                    this.zhiBiaoTableAdapter.Fill(this.settingDataSet.ZhiBiao);
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
