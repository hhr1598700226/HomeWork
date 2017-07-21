using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySchool.Model;
using System.Data;
using System.Configuration;

namespace MainForm.DAL
{

    public class MySchoolC
    {
        //public static readonly string strcon = "data source=.;database = myschool;user id = sa;pwd = 1";
        public static readonly string strcon = ConfigurationManager.ConnectionStrings["MyschoolConnect"].ToString();
        public static SqlDataReader ExecuteReader(string sqlcmd)
        {
            SqlConnection sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(sqlcmd,sqlcon);
            SqlDataReader Reader = cmd.ExecuteReader();
            return Reader;
        }
        public static int ExecuteScalar(string sqlcmd,SqlParameter[] param)
        {
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(sqlcmd, sqlcon);
                if (param != null)
                    cmd.Parameters.AddRange(param);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
        }
        public static int ExecuteNonQuery(string sqlcmd)
        {
            SqlConnection sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(sqlcmd,sqlcon);
            int result = cmd.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }
        public static Dictionary<int, string> GetGrade()
        {
            string sqlcmd = "select GradeId,GradeName from Grade";
            SqlDataReader Reader = MySchoolC.ExecuteReader(sqlcmd);
            Dictionary<int, string> dc = new Dictionary<int, string>();
            while (Reader.Read())
            {
                dc.Add(Convert.ToInt32(Reader["Gradeid"]),Reader["GradeName"].ToString());
            }
            Reader.Close();
            return dc;
        }
        public static List<Student> GetStudent()
        {
            string sqlcmd = @"select studentno,studentname,loginpwd,gender,gradeid,
                            email,[address],Phone,borndate,IdentityCard 
                            from student";
            SqlDataReader Reader = MySchoolC.ExecuteReader(sqlcmd);
            List<Student> DS = new List<Student>() { };
            while (Reader.Read())
            {
                Student xxs = new Student();
                xxs.StudentName = Reader["StudentName"].ToString();
                xxs.StudentNo = Convert.ToInt32(Reader["StudentNo"]);
                xxs.StudentPwd = Reader["LoginPwd"].ToString();
                xxs.Gender = Reader["Gender"].ToString();
                xxs.Grade = Reader["Gradeid"].ToString();
                xxs.Email = Reader["Email"].ToString();
                xxs.Address = Reader["Address"].ToString();
                xxs.Phone = Reader["Phone"].ToString();
                xxs.BornDate = Convert.ToDateTime(Reader["BornDate"]);
                xxs.IdCard = Reader["IdentityCard"].ToString();
                //Student xxs = new Student()
                //{
                //    StudentNo = Convert.ToInt32(Reader["StudentNo"]),
                //    StudentPwd = Reader["LoginPwd"].ToString(),
                //    StudentName = Reader["StudentName"].ToString(),
                //    Address = Reader["Address"].ToString(),
                //    BornDate = Convert.ToDateTime(Reader["BornDate"]),
                //    Email = Reader["Email"].ToString(),
                //    Gender = Reader["Gender"].ToString(),
                //    Grade = Reader["GradeId"].ToString(),
                //    IdCard = Reader["IdentityCard"].ToString(),
                //    Phone = Convert.ToInt32(Reader["Phone"])
                //};

                DS.Add(xxs);
            }
            Reader.Close();
            return DS;
        }
        public static List<Student> GetStudent(string str)
        {
            string sqlcmd = string.Format(@"select studentno,studentname,loginpwd,gender,gradeid,
                            email,[address],Phone,borndate,IdentityCard 
                            from student where gradeid = '{0}'",str);
            SqlDataReader Reader = MySchoolC.ExecuteReader(sqlcmd);
            List<Student> DS = new List<Student>() { };
            while (Reader.Read())
            {
                Student xxs = new Student();
                xxs.StudentName = Reader["StudentName"].ToString();
                xxs.StudentNo = Convert.ToInt32(Reader["StudentNo"]);
                xxs.StudentPwd = Reader["LoginPwd"].ToString();
                xxs.Gender = Reader["Gender"].ToString();
                xxs.Grade = Reader["Gradeid"].ToString();
                xxs.Email = Reader["Email"].ToString();
                xxs.Address = Reader["Address"].ToString();
                xxs.Phone = Reader["Phone"].ToString();
                xxs.BornDate = Convert.ToDateTime(Reader["BornDate"]);
                xxs.IdCard = Reader["IdentityCard"].ToString();

                DS.Add(xxs);
            }
            Reader.Close();
            return DS;
        }
        public static List<Student> GetStudent(string str,string name)
        {
            string sqlcmd = string.Format(@"select studentno,studentname,loginpwd,gender,gradeid,
                            email,[address],Phone,borndate,IdentityCard 
                            from student where gradeid = '{0}' and studentname like '%{1}%'", str,name);
            SqlDataReader Reader = MySchoolC.ExecuteReader(sqlcmd);
            List<Student> DS = new List<Student>() { };
            while (Reader.Read())
            {
                Student xxs = new Student();
                xxs.StudentName = Reader["StudentName"].ToString();
                xxs.StudentNo = Convert.ToInt32(Reader["StudentNo"]);
                xxs.StudentPwd = Reader["LoginPwd"].ToString();
                xxs.Gender = Reader["Gender"].ToString();
                xxs.Grade = Reader["Gradeid"].ToString();
                xxs.Email = Reader["Email"].ToString();
                xxs.Address = Reader["Address"].ToString();
                xxs.Phone = Reader["Phone"].ToString();
                xxs.BornDate = Convert.ToDateTime(Reader["BornDate"]);
                xxs.IdCard = Reader["IdentityCard"].ToString();

                DS.Add(xxs);
            }
            Reader.Close();
            return DS;
        }
        public static List<Subject> GetSubject(int GradeId)
        {
                List<Subject> Ls = new List<Subject>();
                string strcmd = string.Format("select SubjectName,SubjectNo,ClassHour,GradeId from subject where GradeId = '{0}'", GradeId);
                SqlDataReader reader = MySchoolC.ExecuteReader(strcmd);
                while (reader.Read())
                {
                    Subject Sj = new Subject() {
                        SubjectName = reader["SubjectName"].ToString(),
                        SubjectId = Convert.ToInt32(reader["SubjectNo"]),
                        ClassHours = Convert.ToInt32(reader["ClassHour"]),
                        GradeId = Convert.ToInt32(reader["GradeId"])
                    };
                    Ls.Add(Sj);
                }
                reader.Close();
                return Ls;
        }
        public static List<Subject> GetSubject()
        {
            List<Subject> Ls = new List<Subject>();
            string strcmd = string.Format("select SubjectName,SubjectNo,ClassHour,GradeId from subject");
            SqlDataReader reader = MySchoolC.ExecuteReader(strcmd);
            while (reader.Read())
            {
                Subject Sj = new Subject()
                {
                    SubjectName = reader["SubjectName"].ToString(),
                    SubjectId = Convert.ToInt32(reader["SubjectNo"]),
                    ClassHours = Convert.ToInt32(reader["ClassHour"]),
                    GradeId = Convert.ToInt32(reader["GradeId"])
                };
                Ls.Add(Sj);
            }
            reader.Close();
            return Ls;
        }
        public static List<Result> GetResult(int gradeId,int subjectid,string name)
        {
            List<Result> LR = new List<Result>();
            string str = string.Format(@"select student.studentname,result.studentResult,result.ExamDate,subject.subjectName from student,result,subject where
                            student.studentno = result.studentno and subject.SubjectNO = Result.SubjectNo and studentname like '%{0}%' and subject.subjectno = '{1}' and subject.GradeId = '{2}'",name,subjectid,gradeId);
            SqlDataReader reader = MySchoolC.ExecuteReader(str);
            while (reader.Read())
            {
                Result R = new Result() { StudentName = reader["studentname"].ToString(),
                                          StudentResult = Convert.ToInt32(reader["studentresult"]),
                                          Subject = reader["subjectName"].ToString(),
                                          ExamDate = Convert.ToDateTime(reader["ExamDate"])};
                LR.Add(R);
            }
            return LR;
        }
    }
}
