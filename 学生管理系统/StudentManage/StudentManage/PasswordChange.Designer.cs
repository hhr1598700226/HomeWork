namespace StudentManage
{
    partial class PasswordChange
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
            this.components = new System.ComponentModel.Container();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtoldpwd = new System.Windows.Forms.TextBox();
            this.txtnewpwd = new System.Windows.Forms.TextBox();
            this.txtnewtwicepwd = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(31, 142);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "修改";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(158, 142);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "重复新密码：";
            // 
            // txtoldpwd
            // 
            this.txtoldpwd.Location = new System.Drawing.Point(112, 24);
            this.txtoldpwd.Name = "txtoldpwd";
            this.txtoldpwd.Size = new System.Drawing.Size(121, 21);
            this.txtoldpwd.TabIndex = 4;
            // 
            // txtnewpwd
            // 
            this.txtnewpwd.Location = new System.Drawing.Point(112, 61);
            this.txtnewpwd.Name = "txtnewpwd";
            this.txtnewpwd.Size = new System.Drawing.Size(121, 21);
            this.txtnewpwd.TabIndex = 5;
            // 
            // txtnewtwicepwd
            // 
            this.txtnewtwicepwd.Location = new System.Drawing.Point(112, 106);
            this.txtnewtwicepwd.Name = "txtnewtwicepwd";
            this.txtnewtwicepwd.Size = new System.Drawing.Size(121, 21);
            this.txtnewtwicepwd.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 180);
            this.Controls.Add(this.txtnewtwicepwd);
            this.Controls.Add(this.txtnewpwd);
            this.Controls.Add(this.txtoldpwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PasswordChange";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtoldpwd;
        private System.Windows.Forms.TextBox txtnewpwd;
        private System.Windows.Forms.TextBox txtnewtwicepwd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}