using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataQuality.Common
{
    /// <summary>
    /// 字典实体表
    /// </summary>
    class ZiDianEntity
    {
        private string lxbm = string.Empty;//字典类型编码

        public string Lxbm
        {
            get { return lxbm; }
            set { lxbm = value; }
        }

        private string lxmc = string.Empty;//类型名称

        public string Lxmc
        {
            get { return lxmc; }
            set { lxmc = value; }
        }

        private string zddm = string.Empty;//字典代码

        public string Zddm
        {
            get { return zddm; }
            set { zddm = value; }
        }

        private string zdmc = string.Empty;//字典名称

        public string Zdmc
        {
            get { return zdmc; }
            set { zdmc = value; }
        }


    }
}
