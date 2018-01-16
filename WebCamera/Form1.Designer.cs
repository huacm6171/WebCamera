namespace WebCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVLC = new AxAXVLC.AxVLCPlugin2();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.vedioList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVLC)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLC
            // 
            this.axVLC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axVLC.Enabled = true;
            this.axVLC.Location = new System.Drawing.Point(156, 0);
            this.axVLC.Name = "axVLC";
            this.axVLC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLC.OcxState")));
            this.axVLC.Size = new System.Drawing.Size(725, 555);
            this.axVLC.TabIndex = 0;
            // 
            // vedioList
            // 
            this.vedioList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.vedioList.FormattingEnabled = true;
            this.vedioList.ItemHeight = 12;
            this.vedioList.Location = new System.Drawing.Point(0, -1);
            this.vedioList.Name = "vedioList";
            this.vedioList.Size = new System.Drawing.Size(150, 556);
            this.vedioList.TabIndex = 3;
            this.vedioList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.vedioList_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "btnStart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vedioList);
            this.Controls.Add(this.axVLC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WebCamera";
            ((System.ComponentModel.ISupportInitialize)(this.axVLC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLC;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ListBox vedioList;
        private System.Windows.Forms.Button button1;
    }
}

