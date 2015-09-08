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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper();
            string pwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(tbPassword.Text, "MD5");
            string sql = "select * from UserTable where uName='"+tbUserName.Text+"' and uPwd='"+pwd+"'";
            DataTable dt = ah.SelectToDataTable(sql);
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("用户名或密码错误！");
            }
            else
            {
                MainFrm frm = new MainFrm();
                this.ShowInTaskbar = false;
                this.Hide();
                frm.Show();
            }
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPasswordFrm editFrm = new EditPasswordFrm();
            editFrm.userName = tbUserName.Text;
            this.Hide();
            editFrm.ShowDialog();
            if(editFrm.DialogResult==DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
