namespace Cycle
{
    partial class PostOrder
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
            this.preNum = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.RichTextBox();
            this.laterNum = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.trans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // preNum
            // 
            this.preNum.AutoSize = true;
            this.preNum.Location = new System.Drawing.Point(41, 62);
            this.preNum.Name = "preNum";
            this.preNum.Size = new System.Drawing.Size(37, 15);
            this.preNum.TabIndex = 0;
            this.preNum.Text = "原数";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(84, 59);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(138, 27);
            this.input.TabIndex = 1;
            this.input.Text = "";
            // 
            // laterNum
            // 
            this.laterNum.AutoSize = true;
            this.laterNum.Location = new System.Drawing.Point(228, 62);
            this.laterNum.Name = "laterNum";
            this.laterNum.Size = new System.Drawing.Size(67, 15);
            this.laterNum.TabIndex = 2;
            this.laterNum.Text = "逆序结果";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(301, 59);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(138, 27);
            this.output.TabIndex = 3;
            this.output.Text = "";
            // 
            // trans
            // 
            this.trans.Location = new System.Drawing.Point(468, 62);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(75, 23);
            this.trans.TabIndex = 4;
            this.trans.Text = "转换";
            this.trans.UseVisualStyleBackColor = true;
            this.trans.Click += new System.EventHandler(this.trans_Click);
            // 
            // PostOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 167);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.output);
            this.Controls.Add(this.laterNum);
            this.Controls.Add(this.input);
            this.Controls.Add(this.preNum);
            this.Name = "PostOrder";
            this.Text = "逆序输出数字";
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preNum;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Label laterNum;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button trans;
    }
}

