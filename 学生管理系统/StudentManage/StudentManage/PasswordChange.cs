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
    public partial class PasswordChange : Form
    {
        public string m_strpwd;
        public string m_stradmin;
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (this.txtoldpwd.Text.Trim() != this.m_strpwd)
            {
                this.errorProvider1.SetError(this.txtoldpwd,"原密码不正确!");
                return;
            }
            this.errorProvider1.Clear();
            if (string.IsNullOrEmpty(this.txtnewpwd.Text.Trim()))
            {
                this.errorProvider1.SetError(this.txtnewpwd, "密码不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(this.txtnewtwicepwd.Text.Trim()))
            {
                this.errorProvider1.SetError(this.txtnewtwicepwd, "密码不能为空!");
                return;
            }
            if (this.txtnewpwd.Text.Trim() != this.txtnewtwicepwd.Text.Trim())
            {
                this.errorProvider1.SetError(this.txtnewtwicepwd, "两次密码不一致!");
                return;
            }
            this.errorProvider1.Clear();

            string strsqlcon = "data source = .;database = myschool;user id = sa;pwd = 1";
            SqlConnection sqlcon = new SqlConnection(strsqlcon);
            sqlcon.Open();
            string strcmd = string.Format("update admin set loginpwd = '{0}' where loginid = '{1}' and loginpwd = '{2}'"
                                        , this.txtnewpwd.Text.Trim(),m_stradmin,m_strpwd);
            SqlCommand cmd = new SqlCommand(strcmd,sqlcon);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("修改成功!");
                m_strpwd = this.txtnewpwd.Text.Trim();
                this.Close();
            }
            sqlcon.Close();
        }
    }
}
