using DataQuality.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataQuality
{
    public partial class GZPZFrm : Form
    {
        public int GZID = 0;//规则ID
        public GZPZFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GZPZFrm_Load(object sender, EventArgs e)
        {
            if (cbDJLX.Items.Count != 0)
            {
                cbDJLX.SelectedItem = cbDJLX.Items[0];
                cbDJLX.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            if (cbGZLX.Items.Count != 0)
            {
                cbGZLX.SelectedItem = cbGZLX.Items[0];
                cbGZLX.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            if (cbXYLX.Items.Count != 0)
            {
                cbXYLX.SelectedItem = cbXYLX.Items[0];
                cbXYLX.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            if(GZID>0)//规则ID大于0，说明启用的是修改操作。
            {
                AccessHelper ah = new AccessHelper();
                string sql = "select * from GuiZe where ID=" + GZID;
                DataTable dt = ah.SelectToDataTable(sql);
                if(dt.Rows.Count>0)
                {
                    DataRow row = dt.Rows[0];
                    cbDJLX.Text = ComMsg.DJLX[row["登记类型"].ToString()];
                    cbGZLX.Text = row["规则类型"].ToString();
                    tbGZBH.Text = row["规则编号"].ToString();
                    tbGZZBH.Text = row["规则子编号"].ToString();
                    tbGZMC.Text = row["规则名称"].ToString();
                    tbCWMS.Text = row["错误描述"].ToString();
                    if (row["严重程度"].ToString().Contains("轻"))
                        rbQQX.Checked = true;
                    else
                        rbZQX.Checked = true;
                    cbXYLX.Text = row["校验类型"].ToString();
                    tbBDS.Text = row["表达式"].ToString();
                    tbBM.Text = row["表名"].ToString();
                    tbZDM.Text = row["字段名"].ToString();
                    if ((bool)row["是否检查"])
                        rbCheck.Checked = true;
                    else
                        rbCheck_No.Checked = true;
                 }
            }
        }
        /// <summary>
        /// 保存编辑的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
           if(CheckMsg())
           {
               //access帮助类
               AccessHelper ah = new AccessHelper();
               string sql = string.Empty;//sql语句
               if (!ExistGZ(GetDJLXType(cbDJLX.Text.Trim()), cbGZLX.Text.Trim(), tbGZBH.Text.Trim(), tbGZZBH.Text.Trim()))
               {
                   sql = "insert into GuiZe(登记类型,规则类型,规则编号,规则子编号,规则名称,错误描述,严重程度,校验类型,表达式,表名,字段名,是否检查) values(";
                   sql += "'" + GetDJLXType(cbDJLX.Text.Trim()) + "',";
                   sql += "'" + cbGZLX.Text.Trim() + "',";
                   sql += "'" + tbGZBH.Text.Trim() + "',";
                   sql += "" + tbGZZBH.Text.Trim() + ",";
                   sql += "'" + tbGZMC.Text.Trim() + "',";
                   sql += "'" + tbCWMS.Text.Trim() + "',";
                   sql += "'" + (rbZQX.Checked ? "重缺陷" : "轻缺陷") + "',";
                   sql += "'" + cbXYLX.Text.Trim() + "',";
                   sql += "'" + tbBDS.Text.Trim() + "',";
                   sql += "'" + tbBM.Text.Trim() + "',";
                   sql += "'" + tbZDM.Text.Trim() + "',";
                   sql += "'" + (rbCheck.Checked ? 1 : 0) + "')";
               }
               else
               {
                   sql = "update GuiZe set 登记类型='" + GetDJLXType(cbDJLX.Text.Trim()) + "',";
                   sql += "规则类型='" + cbGZLX.Text.Trim() + "',规则编号='" + tbGZBH.Text.Trim() + "',";
                   sql += "规则子编号='" + tbGZZBH.Text.Trim() + "',规则名称='"+tbGZMC.Text.Trim()+"'";
                   sql += ",错误描述='" + tbCWMS.Text.Trim() + "',严重程度='" + (rbZQX.Checked ? "重缺陷" : "轻缺陷") + "',";
                   sql += "校验类型='" + cbXYLX.Text.Trim() + "',表达式='" + tbBDS.Text.Trim() + "',";
                   sql+="表名='"+tbBM.Text.Trim()+"',字段名='"+tbZDM.Text.Trim()+"',";
                   sql += "是否检查=" + (rbCheck.Checked ? 1 : 0) + " where ID="+GZID;
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
        /// 获取登记类型编码
        /// </summary>
        /// <param name="value">登记类型</param>
        /// <returns>登记类型编码</returns>
        private string GetDJLXType(string value)
        {
            foreach (var temp in ComMsg.DJLX)
            {
                if (temp.Value == value)
                {
                    return temp.Key;
                }
            }
            return "";
        }
        /// <summary>
        /// 数据格式检查
        /// </summary>
        /// <returns>格式是否正确</returns>
        private bool CheckMsg()
        {
            if (cbDJLX.Text.Contains("选择"))
            {
                MessageBox.Show("请选择登记类型！");
                return false;
            }
            if (cbXYLX.Text.Contains("选择"))
            {
                MessageBox.Show("请选择校验类型！");
                return false;
            }
            if (cbGZLX.Text.Contains("选择"))
            {
                MessageBox.Show("请选择规则类型！");
                return false;
            }
            if(tbGZMC.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写规则名称！");
                return false;
            }
            if(tbGZBH.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写规则编号！");
                return false;
            }
            if(tbGZZBH.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写规则子编号！");
                return false;
            }
            if(tbBDS.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写表达式!");
                return false;
            }
            if (tbBM.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写表名!");
                return false;
            }
            if (tbZDM.Text.Trim().Length == 0)
            {
                MessageBox.Show("请填写字段名!");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 检查是否有相同条件的规则数据
        /// </summary>
        /// <param name="DJLX">登记类型</param>
        /// <param name="GZLX">规则类型</param>
        /// <param name="GZBM">规则编码</param>
        /// <param name="GZZBM">规则子编码</param>
        /// <returns></returns>
        public bool ExistGZ(string DJLX, string GZLX,string GZBM,string GZZBM)
        {
            string sql = "select * from GuiZe where 登记类型='" + DJLX + "' and 规则类型='" + GZLX + "' and 规则编号='"+GZBM+"' and 规则子编号="+GZZBM+"";
            AccessHelper ah = new AccessHelper();
            DataTable dataTable = ah.SelectToDataTable(sql);
            if (dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
