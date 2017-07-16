using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sqldemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string strconnect = "data source=.;database = Myschool;user id = sa;pwd = 1";
            SqlConnection sqlcon = new SqlConnection(strconnect);
            DataSet ds = new DataSet();
            string cmd = string.Format("select count(*) from student");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd,sqlcon);
            adapter.Fill(ds,"xxx");
            foreach (DataRow item in ds.Tables["xxx"].Rows)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
