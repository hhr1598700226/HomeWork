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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string stradmin = this.txtadmin.Text.Trim();
            string strpwd = this.txtpwd.Text.Trim();           
            if (string.IsNullOrEmpty(stradmin))
            {
                errorProvider.SetError(this.txtadmin,"用户名不能为空！");
                return;
            }
            this.errorProvider.Clear();

            string constr = "data source=.;database = myschool;user id = sa;pwd = 1";
            SqlConnection sqlcon = new SqlConnection(constr);
            sqlcon.Open();
            string cmd = string.Format("select count(*) from admin where loginid = '{0}' and loginpwd = '{1}'",stradmin,strpwd);
            SqlCommand sqlcmd = new SqlCommand(cmd,sqlcon);
            int result = Convert.ToInt32(sqlcmd.ExecuteScalar());
            if (result > 0)
            {
                StudentManage SM = new StudentManage();
                SM.m_strpwd = strpwd;
                SM.m_stradmin = stradmin;
                this.Hide();
                SM.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("用户名或密码不正确");
            }
            sqlcon.Close();
        }
    }
}
