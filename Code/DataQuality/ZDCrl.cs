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
    public partial class ZDCrl : UserControl
    {
        public ZDCrl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// /字典配置的页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZDCrl_Load(object sender, EventArgs e)
        {
            this.ziDianTableAdapter.Fill(this.settingDataSet1.ZiDian);
        }
        /// <summary>
        /// 新增字典信息
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ZDFrm zdFrm = new ZDFrm();
            zdFrm.ShowDialog();
            if(zdFrm.DialogResult==DialogResult.OK)
            {
                this.ziDianTableAdapter.Fill(this.settingDataSet1.ZiDian);
            }
        }
        /// <summary>
        /// 修改字典信息
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //选中数据的主键ID
                int selectRow = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                if (selectRow > 0)
                {
                    ZDFrm zdFrm = new ZDFrm();
                    //传值
                    zdFrm.IntZD = selectRow;
                    zdFrm.ShowDialog();
                    if (zdFrm.DialogResult == DialogResult.OK)
                    {
                        this.ziDianTableAdapter.Fill(this.settingDataSet1.ZiDian);
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("无效的选中行！");
            }
        }
        /// <summary>
        /// 删除字典信息
        /// </summary>
        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "删除选定数据", messButton);
             if (dr == DialogResult.OK)//如果点击“确定”按钮
             {
                 AccessHelper ah = new AccessHelper();
                 string sql = "delete from ZiDian where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value + "";
                 if (ah.ExecuteSQLNonquery(sql))
                 {
                     this.ziDianTableAdapter.Fill(this.settingDataSet1.ZiDian);
                 }
                 else
                 {
                     MessageBox.Show("删除失败");
                 }
                 ah.Close();
             }
            else//如果点击“取消”按钮
            {
            }
            
        }
    }
}
