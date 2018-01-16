namespace WebCamera_dir
{
    partial class WebCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebCamera));
            this.axVLC = new AxAXVLC.AxVLCPlugin2();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnScreenShot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVLC)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLC
            // 
            this.axVLC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axVLC.Enabled = true;
            this.axVLC.Location = new System.Drawing.Point(0, 0);
            this.axVLC.Name = "axVLC";
            this.axVLC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLC.OcxState")));
            this.axVLC.Size = new System.Drawing.Size(1267, 645);
            this.axVLC.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(13, 652);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScreenShot.Location = new System.Drawing.Point(125, 651);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(75, 23);
            this.btnScreenShot.TabIndex = 2;
            this.btnScreenShot.Text = "截屏(&C)";
            this.btnScreenShot.UseVisualStyleBackColor = true;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // WebCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 683);
            this.Controls.Add(this.btnScreenShot);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.axVLC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebCamera";
            this.Text = "WebCamera";
            ((System.ComponentModel.ISupportInitialize)(this.axVLC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLC;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnScreenShot;
    }
}

