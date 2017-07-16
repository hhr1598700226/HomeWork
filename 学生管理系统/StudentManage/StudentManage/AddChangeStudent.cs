using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManage
{
    public partial class AddChangeStudent : Form
    {
        SelectStudent SelectS;

        public string m_StudentName;
        public string m_StudentPwd;
        public string m_StudentNo;
        public string m_Gender;
        public string m_Grade;
        public string m_Phone;
        public string m_Address;
        public DateTime m_BornDate;
        public string m_Email;
        public string m_IdCard;
        public int m_GradeId;

        public string m_type;

        public AddChangeStudent()
        {
            InitializeComponent();
        }

        public AddChangeStudent(SelectStudent SS)
        {
            SelectS = SS;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtstudentpwd.Text) || string.IsNullOrEmpty(this.txtstudentname.Text) ||
                string.IsNullOrEmpty(this.txtemail.Text) || string.IsNullOrEmpty(this.txtphone.Text) ||
                string.IsNullOrEmpty(this.txtidcard.Text) || string.IsNullOrEmpty(this.txtaddress.Text))
            {
                MessageBox.Show("信息不能有空!");
                return;
            }

            string pwd = this.txtstudentpwd.Text.Trim();
            string name = this.txtstudentname.Text.Trim();
            string gender = this.rbman.Checked ? "男" : "女";
            int gradeid = Convert.ToInt32(this.cbclass.SelectedValue);
            string phone = this.txtphone.Text.Trim();
            string address = this.txtaddress.Text.Trim();
            DateTime borndate = this.borndate.Value; 
            string email = this.txtemail.Text.Trim();
            string idcard = this.txtidcard.Text.Trim();

            string strcon = "data source = .;database = Myschool;user id = sa;pwd = 1";
            SqlConnection sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            string sqlcmd = "";
            if (m_type == "添加")
            {
                sqlcmd = string.Format("insert into student(loginpwd,studentname,gender,gradeid,phone,address,borndate,email,identitycard) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}')", pwd, name, gender, gradeid, phone, address, borndate, email, idcard);
            }
            else
            {
                sqlcmd = string.Format(@"update student set loginpwd = '{0}',studentname = '{1}',gradeid = '{2}',phone = '{3}',
                                        [address] = '{4}',borndate = '{5}',email = '{6}',identitycard = '{7}',gender = '{8}' where studentno = '{9}'",
                                        pwd, name, gradeid, phone, address, borndate, email, idcard,gender,this.txtstudentno.Text);
            }
            SqlCommand cmd = new SqlCommand(sqlcmd,sqlcon);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                if (m_type == "修改")
                {
                    MessageBox.Show("修改学生成功!");
                    SelectS.Updata();
                }
                else
                {
                    MessageBox.Show("增加学生成功!");
                }
            }
            sqlcon.Close();
        }

        private void AddChangeStudent_Load(object sender, EventArgs e)
        {
            string strcon = "data source = .;database = Myschool;user id = sa;pwd = 1";
            SqlConnection sqlcon = new SqlConnection(strcon);
            string strcmd = string.Format("select gradeid,gradename from Grade");
            SqlDataAdapter adapter = new SqlDataAdapter(strcmd, sqlcon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "grade");
            this.cbclass.DisplayMember = "gradename";
            this.cbclass.ValueMember = "gradeid";
            this.cbclass.DataSource = ds.Tables["grade"];

            if (m_type == "修改")
            {
                this.txtstudentno.Text = m_StudentNo;
                this.txtstudentname.Text = m_StudentName;
                this.txtstudentpwd.Text = m_StudentPwd;
                if (m_Gender == "男")
                {
                    this.rbman.Checked = true;
                }
                else
                {
                    this.rbwomen.Checked = true;
                }
                for (int i = 0; i < cbclass.Items.Count; i++)
                {
                    if (m_Grade == this.cbclass.GetItemText(cbclass.Items[i]))
                    {
                        this.cbclass.SelectedIndex = i;
                        m_GradeId = i + 1;
                    }
                }
                this.txtphone.Text = m_Phone;
                this.txtaddress.Text = m_Address;
                this.txtemail.Text = m_Email;
                this.txtidcard.Text = m_IdCard;
                this.borndate.Value = m_BornDate;

                this.button1.Text = "修改";
            }
            else
            {
                this.button1.Text = "添加";
            }
        }
    }
}
