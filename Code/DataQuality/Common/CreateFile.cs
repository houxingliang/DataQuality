using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MSWord = Microsoft.Office.Interop.Word;

namespace DataQuality.Common
{
    /// <summary>
    /// 创建成果文件
    /// </summary>
    public class CreateFile
    {
        /// <summary>
        /// 创建word文档
        /// </summary>
        /// <param name="p">文件的存储位置</param>
        /// <param name="level">检查类别</param>
        public void CreateDoc(string p,string level)
        {
            if(p.Length==0)
            {
                return;
            }
            string Quhua = string.Empty;//行政区划
            string Level = string.Empty;//检查级别
            string Type = string.Empty;//检查类别
            string FileName = string.Empty;//文件名称
            //查看文件检查级别
            if (level.Contains("省级"))
            {
                Level = "省级检查情况报告";
            }
            if(level.Contains("县级"))
            {
                Level = "县级检查情况报告";
            }
            //路径文件夹是国土使用权还是集体所有权
            if(p.Contains("国有"))
            {
                Type = "GTSYQ";
            }
            if(p.Contains("集体"))
            {
                Type = "JTSYQ";
            }
            try
            {
                //查看其行政区划编码
                Quhua = p.Substring(p.IndexOf("(")+1);
                Quhua = Quhua.Substring(0, Quhua.IndexOf(")"));
            }
            catch (Exception)
            {
            }
            FileName = Type + Quhua + Level;//文件名称
            string path = p + @"\"+FileName+".doc";//生成后的完整目录
            //检查文件是否存在，如果存在删除原有文件
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            //模板文件位置
            string TemplateFile = System.Windows.Forms.Application.StartupPath + @"\" + "检查情况报告.doc";
            try
            {
                File.Copy(TemplateFile, path);
            }
            catch (Exception)
            {
                MessageBox.Show("文件创建出错");
            }
            
            ComMsg.docPath = path;//向docPath赋值
        }
        /// <summary>
        /// 创建excel文档
        /// </summary>
        /// <param name="p">文件的存储位置</param>
        public void CreateXls(string p,string level)
        {
            if (p.Length == 0)
            {
                return;
            }
            string Quhua = string.Empty;//行政区划
            string Level = string.Empty;//检查级别
            string Type = string.Empty;//检查类别
            string FileName = string.Empty;//文件名称
            //查看文件检查级别
            if (level.Contains("省级"))
            {
                Level = "省级检查情况报告";
            }
            //路径文件夹是国土使用权还是集体所有权
            if (p.Contains("国有"))
            {
                Type = "GTSYQ";
            }
            try
            {
                //查看其行政区划编码
                Quhua = p.Substring(p.IndexOf("(") + 1);
                Quhua = Quhua.Substring(0, Quhua.IndexOf(")"));
            }
            catch (Exception)
            {
                string tName = p.Substring(p.IndexOf(@"\") + 1);
                if(!p.Contains("("))
                    ComMsg.ResultShow.Add(new ResultEntity(tName, "数据完整性", "900000001", "成果完整性符合标准",
                        "目录结构或者文件不符合标准; 成果目录名缺少[(]字符", "", "重缺陷", DateTime.Now.ToShortDateString()));
                if(!p.Contains(")"))
                    ComMsg.ResultShow.Add(new ResultEntity(tName, "数据完整性", "900000001", "成果完整性符合标准",
                        "目录结构或者文件不符合标准; 成果目录名缺少成果目录名缺少[)]字符", "", "重缺陷", DateTime.Now.ToShortDateString()));
                if (!p.Contains("土地登记成果"))
                    ComMsg.ResultShow.Add(new ResultEntity(tName, "数据完整性", "900000001", "成果完整性符合标准",
                        "目录结构或者文件不符合标准; 成果目录名不包含[土地登记成果]字符", "", "重缺陷", DateTime.Now.ToShortDateString()));
            }
            FileName = Type + Quhua + Level;//文件名称
            string path = p + @"\" + FileName + ".xlsx";//生成后的完整目录
            //检查文件是否存在，如果存在删除原有文件
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            //模板文件位置
            string TemplateFile = System.Windows.Forms.Application.StartupPath + @"\" + "检查结果记录表.xlsx";
            object file = path;
            try
            {
                File.Copy(TemplateFile, path);
                ComMsg.xlsPath = path;//向xlsPath赋值，供其它方法写书据使用
            }
            catch (Exception)
            {
                return;
            }
           
        }

        /// <summary>
        /// 向doc文件写入数据
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool WrithDocFile(string path)
        {
            string Quhua = string.Empty;//区划编码
            string CheckType = string.Empty;//检查类型
            try
            {
                //查看其行政区划编码
                Quhua = path.Substring(path.IndexOf("(") + 1);
                Quhua = Quhua.Substring(0, Quhua.IndexOf(")"));
            }
            catch (Exception)
            {
                MessageBox.Show("不合法的文件夹格式");
                return false;
            }
            if (path.Contains("GTSYQ"))

                CheckType = "国有土地使用权";
            else if (path.Contains("JTSYQ"))
                CheckType = "集体土地使用权";
            else
                CheckType = "集体土地所有权";
            object file = path;
            //操作word文档
            MSWord.Application wordApp;
            MSWord.Document wordDoc;
            wordApp = new MSWord.ApplicationClass();
            Object nothing = Missing.Value;
            wordDoc = wordApp.Documents.Open(ref file, ref nothing, ref nothing, ref nothing);
            Bookmarks marks = wordDoc.Bookmarks;
            wordDoc.Bookmarks.get_Item("xzqdm").Range.Text = Quhua;//行政区代码
            string quHuaName = new QuHuaHelper().GetQuHuaName(Quhua);
            wordDoc.Bookmarks.get_Item("rootpath1").Range.Text = quHuaName;//行政区划名称
            wordDoc.Bookmarks.get_Item("startdate").Range.Text = DateTime.Now.ToShortDateString();

            var sjwzx = from p in ComMsg.ResultShow
                        where p.Gzlx.Equals("数据完整性")
                        select p;

            wordDoc.Bookmarks.get_Item("sjwzxzqx").Range.Text = (from p in sjwzx where p.Cwdj.Equals("重缺陷") select p).ToList().Count.ToString();//数据完整性_重缺陷
            wordDoc.Bookmarks.get_Item("sjwzxqqx").Range.Text = (from p in sjwzx where p.Cwdj.Equals("轻缺陷") select p).ToList().Count.ToString();//数据完整性_轻缺陷
            wordDoc.Bookmarks.get_Item("sjwzxtotal").Range.Text = sjwzx.ToList().Count.ToString();//数据完整性_错误合计

            var jgfhx = from p in ComMsg.ResultShow
                        where p.Gzlx.Equals("结构符合性")
                        select p;
            wordDoc.Bookmarks.get_Item("jgfhxzqx").Range.Text = (from p in jgfhx where p.Cwdj.Equals("重缺陷") select p).ToList().Count.ToString();//结构符合性_重缺陷
            wordDoc.Bookmarks.get_Item("jgfhxqqx").Range.Text = (from p in jgfhx where p.Cwdj.Equals("轻缺陷") select p).ToList().Count.ToString();//结构符合性_轻缺陷
            wordDoc.Bookmarks.get_Item("jgfhxtotal").Range.Text = jgfhx.ToList().Count.ToString();//结构符合性_错误合计

            var jczb= from p in ComMsg.ResultShow
                        where p.Gzlx.Equals("基础指标")
                        select p;
            wordDoc.Bookmarks.get_Item("jczbzqx").Range.Text = (from p in jczb where p.Cwdj.Equals("重缺陷") select p).ToList().Count.ToString();//基础指标_重缺陷
            wordDoc.Bookmarks.get_Item("jczbqqx").Range.Text = (from p in jczb where p.Cwdj.Equals("轻缺陷") select p).ToList().Count.ToString();//基础指标_轻缺陷
            wordDoc.Bookmarks.get_Item("jczbtotal").Range.Text = jczb.ToList().Count.ToString();//基础指标_错误合计

            wordDoc.Bookmarks.get_Item("ljglzqx").Range.Text = "0";//逻辑关联_重缺陷
            wordDoc.Bookmarks.get_Item("ljglqqx").Range.Text = "0";//逻辑关联_轻缺陷
            wordDoc.Bookmarks.get_Item("ljgltotal").Range.Text = "0";//逻辑关联_错误合计

            wordDoc.Bookmarks.get_Item("txjczqx").Range.Text = "0";//空间图形检查_重缺陷
            wordDoc.Bookmarks.get_Item("txjcqqx").Range.Text = "0";//空间图形检查_轻缺陷
            wordDoc.Bookmarks.get_Item("txjctotal").Range.Text = "0";//空间图形检查_错误合计

             var hzbg=from p in ComMsg.ResultShow
                        select p;
             wordDoc.Bookmarks.get_Item("hzbgjczqx").Range.Text = (from p in hzbg where p.Cwdj.Equals("重缺陷") select p).ToList().Count.ToString();//汇总表格检查_重缺陷
             wordDoc.Bookmarks.get_Item("hzbgjcqqx").Range.Text = (from p in hzbg where p.Cwdj.Equals("轻缺陷") select p).ToList().Count.ToString();//汇总表格检查_轻缺陷
            wordDoc.Bookmarks.get_Item("hzbgjctotal").Range.Text = hzbg.ToList().Count.ToString();//汇总表格检查_错误合计

            wordDoc.Bookmarks.get_Item("zqx1").Range.Text = (from p in hzbg where p.Cwdj.Equals("重缺陷") select p).ToList().Count.ToString();//总计_重缺陷
            wordDoc.Bookmarks.get_Item("qqx1").Range.Text = (from p in hzbg where p.Cwdj.Equals("轻缺陷") select p).ToList().Count.ToString();//总计_轻缺陷
            wordDoc.Bookmarks.get_Item("total1").Range.Text =hzbg.ToList().Count.ToString();//总计_错误合计

            wordDoc.Bookmarks.get_Item("zqx2").Range.Text = (from p in hzbg where p.Cwdj.Equals("重缺陷") select p).ToList().Count.ToString();//总计_重缺陷
            wordDoc.Bookmarks.get_Item("qqx2").Range.Text = (from p in hzbg where p.Cwdj.Equals("轻缺陷") select p).ToList().Count.ToString();//总计_轻缺陷
            wordDoc.Bookmarks.get_Item("total2").Range.Text = hzbg.ToList().Count.ToString();//总计_错误合计

            wordDoc.Bookmarks.get_Item("sxsjtotal").Range.Text = hzbg.ToList().Count.ToString();//属性数据总和
            wordDoc.Bookmarks.get_Item("slsjtotal").Range.Text = "0";//矢量数据总和

            wordDoc.Bookmarks.get_Item("checkresult").Range.Text = quHuaName + "(" + Quhua + ")" + CheckType + "土地登记成果检查" + ((from p in hzbg where p.Cwdj.Equals("轻缺陷") select p).ToList().Count > 0 ? "未通过" : "通过");
            wordDoc.Bookmarks.get_Item("rootpath2").Range.Text = quHuaName + "(" + Quhua + ")" + CheckType + "土地登记成果";
            wordDoc.Bookmarks.get_Item("rootpath3").Range.Text = quHuaName + "(" + Quhua + ")" + CheckType + "土地登记成果";

            object oMissing = System.Reflection.Missing.Value;
            wordDoc.SaveAs(ref file, ref oMissing, ref oMissing, ref oMissing,   
   ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,  
   ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,  
   ref oMissing, ref oMissing); 
            wordDoc.Close(ref nothing, ref nothing, ref nothing);
            wordApp.Quit(ref nothing, ref nothing, ref nothing);
            return true;
        }

    }
}