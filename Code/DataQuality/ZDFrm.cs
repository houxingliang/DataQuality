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
    public partial class ZDFrm : Form
    {
        public int IntZD = 0;//主键ID
        public ZDFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 字典编码保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckMsg())
            {
                AccessHelper ah = new AccessHelper();
                string sql = string.Empty;//sql语句
                if(IntZD==0)//新增
                {
                    if (ExistZiDianByTypeAndDM(tbLXBM.Text.Trim(), tbZDDM.Text.Trim()))
                    {
                        MessageBox.Show("存在相同的类型编码和字典代码数据！");
                        return;
                    }
                    sql = "insert into ZiDian(类型编码,类型名称,字典代码,字典名称,排序) values('";
                    sql+=""+tbLXBM.Text.Trim()+"',";
                    sql+="'"+tbLXMC.Text.Trim()+"',";
                    sql+="'"+tbZDDM.Text.Trim()+"',";
                    sql+="'"+tbZDMC.Text.Trim()+"',";
                    sql+=""+tbPX.Text.Trim()+")";

                }
                else//修改
                {
                    sql = "update ZiDian set 类型编码='" + tbLXBM.Text.Trim() + "',";
                    sql += "类型名称='" + tbLXMC.Text.Trim() + "',";
                    sql += "字典代码='" + tbZDDM.Text.Trim() + "',";
                    sql += "字典名称='" + tbZDMC.Text.Trim() + "',";
                    sql += "排序=" + tbPX.Text.Trim() + " where ID="+IntZD+"";
                }
                if (ah.ExecuteSQLNonquery(sql))
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("保存成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
                ah.Close();
            }

        }
        /// <summary>
        /// 检查数据格式
        /// </summary>
        /// <returns>是否通过验证</returns>
        private bool CheckMsg()
        {
            if(tbLXBM.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写类型编码！");
                return false;
            }
            if(tbLXMC.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写类型名称！");
                return false;
            }
            if(tbZDDM.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写字典代码！");
                return false;
            }
            if(tbZDMC.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写字典名称！");
                return false;
            }
            if(!Regex.Match(tbPX.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("请填写数字");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 是否存在类型编码与字典代码相同的数据
        /// </summary>
        /// <param name="LXBM">类型编码</param>
        /// <param name="ZDDM">字典代码</param>
        /// <returns></returns>
        private bool ExistZiDianByTypeAndDM(string LXBM,string ZDDM)
        {

            string sql = "select * from ZiDian where 类型编码='" + LXBM + "' and 字典代码='" + ZDDM + "'";
            AccessHelper ah = new AccessHelper();
            DataTable dataTable = ah.SelectToDataTable(sql);
            if (dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void ZDFrm_Load(object sender, EventArgs e)
        {
            //IntZD不等于0，说明从父窗体传来了主键ID，
            //加载实体信息做修改操作。
            if(IntZD!=0)
            {
                AccessHelper ah = new AccessHelper();
                string sql = "select * from ZiDian where ID= " + IntZD + "";
                DataTable dt = ah.SelectToDataTable(sql);
                if(dt.Rows.Count>0)
                {
                    DataRow row = dt.Rows[0];
                    tbLXBM.Text=row["类型编码"].ToString();
                    tbLXMC.Text = row["类型名称"].ToString();
                    tbZDDM.Text = row["字典代码"].ToString();
                    tbZDMC.Text = row["字典名称"].ToString();
                    tbPX.Text = row["排序"].ToString();
                }
            }
        }
    }
}
