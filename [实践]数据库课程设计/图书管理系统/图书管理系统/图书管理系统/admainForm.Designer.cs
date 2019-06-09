namespace 图书管理系统
{
    partial class admainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新书入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.逾期处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账户密码重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.userNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新书入库ToolStripMenuItem,
            this.图书增加ToolStripMenuItem,
            this.逾期处理ToolStripMenuItem,
            this.用户信息ToolStripMenuItem,
            this.账户密码重置ToolStripMenuItem,
            this.注销账户ToolStripMenuItem,
            this.注销书籍ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(878, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新书入库ToolStripMenuItem
            // 
            this.新书入库ToolStripMenuItem.Name = "新书入库ToolStripMenuItem";
            this.新书入库ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.新书入库ToolStripMenuItem.Text = "新书入库";
            this.新书入库ToolStripMenuItem.Click += new System.EventHandler(this.新书入库ToolStripMenuItem_Click);
            // 
            // 图书增加ToolStripMenuItem
            // 
            this.图书增加ToolStripMenuItem.Name = "图书增加ToolStripMenuItem";
            this.图书增加ToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.图书增加ToolStripMenuItem.Text = "库存查询和增加";
            this.图书增加ToolStripMenuItem.Click += new System.EventHandler(this.图书增加ToolStripMenuItem_Click);
            // 
            // 逾期处理ToolStripMenuItem
            // 
            this.逾期处理ToolStripMenuItem.Name = "逾期处理ToolStripMenuItem";
            this.逾期处理ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.逾期处理ToolStripMenuItem.Text = "办理还书";
            this.逾期处理ToolStripMenuItem.Click += new System.EventHandler(this.逾期处理ToolStripMenuItem_Click);
            // 
            // 账户密码重置ToolStripMenuItem
            // 
            this.账户密码重置ToolStripMenuItem.Name = "账户密码重置ToolStripMenuItem";
            this.账户密码重置ToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.账户密码重置ToolStripMenuItem.Text = "账户密码重置";
            this.账户密码重置ToolStripMenuItem.Click += new System.EventHandler(this.账户密码重置ToolStripMenuItem_Click);
            // 
            // 注销账户ToolStripMenuItem
            // 
            this.注销账户ToolStripMenuItem.Name = "注销账户ToolStripMenuItem";
            this.注销账户ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.注销账户ToolStripMenuItem.Text = "注销账户";
            this.注销账户ToolStripMenuItem.Click += new System.EventHandler(this.注销账户ToolStripMenuItem_Click);
            // 
            // 注销书籍ToolStripMenuItem
            // 
            this.注销书籍ToolStripMenuItem.Name = "注销书籍ToolStripMenuItem";
            this.注销书籍ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.注销书籍ToolStripMenuItem.Text = "注销书籍";
            this.注销书籍ToolStripMenuItem.Click += new System.EventHandler(this.注销书籍ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.退出登录ToolStripMenuItem.Text = "注销登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.用户信息ToolStripMenuItem.Text = "用户信息";
            this.用户信息ToolStripMenuItem.Click += new System.EventHandler(this.用户信息ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(878, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // admainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "admainForm";
            this.Text = "图书馆管理系统-管理端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdmainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdmainForm_FormClosed);
            this.Load += new System.EventHandler(this.AdmainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新书入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 逾期处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账户密码重置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel userNameLabel;
    }
}