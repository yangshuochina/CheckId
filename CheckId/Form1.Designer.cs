namespace CheckId
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
            this.tbIdNum = new System.Windows.Forms.TextBox();
            this.tbResultNum = new System.Windows.Forms.TextBox();
            this.btnCalcNum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始号码：";
            // 
            // tbIdNum
            // 
            this.tbIdNum.Location = new System.Drawing.Point(102, 19);
            this.tbIdNum.Name = "tbIdNum";
            this.tbIdNum.Size = new System.Drawing.Size(346, 21);
            this.tbIdNum.TabIndex = 1;
            // 
            // tbResultNum
            // 
            this.tbResultNum.Location = new System.Drawing.Point(102, 56);
            this.tbResultNum.Multiline = true;
            this.tbResultNum.Name = "tbResultNum";
            this.tbResultNum.ReadOnly = true;
            this.tbResultNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultNum.Size = new System.Drawing.Size(452, 457);
            this.tbResultNum.TabIndex = 2;
            // 
            // btnCalcNum
            // 
            this.btnCalcNum.Location = new System.Drawing.Point(479, 16);
            this.btnCalcNum.Name = "btnCalcNum";
            this.btnCalcNum.Size = new System.Drawing.Size(75, 23);
            this.btnCalcNum.TabIndex = 3;
            this.btnCalcNum.Text = "计算号码";
            this.btnCalcNum.UseVisualStyleBackColor = true;
            this.btnCalcNum.Click += new System.EventHandler(this.btnCalcNum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "计算号码：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 525);
            this.Controls.Add(this.btnCalcNum);
            this.Controls.Add(this.tbResultNum);
            this.Controls.Add(this.tbIdNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CheckId";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdNum;
        private System.Windows.Forms.TextBox tbResultNum;
        private System.Windows.Forms.Button btnCalcNum;
        private System.Windows.Forms.Label label2;
    }
}

