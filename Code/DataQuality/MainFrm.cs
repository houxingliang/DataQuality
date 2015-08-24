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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 主窗体的加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Load(object sender, EventArgs e)
        {
            zbbzdpzCrl1.Visible = false;
        }

        /// <summary>
        /// 成果检查单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmCGJC_Click(object sender, EventArgs e)
        {
            mainCrl1.Visible = true;
            zbbzdpzCrl1.Visible = false;
            zdCrl1.Visible = false;
            gzpzCrl1.Visible = false;
            cgmlpzCrl1.Visible = false;
            cgwjpzCrl1.Visible = false;
            xzqhbmCrl1.Visible = false;
        }
        /// <summary>
        /// 成果检查主控件加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainCrl1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 指标表字段配置
        /// </summary>
        private void tsmZBBZDPZ_Click(object sender, EventArgs e)
        {
            zbbzdpzCrl1.Visible = true;
            mainCrl1.Visible = false;
            zdCrl1.Visible = false;
            gzpzCrl1.Visible = false;
            cgmlpzCrl1.Visible = false;
            cgwjpzCrl1.Visible = false;
            xzqhbmCrl1.Visible = false;
        }
        /// <summary>
        /// 字典配置
        /// </summary>
        private void tsmZDPZ_Click(object sender, EventArgs e)
        {
            zbbzdpzCrl1.Visible = false;
            mainCrl1.Visible = false;
            zdCrl1.Visible = true;
            gzpzCrl1.Visible = false;
            cgmlpzCrl1.Visible = false;
            cgwjpzCrl1.Visible = false;
            xzqhbmCrl1.Visible = false;
        }
        /// <summary>
        /// 规则配置
        /// </summary>
        private void tsmGZPZ_Click(object sender, EventArgs e)
        {
            zbbzdpzCrl1.Visible = false;
            mainCrl1.Visible = false;
            zdCrl1.Visible = false;
            gzpzCrl1.Visible = true;
            cgmlpzCrl1.Visible = false;
            cgwjpzCrl1.Visible = false;
            xzqhbmCrl1.Visible = false;
        }
        /// <summary>
        /// 成果目录配置
        /// </summary>
        private void tsmCGMLPZ_Click(object sender, EventArgs e)
        {
            zbbzdpzCrl1.Visible = false;
            mainCrl1.Visible = false;
            zdCrl1.Visible = false;
            gzpzCrl1.Visible = false;
            cgmlpzCrl1.Visible = true;
            cgwjpzCrl1.Visible = false;
            xzqhbmCrl1.Visible = false;
        }
        /// <summary>
        /// 成果文件配置
        /// </summary>
        private void tsmCGWJPZ_Click(object sender, EventArgs e)
        {
            zbbzdpzCrl1.Visible = false;
            mainCrl1.Visible = false;
            zdCrl1.Visible = false;
            gzpzCrl1.Visible = false;
            cgmlpzCrl1.Visible = false;
            cgwjpzCrl1.Visible = true;
            xzqhbmCrl1.Visible = false;
        }
        /// <summary>
        /// 行政区划编码
        /// </summary>
        private void tsmXZQHBM_Click(object sender, EventArgs e)
        {
            zbbzdpzCrl1.Visible = false;
            mainCrl1.Visible = false;
            zdCrl1.Visible = false;
            gzpzCrl1.Visible = false;
            cgmlpzCrl1.Visible = false;
            cgwjpzCrl1.Visible = false;
            xzqhbmCrl1.Visible = true;
        }

    }
}
