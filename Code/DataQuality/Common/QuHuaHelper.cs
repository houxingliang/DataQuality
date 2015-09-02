using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataQuality.Common
{
    /// <summary>
    /// 行政区划帮助类
    /// </summary>
    class QuHuaHelper
    {
        string fullName = string.Empty;
        /// <summary>
        /// 根据区划编码获取完整区划名称
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string GetQuHuaName(string code)
        {
            GetQuHua(code, "");
            return fullName;
        }
        /// <summary>
        /// 递归获取行政区划的完整级别
        /// </summary>
        /// <param name="code">行政区编码</param>
        /// <param name="result">完整行政区名称</param>
        /// <returns></returns>
        public void GetQuHua(string code,string result)
        {
            AccessHelper ah = new AccessHelper();
            string sql = "select * from QuHua where 行政区编码='"+code+"'";
            DataTable dt = ah.SelectToDataTable(sql);
            if(dt.Rows.Count>0)
            {
                fullName = (dt.Rows[0]["行政区名称"].ToString()+result);
                if(!dt.Rows[0]["父级编码"].ToString().Equals("0"))
                {
                    GetQuHua(dt.Rows[0]["父级编码"].ToString(), fullName);
                }
            }
        }
    }
}
