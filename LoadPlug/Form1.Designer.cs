namespace PluginInterface
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlugComb = new System.Windows.Forms.ComboBox();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.PlugTxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // PlugComb
            // 
            this.PlugComb.FormattingEnabled = true;
            this.PlugComb.Location = new System.Drawing.Point(12, 12);
            this.PlugComb.Name = "PlugComb";
            this.PlugComb.Size = new System.Drawing.Size(371, 20);
            this.PlugComb.TabIndex = 0;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(127, 120);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(75, 23);
            this.ExecuteBtn.TabIndex = 1;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // PlugTxt
            // 
            this.PlugTxt.Location = new System.Drawing.Point(12, 38);
            this.PlugTxt.Multiline = true;
            this.PlugTxt.Name = "PlugTxt";
            this.PlugTxt.Size = new System.Drawing.Size(371, 40);
            this.PlugTxt.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = ";";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 152);
            this.Controls.Add(this.PlugTxt);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.PlugComb);
            this.MaximumSize = new System.Drawing.Size(403, 186);
            this.MinimumSize = new System.Drawing.Size(403, 186);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PlugComb;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.TextBox PlugTxt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

