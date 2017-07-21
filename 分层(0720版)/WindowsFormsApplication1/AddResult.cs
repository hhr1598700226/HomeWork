using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySchool.Model;
using MainForm.DAL;

namespace WindowsFormsApplication1
{
    public partial class AddResult : Form
    {
        public int m_studentNo;
        public AddResult()
        {
            InitializeComponent();
        }

        public AddResult(int no)
        {
            m_studentNo = no;
            InitializeComponent();
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> Dc = MySchoolC.GetGrade();
            BindingSource bs = new BindingSource();
            bs.DataSource = Dc;
            this.cobGrade.ValueMember = "Key";
            this.cobGrade.DisplayMember = "Value";
            this.cobGrade.DataSource = bs;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cobGrade.SelectedValue.ToString() +"\n" + this.cobSubject.SelectedValue.ToString() + "\n" + m_studentNo);
            string str = string.Format(@"insert into result(studentno,subjectno,studentResult,ExamDate) 
                Values('{0}','{1}','{2}','{3}')",m_studentNo,this.cobSubject.SelectedValue.ToString(),this.txtResult.Text,this.dtpExamdate.Value);
            int result = MySchoolC.ExecuteNonQuery(str);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void cobGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Subject> LS = MySchoolC.GetSubject(Convert.ToInt32(this.cobGrade.SelectedValue));
            this.cobSubject.DisplayMember = "SubjectName";
            this.cobSubject.ValueMember = "SubjectId";
            this.cobSubject.DataSource = new BindingList<Subject>(LS);
        }
    }
}
