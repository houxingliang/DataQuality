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
    public partial class EditPasswordFrm : Form
    {
        public int id;
        public string userName;

        public EditPasswordFrm()
        {
            InitializeComponent();
        }

        private void tbEdit_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper();
            string pwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(tbOldPwd.Text, "MD5");
            string sql = "select * from UserTable where uName='" + tbUserName.Text + "' and uPwd='" + pwd + "'";
            DataTable dt = ah.SelectToDataTable(sql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("用户名或密码错误！");
                return;
            }
            if(tbNewPwd.Text.Length<6)
            {
                MessageBox.Show("请输入长度大于等于6位的密码！");
                return;
            }
            if (!tbNewPwd.Text.Trim().Equals(tbRePwd.Text.Trim()))
            {
                MessageBox.Show("两次输入密码不一致！");
                return;
            }
            string editPwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(tbNewPwd.Text, "MD5");
            string editSql = "update UserTable set uName='"+tbUserName.Text.Trim()+"',uPwd='"+editPwd+"' where id=" + dt.Rows[0]["id"].ToString();
            if(ah.ExecuteSQLNonquery(editSql))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void EditPasswordFrm_Load(object sender, EventArgs e)
        {
            this.tbUserName.Text = userName;
        }

        private void EditPasswordFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
