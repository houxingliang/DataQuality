using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;
using System.Windows.Forms;

/// <summary>
///accessDB 的摘要说明
/// </summary>
public class AccessHelper
{

    //变量声明处#region 变量声明处
    public OleDbConnection Conn;
    public string ConnString;//连接字符串



    /// <summary>
    /// 构造函数
    /// </summary>
    public AccessHelper()
    {
        ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Setting.accdb";
        Conn = new OleDbConnection(ConnString);
        Conn.Open();
    }


    //构造函数与连接关闭数据库#region 构造函数与连接关闭数据库
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="Dbpath">ACCESS数据库路径-webconfig中自定义</param>
    public AccessHelper(string DBpath)
    {
        ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBpath;
        Conn = new OleDbConnection(ConnString);
        Conn.Open();
    }    



    /// <summary>
    /// 打开数据源链接
    /// </summary>
    /// <returns></returns>
    public OleDbConnection DbConn()
    {
        Conn.Open();
        return Conn;
    }

    /// <summary>
    /// 请在数据传递完毕后调用该函数，关闭数据链接。
    /// </summary>
    public void Close()
    {
        Conn.Close();
    }


    /// 数据库基本操作#region 数据库基本操作
    /// <summary>
    /// 根据SQL命令返回数据DataTable数据表,
    /// 可直接作为dataGridView的数据源
    /// </summary>
    /// <param name="SQL"></param>
    /// <returns></returns>
    public DataTable SelectToDataTable(string SQL)
    {
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbCommand command = new OleDbCommand(SQL, Conn);
        adapter.SelectCommand = command;
        DataTable Dt = new DataTable();
        adapter.Fill(Dt);
        return Dt;
    }

    public DataTable SelectToDataTable(string SQL,string PATH)
    {
        ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + PATH;
        Conn = new OleDbConnection(ConnString);
        Conn.Open();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbCommand command = new OleDbCommand(SQL, Conn);
        adapter.SelectCommand = command;
        DataTable Dt = new DataTable();
        adapter.Fill(Dt);
        Conn.Close();
        return Dt;
    }
    /// <summary>
    /// 根据SQL命令返回数据DataSet数据集，其中的表可直接作为dataGridView的数据源。
    /// </summary>
    /// <param name="SQL"></param>
    /// <param name="subtableName">在返回的数据集中所添加的表的名称</param>
    /// <returns></returns>
    public DataSet SelectToDataSet(string SQL, string subtableName)
    {
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbCommand command = new OleDbCommand(SQL, Conn);
        adapter.SelectCommand = command;
        DataSet Ds = new DataSet();
        Ds.Tables.Add(subtableName);
        adapter.Fill(Ds, subtableName);
        return Ds;
    }

    /// <summary>
    /// 在指定的数据集中添加带有指定名称的表，由于存在覆盖已有名称表的危险，返回操作之前的数据集。
    /// </summary>
    /// <param name="SQL"></param>
    /// <param name="subtableName">添加的表名</param>
    /// <param name="DataSetName">被添加的数据集名</param>
    /// <returns></returns>
    public DataSet SelectToDataSet(string SQL, string subtableName, DataSet DataSetName)
    {
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbCommand command = new OleDbCommand(SQL, Conn);
        adapter.SelectCommand = command;
        DataTable Dt = new DataTable();
        DataSet Ds = new DataSet();
        Ds = DataSetName;
        adapter.Fill(DataSetName, subtableName);
        return Ds;
    }


    /// <summary>
    /// 根据SQL命令返回OleDbDataAdapter，
    /// 使用前请在主程序中添加命名空间System.Data.OleDb
    /// </summary>
    /// <param name="SQL"></param>
    /// <returns></returns>
    public OleDbDataAdapter SelectToOleDbDataAdapter(string SQL)
    {
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbCommand command = new OleDbCommand(SQL, Conn);
        adapter.SelectCommand = command;
        return adapter;
    }

    /// <summary>
    /// 执行SQL命令，不需要返回数据的修改，删除可以使用本函数
    /// </summary>
    /// <param name="SQL"></param>
    /// <returns></returns>
    public bool ExecuteSQLNonquery(string SQL)
    {
        OleDbCommand cmd = new OleDbCommand(SQL, Conn);
        try
        {
            cmd.ExecuteNonQuery();
            return true;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// 执行SQL命令，数据是否存在，返回bool
    /// </summary>
    /// <param name="SQL"></param>
    /// <returns></returns>
    public bool Exists(string SQL)
    {
        OleDbCommand cmd = new OleDbCommand(SQL, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    /// <summary>
    /// 执行SQL命令，查询记录总数，返回int
    /// </summary>
    /// <param name="SQL"></param>
    /// <returns></returns>
    public int MaxCount(string SQL)
    {
        OleDbCommand cmd = new OleDbCommand(SQL, Conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count > 0)
        {
            return count;
        }
        else
        {
            return 0;
        }
    }

    /// <summary>
    /// 返回Mdb数据库中所有表表名
    /// </summary>
    public string[] GetShemaTableName(string database_path, string database_password)
    {
        try
        {
            //获取数据表
            Conn = new OleDbConnection();
            Conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + database_path;
            Conn.Open();
            DataTable shemaTable = Conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            int n = shemaTable.Rows.Count;
            string[] strTable = new string[n];
            int m = shemaTable.Columns.IndexOf("TABLE_NAME");
            for (int i = 0; i < n; i++)
            {
                DataRow m_DataRow = shemaTable.Rows[i];
                strTable[i] = m_DataRow.ItemArray.GetValue(m).ToString();
            }
            return strTable;
        }
        catch (OleDbException ex)
        {
            MessageBox.Show("指定的限制集无效:/n" + ex.Message);
            return null;
        }
        finally
        {
            Conn.Close();
            Conn.Dispose();
        }
    }

    /// <summary>
    /// 返回某一表的所有字段名
    /// </summary>
    public string[] GetTableColumn(string database_path, string varTableName)
    {
        DataTable dt = new DataTable();
        try
        {
            Conn = new OleDbConnection();
            Conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + database_path;
            Conn.Open();
            dt = Conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, varTableName, null });
            int n = dt.Rows.Count;
            string[] strTable = new string[n];
            int m = dt.Columns.IndexOf("COLUMN_NAME");
            for (int i = 0; i < n; i++)
            {
                DataRow m_DataRow = dt.Rows[i];
                strTable[i] = m_DataRow.ItemArray.GetValue(m).ToString();
                
            }
            return strTable;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Conn.Close();
        }
    }

    
}
