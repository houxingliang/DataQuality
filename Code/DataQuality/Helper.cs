using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataQuality
{
    public class Helper
    {
        #region treeView显示文件夹及其所属文件

        #endregion
        /// <summary> 
        ///使用relateTreeView函数时 path 路径使用本地路径,或经过Server.MapPath("服务器的文件路径")解析过的路径; 
        ///例如：relateTreeView(TreeView1, "D:\\Download");         
        /// </summary> 
        /// <param name="tv">TreeView</param>         
        /// <param name="path">遍历路径</param> 
        public void relateTreeView(TreeView tv, string path)
        {
            tv.Nodes.Clear(); //清空TreeView 
            tv.Nodes.Add(new TreeNode()); //添加新节点 
            string[] pathinfo = Path.GetFullPath(path.Trim()).Split(char.Parse("\\")); //得到文件路径数组 
            tv.Nodes[0].Text = pathinfo[pathinfo.Length - 1]; //得到文件夹名             
            tv.Nodes[0].Name = path; //得到文件夹的详细本地路径             
            tv.Nodes[0].Expand(); //展开根节点 
            tv.Nodes[0].ImageIndex = 0; //根节点图片 
            TraversingCatalog(tv.Nodes[0], path); //调用函数        
        }
        /// <summary> 
        /// 遍历根节点下的所有文件夹及文件         /// </summary> 
        /// <param name="tn">根节点</param> 
        /// <param name="path">根节点路径</param>         /// <returns></returns> 
        private bool TraversingCatalog(TreeNode tn, string path) //遍历文件夹       
        {
            if (Directory.Exists(path) == false)
            { return false; }
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            int allNum = dirInfo.GetDirectories().Length + dirInfo.GetFiles("*.*").Length;
            if (allNum == 0) //没有任何文件夹和文件就建立"（空白）"节点并返回false             
            {
                TreeNode empty = new TreeNode();
                empty.Text = "（空白）"; //得到文件名 
                empty.Name = ""; //得到文件的详细本地路径                
                empty.ImageIndex = 0; //节点图片                 
                //empty.Expanded = false; //折叠节点                
                tn.Nodes.Add(empty); //添加新节点                
                return false;
            }
            //循环文件夹(避免混乱,先循环文件夹) 

            int folderIndex = -1; //文件夹索引 
            foreach (DirectoryInfo folder in dirInfo.GetDirectories())             
            { 
                folderIndex++; 
                TreeNode folderNode = new TreeNode(); 
                folderNode.Text = folder.Name; //得到文件夹名 
                folderNode.Name = folder.FullName; //得到文件夹的详细本地路径                 
                folderNode.ToolTipText = folder.Name; //得到文件夹名                 
                folderNode.Expand(); //折叠节点 
                folderNode.ImageIndex = 0; //节点图片                 
                tn.Nodes.Add(folderNode); //添加新节点 
                TraversingCatalog(tn.Nodes[folderIndex], path + "/" + folder.Name); //递归遍历其它文件夹             
            }  
            //循环文件 
            foreach (FileInfo file in dirInfo.GetFiles("*.*")) //循环扩展名为*.*的文件             
            { 
                TreeNode fileNode = new TreeNode();                 
                fileNode.Text = file.Name; //得到文件名 
                fileNode.Name = file.FullName; //得到文件的详细本地路径                 
                fileNode.ToolTipText = file.Name; //得到文件名                 
                fileNode.Expand(); //折叠节点 
                fileNode.ImageIndex = 1; //节点图片                 
                fileNode.SelectedImageIndex = 1;                 
                tn.Nodes.Add(fileNode); //添加新节点             
            } 
            return true;
        }
    }
}
