namespace WindowsFormsApp1
{
    partial class Form6
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 231);
            this.label1.TabIndex = 0;
            this.label1.Text = "可以使用名字或组号，其他内容作者正在编写。\r\n你可以在名字点名模式导入你的班级。\r\n格式通常为这样的：\r\n张三\r\n李四\r\n王五\r\n注释：每个名字用回车间隔\r\n你可" +
    "以把它放在程序运行的根目录下，并命名为\"dianming.txt\"\r\n或者在运行点名模式时，进行导入文件\r\n\r\n如果你有更好的创意或者其他建议，欢迎反馈给作者。" +
    "\r\n";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 259);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.ShowInTaskbar = false;
            this.Text = "Form6";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}