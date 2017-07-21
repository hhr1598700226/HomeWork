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
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string str = string.Format("select count(*) from admin where loginid = @loginid and loginpwd = @loginpwd");
            SqlParameter[] parm = new SqlParameter[] {
                                                         new SqlParameter("@loginid",this.txtname.Text.Trim()),
                                                            new SqlParameter("@loginpwd",this.txtpwd.Text.Trim())
                  };
            int result = Convert.ToInt32(MySchoolC.ExecuteScalar(str,parm));
                if (result > 0)
                {
                    MessageBox.Show("登陆成功！");
                    Form1 f = new Form1();
                    this.Hide();
                    f.ShowDialog();
                    this.Dispose();
                }
            }
        }
    }

