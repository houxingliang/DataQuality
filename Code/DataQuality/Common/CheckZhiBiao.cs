using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataQuality.Common
{
    /// <summary>
    /// 检查基础指标
    /// </summary>
    public class CheckZhiBiao
    {
        /// <summary>
        /// 检查基础指标信息
        /// </summary>
        /// <param name="infoList"></param>
        public void CheckZhiBiaoMsg(List<FileInfo> infoList,string path,MainCrl crl)
        {
            List<string> files = new List<string>();//去除所有父级目录后的文件信息
            string tName = path.Substring(path.IndexOf(@"\") + 1);//成果名称
            tName = tName.Substring(tName.LastIndexOf(@"\")+1);
            //读取了目标文件夹下所有的文件信息，将这些文件和数据库的信息进行成果比对
            for (int i = 0; i < infoList.Count(); i++)
            {
                //去除选定目录的所有父级目录，只保留选定文件夹所包含的文件夹路径
                files.Add(infoList[i].FullName);
            }
            List<string> accessFiles = new List<string>();
            //获取所有的access文件
            foreach(string file in files)
            {
                if(file.Contains("mdb")||file.Contains("accdb"))
                {
                    accessFiles.Add(file);
                }
            }
            AccessHelper ah = new AccessHelper();
            Dictionary<string, string> tables = new Dictionary<string, string>();
            List<string> columns = new List<string>();
            //检查access文件中是否有表名
            foreach(string p in accessFiles)
            {
                string[] tableNames = ah.GetShemaTableName(p, "");
                if(tableNames.Count()>0)
                {
                    for(int i=0;i<tableNames.Count();i++)
                    {
                        tables.Add(tableNames[i], p);
                        columns.AddRange(ah.GetTableColumn(p, tableNames[i]));
                    }
                }
            }

            if(tables.Count>0)
            {
                AccessHelper accessHelper = new AccessHelper();
                DataTable dt = accessHelper.SelectToDataTable("select * from ZhiBiao ");
                for(int i=0;i<dt.Rows.Count;i++)
                {
                   string tablePath=tables[dt.Rows[i]["表名"].ToString()];
                   string sql = "select  " + dt.Rows[i]["列名"].ToString() + "  from  " + dt.Rows[i]["表名"].ToString();
                   DataTable tempDT = ah.SelectToDataTable(sql, tablePath);
                    if(tempDT.Rows.Count>0)
                    {
                        for(int j=0;j<tempDT.Rows.Count;j++)
                        {
                            String check = tempDT.Rows[j][(dt.Rows[i]["列名"].ToString())].ToString();
                            //除去数据类型为date的数据，都需要检查字段长度
                            if (!dt.Rows[i]["数据类型"].ToString().Equals("Date"))//长度检查
                            {
                                if (check.Length > (int)dt.Rows[i]["数据长度"])
                                {
                                    ComMsg.ResultShow.Add(new ResultEntity(tName, "结构符合性", "100000004", "字段值长度不能超过数据库标准的字段长度", "字段值长度不能超过数据库标准的字段长度", j + "", "重缺陷", DateTime.Now.ToShortDateString()));
                                    crl.rtbLog.Text += "\n " + "字段值长度不能超过数据库标准的字段长度" + dt.Rows[i]["列名"].ToString();
                                }
                            }
                            if(dt.Rows[i]["是否必填"].ToString().Equals("M"))//是否必填
                            {
                                if (tempDT.Rows[j][(dt.Rows[i]["列名"].ToString())].ToString().Length==0)
                                {
                                    ComMsg.ResultShow.Add(new ResultEntity(tName, "结构符合性", "100000002", "指标信息不能缺少字段", "指标信息不能缺少字段", j + "", "重缺陷", DateTime.Now.ToShortDateString()));
                                    crl.rtbLog.Text += "\n " + "指标信息不能缺少字段" + dt.Rows[i]["列名"].ToString();
                                }
                            }

                            //字段类型为int
                            if (dt.Rows[i]["数据类型"].ToString().Equals("Int"))
                            {
                                try
                                {
                                    int temp = Convert.ToInt32(tempDT.Rows[j][(dt.Rows[i]["列名"].ToString())]);
                                }
                                catch (Exception e)
                                {
                                    if (tempDT.Rows[j][(dt.Rows[i]["列名"].ToString())].ToString().Length > 0)
                                    {
                                        ComMsg.ResultShow.Add(new ResultEntity(tName, "结构符合性", "100000003", "字段值符合标准数据库字段类型", "字段值不符合标准数据库字段类型", j + "", "重缺陷", DateTime.Now.ToShortDateString()));
                                        crl.rtbLog.Text += "\n " + "字段值不符合标准数据库字段类型" + dt.Rows[i]["列名"].ToString();
                                    }
                                }
                            }
                            //字段类型为double
                            if (dt.Rows[i]["数据类型"].ToString().Equals("Double")&&tempDT.Rows[j][(dt.Rows[i]["列名"].ToString())].ToString().Length>0)
                            {
                                try
                                {
                                    string temp = tempDT.Rows[j][(dt.Rows[i]["列名"].ToString())].ToString();
                                    //检查小数位
                                    if(temp.Contains("."))
                                    {
                                        temp = temp.Substring(temp.LastIndexOf(".") + 1);
                                        if (temp.Length > (int)dt.Rows[i]["数据精度"])
                                        {
                                            string a = dt.Rows[i]["列名"].ToString();
                                            ComMsg.ResultShow.Add(new ResultEntity(tName, "结构符合性", "100000005", "字段值小数位数不能超过数据库标准的小数位数", (dt.Rows[i]["列名"] + "字段值小数位数不能超过数据库标准的小数位数"), (j + 1) + "", "重缺陷", DateTime.Now.ToShortDateString()));
                                            crl.rtbLog.Text += "\n " + "字段值小数位数不能超过数据库标准的小数位数" + dt.Rows[i]["列名"].ToString();
                                        }
                                    }
                                }
                                catch (Exception e)
                                {
                                    if (tempDT.Rows[j][(dt.Rows[i]["列名"].ToString())].ToString().Length > 0)
                                    {
                                        ComMsg.ResultShow.Add(new ResultEntity(tName, "结构符合性", "100000003", "字段值符合标准数据库字段类型", "字段值不符合标准数据库字段类型", j + "", "重缺陷",   
                                DateTime.Now.ToShortDateString()));
                                        crl.rtbLog.Text += "\n " + "字段值不符合标准数据库字段类型" + dt.Rows[i]["列名"].ToString();
                                    }
                                }
                            }
                            //字段类型为date
                            if (dt.Rows[i]["数据类型"].ToString().Equals("Date"))
                            {
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
