namespace WindowsFormsApplication1
{
    partial class AddResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrollback = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dtpExamdate = new System.Windows.Forms.DateTimePicker();
            this.cobSubject = new System.Windows.Forms.ComboBox();
            this.cobGrade = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "成绩";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "科目";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "考试时间";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(71, 59);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(121, 21);
            this.txtResult.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrollback);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.dtpExamdate);
            this.groupBox1.Controls.Add(this.cobSubject);
            this.groupBox1.Controls.Add(this.cobGrade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入成绩";
            // 
            // btnrollback
            // 
            this.btnrollback.Location = new System.Drawing.Point(292, 96);
            this.btnrollback.Name = "btnrollback";
            this.btnrollback.Size = new System.Drawing.Size(75, 23);
            this.btnrollback.TabIndex = 4;
            this.btnrollback.Text = "返回";
            this.btnrollback.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(117, 96);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dtpExamdate
            // 
            this.dtpExamdate.Location = new System.Drawing.Point(292, 59);
            this.dtpExamdate.Name = "dtpExamdate";
            this.dtpExamdate.Size = new System.Drawing.Size(127, 21);
            this.dtpExamdate.TabIndex = 3;
            // 
            // cobSubject
            // 
            this.cobSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSubject.FormattingEnabled = true;
            this.cobSubject.Location = new System.Drawing.Point(292, 24);
            this.cobSubject.Name = "cobSubject";
            this.cobSubject.Size = new System.Drawing.Size(127, 20);
            this.cobSubject.TabIndex = 2;
            // 
            // cobGrade
            // 
            this.cobGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobGrade.FormattingEnabled = true;
            this.cobGrade.Location = new System.Drawing.Point(71, 24);
            this.cobGrade.Name = "cobGrade";
            this.cobGrade.Size = new System.Drawing.Size(121, 20);
            this.cobGrade.TabIndex = 2;
            this.cobGrade.SelectedIndexChanged += new System.EventHandler(this.cobGrade_SelectedIndexChanged);
            // 
            // AddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 158);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddResult";
            this.Text = "AddResult";
            this.Load += new System.EventHandler(this.AddResult_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnrollback;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker dtpExamdate;
        private System.Windows.Forms.ComboBox cobSubject;
        private System.Windows.Forms.ComboBox cobGrade;
    }
}