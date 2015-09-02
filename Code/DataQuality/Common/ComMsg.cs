using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataQuality.Common
{
    public static class ComMsg
    {
        /// <summary>
        /// 数据类型编码
        /// </summary>
        public static Dictionary<int, string> DataType = new Dictionary<int, string> {   
                                               { 130, "Char" },  
                                               { 5, "Double" },  
                                               { 2, "Int" },  
                                               { 7, "Date" }};
        /// <summary>
        /// 登记类型
        /// </summary>
        public static Dictionary<string, string> DJLX = new Dictionary<string, string>
        {
            {"A","总登记(A)"},
            {"B","初始登记(B)"},
            {"C","变更登记(C)"},
            {"D","注销登记(D)"},
            {"E","更正登记(E)"},
            {"F","遗失补证登记(F)"},
            {"G","抵押登记(G)"},
            {"H","抵押变更登记(H)"},
            {"I","抵押注销登记(I)"},
            {"J","查封登记(J)"},
            {"K","解封登记(K)"},
            {"L","预告登记(L)"},
            {"M","预告注销登记(M)"},
            {"N","异议登记(N)"},
            {"O","异议注销登记(O)"},
            {"P","地役登记(P)"},
            {"Q","地役变更登记(Q)"},
            {"R","地役注销登记(R)"}
        };
        /// <summary>
        /// 检查结果
        /// </summary>
        public static List<ResultEntity> ResultShow = new List<ResultEntity>();
        /// <summary>
        /// xls文件路径
        /// </summary>
        public static string xlsPath = string.Empty;
        /// <summary>
        /// doc文件路径
        /// </summary>
        public static string docPath = string.Empty;
    }
}
