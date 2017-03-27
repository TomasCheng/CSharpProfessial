using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010Excel操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "装备信息.xls";
            //HDR表示是否包含第一行
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1\"";

            //创建连接到数据源的对象
            OleDbConnection connection = new OleDbConnection(connectionString);

            //打开连接
            connection.Open();

            string sql = "select * from [Sheet1$]";

            //查询
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connection);

            //存放数据的容器,可以存放很多个datatable
            DataSet dataSet = new DataSet();

            //把查询的结果（datatable）放到容器中
            adapter.Fill(dataSet);

            connection.Close();

            //取数据
            DataTableCollection tableCollection = dataSet.Tables;
            DataTable table = tableCollection[0];

            //取得table所有行
            //注意，默认第一行是表头，所以，没有去第一行
            DataRowCollection rowCollection = table.Rows;

            foreach (DataRow row in rowCollection)
            {
                //取得row中前8列的数据，索引是 0-7
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(row[i]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
