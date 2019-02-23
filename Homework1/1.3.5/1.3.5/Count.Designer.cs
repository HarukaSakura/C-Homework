namespace _1._3._5
{
    partial class Count
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
            this.SuspendLayout();
            // 
            // Count
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 473);
            this.Name = "Count";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
            this.Controls.Add(btn);
            this.Controls.Add(lb1);
            txt1.Dock = System.Windows.Forms.DockStyle.Left;
            txt2.Dock = System.Windows.Forms.DockStyle.Right;
            btn.Dock = System.Windows.Forms.DockStyle.Fill;
            lb1.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn.Text = "求积";
            lb1.Text = "";
            btn.Click += new System.EventHandler(this.button_Click);

        }

        #endregion
        
    }
}

