using DataQuality.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataQuality.DLL
{

    class ZiDianService
    {
        /// <summary>
        /// 查询字典集合
        /// </summary>
        /// <returns>字典集合</returns>
        public List<ZiDianEntity> GetZiDianList()
        {
            List<ZiDianEntity> zdList = new List<ZiDianEntity>();
            AccessHelper ah = new AccessHelper();
            DataTable dt = ah.SelectToDataTable("select * from ZiDian");
            if(dt.Rows.Count!=0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    ZiDianEntity zd = new ZiDianEntity();
                    zd.Lxbm = dt.Rows[i]["类型编码"].ToString();
                    zd.Lxmc = dt.Rows[i]["类型名称"].ToString();
                    zd.Zddm = dt.Rows[i]["字典代码"].ToString();
                    zd.Zdmc = dt.Rows[i]["字典名称"].ToString();
                    zdList.Add(zd);
                }
            }
            return zdList;
        }
        /// <summary>
        /// 返回字典编码集合
        /// </summary>
        /// <param name="LXBM">类型编码</param>
        /// <returns></returns>
        public List<string> GetZiDianCodeByLXBM(string LXBM)
        {
            List<string> returnList = new List<string>();
            AccessHelper ah = new AccessHelper();
            DataTable dt = ah.SelectToDataTable("select * from ZiDian where 类型编码='" + LXBM + "'");
            if(dt.Rows.Count!=0)
            {
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    returnList.Add(dt.Rows[i]["字典代码"].ToString());
                }
            }
            return returnList;
        }
        /// <summary>
        /// 返回字典名称集合
        /// </summary>
        /// <param name="LXBM">类型名称</param>
        /// <returns></returns>
        public List<string> GetZiDianNameByLXBM(string LXBM)
        {
            List<string> returnList = new List<string>();
            AccessHelper ah = new AccessHelper();
            DataTable dt = ah.SelectToDataTable("select * from ZiDian where 类型编码='" + LXBM + "'");
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    returnList.Add(dt.Rows[i]["字典名称"].ToString());
                }
            }
            return returnList;
        }
        /// <summary>
        /// 根据字典类型编码获取字典名称
        /// </summary>
        /// <param name="code">字典类型编码</param>
        /// <returns>字典名称</returns>
        public string GetZiDianName(string code)
        {
            if (ComMsg.ziDian.ContainsKey(code))
            {
                return ComMsg.ziDian[code];
            }
            else
            {
                AccessHelper ah = new AccessHelper();
                DataTable dt = ah.SelectToDataTable("select 类型名称 from ZiDian where 类型编码='" + code + "'");
                ah.Close();
                if (dt != null && dt.Rows.Count > 0)
                {
                    ComMsg.ziDian.Add(code, dt.Rows[0]["类型名称"].ToString());
                    return dt.Rows[0]["类型名称"].ToString();
                }
            }
            return "";
        }
    }
}
