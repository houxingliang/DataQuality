using DataQuality.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DataQuality
{
    public partial class ZBBPZFrm : Form
    {
        public int IntZhiBiaoId = 0;//从父窗体传递来的指标表数据ID
        public ZBBPZFrm()
        {
            InitializeComponent();
        }

        private void ZBBPZFrm_Load(object sender, EventArgs e)
        {
            //显示数据类型
            if (cbType.Items.Count != 0)
            {
                cbType.SelectedItem = cbType.Items[0];
                cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            if(IntZhiBiaoId>0)
            {
                AccessHelper ah = new AccessHelper();
                string sql="select * from ZhiBiao where ID="+IntZhiBiaoId+"";
                DataTable dt = ah.SelectToDataTable(sql);
                if (dt.Rows.Count>0)
                {
                    DataRow row = dt.Rows[0];
                    tbTableName.Text=row["表名"].ToString();
                    tbColName.Text=row["列名"].ToString();
                    tbColRemark.Text = row["列描述"].ToString();
                    cbType.Text = row["数据类型"].ToString();
                    cbType.DropDownStyle = ComboBoxStyle.DropDownList;
                    tbDataLen.Text = row["数据长度"].ToString();
                    tbDataProcision.Text = row["数据精度"].ToString();
                }
                //tbTableName=dt.Rows[0][""].ToString();
                
            }
        }
        /// <summary>
        /// 检查填入的数据是否符合标准
        /// </summary>
        private bool CheckMsg()
        {
            if(tbTableName.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写表名！");
                return false;
            }
            if(tbColName.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写列名！");
                return false;
            }
            if(tbColRemark.Text.Trim().Length==0)
            {
                MessageBox.Show("请填写列描述！");
                return false;
            }
            if (!Regex.Match(tbDataLen.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("请在数据长度位置输入数字！");
                return false;
            }
            if(Regex.Match(tbDataLen.Text, "^[0-9]*$").Success&&tbDataLen.Text.Trim().Length>=5)
            {
                MessageBox.Show("数据长度位置输入数字过大！");
                return false;
            }
            if (!Regex.Match(tbDataProcision.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("请在数据精度位置输入数字！");
                return false;
            }
            if (Regex.Match(tbDataProcision.Text, "^[0-9]*$").Success && tbDataLen.Text.Trim().Length >= 5)
            {
                MessageBox.Show("数据精度位置输入数字过大！");
                return false;
            }
            if(cbType.Text.Contains("选择"))
            {
                MessageBox.Show("请选择数据类型");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 根据数据类型找到数据类型编码
        /// </summary>
        private int GetDataType(string value)
        {
            foreach(var temp in ComMsg.DataType)
            {
                if(temp.Value==value)
                {
                    return temp.Key;
                }
            }
            return 0;
        }
        /// <summary>
        /// 新增/修改指标表配置项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckMsg())
            {
                AccessHelper ah = new AccessHelper();
                string sql = string.Empty;
                if (IntZhiBiaoId == 0)//新增
                {
                    if (!ExistZhiBiaoByTableAndRow(tbTableName.Text.Trim(),tbColName.Text.Trim()))
                    {
                        MessageBox.Show("存在相同表名和列名数据！");
                        return;
                    }
                    sql = "insert into ZhiBiao(表名,列名,列描述,数据类型编码,数据类型,数据长度,数据精度) values('" + tbTableName.Text.Trim() + "',";
                    sql += "'" + tbColName.Text.Trim() + "',";
                    sql += "'" + tbColRemark.Text.Trim() + "'," + GetDataType(cbType.Text) + ",'";
                    sql += "" + cbType.Text.Trim() + "',";
                    sql += "" + tbDataLen.Text.Trim() + ",";
                    sql += "" + tbDataProcision.Text.Trim() + ")";
                }
                else//修改
                {
                    sql = "update ZhiBiao set 表名='" + tbTableName.Text.Trim() + "',列名='";
                    sql += "" + tbColName.Text.Trim() + "'";
                    sql += ",列描述='" + tbColRemark.Text.Trim() + "'";
                    sql += ",数据类型编码=" + GetDataType(cbType.Text) + "";
                    sql += ",数据类型='" + cbType.Text.Trim() + "'";
                    sql += ",数据长度=" + tbDataLen.Text.Trim() + "";
                    sql += ",数据精度=" + tbDataProcision.Text.Trim() + " where ID=" + IntZhiBiaoId + "";
                }
                if (ah.ExecuteSQLNonquery(sql))
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("保存成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
                ah.Close();
            }
        }
        /// <summary>
        /// 根据表名和列名查询检查项是否存在
        /// </summary>
        /// <param name="table"></param>
        /// <param name="row"></param>
        /// <returns>true 不存在，false 存在相同数据</returns>
        public bool ExistZhiBiaoByTableAndRow(string table,string row)
        {
            string sql = "select * from ZhiBiao where 表名='"+table+"' and 列名='"+row+"'";
            AccessHelper ah = new AccessHelper();
            DataTable dataTable = ah.SelectToDataTable(sql);
            if (dataTable.Rows.Count > 0)
                return false;
            else
                return true;
        }
    }
}
