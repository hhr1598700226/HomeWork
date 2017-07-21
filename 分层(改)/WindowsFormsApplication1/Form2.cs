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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Format("select count(*) from admin where loginid = '{0}' and loginpwd = '{1}'",this.txtname.Text,this.txtpwd.Text);
            int result = MySchoolC.ExecuteScalar(str);
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
