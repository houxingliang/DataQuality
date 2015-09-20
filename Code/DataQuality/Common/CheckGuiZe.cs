using DataQuality.DLL;
using DataQuality.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace DataQuality.Common
{
    /// <summary>
    /// 检查规则
    /// </summary>
    class CheckGuiZe
    {
        /// <summary>
        /// 检查规则
        /// </summary>
        /// <param name="crl">选定文件夹中的所有文件</param>
        public void CheckSempleGuiZe(string path,MainCrl crl)
        {
            crl.rtbLog.Text += "\n " + DateTime.Now.ToLongTimeString() + "开始检查质检规则";
            List<FileInfo> infoList= ComMsg.infoList;
            List<string> files = new List<string>();//去除所有父级目录后的文件信息
            string tName = path.Substring(path.IndexOf(@"\") + 1);//成果名称
            tName = tName.Substring(tName.LastIndexOf(@"\") + 1);
            //读取了目标文件夹下所有的文件信息，将这些文件和数据库的信息进行成果比对
            for (int i = 0; i < infoList.Count(); i++)
            {
                //去除选定目录的所有父级目录，只保留选定文件夹所包含的文件夹路径
                files.Add(infoList[i].FullName);
            }
            List<string> accessFiles = new List<string>();
            //获取所有的access文件
            foreach (string file in files)
            {
                if (file.Contains("mdb") || file.Contains("accdb"))
                {
                    accessFiles.Add(file);
                }
            }
            AccessHelper ah = new AccessHelper();
            Dictionary<string, string> tables = new Dictionary<string, string>();
            List<string> columns = new List<string>();
            //检查access文件中是否有表名
            foreach (string p in accessFiles)
            {
                string[] tableNames = ah.GetShemaTableName(p, "");
                if (tableNames.Count() > 0)
                {
                    for (int i = 0; i < tableNames.Count(); i++)
                    {
                        tables.Add(tableNames[i], p);
                        columns.AddRange(ah.GetTableColumn(p, tableNames[i]));
                    }
                }
            }

            if (tables.Count >= 0)
            {
                AccessHelper accessHelper = new AccessHelper();

                foreach(KeyValuePair<string,string> table in tables)
                {
                    string sql = "select * from " + table.Key;
                    //字段值大于等于某一值
                    ZDZDYDYMZ(sql, table, crl,tName);
                    //检查字段值是否在字典表中
                    CheckZidianCode(sql, table, crl, tName);
                    //检查字典名称是否在字典表中
                    CheckZiDianName(sql, table, crl, tName);

                    //逻辑检查
                    CheckLuoJi(sql, table, crl, tName);
                }
            }
            crl.rtbLog.Text += "\n " + DateTime.Now.ToLongTimeString() + "质检规则检查完毕";
        }
        /// <summary>
        /// 字段值大于等于某一值
        /// </summary>
        /// <param name="sql">检查的sql语句</param>
        /// <param name="table">检查的数据表</param>
        /// <param name="crl">主页面需要显示的窗体</param>
        public void ZDZDYDYMZ(string sql,KeyValuePair<string,string> table,MainCrl crl,string tName)
        {
            AccessHelper accessHelper = new AccessHelper();
            AccessHelper ah = new AccessHelper();
            DataTable checkTable = ah.SelectToDataTable(sql, table.Value); //待检查数据
            //字段值大于等于某一字段值
            DataTable dt = accessHelper.SelectToDataTable("select * from GuiZe where 规则类型='基础指标' and 校验类型='SQL'");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["表名"].Equals(table.Key))
                    {
                        string checkSql = "select * from " + table.Key + " where " + dt.Rows[i]["表达式"];
                        DataTable resultTable = ah.SelectToDataTable(checkSql, table.Value);

                        //获取两个数据源的差集
                        IEnumerable<DataRow> query2 = checkTable.AsEnumerable().Except(resultTable.AsEnumerable(), DataRowComparer.Default);
                        //两个数据源的差集集合
                        if (query2 != null && query2.Count() > 0)
                        {
                            DataTable dt3 = query2.CopyToDataTable();
                            if (dt3.Rows.Count > 0)
                            {
                                for (int j = 0; j < checkTable.Rows.Count; j++)
                                {
                                    for (int k = 0; k < dt3.Rows.Count;k++ )
                                    {
                                        if (dt3.Rows[k]["ZDTYBM"].Equals(checkTable.Rows[j]["ZDTYBM"]))
                                        {
                                            ComMsg.ResultShow.Add(new ResultEntity(tName, dt.Rows[i]["规则类型"].ToString(), dt.Rows[i]["规则编号"].ToString(), dt.Rows[i]["规则名称"].ToString(),
                            dt.Rows[i]["字段名"]+dt.Rows[i]["错误描述"].ToString(), (j + 1) + "", dt.Rows[i]["严重程度"].ToString(), DateTime.Now.ToShortDateString()));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 检查数据是否在字典表中
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="table"></param>
        /// <param name="crl"></param>
        /// <param name="tName"></param>
        public void CheckZidianCode(string sql,KeyValuePair<string,string> table,MainCrl crl,string tName)
        {
            AccessHelper accessHelper = new AccessHelper();
            AccessHelper ah = new AccessHelper();
            //字段值大于等于某一字段值
            DataTable dt = accessHelper.SelectToDataTable("select * from GuiZe where 规则类型='基础指标' and 校验类型='DICTCODE'");
            if (dt.Rows.Count > 0)
            {
                ZiDianService zdService = new ZiDianService();
                List<ZiDianEntity> zdList = zdService.GetZiDianList();//规则集合
                if(table.Key.Equals("ZBXXB"))
                {
                    string path = table.Value;
                    ZBXXBService zbxxbService = new ZBXXBService();
                    List < ZBXXBEntity > zbxxbList = zbxxbService.GetZBXXBList(path);//待检查数据集合
                    DataTable zbxxbTable=ah.SelectToDataTable("select * from ZBXXB",path);//待检查数据table
                    DataTable zdTable=accessHelper.SelectToDataTable("select * from ZiDian");//字典表
                    for (int i = 0; i < dt.Rows.Count; i++)//需要检查字典的数据条数
                    {
                        List<string> codeList =zdService.GetZiDianCodeByLXBM(dt.Rows[i]["字段名"].ToString());
                        string checkSql="select * from ZBXXB where "+dt.Rows[i]["字段名"]+" not in (";
                        for(int j=0;j<codeList.Count;j++)
                        {
                            if (codeList.Count == 1)
                                checkSql += "'"+codeList[j]+"'" + ")";
                            else if (j != (codeList.Count-1))
                                checkSql += "'" + codeList[j] + "'" + ",";
                            else
                                checkSql += "'" + codeList[j] + "'" + ")";
                        }
                        DataTable resultTable = ah.SelectToDataTable(checkSql, path);
                        if (resultTable != null)
                        {
                            for (int j = 0; j < resultTable.Rows.Count; j++)
                            {
                                ComMsg.ResultShow.Add(new ResultEntity(tName, "基础指标", "130000001", "字段值在字典值域内", dt.Rows[i]["字段名"].ToString() + "字段值不在" + zdService.GetZiDianName(dt.Rows[i]["字段名"].ToString()) + "字典值域内,字段值为："+resultTable.Rows[j][dt.Rows[i]["字段名"].ToString()], j + "", dt.Rows[i]["严重程度"].ToString(), DateTime.Now.ToShortDateString()));
                            }
                        }

                    }
                }
                
            }
        }
        /// <summary>
        /// 检查数据是否在字典表中的字典名称值域内
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="table"></param>
        /// <param name="crl"></param>
        /// <param name="tName"></param>
        public void CheckZiDianName(string sql, KeyValuePair<string, string> table, MainCrl crl, string tName)
        {
            AccessHelper accessHelper = new AccessHelper();
            AccessHelper ah = new AccessHelper();
            //字段值大于等于某一字段值
            DataTable dt = accessHelper.SelectToDataTable("select * from GuiZe where 规则类型='基础指标' and 校验类型='DICTName'");
            if (dt.Rows.Count > 0)
            {
                ZiDianService zdService = new ZiDianService();
                List<ZiDianEntity> zdList = zdService.GetZiDianList();//规则集合
                if (table.Key.Equals("ZBXXB"))
                {
                    string path = table.Value;
                    ZBXXBService zbxxbService = new ZBXXBService();
                    List<ZBXXBEntity> zbxxbList = zbxxbService.GetZBXXBList(path);//待检查数据集合
                    DataTable zbxxbTable = ah.SelectToDataTable("select * from ZBXXB", path);//待检查数据table
                    DataTable zdTable = accessHelper.SelectToDataTable("select * from ZiDian");//字典表
                    for (int i = 0; i < dt.Rows.Count; i++)//需要检查字典的数据条数
                    {
                        List<string> codeList = zdService.GetZiDianCodeByLXBM(dt.Rows[i]["字段名"].ToString());
                        string checkSql = "select * from ZBXXB where " + dt.Rows[i]["字段名"] + " not in (";
                        for (int j = 0; j < codeList.Count; j++)
                        {
                            if (codeList.Count == 1)
                                checkSql += "'" + codeList[j] + "'" + ")";
                            else if (j != (codeList.Count - 1))
                                checkSql += "'" + codeList[j] + "'" + ",";
                            else
                                checkSql += "'" + codeList[j] + "'" + ")";
                        }
                        DataTable resultTable = ah.SelectToDataTable(checkSql, path);
                        if (resultTable != null)
                        {
                            for (int j = 0; j < resultTable.Rows.Count; j++)
                            {
                                ComMsg.ResultShow.Add(new ResultEntity(tName, "基础指标", "130000001", "字段值在字典值域内", dt.Rows[i]["字段名"].ToString() + "字段值不在" + zdService.GetZiDianName(dt.Rows[i]["字段名"].ToString()) + "字典值域内,字段值为：" + resultTable.Rows[j][dt.Rows[i]["字段名"].ToString()], j + "", dt.Rows[i]["严重程度"].ToString(), DateTime.Now.ToShortDateString()));
                            }
                        }

                    }
                }

            }
        }

        /// <summary>
        /// 检查指定表的逻辑关联性
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="table"></param>
        /// <param name="crl"></param>
        /// <param name="tName"></param>
        public void CheckLuoJi(string sql, KeyValuePair<string, string> table, MainCrl crl, string tName)
        {
            AccessHelper accessHelper = new AccessHelper();
            AccessHelper ah = new AccessHelper();
            //字段值大于等于某一字段值
            DataTable dt = accessHelper.SelectToDataTable("select * from GuiZe where 规则类型='逻辑关联性'");
            if (dt.Rows.Count > 0)
            {
                if (table.Key.Equals("ZBXXB"))
                {
                    string path = table.Value;
                    DataTable dataTable = ah.SelectToDataTable("select * from ZBXXB", path);
                    for(int i=0;i<dt.Rows.Count;i++)
                    {
                        DataTable ResultTable = ah.SelectToDataTable(dt.Rows[i]["表达式"].ToString(), path);
                        if(ResultTable.Rows.Count>0)
                        {
                            for (int j = 0; j < ResultTable.Rows.Count;j++ )
                            {
                                for (int k = 0; k < dataTable.Rows.Count;k++ )
                                {
                                    if (ResultTable.Rows[j]["ZDTYBM"].Equals(dataTable.Rows[k]["ZDTYBM"]))
                                    {
                                        ComMsg.ResultShow.Add(new ResultEntity(tName, dt.Rows[i]["规则类型"].ToString(), dt.Rows[i]["规则编号"].ToString(), dt.Rows[i]["规则名称"].ToString(),
                        dt.Rows[i]["字段名"] + dt.Rows[i]["错误描述"].ToString(), (k + 1) + "", dt.Rows[i]["严重程度"].ToString(), DateTime.Now.ToShortDateString()));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #region 暂时废弃代码
        /// <summary>
        /// 字段值大于等于某一字段值
        /// </summary>
        /// <param name="sql">检查的sql语句</param>
        /// <param name="table">检查的数据表</param>
        /// <param name="crl">主页面需要显示的窗体</param>
        public void ZDZDYDYMYZDZ(string sql, KeyValuePair<string, string> table, MainCrl crl, string tName)
        {
            AccessHelper accessHelper = new AccessHelper();
            AccessHelper ah = new AccessHelper();
            DataTable checkTable = ah.SelectToDataTable(sql, table.Value); //待检查数据
            //字段值大于等于某一字段值
            DataTable dt = accessHelper.SelectToDataTable("select * from GuiZe where 规则名称='字段值大于等于某一字段值'");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["表名"].Equals(table.Key))
                    {
                        string checkSql = "select * from " + table.Key + " where " + dt.Rows[i]["表达式"];
                        DataTable resultTable = ah.SelectToDataTable(checkSql, table.Value);

                        //获取两个数据源的差集
                        IEnumerable<DataRow> query2 = checkTable.AsEnumerable().Except(resultTable.AsEnumerable(), DataRowComparer.Default);
                        //两个数据源的差集集合
                        if (query2 != null && query2.Count() > 0)
                        {
                            DataTable dt3 = query2.CopyToDataTable();
                            if (dt3.Rows.Count > 0)
                            {
                                for (int j = 0; j < checkTable.Rows.Count; j++)
                                {
                                    for (int k = 0; k < dt3.Rows.Count; k++)
                                    {
                                        if (dt3.Rows[k]["ZDTYBM"].Equals(checkTable.Rows[j]["ZDTYBM"]))
                                        {
                                            ComMsg.ResultShow.Add(new ResultEntity(tName, dt.Rows[i]["规则类型"].ToString(), dt.Rows[i]["规则编号"].ToString(), dt.Rows[i]["规则名称"].ToString(),
                                dt.Rows[i]["字段名"] + dt.Rows[i]["错误描述"].ToString(), (j + 1) + "", dt.Rows[i]["严重程度"].ToString(), DateTime.Now.ToShortDateString()));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 字段值不能为空
        /// </summary>
        /// <param name="sql">检查的sql语句</param>
        /// <param name="table">检查的数据表</param>
        /// <param name="crl">主页面需要显示的窗体</param>
        /// <param name="tName">成果名称</param>
        public void ZDZBNWK(string sql, KeyValuePair<string, string> table, MainCrl crl, string tName)
        {
            AccessHelper accessHelper = new AccessHelper();
            AccessHelper ah = new AccessHelper();
            DataTable checkTable = ah.SelectToDataTable(sql, table.Value); //待检查数据
            //字段值大于等于某一字段值
            DataTable dt = accessHelper.SelectToDataTable("select * from GuiZe where 规则名称='字段值不能为空'");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["表名"].Equals(table.Key))
                    {
                        string checkSql = "select * from " + table.Key + " where " + dt.Rows[i]["表达式"];
                        DataTable resultTable = ah.SelectToDataTable(checkSql, table.Value);

                        //获取两个数据源的差集
                        IEnumerable<DataRow> query2 = checkTable.AsEnumerable().Except(resultTable.AsEnumerable(), DataRowComparer.Default);
                        //两个数据源的差集集合
                        if (query2 != null && query2.Count() > 0)
                        {
                            DataTable dt3 = query2.CopyToDataTable();
                            if (dt3.Rows.Count > 0)
                            {
                                for (int j = 0; j < checkTable.Rows.Count; j++)
                                {
                                    for (int k = 0; k < dt3.Rows.Count; k++)
                                    {
                                        if (dt3.Rows[k]["ZDTYBM"].Equals(checkTable.Rows[j]["ZDTYBM"]))
                                        {
                                            ComMsg.ResultShow.Add(new ResultEntity(tName, dt.Rows[i]["规则类型"].ToString(), dt.Rows[i]["规则编号"].ToString(), dt.Rows[i]["规则名称"].ToString(),
                                dt.Rows[i]["字段名"] + dt.Rows[i]["错误描述"].ToString(), (j + 1) + "", dt.Rows[i]["严重程度"].ToString(), DateTime.Now.ToShortDateString()));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 字段值必须为空
        /// </summary>
        /// <param name="sql">检查的sql语句</param>
        /// <param name="table">检查的数据表</param>
        /// <param name="crl">主页面需要显示的窗体</param>
        /// <param name="tName">成果名称</param>
        public void ZDZBXWK(string sql, KeyValuePair<string, string> table, MainCrl crl, string tName)
        {
            AccessHelper accessHelper = new AccessHelper();
            AccessHelper ah = new AccessHelper();
            DataTable checkTable = ah.SelectToDataTable(sql, table.Value); //待检查数据
            //字段值大于等于某一字段值
            DataTable dt = accessHelper.SelectToDataTable("select * from GuiZe where 规则名称='字段值必须为空'");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["表名"].Equals(table.Key))
                    {
                        string checkSql = "select * from " + table.Key + " where " + dt.Rows[i]["表达式"];
                        DataTable resultTable = ah.SelectToDataTable(checkSql, table.Value);

                        //获取两个数据源的差集
                        IEnumerable<DataRow> query2 = checkTable.AsEnumerable().Except(resultTable.AsEnumerable(), DataRowComparer.Default);
                        //两个数据源的差集集合
                        if (query2 != null && query2.Count() > 0)
                        {
                            DataTable dt3 = query2.CopyToDataTable();
                            if (dt3.Rows.Count > 0)
                            {
                                for (int j = 0; j < checkTable.Rows.Count; j++)
                                {
                                    for (int k = 0; k < dt3.Rows.Count; k++)
                                    {
                                        if (dt3.Rows[k]["ZDTYBM"].Equals(checkTable.Rows[j]["ZDTYBM"]))
                                        {
                                            ComMsg.ResultShow.Add(new ResultEntity(tName, dt.Rows[i]["规则类型"].ToString(), dt.Rows[i]["规则编号"].ToString(), dt.Rows[i]["规则名称"].ToString(),
                                dt.Rows[i]["字段名"] + dt.Rows[i]["错误描述"].ToString(), (j + 1) + "", dt.Rows[i]["严重程度"].ToString(), DateTime.Now.ToShortDateString()));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion
        
    }
}
