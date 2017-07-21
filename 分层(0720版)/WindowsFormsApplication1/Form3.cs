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

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        Form1 FF1;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 F1)
        {
            FF1 = F1;
            FF1.DS = F1.DS;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.StudentName = this.txtname.Text.Trim();
            if (this.txtpwd.Text.Trim() == this.txtpwd2.Text.Trim())
            {
                s.StudentPwd = this.txtpwd.Text.Trim();
            }
            else
            {
                this.errorProvider1.SetError(this.txtpwd2, "两次密码不一致！");
                return;
            }
            this.errorProvider1.Clear();
            s.Address = this.txtaddress.Text.Trim();
            s.BornDate = this.dateTimePicker1.Value;
            s.Email = this.txtemail.Text.Trim();
            s.IdCard = this.txtidcard.Text.Trim();
            s.Phone = this.txtphone.Text.Trim();
            s.Gender = this.rbman.Checked ? "男" : "女";
            s.Grade = this.cobgrade.SelectedValue.ToString();

            string str = string.Format("insert into student(studentname,loginpwd,gender,gradeid,phone,[address],borndate,email,identitycard) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}')",
                                        s.StudentName,s.StudentPwd,s.Gender,Convert.ToInt32(s.Grade),s.Phone,s.Address,s.BornDate,s.Email,s.IdCard);
            int result = MySchoolC.ExecuteNonQuery(str);
            if (result > 0)
            {
                MessageBox.Show("添加成功!");
                FF1.DS.Clear();
                FF1.DS = MySchoolC.GetStudent();
                FF1.UpdataView();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> dc = MySchoolC.GetGrade();
            BindingSource bs = new BindingSource();
            bs.DataSource = dc;
            this.cobgrade.DataSource = bs;
            this.cobgrade.ValueMember = "Key";
            this.cobgrade.DisplayMember = "Value";
        }
    }
}
