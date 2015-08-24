﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using System.Web;
using System.IO;
using System.Web.UI.WebControls;

namespace DataQuality
{
    public partial class MainCrl : UserControl
    {
        XmlDocument XmlDoc = new XmlDocument();
        public MainCrl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 质检页面加载事件
        /// 将xml文件读取到页面
        /// </summary>
        private void MainCrl_Load(object sender, EventArgs e)
        {
            FillcmbType();
        }
        /// <summary>
        /// 浏览读取需要校验数据的文件夹下的所有文件
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowseDiaolg=new FolderBrowserDialog();
            DialogResult dialogResult = folderBrowseDiaolg.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                tbBrowse.Text = folderBrowseDiaolg.SelectedPath;//显示选定文件夹目录

                Helper helper = new Helper();//实例化帮助类
                helper.relateTreeView(treeView1, tbBrowse.Text);//加载选定目录下所有的文件
                treeView1.ExpandAll();//展开加载的所有文件目录
            }
        }

      
        /// <summary>
        /// 向cmbType填充数据
        /// cmbType 检查类别
        /// </summary>
        private void FillcmbType()
        {
            try
            {
                XmlDoc.Load(Application.StartupPath + "\\PeiZhi.xml");
                XmlElement rootElem = XmlDoc.DocumentElement;   //获取根节点  
                XmlNodeList typeNodes = rootElem.GetElementsByTagName("TypeMsg"); //获取TypeMsg子节点集合 
                foreach (XmlNode node in typeNodes)
                {
                    string name = node.InnerText;
                    cmbType.Items.Add(name);
                }
                if (cmbType.Items.Count != 0)
                {
                    cmbType.SelectedItem = cmbType.Items[0];
                }
            }
            catch (Exception )
            {
                MessageBox.Show("未检测到'PeiZhi.xml'文件");
            }
           
        }

        /// <summary>
        /// 生成指定目录下的treeview
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="fullPath"></param>
        private void PaintTreeView(System.Windows.Forms.TreeView treeView,string fullPath)
        {

        }


    }
}
