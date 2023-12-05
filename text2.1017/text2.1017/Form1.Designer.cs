
namespace text2._1017
{
    partial class btnOK
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入数字：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "判断";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(229, 68);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(279, 28);
            this.txtString.TabIndex = 2;
            this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(53, 156);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(676, 184);
            this.lblShow.TabIndex = 3;
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // btnOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "btnOK";
            this.Text = "判断是否为回文数";
            this.Load += new System.EventHandler(this.btnOK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label lblShow;
    }
}

