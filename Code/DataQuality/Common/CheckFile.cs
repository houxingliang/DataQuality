﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataQuality.Common
{
    /// <summary>
    /// 检查成果文件配置
    /// </summary>
    class CheckFile
    {

        /// <summary>
        /// 检查加载进来的文件夹下面的所有文件信息
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="mainCrl">检查主窗体</param>
        public List<FileInfo> ReturnFiles(string path,MainCrl mainCrl)
        {
            if(path.Length==0)
            {
                MessageBox.Show("请选择路径");
                return null;
            }
            System.IO.DirectoryInfo aDir = null;
            try
            {
                //获取当前目录
                aDir = new System.IO.DirectoryInfo(path);
            }
            catch (Exception)
            {
                MessageBox.Show("路径不合法");
                return null;
            }
            DirectoryInfo[] dirs = aDir.GetDirectories();//获取当前目录的所有子目录
            if(dirs.Count()>0)
            {
                //记录当前目录下所有的子目录名称
                List<string> AllFileName = new List<string>();
                foreach (DirectoryInfo dir in dirs)
                {
                    AllFileName.Add(dir.FullName);//当前目录的子目录
                    if (dir.GetFiles().Count() != 0)
                    {
                        ComMsg.infoList.AddRange(dir.GetFiles());
                    }
                    AllFile(AllFileName, dir);
                }
            }
            return  ComMsg.infoList;
        }

        /// <summary>
        /// 检查文件信息
        /// </summary>
        /// <param name="infoList"></param>
        public void CheckFileMsg(List<FileInfo> infoList,string path,MainCrl crl)
        {
            crl.rtbLog.Text += "\n " + DateTime.Now.ToLongTimeString() + "开始检查文件目录及文件";
            List<string> files = new List<string>();//去除所有父级目录后的文件信息
            //读取了目标文件夹下所有的文件信息，将这些文件和数据库的信息进行成果比对
            if (infoList == null) return;
            for (int i = 0; i < infoList.Count(); i++)
            {
                //去除选定目录的所有父级目录，只保留选定文件夹所包含的文件夹路径
                files.Add(infoList[i].FullName.Replace(path + @"\", ""));
                //截取文件夹
                //folders.Add(files[i].Substring(0, files[i].LastIndexOf(@"\")));
                //截取文件
                // folderFiles.Add(files[i].Substring(files[i].LastIndexOf(@"\")+1));
            }
            //检查当前文件是否在数据库配置中
            AccessHelper ah = new AccessHelper();
            System.Data.DataTable dt = ah.SelectToDataTable("select * from WenJian");
            List<string> dateList = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(((bool)dt.Rows[i]["是否必填"]))
                {
                    bool showError = true;//是否显示问题数据
                    for (int j = 0; j < files.Count; j++)
                    {
                        if(dt.Rows[i]["文件开始字符"].ToString().Contains("|"))
                        {
                            string[] actionList = dt.Rows[i]["文件开始字符"].ToString().Split("|".ToArray());
                            if (actionList.Contains(files[j].Substring(0,files[j].LastIndexOf(@"\"))))
                            {
                                if (dt.Rows[i]["文件结束字符"].ToString().Contains("|"))//有“|”说明有多种选择，将字符按|进行分割比较
                                {
                                    string[] fileNameList = dt.Rows[i]["文件结束字符"].ToString().Split("|".ToArray());
                                    foreach(string temp in fileNameList)
                                    {
                                        if(files[j].Contains(temp))
                                        {
                                            //在此判断后缀
                                            if (dt.Rows[i]["文件扩展名"].ToString().Contains("|"))
                                            {
                                                string[] fileEndList = dt.Rows[i]["文件扩展名"].ToString().Split("|".ToArray());
                                                foreach(string endTemp in fileEndList)
                                                {
                                                    if (endTemp.Contains(files[j].Substring(files[j].LastIndexOf(".") + 1)))
                                                    {
                                                        files.Remove(files[j]);
                                                        showError = false;
                                                        break;
                                                    }
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                if(dt.Rows[i]["文件扩展名"].ToString().Contains(files[j].Substring(files[j].LastIndexOf(".") + 1)))
                                                {
                                                    files.Remove(files[j]);
                                                    showError = false;
                                                    break;
                                                }
                                                break;
                                            }
                                        }
                                    }
                                }
                                else if (files[j].Contains(dt.Rows[i]["文件结束字符"].ToString()))
                                {
                                    if (dt.Rows[i]["文件扩展名"].ToString().Contains("|"))
                                    {
                                        string[] fileEndList = dt.Rows[i]["文件扩展名"].ToString().Split("|".ToArray());
                                        foreach (string endTemp in fileEndList)
                                        {
                                            if (endTemp.Contains(files[j].Substring(files[j].LastIndexOf(".") + 1)))
                                            {
                                                files.Remove(files[j]);
                                                showError = false;
                                                break;
                                            }
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        if (dt.Rows[i]["文件扩展名"].ToString().Contains(files[j].Substring(files[j].LastIndexOf(".") + 1)))
                                        {
                                            files.Remove(files[j]);
                                            showError = false;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (files[j].Contains(dt.Rows[i]["文件开始字符"].ToString()))
                        {
                            if (dt.Rows[i]["文件结束字符"].ToString().Contains("|"))//有“|”说明有多种选择，将字符按|进行分割比较
                            {
                                string[] fileNameList = dt.Rows[i]["文件结束字符"].ToString().Split("|".ToArray());
                                if (fileNameList.Contains(files[j]))
                                {
                                    if (dt.Rows[i]["文件扩展名"].ToString().Contains("|"))
                                    {
                                        string[] fileEndList = dt.Rows[i]["文件扩展名"].ToString().Split("|".ToArray());
                                        foreach (string endTemp in fileEndList)
                                        {
                                            if (files[j].Contains(endTemp))
                                            {
                                                files.Remove(files[j]);
                                                showError = false;
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (dt.Rows[i]["文件扩展名"].ToString().Contains(files[j].Substring(files[j].LastIndexOf(".") + 1)))
                                        {
                                            files.Remove(files[j]);
                                            showError = false;
                                            break;
                                        }
                                    }
                                }
                            }
                            else if (files[j].Contains(dt.Rows[i]["文件结束字符"].ToString()))
                            {
                                if (dt.Rows[i]["文件扩展名"].ToString().Contains("|"))
                                {
                                    string[] fileEndList = dt.Rows[i]["文件扩展名"].ToString().Split("|".ToArray());
                                    foreach (string endTemp in fileEndList)
                                    {
                                        if (files[j].Contains(endTemp))
                                        {
                                            files.Remove(files[j]);
                                            showError = false;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    if (dt.Rows[i]["文件扩展名"].ToString().Contains(files[j].Substring(files[j].LastIndexOf(".") + 1)))
                                    {
                                        files.Remove(files[j]);
                                        showError = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (showError)
                    {
                        ComMsg.ResultShow.Add(new ResultEntity(path.Substring(path.LastIndexOf(@"\") + 1), "数据完整性", "900000001", "成果完整性符合标准",
                           "目录结构或者文件不符合标准;缺少文件：" + dt.Rows[i]["文件结束字符"].ToString(), "", "重缺陷", DateTime.Now.ToShortDateString()));
                        
                    }
                        
                }
            }
        }

        private bool AllFile(List<string> returnNum, DirectoryInfo infos)
        {
            if (Directory.Exists(infos.FullName) == false)
            { 
                //获取文件夹下的所有文件信息
                foreach(DirectoryInfo info in infos.GetDirectories())
                {
                     if(infos.GetFiles().Count()!=0)
                    {
                        ComMsg.infoList.AddRange(infos.GetFiles());
                    }
                }
               
                return false;
            }
            //if (allNum == 0)
            //    return false;
            foreach (DirectoryInfo info in infos.GetDirectories())
            {
                returnNum.Add(info.FullName);
                //获取文件夹下的所有文件信息
                if (info.GetFiles().Count() != 0)
                {
                    ComMsg.infoList.AddRange(info.GetFiles());
                }
                AllFile(returnNum, info);
            }
            return true;
        }
    }
}
