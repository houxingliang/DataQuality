using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DataQuality
{
    public partial class XZQHBMFrm : Form
    {
        public int XZQHID = 0;//行政区划ID
        public string FJQHBM = string.Empty;//父级区划编码
        string oldQHBM = string.Empty;//修改前的区划编码
        public XZQHBMFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void XZQHBMFrm_Load(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper();
            string sql = "select * from QuHua where ID=" + XZQHID;
            DataTable dt = ah.SelectToDataTable(sql);
            if(dt.Rows.Count>0)
            {
                DataRow dr = dt.Rows[0];
                tbQHBM.Text = dr["行政区编码"].ToString();
                oldQHBM = dr["行政区编码"].ToString();
                tbQHMC.Text = dr["行政区名称"].ToString();
                FJQHBM = dr["父级编码"].ToString();
            }
            tbFJQHBM.Text = FJQHBM;
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            //检查数据格式
            if(CheckMsg())
            {
                AccessHelper ah = new AccessHelper();
                string sql = string.Empty;
                if(XZQHID==0)//新增
                {
                    sql = "insert into QuHua(行政区编码,行政区名称,父级编码) values('"+tbQHBM.Text.Trim()+"',";
                    sql+="'"+tbQHMC.Text.Trim()+"','"+FJQHBM+"')";
                }
                else
                {
                    sql = "update QuHua set 行政区编码='"+tbQHBM.Text.Trim()+"',行政区名称='"+tbQHMC.Text.Trim()+"',父级编码='"+FJQHBM+"' where ID="+XZQHID;

                }
                if(ah.ExecuteSQLNonquery(sql))
                {
                    this.DialogResult = DialogResult.OK;
                    string OtherSql = "update QuHua set 父级编码='" + tbQHBM.Text.Trim() + "' where 父级编码='"+oldQHBM+"'";
                    ah.ExecuteSQLNonquery(OtherSql);
                    MessageBox.Show("保存成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
                ah.Close();
            }
            FJQHBM = string.Empty;
        }
        /// <summary>
        /// 检查输入格式
        /// </summary>
        /// <returns>检查通过返回true，不通过返回false</returns>
        bool CheckMsg()
        {
            if(tbQHBM.Text.Length==0)
            {
                MessageBox.Show("行政区划编码不能为空");
                return false;
            }
            if(tbQHMC.Text.Length==0)
            {
                MessageBox.Show("行政区划名称不能为空");
                return false;
            }
            if (!Regex.Match(tbQHBM.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("请输入数字编码");
                return false;
            }
            return true;
        }
    }
}
