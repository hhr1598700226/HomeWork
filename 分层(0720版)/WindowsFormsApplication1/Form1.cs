using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.DAL;
using MySchool.Model;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public List<Student> DS = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> dc = MySchoolC.GetGrade();
            BindingSource bs = new BindingSource();
            bs.DataSource = dc;
            comboBox1.DataSource = bs;
            comboBox1.ValueMember = "Key";
            comboBox1.DisplayMember = "Value";

            Dictionary<int, string> dc1 = MySchoolC.GetGrade();
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dc1;
            cbstudentgrade.DataSource = bs1;
            cbstudentgrade.ValueMember = "Key";
            cbstudentgrade.DisplayMember = "Value";

            List<Student> DS = MySchoolC.GetStudent();

            this.dgbstudent.DataSource = new BindingList<Student>(DS);
        }

        public void UpdataView()
        {
            this.dgbstudent.DataSource = new BindingList<Student>(DS);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            if (this.txtname.Text.Trim() == "" || this.txtname.Text.Trim() == null)
            {
                DS = MySchoolC.GetStudent(this.comboBox1.SelectedValue.ToString());
            }
            else
            {
                DS = MySchoolC.GetStudent(this.comboBox1.SelectedValue.ToString(),this.txtname.Text.Trim());
            }

            this.dgbstudent.DataSource = new BindingList<Student>(DS);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Student> DS = MySchoolC.GetStudent(this.comboBox1.SelectedValue.ToString());

            //this.dataGridView1.DataSource = new BindingList<Student>(DS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3(this);
            F3.Show();
        }

        private void dgbstudent_SelectionChanged(object sender, EventArgs e)
        {
            ;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.StudentNo = Convert.ToInt32(this.dgbstudent.SelectedRows[0].Cells[0].Value);
            s.StudentName = this.txtStudentName.Text.Trim();
            s.StudentPwd = this.txtStudentPwd.Text.Trim();
            s.Address = this.txtaddress.Text.Trim();
            s.BornDate = Convert.ToDateTime(this.txtborndate.Text.Trim());
            s.Email = this.txtemail.Text.Trim();
            s.IdCard = this.txtidcard.Text.Trim();
            s.Phone = this.txtphone.Text.Trim();
            s.Gender = this.rbman.Checked ? "男" : "女";
            s.Grade = this.cbstudentgrade.SelectedValue.ToString();

            string str = string.Format("Update student Set studentname = '{0}',loginpwd = '{1}',gender = '{2}',gradeid = '{3}',phone = '{4}',[address] = '{5}',borndate = '{6}',email = '{7}',identitycard = '{8}' where studentno = '{9}'",
                                        s.StudentName, s.StudentPwd, s.Gender, Convert.ToInt32(s.Grade), s.Phone, s.Address, s.BornDate, s.Email, s.IdCard,s.StudentNo); 
            int result = MySchoolC.ExecuteNonQuery(str);
            if (result > 0)
            {
                MessageBox.Show("修改成功!");
                DS.Clear();
                DS = MySchoolC.GetStudent();
                UpdataView();
            }
        }

        private void dgbstudent_MouseClick(object sender, MouseEventArgs e)
        {
            this.labstudentNo.Text = this.dgbstudent.SelectedRows[0].Cells[0].Value.ToString();
            this.txtStudentName.Text = this.dgbstudent.SelectedRows[0].Cells[1].Value.ToString();
            this.txtStudentPwd.Text = this.dgbstudent.SelectedRows[0].Cells[2].Value.ToString();
            if (this.dgbstudent.SelectedRows[0].Cells[3].Value.ToString() == "男")
            {
                this.rbman.Checked = true;
            }
            else
            {
                this.rbwoman.Checked = true;
            }
            this.cbstudentgrade.SelectedIndex = Convert.ToInt32(this.dgbstudent.SelectedRows[0].Cells[4].Value) - 1;
            this.txtaddress.Text = this.dgbstudent.SelectedRows[0].Cells[5].Value.ToString();
            this.txtemail.Text = this.dgbstudent.SelectedRows[0].Cells[6].Value.ToString();
            this.txtphone.Text = this.dgbstudent.SelectedRows[0].Cells[7].Value.ToString();
            this.txtborndate.Text = this.dgbstudent.SelectedRows[0].Cells[8].Value.ToString();
            this.txtidcard.Text = this.dgbstudent.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchResult SR = new SearchResult();
            SR.Show();
        }

        private void 添加成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddResult AR = new AddResult();
            AR.m_studentNo = Convert.ToInt32(this.dgbstudent.SelectedRows[0].Cells[0].Value);
            AR.Show();
        }
    }
}
