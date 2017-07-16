using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SqlDemo0711
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlconnect = new SqlConnection();
            try
            {
                Console.WriteLine("请输入用户名:");
                string admin = Console.ReadLine();
                Console.WriteLine("请输入密码:");
                string password = Console.ReadLine();

                string constr = "data source = .;database = Myschool;user id = sa;pwd = 1";
                sqlconnect = new SqlConnection(constr);
                string sqlcmd = string.Format("select count(*) from admin where admin = '{0}' and password = '{1}'", admin, password);
                sqlconnect.Open();
                SqlCommand cmd = new SqlCommand(sqlcmd, sqlconnect);

                //SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd, sqlconnect);
                //DataSet ds = new DataSet();
                //adapter.Fill(ds, "xxx");

                int num = Convert.ToInt32(cmd.ExecuteScalar());
                if (num == 1)
                {
                    Console.WriteLine("登陆成功!");
                    loadmenu();
                }
                else
                {
                    Console.WriteLine("登陆失败!请检查用户名和密码！");
                }

                while (true)
                {
                    switch (scan_key())
                    {
                        case 1:
                            {
                                sqlcmd = string.Format("select count(*) from student");
                                cmd = new SqlCommand(sqlcmd, sqlconnect);
                                Console.WriteLine(Convert.ToInt32(cmd.ExecuteScalar()));
                            }
                            break;
                        case 2:
                            {
                                sqlcmd = string.Format("select studentno,studentname from student");
                                cmd = new SqlCommand(sqlcmd,sqlconnect);
                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        Console.WriteLine("{0}\t{1}",reader["studentno"].ToString(),reader["studentname"].ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("没有学生信息!");
                                }
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("请输入查找学号:");
                                string stunum = Console.ReadLine();
                                sqlcmd = string.Format("select studentname from student where studentno = '{0}'",stunum);
                                cmd = new SqlCommand(sqlcmd, sqlconnect);
                                string name = Convert.ToString(cmd.ExecuteScalar());
                                if (name == "")
                                {
                                    Console.WriteLine("学号不存在");
                                    Console.WriteLine();
                                    break;
                                }
                                Console.WriteLine(name);
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("输入学生姓名:");
                                string name = Console.ReadLine();
                                sqlcmd = string.Format("select student.studentname,student.gender,class.classname,student.borndate from student,class where studentname = '{0}' and class.class = student.class",name);
                                cmd = new SqlCommand(sqlcmd,sqlconnect);
                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        Console.WriteLine("{0}\t{1}\t{2}\t{3}",reader["studentname"],reader["gender"],reader["classname"],reader["borndate"]);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("学生信息不存在!");
                                }
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("输入需要修改出生日期的学生姓名:");
                                string name = Console.ReadLine();
                                Console.WriteLine("输入出生日期:");
                                DateTime date = Convert.ToDateTime(Console.ReadLine());
                                sqlcmd = string.Format("update student set borndate = '{0}' where studentname = '{1}'", date,name);
                                cmd = new SqlCommand(sqlcmd, sqlconnect);
                                int a = cmd.ExecuteNonQuery();
                                if (a > 0)
                                {
                                    Console.WriteLine("更新成功!");
                                }
                                else
                                {
                                    Console.WriteLine("没有此学生信息！");
                                }
                            }
                            break;
                        case 6:
                            {
                                Console.WriteLine("输入需要删除记录的学生姓名:");
                                string name = Console.ReadLine();
                                sqlcmd = string.Format("delete student where studentname = '{0}'", name);
                                cmd = new SqlCommand(sqlcmd, sqlconnect);
                                int b = cmd.ExecuteNonQuery();
                                if (b > 0)
                                {
                                    Console.WriteLine("删除成功");
                                }
                                else
                                {
                                    Console.WriteLine("没有学生记录！");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("请输入正确数字");
                            break;
                    }
                    loadmenu();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlconnect.Close();
            }

            Console.ReadLine();
        }

        private static int scan_key()
        {
            int key = Convert.ToInt32(Console.ReadLine());
            return key;
        }

        private static void loadmenu()
        {
            Console.WriteLine("=========请选择操作键==========");
            Console.WriteLine("1.统计学生人数");
            Console.WriteLine("2.查看学生名单");
            Console.WriteLine("3.按学号查询学生姓名");
            Console.WriteLine("4.按姓名查询学生信息");
            Console.WriteLine("5.修改学生出生日期");
            Console.WriteLine("6.删除学生记录");
            Console.WriteLine("7.新增年纪信息");
            Console.WriteLine("0.退出");
            Console.WriteLine("===============================");
        }
    }
}
