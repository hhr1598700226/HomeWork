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

            List<Student> DS = MySchoolC.GetStudent();

            this.btnadd.DataSource = new BindingList<Student>(DS);

        }

        public void UpdataView()
        {
            this.btnadd.DataSource = new BindingList<Student>(DS);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            DS = MySchoolC.GetStudent(this.comboBox1.SelectedValue.ToString());

            this.btnadd.DataSource = new BindingList<Student>(DS);
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
    }
}
