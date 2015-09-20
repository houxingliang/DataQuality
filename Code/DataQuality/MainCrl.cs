using System;
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
using DataQuality.Common;
using System.Threading;

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
            catch (Exception)
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
        /// <summary>
        /// 检查事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {

            //检查文件路径
            if (cbJGFHX.Checked)
            {
                CheckPath checkPath = new CheckPath();
                checkPath.CheckPathMsg(tbBrowse.Text, this);
            }
            //成果文件配置
            if(cbJGFHX.Checked)
            {
                CheckFile checkFile = new CheckFile();
                checkFile.CheckFileMsg(checkFile.ReturnFiles(tbBrowse.Text, this), tbBrowse.Text,this);
            }
            if(cbJCZB.Checked)
            {
                CheckFile checkFile = new CheckFile();
                CheckZhiBiao zhibiao = new CheckZhiBiao();
                //zhibiao.CheckZhiBiaoMsg(ComMsg.infoList, tbBrowse.Text, this);
                Thread thread = new Thread(delegate() { zhibiao.CheckZhiBiaoMsg(ComMsg.infoList, tbBrowse.Text, this); });
                thread.Start();  
            }
            if(cbJCZB.Checked)
            {
                CheckGuiZe guize = new CheckGuiZe();
                guize.CheckSempleGuiZe(tbBrowse.Text, this);
            }
            /********************此区域预留用于检查其它项目，代码参考CheckPathMsg**************************/

            /********************************************************************************************/
            //将错误信息写入首页的DataGridView
            WriteFile writeFile = new WriteFile();
            this.rtbLog.Text += "\n " + DateTime.Now.ToLongTimeString() + "写入列表文件";
            writeFile.WriteDataGridView(ComMsg.ResultShow, this.dgCheckResult);

            //生成文档
            CreateFile createFile = new CreateFile();
            createFile.CreateDoc(tbBrowse.Text, cmbType.Text);//创建word文档
            createFile.CreateXls(tbBrowse.Text, cmbType.Text);//创建Excel文档

            //写入文档
            this.rtbLog.Text += "\n " + DateTime.Now.ToLongTimeString() + "写入Excel文件";
            writeFile.WriteXls(ComMsg.xlsPath);//向Excel文档中写入检查结果
            this.rtbLog.Text += "\n " + DateTime.Now.ToLongTimeString() + "写入Word文件";
            createFile.WrithDocFile(ComMsg.docPath);//向doc文档中写入检查结果


            //清空相关的文档
            ComMsg.docPath = string.Empty;
            ComMsg.xlsPath = string.Empty;
            ComMsg.infoList = new List<FileInfo>();
            ComMsg.ResultShow = new List<ResultEntity>();
            
        }
    }
}
