using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataQuality.Common
{
    /// <summary>
    /// 检查结果实体类
    /// </summary>
    public class ResultEntity
    {
        public ResultEntity()
        {
    
        }

        public ResultEntity(string cgmc,string gzlx,string gzbh,string gzmc,string cwms,string hh,string cwdj,string jcrq)
        {
            this.Cgmc = cgmc;
            this.Gzlx = gzlx;
            this.Gzbh = gzbh;
            this.Gzmc = gzmc;
            this.Cwms = cwms;
            this.Hh = hh;
            this.Cwdj = cwdj;
            this.Jcrq = jcrq;
        }
        string cgmc;

        public string Cgmc
        {
            get { return cgmc; }
            set { cgmc = value; }
        }
        string gzlx;

        public string Gzlx
        {
            get { return gzlx; }
            set { gzlx = value; }
        }
        string gzbh;

        public string Gzbh
        {
            get { return gzbh; }
            set { gzbh = value; }
        }
        string gzmc;

        public string Gzmc
        {
            get { return gzmc; }
            set { gzmc = value; }
        }
        string cwms;

        public string Cwms
        {
            get { return cwms; }
            set { cwms = value; }
        }
        string hh;

        public string Hh
        {
            get { return hh; }
            set { hh = value; }
        }
        string cwdj;

        public string Cwdj
        {
            get { return cwdj; }
            set { cwdj = value; }
        }
        string jcrq;

        public string Jcrq
        {
            get { return jcrq; }
            set { jcrq = value; }
        }
    }
}
