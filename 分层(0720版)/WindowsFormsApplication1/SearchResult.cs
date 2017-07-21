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
    public partial class SearchResult : Form
    {
        public int m_subjectno;
        public SearchResult()
        {
            InitializeComponent();
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> dc = MySchoolC.GetGrade();
            BindingSource bs = new BindingSource();
            bs.DataSource = dc;
            this.cobGrade.ValueMember = "Key";
            this.cobGrade.DisplayMember = "Value";
            this.cobGrade.DataSource = bs;

            List<Subject> Ls = MySchoolC.GetSubject();
            this.comboSubject.DataSource = new BindingList<Subject>(Ls);
            this.comboSubject.DisplayMember = "SubjectName";
            this.comboSubject.ValueMember = "SubjectId";
            //List<Result> R = MySchoolC.GetResult();
            //this.dataGridView1.DataSource = new BindingList<Result>(R);
        }

        private void cobGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Subject> Ls = MySchoolC.GetSubject(Convert.ToInt32(this.cobGrade.SelectedValue));
            this.cobSelectSubject.DataSource = new BindingList<Subject>(Ls);
            this.cobSelectSubject.DisplayMember = "SubjectName";
            this.cobSelectSubject.ValueMember = "SubjectId";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            List<Result> R = MySchoolC.GetResult(Convert.ToInt32(this.cobGrade.SelectedValue),Convert.ToInt32(this.cobSelectSubject.SelectedValue),this.txtSelectName.Text.Trim());
            this.dataGridView1.DataSource = new BindingList<Result>(R);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows[0].Cells[0].Value == null)
                return;
            this.labname.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.txtStudentResult.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.txtExamDate.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            for (int i = 0; i < this.comboSubject.Items.Count; i++)
            {
                if (comboSubject.GetItemText(comboSubject.Items[i]) == this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString())
                {
                    m_subjectno = i + 1;
                    this.comboSubject.SelectedIndex = i;
                }
            }
            //string str = string.Format(@"select student.studentname,result.studentResult,result.ExamDate,subject.subjectName from student,result,subject where
            //                student.studentno = result.studentno and subject.SubjectNO = Result.SubjectNo and studentname like '%{0}%' and subject.subjectno = '{1}' and subject.GradeId = '{2}'", name, subjectid, gradeId);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string str = string.Format(@"update result set StudentResult = '{0}',SubjectNo = '{1}',ExamDate = '{2}' 
                 where studentno = (select studentno from student where studentname = '{3}' and SubjectNo = '{4}')", this.txtStudentResult.Text.Trim(),this.comboSubject.SelectedValue.ToString(),Convert.ToDateTime(this.txtExamDate.Text.Trim()), 
                            this.labname.Text,m_subjectno);
            int result = MySchoolC.ExecuteNonQuery(str);
            if (result > 0)
            {
                List<Result> R = MySchoolC.GetResult(Convert.ToInt32(this.cobGrade.SelectedValue), Convert.ToInt32(this.cobSelectSubject.SelectedValue), this.txtSelectName.Text.Trim());
                this.dataGridView1.DataSource = new BindingList<Result>(R);
            }
            else
            {
                MessageBox.Show("修改失败!");
                return;
            }
        }
    }
}
