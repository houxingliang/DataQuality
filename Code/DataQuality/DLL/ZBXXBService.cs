using DataQuality.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataQuality.DLL
{
    class ZBXXBService
    {
       /// <summary>
       /// 查询所有的需要质检的表数据
       /// </summary>
       /// <param name="path">路径</param>
       /// <returns></returns>
        public List<ZBXXBEntity> GetZBXXBList(string path)
        {
            AccessHelper ah = new AccessHelper();
            DataTable dt = ah.SelectToDataTable(" select * from ZBXXB", path);
            if(dt.Rows.Count>0)
            {
                List<ZBXXBEntity> zbxxbList = new List<ZBXXBEntity>();
                foreach( DataRow row in dt.Rows)
                {
                    ZBXXBEntity zbxxb = new ZBXXBEntity();
                    zbxxb.BJS_JSSJ = row["BJS_JSSJ"].ToString();
                    zbxxb.BJS_KSSJ = row["BJS_KSSJ"].ToString();
                    zbxxb.CFFY = row["CFFY"].ToString();
                    zbxxb.CFRQ = row["CFRQ"].ToString();
                    zbxxb.CFSXH = row["CFSXH"].ToString();
                    zbxxb.CFWH = row["CFWH"].ToString();
                    zbxxb.CFZT = row["CFZT"].ToString();
                    zbxxb.CFZZRQ = row["CFZZRQ"].ToString();
                    zbxxb.CSR_SGZH = row["CSR_SGZH"].ToString();
                    zbxxb.DJLX = row["DJLX"].ToString();
                    zbxxb.DJRQ = row["DJRQ"].ToString();
                    zbxxb.DWXZ = row["DWXZ"].ToString();
                    zbxxb.DYJE = row["DYJE"].ToString();
                    zbxxb.DYMJ = row["DYMJ"].ToString();
                    zbxxb.DYQDJ = row["DYQDJ"].ToString();
                    zbxxb.DYR=row["DYR"].ToString();
                    zbxxb.DYRLX=row["DYRLX"].ToString();
                    zbxxb.DYRQ = row["DYRQ"].ToString();
                    zbxxb.DYRZJLX = row["DYRZJLX"].ToString();
                    zbxxb.DYSXH = row["DYSXH"].ToString();
                    zbxxb.DYTDJG = row["DYTDJG"].ToString();
                    zbxxb.DYZT = row["DYZT"].ToString();
                    zbxxb.DYZZRQ = row["DYZZRQ"].ToString();
                    zbxxb.FTMJ = row["FTMJ"].ToString();
                    zbxxb.FZJG = row["FZJG"].ToString();
                    zbxxb.GDHTH = row["GDHTH"].ToString();
                    zbxxb.GDJGH = row["GDJGH"].ToString();
                    zbxxb.GG_JSSJ = row["GG_JSSJ"].ToString();
                    zbxxb.GLQLR = row["GLQLR"].ToString();
                    zbxxb.GLTDQLZSH = row["GLTDQLZSH"].ToString();
                    zbxxb.GLTDTXQLZMSH = row["GLTDTXQLZMSH"].ToString();
                    zbxxb.GLZDBH = row["GLZDBH"].ToString();
                    zbxxb.GYR = row["GYR"].ToString();
                    zbxxb.HBLX = row["HBLX"].ToString();
                    zbxxb.HYDM = row["HYDM"].ToString();
                    zbxxb.JBR_SGZH = row["JBR_SGZH"].ToString();
                    zbxxb.JFRQ = row["JFRQ"].ToString();
                    zbxxb.JZMD = row["JZMD"].ToString();
                    zbxxb.JZRJL = row["JZRJL"].ToString();
                    zbxxb.JZWMJ = row["JZWMJ"].ToString();
                    zbxxb.LCHS = row["LCHS"].ToString();
                    zbxxb.PHID = row["PHID"].ToString();
                    zbxxb.PZJG = row["PZJG"].ToString();
                    zbxxb.PZYT = row["PZYT"].ToString();
                    zbxxb.PZYTBM = row["PZYTBM"].ToString();
                    zbxxb.QDJG = row["QDJG"].ToString();
                    zbxxb.QLR = row["QLR"].ToString();
                    zbxxb.QSXZ = row["QSXZ"].ToString();
                    zbxxb.SFJNQK = row["SFJNQK"].ToString();
                    zbxxb.SFSJXZ = row["SFSJXZ"].ToString();
                    zbxxb.SFZZYDFGDJ = row["SFZZYDFGDJ"].ToString();
                    zbxxb.SHR_SGZH = row["SHR_SGZH"].ToString();
                    zbxxb.SHRMC = row["SHRMC"].ToString();
                    zbxxb.SJXZSM = row["SJXZSM"].ToString();
                    zbxxb.SYQLX = row["SYQLX"].ToString();
                    zbxxb.SYQMJ = row["SYQMJ"].ToString();
                    zbxxb.SYQX = row["SYQX"].ToString();
                    zbxxb.TDDYMJ = row["TDDYMJ"].ToString();
                    zbxxb.TFBH = row["TFBH"].ToString();
                    zbxxb.TXZSBH = row["TXZSBH"].ToString();
                    zbxxb.XYR = row["XYR"].ToString();
                    zbxxb.XZQBM = row["YGDJ"].ToString();
                    zbxxb.YGDJ = row["YGDJ"].ToString();
                    zbxxb.YGR = row["YGR"].ToString();
                    zbxxb.YTDQLRBSM = row["YTDQLRBSM"].ToString();
                    zbxxb.YYDJ = row["YYDJ"].ToString();
                    zbxxb.YYR = row["YYR"].ToString();
                    zbxxb.YZDBSM = row["YZDBSM"].ToString();
                    zbxxb.ZDBH = row["ZDBH"].ToString();
                    zbxxb.ZDLX = row["ZDLX"].ToString();
                    zbxxb.ZDMJ = row["ZDMJ"].ToString();
                    zbxxb.ZDTYBM = row["ZDTYBM"].ToString();
                    zbxxb.ZDZL = row["ZDZL"].ToString();
                    zbxxb.ZDZT = row["ZDZT"].ToString();
                    zbxxb.ZJBH = row["ZJBH"].ToString();
                    zbxxb.ZJLX = row["ZJLX"].ToString();
                    zbxxb.ZSBH = row["ZSBH"].ToString();
                    zbxxb.ZZRQ = row["ZZRQ"].ToString();
                    zbxxbList.Add(zbxxb);
                }
                return zbxxbList;
            }
            return null;
        }
    }
}
