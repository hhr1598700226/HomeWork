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
    public partial class SelectStudent : Form
    {
        DataSet ds;
        public SelectStudent()
        {
            ds = new DataSet();
            InitializeComponent();
        }

        private void SelectStudent_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            string strcon = "data source = .;database = myschool;user id = sa;pwd = 1";
            SqlConnection sqlcon = new SqlConnection(strcon);
            string sqlcmd = "";
                sqlcmd = @"select StudentNo,LoginPwd,StudentName,Gender,Grade.Gradename,Phone,Address,BornDate,Email,IdentityCard
                                from student,Grade where Grade.Gradeid = student.Gradeid ";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd, sqlcon);
            adapter.Fill(ds, "student");
            this.dataGridView1.DataSource = ds.Tables["student"];

            sqlcmd = "select gradeid,gradename from grade";
            adapter = new SqlDataAdapter(sqlcmd, sqlcon);
            adapter.Fill(ds, "grade");
            this.cbgrade.ValueMember = "Gradeid";
            this.cbgrade.DisplayMember = "gradename";
            DataRow dr = ds.Tables["grade"].NewRow();
            dr[0] = -1;
            dr[1] = "全部年级";
            ds.Tables["grade"].Rows.InsertAt(dr, 0);
            this.cbgrade.DataSource = ds.Tables["grade"];
            this.cbgrade.SelectedIndex = 0;
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            Updata();
        }

        public void Updata()
        {
            ds.Tables["student"].Clear();
            string strcon = "data source = .;database = myschool;user id = sa;pwd = 1";
            SqlConnection sqlcon = new SqlConnection(strcon);
            string sqlcmd = "";
            if (Convert.ToInt32(this.cbgrade.SelectedValue) == -1)
            {
                sqlcmd = string.Format(@"select StudentNo,LoginPwd,StudentName,Gender,Grade.Gradename,Phone,Address,BornDate,Email ,IdentityCard  
                                from student,Grade where Grade.Gradeid = student.Gradeid and studentname like '%{0}%' and phone like '%{1}%'", this.txtname.Text.Trim(),this.txtphone.Text.Trim());
            }
            else
            {
                sqlcmd = string.Format(@"select StudentNo, LoginPwd, StudentName, Gender, Grade.Gradename, Phone, Address, BornDate, Email,IdentityCard  
                                from student,Grade where Grade.Gradeid = student.Gradeid AND Grade.Gradeid = '{0}' and studentname like '%{1}%' and phone like '%{2}%'", Convert.ToInt32(this.cbgrade.SelectedValue), this.txtname.Text.Trim(), this.txtphone.Text.Trim());
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd, sqlcon);
            adapter.Fill(ds, "student");
            this.dataGridView1.DataSource = ds.Tables["student"];
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChangeStudent CS = new AddChangeStudent(this);
            CS.MdiParent = StudentManage.ActiveForm;
            CS.m_type = "修改";
            CS.m_StudentNo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CS.m_StudentPwd = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CS.m_StudentName = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CS.m_Gender = this.dataGridView1.CurrentRow.Cells[3].Value.ToString(); 
            CS.m_Grade = this.dataGridView1.CurrentRow.Cells[4].Value.ToString(); 
            CS.m_Phone = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            CS.m_Address = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            CS.m_BornDate = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[7].Value);
            CS.m_Email = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            CS.m_IdCard = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            CS.Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("删除后不可恢复你真的要删除吗？","系统提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                string strcon = "data source = .;database = myschool;user id = sa;pwd = 1";
                SqlConnection sqlcon = new SqlConnection(strcon);
                sqlcon.Open();
                string sqlcmd = string.Format(@"delete from student where studentno = '{0}'",this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                SqlCommand cmd = new SqlCommand(sqlcmd,sqlcon);
                int re = cmd.ExecuteNonQuery();
                if (re > 0)
                {
                    MessageBox.Show("删除成功！");
                    Updata();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                sqlcon.Close();
            }
        }
    }
}
