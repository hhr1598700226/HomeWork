namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.dgbstudent = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtgrade = new System.Windows.Forms.GroupBox();
            this.cbstudentgrade = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.rbman = new System.Windows.Forms.RadioButton();
            this.rbwoman = new System.Windows.Forms.RadioButton();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtStudentPwd = new System.Windows.Forms.TextBox();
            this.txtidcard = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtborndate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labstudentNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbstudent)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.txtgrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(438, 15);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 2;
            this.btnselect.Text = "查找";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // dgbstudent
            // 
            this.dgbstudent.AllowUserToAddRows = false;
            this.dgbstudent.AllowUserToDeleteRows = false;
            this.dgbstudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbstudent.ContextMenuStrip = this.contextMenuStrip1;
            this.dgbstudent.Location = new System.Drawing.Point(12, 60);
            this.dgbstudent.Name = "dgbstudent";
            this.dgbstudent.ReadOnly = true;
            this.dgbstudent.RowTemplate.Height = 23;
            this.dgbstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbstudent.Size = new System.Drawing.Size(621, 205);
            this.dgbstudent.TabIndex = 3;
            this.dgbstudent.SelectionChanged += new System.EventHandler(this.dgbstudent_SelectionChanged);
            this.dgbstudent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgbstudent_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加成绩ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // 添加成绩ToolStripMenuItem
            // 
            this.添加成绩ToolStripMenuItem.Name = "添加成绩ToolStripMenuItem";
            this.添加成绩ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加成绩ToolStripMenuItem.Text = "添加成绩";
            this.添加成绩ToolStripMenuItem.Click += new System.EventHandler(this.添加成绩ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加学生";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "姓名";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(196, 17);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(104, 21);
            this.txtname.TabIndex = 6;
            // 
            // txtgrade
            // 
            this.txtgrade.Controls.Add(this.cbstudentgrade);
            this.txtgrade.Controls.Add(this.btnChange);
            this.txtgrade.Controls.Add(this.rbman);
            this.txtgrade.Controls.Add(this.rbwoman);
            this.txtgrade.Controls.Add(this.txtemail);
            this.txtgrade.Controls.Add(this.txtStudentPwd);
            this.txtgrade.Controls.Add(this.txtidcard);
            this.txtgrade.Controls.Add(this.txtphone);
            this.txtgrade.Controls.Add(this.txtaddress);
            this.txtgrade.Controls.Add(this.label12);
            this.txtgrade.Controls.Add(this.txtborndate);
            this.txtgrade.Controls.Add(this.label9);
            this.txtgrade.Controls.Add(this.label11);
            this.txtgrade.Controls.Add(this.txtStudentName);
            this.txtgrade.Controls.Add(this.label8);
            this.txtgrade.Controls.Add(this.label10);
            this.txtgrade.Controls.Add(this.label6);
            this.txtgrade.Controls.Add(this.label7);
            this.txtgrade.Controls.Add(this.label5);
            this.txtgrade.Controls.Add(this.label4);
            this.txtgrade.Controls.Add(this.labstudentNo);
            this.txtgrade.Controls.Add(this.label2);
            this.txtgrade.Location = new System.Drawing.Point(12, 271);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(621, 138);
            this.txtgrade.TabIndex = 7;
            this.txtgrade.TabStop = false;
            this.txtgrade.Text = "修改学生信息";
            // 
            // cbstudentgrade
            // 
            this.cbstudentgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentgrade.FormattingEnabled = true;
            this.cbstudentgrade.Location = new System.Drawing.Point(234, 72);
            this.cbstudentgrade.Name = "cbstudentgrade";
            this.cbstudentgrade.Size = new System.Drawing.Size(106, 20);
            this.cbstudentgrade.TabIndex = 4;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(527, 99);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // rbman
            // 
            this.rbman.AutoSize = true;
            this.rbman.Location = new System.Drawing.Point(487, 19);
            this.rbman.Name = "rbman";
            this.rbman.Size = new System.Drawing.Size(35, 16);
            this.rbman.TabIndex = 2;
            this.rbman.TabStop = true;
            this.rbman.Text = "男";
            this.rbman.UseVisualStyleBackColor = true;
            // 
            // rbwoman
            // 
            this.rbwoman.AutoSize = true;
            this.rbwoman.Location = new System.Drawing.Point(546, 19);
            this.rbwoman.Name = "rbwoman";
            this.rbwoman.Size = new System.Drawing.Size(35, 16);
            this.rbwoman.TabIndex = 2;
            this.rbwoman.TabStop = true;
            this.rbwoman.Text = "女";
            this.rbwoman.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(274, 45);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(119, 21);
            this.txtemail.TabIndex = 1;
            // 
            // txtStudentPwd
            // 
            this.txtStudentPwd.Location = new System.Drawing.Point(328, 18);
            this.txtStudentPwd.Name = "txtStudentPwd";
            this.txtStudentPwd.Size = new System.Drawing.Size(100, 21);
            this.txtStudentPwd.TabIndex = 1;
            // 
            // txtidcard
            // 
            this.txtidcard.Location = new System.Drawing.Point(417, 72);
            this.txtidcard.Name = "txtidcard";
            this.txtidcard.Size = new System.Drawing.Size(147, 21);
            this.txtidcard.TabIndex = 1;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(452, 45);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(129, 21);
            this.txtphone.TabIndex = 1;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(65, 72);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(113, 21);
            this.txtaddress.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "年级：";
            // 
            // txtborndate
            // 
            this.txtborndate.Location = new System.Drawing.Point(81, 45);
            this.txtborndate.Name = "txtborndate";
            this.txtborndate.Size = new System.Drawing.Size(134, 21);
            this.txtborndate.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "身份证号：";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(159, 18);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 21);
            this.txtStudentName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "phone：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "地址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "密码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "出生日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名：";
            // 
            // labstudentNo
            // 
            this.labstudentNo.AutoSize = true;
            this.labstudentNo.Location = new System.Drawing.Point(65, 21);
            this.labstudentNo.Name = "labstudentNo";
            this.labstudentNo.Size = new System.Drawing.Size(53, 12);
            this.labstudentNo.TabIndex = 0;
            this.labstudentNo.Text = "        ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "查看学生成绩";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtgrade);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgbstudent);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbstudent)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.txtgrade.ResumeLayout(false);
            this.txtgrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.DataGridView dgbstudent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox txtgrade;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.RadioButton rbman;
        private System.Windows.Forms.RadioButton rbwoman;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtStudentPwd;
        private System.Windows.Forms.TextBox txtidcard;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtborndate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labstudentNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbstudentgrade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加成绩ToolStripMenuItem;
    }
}

