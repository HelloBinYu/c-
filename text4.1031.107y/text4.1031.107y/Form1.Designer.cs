
namespace text4._1031._107y
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stuNo = new System.Windows.Forms.TextBox();
            this.stuName = new System.Windows.Forms.TextBox();
            this.stuSex = new System.Windows.Forms.TextBox();
            this.stuAge = new System.Windows.Forms.TextBox();
            this.stuSpecialty = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "专业";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(442, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 353);
            this.label7.TabIndex = 6;
            // 
            // stuNo
            // 
            this.stuNo.Location = new System.Drawing.Point(129, 65);
            this.stuNo.Name = "stuNo";
            this.stuNo.Size = new System.Drawing.Size(264, 28);
            this.stuNo.TabIndex = 7;
            this.stuNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stuName
            // 
            this.stuName.Location = new System.Drawing.Point(129, 123);
            this.stuName.Name = "stuName";
            this.stuName.Size = new System.Drawing.Size(264, 28);
            this.stuName.TabIndex = 8;
            // 
            // stuSex
            // 
            this.stuSex.Location = new System.Drawing.Point(129, 179);
            this.stuSex.Name = "stuSex";
            this.stuSex.Size = new System.Drawing.Size(264, 28);
            this.stuSex.TabIndex = 9;
            // 
            // stuAge
            // 
            this.stuAge.Location = new System.Drawing.Point(129, 236);
            this.stuAge.Name = "stuAge";
            this.stuAge.Size = new System.Drawing.Size(264, 28);
            this.stuAge.TabIndex = 10;
            // 
            // stuSpecialty
            // 
            this.stuSpecialty.Location = new System.Drawing.Point(129, 291);
            this.stuSpecialty.Name = "stuSpecialty";
            this.stuSpecialty.Size = new System.Drawing.Size(264, 28);
            this.stuSpecialty.TabIndex = 11;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(69, 358);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(323, 47);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "添    加";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.stuSpecialty);
            this.Controls.Add(this.stuAge);
            this.Controls.Add(this.stuSex);
            this.Controls.Add(this.stuName);
            this.Controls.Add(this.stuNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "显示添加学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stuNo;
        private System.Windows.Forms.TextBox stuName;
        private System.Windows.Forms.TextBox stuSex;
        private System.Windows.Forms.TextBox stuAge;
        private System.Windows.Forms.TextBox stuSpecialty;
        private System.Windows.Forms.Button buttonOK;
    }
}

