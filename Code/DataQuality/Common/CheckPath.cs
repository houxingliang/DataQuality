using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace DataQuality.Common
{
    /// <summary>
    /// 检查目录是否符合标准
    /// </summary>
    public class CheckPath
    {
        //检查文件路径信息
        public void CheckPathMsg(string path,MainCrl crl)
        {
            //获取当前目录
            System.IO.DirectoryInfo aDir = new System.IO.DirectoryInfo(path);
            DirectoryInfo[] dirs =aDir.GetDirectories();//获取当前目录的所有子目录
            if(dirs.Count()>=0)
            {
                //记录当前目录下所有的子目录名称
                List<string> AllFileName = new List<string>();
                foreach(DirectoryInfo dir in dirs)
                {
                    AllFileName.Add(dir.FullName);//当前目录的子目录
                    AllFile(AllFileName,dir);
                }
                //获取配置库中需要检查的目录信息
                AccessHelper ah = new AccessHelper();
                string sql = "select * from MuLu";
                DataTable dt = ah.SelectToDataTable(sql);
                if(dt.Rows.Count>0)
                {
                    for (int i = 0; i < AllFileName.Count();i++ )
                    {
                        AllFileName[i] = AllFileName[i].Replace(path+@"\", "");//截取当前目录所有子目录，使其符合数据库配置规则。
                    }
                        //检查当前目录是否在数据库配置库中，
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string temp = dt.Rows[i]["目录名称"].ToString();
                            if(!AllFileName.Contains(temp))//如果不存在，说明当前目录的子目录缺少必须的目录
                            {
                                crl.rtbLog.Text += "\n 目录结构不完整，缺少" + temp+"文件夹";
                            }
                        }
                       
                }
            }
        }
        private bool AllFile(List<string> returnNum,DirectoryInfo infos)
        {
            if (Directory.Exists(infos.FullName) == false)
            { return false; }
            //if (allNum == 0)
            //    return false;
            foreach(DirectoryInfo info in infos.GetDirectories())
            {
                returnNum.Add(info.FullName);
                AllFile(returnNum, info);
            }
            return true;
        }
    }
}
