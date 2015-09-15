using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DataQuality.Common
{
    /// <summary>
    /// 写入文件，将错误信息写入doc/excel/dataGridView中
    /// </summary>
    class WriteFile
    {
        /// <summary>
        /// 向DataGridView中写入检查出的错误数据
        /// </summary>
        /// <param name="resultList">错误数据列表</param>
        /// <param name="dgv">要写入的目标DataGridView</param>
        /// <returns>是否写入成功</returns>
        public bool WriteDataGridView(List<ResultEntity> resultList,DataGridView dgv)
        {
            //如果错误数据列表条目大于0，向dgv写入数据
            if(resultList.Count>0)
            {
                dgv.Rows.Add(resultList.Count);
                for(int i=0;i<resultList.Count;i++)
                {
                    ResultEntity re=resultList[i];
                    dgv.Rows[i].Cells["cmXH"].Value = (i+1).ToString();
                    dgv.Rows[i].Cells["cmCGMC"].Value=re.Cgmc;
                    dgv.Rows[i].Cells["cmGZLX"].Value = re.Gzlx;
                    dgv.Rows[i].Cells["cmGZBH"].Value = re.Gzbh;
                    dgv.Rows[i].Cells["cmGZMC"].Value = re.Gzmc;
                    dgv.Rows[i].Cells["cmCWMS"].Value = re.Cwms;
                    dgv.Rows[i].Cells["cmHH"].Value = re.Hh;
                    dgv.Rows[i].Cells["cmCWDJ"].Value = re.Cwdj;
                    dgv.Rows[i].Cells["cmJCRQ"].Value = re.Jcrq;
                }
            }
            return true;
        }
        /// <summary>
        /// 向word文档写入检查出的错误数据
        /// </summary>
        /// <param name="resultList">错误数据列表</param>
        /// <param name="path">要写入的目标doc文档路径</param>
        /// <returns></returns>
        public bool WriteDoc(List<ResultEntity> resultList,string path)
        {
            return false;
        }

        /// <summary>
        /// 向excel文档写入检查出的错误数据
        /// </summary>
        /// <param name="resultList">错误数据列表</param>
        /// <param name="path">要写入的目标excel文档路径</param>
        /// <returns></returns>
        public bool WriteXls(string path)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;//引用excel对象
            Microsoft.Office.Interop.Excel.Workbook workBook = null;//引用工作簿
            Microsoft.Office.Interop.Excel.Worksheet sheetMuLu = null;//引用工作表-目录完整性
            Microsoft.Office.Interop.Excel.Worksheet sheetZhiBiao = null;//应用工作表-结构符合性
            Microsoft.Office.Interop.Excel.Worksheet sheetJiChu = null;//引用工作表-基础指标
            try
            {
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                workBook = excelApp.Workbooks.Open(ComMsg.xlsPath, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value);
                //成果目录相关
                sheetMuLu = (Worksheet)workBook.Worksheets[1];
                var mulu = from p in ComMsg.ResultShow
                           where p.Gzlx.Equals("数据完整性")
                           select p;
                List<ResultEntity> muluList = mulu.ToList();
                for (int i = 0; i < muluList.Count; i++)
                {
                    sheetMuLu.Cells[1][i + 2] = (i + 1).ToString();//第一列，第(i+2)行
                    sheetMuLu.Cells[2][i + 2] = muluList[i].Cgmc;
                    sheetMuLu.Cells[3][i + 2] = muluList[i].Gzlx;
                    sheetMuLu.Cells[4][i + 2] = muluList[i].Gzbh;
                    sheetMuLu.Cells[5][i + 2] = muluList[i].Gzmc;
                    sheetMuLu.Cells[6][i + 2] = muluList[i].Cwms;
                    sheetMuLu.Cells[7][i + 2] = muluList[i].Hh;
                    sheetMuLu.Cells[8][i + 2] = muluList[i].Cwdj;
                    sheetMuLu.Cells[9][i + 2] = muluList[i].Jcrq;
                }
                //结构符合性
                sheetZhiBiao = (Worksheet)workBook.Worksheets[2];
                var zhibiao = from p in ComMsg.ResultShow
                              where p.Gzlx.Equals("结构符合性")
                              select p;
                List<ResultEntity> zhibiaoList = zhibiao.ToList();
                for (int i = 0; i < zhibiaoList.Count;i++ )
                {
                    sheetZhiBiao.Cells[1][i + 2] = (i + 1).ToString();//第一列，第(i+2)行
                    sheetZhiBiao.Cells[2][i + 2] = zhibiaoList[i].Cgmc;
                    sheetZhiBiao.Cells[3][i + 2] = zhibiaoList[i].Gzlx;
                    sheetZhiBiao.Cells[4][i + 2] = zhibiaoList[i].Gzbh;
                    sheetZhiBiao.Cells[5][i + 2] = zhibiaoList[i].Gzmc;
                    sheetZhiBiao.Cells[6][i + 2] = zhibiaoList[i].Cwms;
                    sheetZhiBiao.Cells[7][i + 2] = zhibiaoList[i].Hh;
                    sheetZhiBiao.Cells[8][i + 2] = zhibiaoList[i].Cwdj;
                    sheetZhiBiao.Cells[9][i + 2] = zhibiaoList[i].Jcrq;
                }

                //基础指标
                sheetJiChu = (Worksheet)workBook.Worksheets[3];
                var jichu = from p in ComMsg.ResultShow
                              where p.Gzlx.Equals("基础指标")
                              select p;
                List<ResultEntity> jichuList = jichu.ToList();
                for (int i = 0; i < jichuList.Count; i++)
                {
                    sheetJiChu.Cells[1][i + 2] = (i + 1).ToString();//第一列，第(i+2)行
                    sheetJiChu.Cells[2][i + 2] = jichuList[i].Cgmc;
                    sheetJiChu.Cells[3][i + 2] = jichuList[i].Gzlx;
                    sheetJiChu.Cells[4][i + 2] = jichuList[i].Gzbh;
                    sheetJiChu.Cells[5][i + 2] = jichuList[i].Gzmc;
                    sheetJiChu.Cells[6][i + 2] = jichuList[i].Cwms;
                    sheetJiChu.Cells[7][i + 2] = jichuList[i].Hh;
                    sheetJiChu.Cells[8][i + 2] = jichuList[i].Cwdj;
                    sheetJiChu.Cells[9][i + 2] = jichuList[i].Jcrq;
                }
                    /***************************此处预留其它检查类型******************************************/



                    /*********************************************************************/

                //汇总表格
                Microsoft.Office.Interop.Excel.Worksheet shetHuiZong = null;
                shetHuiZong = (Worksheet)workBook.Worksheets[6];
                var huizong = from p in ComMsg.ResultShow
                              select p;
                List<ResultEntity> huizongList = huizong.ToList();
                for (int i = 0; i < huizongList.Count; i++)
                {
                    shetHuiZong.Cells[1][i + 2] = (i + 1).ToString();//第一列，第(i+2)行
                    shetHuiZong.Cells[2][i + 2] = huizongList[i].Cgmc;
                    shetHuiZong.Cells[3][i + 2] = huizongList[i].Gzlx;
                    shetHuiZong.Cells[4][i + 2] = huizongList[i].Gzbh;
                    shetHuiZong.Cells[5][i + 2] = huizongList[i].Gzmc;
                    shetHuiZong.Cells[6][i + 2] = huizongList[i].Cwms;
                    shetHuiZong.Cells[7][i + 2] = huizongList[i].Hh;
                    shetHuiZong.Cells[8][i + 2] = huizongList[i].Cwdj;
                    shetHuiZong.Cells[9][i + 2] = huizongList[i].Jcrq;
                }
                //缺陷排行
                Microsoft.Office.Interop.Excel.Worksheet sheetPaiHang = null;
                sheetPaiHang = (Worksheet)workBook.Worksheets[7];
                var paihang = (from p in ComMsg.ResultShow
                              group p by p.Gzbh into g
                              select new { 
                                gzbh=g.Key,
                                cwms=g,
                                count=g.Count()
                              } into c
                              orderby c.count descending
                              select c).ToList();
               if(paihang.Count>0)
               {
                   for (int i = 0; i < paihang.Count; i++)
                   {
                       sheetPaiHang.Cells[1][i + 2] = (i + 1).ToString();//第一列，第(i+2)行
                       sheetPaiHang.Cells[2][i + 2] = paihang[i].cwms.First().Cwdj;
                       sheetPaiHang.Cells[3][i + 2] = paihang[i].gzbh;
                       sheetPaiHang.Cells[4][i + 2] = paihang[i].cwms.First().Cwms;
                       sheetPaiHang.Cells[5][i + 2] = paihang[i].count;
                   }
               }

                    //保存写入的数据
                workBook.SaveAs(ComMsg.xlsPath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                workBook.Close(false, Type.Missing, Type.Missing);
                excelApp.Quit();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }
    }
}
