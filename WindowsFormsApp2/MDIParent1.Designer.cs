namespace WindowsFormsApp2
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加单位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加产品名字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购产品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售产品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品库存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.经销商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加经销商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 396);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户ToolStripMenuItem,
            this.单位ToolStripMenuItem,
            this.产品ToolStripMenuItem,
            this.经销商ToolStripMenuItem,
            this.操作记录ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 单位ToolStripMenuItem
            // 
            this.单位ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加单位ToolStripMenuItem});
            this.单位ToolStripMenuItem.Name = "单位ToolStripMenuItem";
            this.单位ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.单位ToolStripMenuItem.Text = "单位";
            // 
            // 添加单位ToolStripMenuItem
            // 
            this.添加单位ToolStripMenuItem.Name = "添加单位ToolStripMenuItem";
            this.添加单位ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加单位ToolStripMenuItem.Text = "添加单位";
            this.添加单位ToolStripMenuItem.Click += new System.EventHandler(this.添加单位ToolStripMenuItem_Click);
            // 
            // 产品ToolStripMenuItem
            // 
            this.产品ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加产品名字ToolStripMenuItem,
            this.采购产品ToolStripMenuItem,
            this.销售产品ToolStripMenuItem,
            this.产品库存ToolStripMenuItem});
            this.产品ToolStripMenuItem.Name = "产品ToolStripMenuItem";
            this.产品ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.产品ToolStripMenuItem.Text = "产品";
            // 
            // 添加产品名字ToolStripMenuItem
            // 
            this.添加产品名字ToolStripMenuItem.Name = "添加产品名字ToolStripMenuItem";
            this.添加产品名字ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加产品名字ToolStripMenuItem.Text = "添加产品名字";
            this.添加产品名字ToolStripMenuItem.Click += new System.EventHandler(this.添加产品名字ToolStripMenuItem_Click);
            // 
            // 采购产品ToolStripMenuItem
            // 
            this.采购产品ToolStripMenuItem.Name = "采购产品ToolStripMenuItem";
            this.采购产品ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.采购产品ToolStripMenuItem.Text = "采购产品";
            this.采购产品ToolStripMenuItem.Click += new System.EventHandler(this.采购产品ToolStripMenuItem_Click);
            // 
            // 销售产品ToolStripMenuItem
            // 
            this.销售产品ToolStripMenuItem.Name = "销售产品ToolStripMenuItem";
            this.销售产品ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.销售产品ToolStripMenuItem.Text = "销售产品";
            this.销售产品ToolStripMenuItem.Click += new System.EventHandler(this.销售产品ToolStripMenuItem_Click);
            // 
            // 产品库存ToolStripMenuItem
            // 
            this.产品库存ToolStripMenuItem.Name = "产品库存ToolStripMenuItem";
            this.产品库存ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.产品库存ToolStripMenuItem.Text = "产品库存";
            this.产品库存ToolStripMenuItem.Click += new System.EventHandler(this.产品库存ToolStripMenuItem_Click);
            // 
            // 经销商ToolStripMenuItem
            // 
            this.经销商ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加经销商ToolStripMenuItem});
            this.经销商ToolStripMenuItem.Name = "经销商ToolStripMenuItem";
            this.经销商ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.经销商ToolStripMenuItem.Text = "经销商";
            // 
            // 添加经销商ToolStripMenuItem
            // 
            this.添加经销商ToolStripMenuItem.Name = "添加经销商ToolStripMenuItem";
            this.添加经销商ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加经销商ToolStripMenuItem.Text = "添加经销商";
            this.添加经销商ToolStripMenuItem.Click += new System.EventHandler(this.添加经销商ToolStripMenuItem_Click);
            // 
            // 操作记录ToolStripMenuItem
            // 
            this.操作记录ToolStripMenuItem.Name = "操作记录ToolStripMenuItem";
            this.操作记录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.操作记录ToolStripMenuItem.Text = "操作记录";
            this.操作记录ToolStripMenuItem.Click += new System.EventHandler(this.操作记录ToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 418);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加单位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加产品名字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 经销商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加经销商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购产品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售产品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品库存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作记录ToolStripMenuItem;
    }
}



