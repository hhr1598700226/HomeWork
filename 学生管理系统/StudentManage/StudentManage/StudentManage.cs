using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManage
{
    public partial class StudentManage : Form
    {
        public string m_strpwd;
        public string m_stradmin;
        public StudentManage()
        {
            InitializeComponent();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChange PC = new PasswordChange();
            PC.MdiParent = this;
            PC.m_strpwd = this.m_strpwd;
            PC.m_stradmin = this.m_stradmin;
            PC.Show();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChangeStudent ACS = new AddChangeStudent();
            ACS.m_type = "添加";
            ACS.MdiParent = this;
            ACS.Show();
        }

        private void 查找学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectStudent SS = new SelectStudent();
            SS.MdiParent = this;
            SS.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ;
        }
    }
}
