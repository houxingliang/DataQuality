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
    public partial class CGMLPZFrm : Form
    {
        public int MLID = 0;//目录ID
        public CGMLPZFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存编辑的目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper();
            string sql = string.Empty;
            if (CheckMsg())
            { 
                if(MLID==0)//新增
                {
                    if(ExistSameMuLu(tbCGML.Text.Trim()))
                    {
                        MessageBox.Show("包含相同目录的记录，请检查后录入");
                        return;
                    }
                    sql = "insert into Mulu(目录名称,检查级别) values('"+tbCGML.Text.Trim()+"',";
                    sql+="'"+"省级质检"+"')";//后期修改
                }
                else//修改
                {
                    sql = "update Mulu set 目录名称='"+tbCGML.Text.Trim()+"',";
                    sql+="检查级别='"+"省级质检"+"' where ID=" + MLID;//后期修改
                }
                if(ah.ExecuteSQLNonquery(sql))
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
        /// 数据检验
        /// </summary>
        /// <returns>是否通过</returns>
        private bool CheckMsg()
        {
            if (!checkString(tbCGML.Text))
            {
                MessageBox.Show("文本包含特殊字符！");
                return false;
            }
            if(tbCGML.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写目录！");
                return false;
            }
            int position=tbCGML.Text.Trim().LastIndexOf(@"\");
            string result = tbCGML.Text.Trim().Substring(position+1);
            if(result.Length==0)
            {
                MessageBox.Show("无效的目录结构");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 检查特殊字符
        /// </summary>
        /// <param name="source">待检查文本</param>
        /// <returns>是否包含特殊字符</returns>
        public static bool checkString(string source)
        {
            Regex regExp = new Regex("[~!@#$%^&*()=+[\\]{}';:/?.,><`|！·￥…—（）\\-、；：。，》《]");
            return !regExp.IsMatch(source);
        }
        /// <summary>
        /// 是否包含相同的目录
        /// </summary>
        /// <param name="mulu">目录</param>
        /// <returns>是否有相同的目录数据，是true，否false</returns>
        public bool ExistSameMuLu(string mulu)
        {
            AccessHelper ah = new AccessHelper();
            string sql = "select * from MuLu where 目录名称='" + mulu + "'";
            DataTable dt = ah.SelectToDataTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void CGMLPZFrm_Load(object sender, EventArgs e)
        {
            //目录ID大于0，从数据库查询相关数据
            if(MLID>0)
            {
                AccessHelper ah = new AccessHelper();
                string sql = "select * from MuLu where ID=" + MLID;
                DataTable dt = ah.SelectToDataTable(sql);
                if(dt.Rows.Count>0)
                {
                    DataRow dr = dt.Rows[0];
                    tbCGML.Text=dr["目录名称"].ToString();
                }
            }
        }
    }
}
