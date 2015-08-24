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
    public partial class CGWJPZFrm : Form
    {
        public int CGWJID = 0;//成果文件主键ID
        public CGWJPZFrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckMsg())
            {
                AccessHelper ah = new AccessHelper();
                string sql = string.Empty;
                //新增
                if(CGWJID==0)
                {
                    if (!ExistSameWenJian(cbAction.Text.Trim(), tbEnd.Text.Trim()))
                    {
                        sql = "insert into WenJian(文件开始字符,文件结束字符,文件扩展名,文件类型,是否必填) values(";
                        sql += "'" + cbAction.SelectedText + "',";
                        sql += "'" + tbEnd.Text.Trim() + "',";
                        sql += "'" + lbWJKZM.Text + "',";
                        sql += "'" + tbType.Text.Trim() + "',";
                        sql += "" + (rbYes.Checked ? 1 : 0) + ")";
                    }
                    else
                    {
                        MessageBox.Show("包含相同开始字符和结束字符的数据");
                        return;
                    }  
                }
                else//修改
                {
                    sql = "update WenJian set 文件开始字符='" + cbAction.Text + "',";
                    sql += "文件结束字符='" + tbEnd.Text.Trim() + "',";
                    sql += "文件扩展名='" + lbWJKZM.Text + "',";
                    sql += "文件类型='" + tbType.Text.Trim() + "',";
                    sql += "是否必填=" + (rbYes.Checked ? 1 : 0) + " where ID="+CGWJID;
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

        private void CGWJPZFrm_Load(object sender, EventArgs e)
        {
            this.muLuTableAdapter.Fill(this.settingDataSet.MuLu);
            if (CGWJID > 0)
            {
                AccessHelper ah = new AccessHelper();
                string sql = "select * from WenJian where ID=" + CGWJID;
                DataTable dt = ah.SelectToDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    cbAction.Text = dr["文件开始字符"].ToString();
                    tbEnd.Text = dr["文件结束字符"].ToString();
                    tbType.Text = dr["文件类型"].ToString();
                    if ((bool)dr["是否必填"])
                        rbYes.Checked = true;
                    else
                        rbNo.Checked = true;
                    string type = dr["文件扩展名"].ToString();
                    foreach(Control c in this.groupBox1.Controls)
                    {
                        if (c is CheckBox)
                        {
                           if(type.Contains(((CheckBox)c).Text))
                           {
                               ((CheckBox)c).Checked = true;
                           }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 字段检查
        /// </summary>
        /// <returns>通过返回true，不通过返回false</returns>
        private bool CheckMsg()
        {
            if(tbEnd.Text.Length==0)
            {
                MessageBox.Show("请填写文件结束字符");
                return false;
            }
            lbWJKZM.Text = string.Empty;
            //获取选中的文件格式
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        lbWJKZM.Text += c.Text + "|";
                    }
                }
            }
            if(lbWJKZM.Text.Length==0)
            {
                MessageBox.Show("请选择最少一种文件格式");
                return false;
            }
            else
            {
                lbWJKZM.Text = lbWJKZM.Text.Substring(0, lbWJKZM.Text.Length - 1);
            }
            return true;
        }
        /// <summary>
        /// 检查是否有相同开始和结束字符的数据
        /// </summary>
        /// <param name="action">文件开始字符</param>
        /// <param name="end">文件结束字符</param>
        /// <returns>true有相同条件数据，false没有相同条件数据</returns>
        private bool ExistSameWenJian(string action,string end)
        {
            AccessHelper ah = new AccessHelper();
            string sql = "select * from WenJian where 文件开始字符='"+action+"'";
            sql+="and 文件结束字符='"+end+"'";
            DataTable dt = ah.SelectToDataTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
