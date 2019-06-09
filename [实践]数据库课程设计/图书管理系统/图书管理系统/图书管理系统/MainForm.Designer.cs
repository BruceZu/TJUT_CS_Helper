namespace 图书管理系统
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.账号信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.选座ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询书籍和借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.userNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账号信息ToolStripMenuItem,
            this.修改密码ToolStripMenuItem1,
            this.选座ToolStripMenuItem,
            this.查询书籍和借书ToolStripMenuItem,
            this.还书ToolStripMenuItem1,
            this.帮助HToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(846, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 账号信息ToolStripMenuItem
            // 
            this.账号信息ToolStripMenuItem.Name = "账号信息ToolStripMenuItem";
            this.账号信息ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.账号信息ToolStripMenuItem.Text = "账号信息";
            this.账号信息ToolStripMenuItem.Click += new System.EventHandler(this.账号信息ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem1
            // 
            this.修改密码ToolStripMenuItem1.Name = "修改密码ToolStripMenuItem1";
            this.修改密码ToolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.修改密码ToolStripMenuItem1.Text = "修改密码";
            this.修改密码ToolStripMenuItem1.Click += new System.EventHandler(this.修改密码ToolStripMenuItem1_Click);
            // 
            // 选座ToolStripMenuItem
            // 
            this.选座ToolStripMenuItem.Name = "选座ToolStripMenuItem";
            this.选座ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.选座ToolStripMenuItem.Text = "选座";
            this.选座ToolStripMenuItem.Click += new System.EventHandler(this.选座ToolStripMenuItem_Click);
            // 
            // 查询书籍和借书ToolStripMenuItem
            // 
            this.查询书籍和借书ToolStripMenuItem.Name = "查询书籍和借书ToolStripMenuItem";
            this.查询书籍和借书ToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.查询书籍和借书ToolStripMenuItem.Text = "查询书籍和借书";
            this.查询书籍和借书ToolStripMenuItem.Click += new System.EventHandler(this.查询书籍和借书ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem1
            // 
            this.还书ToolStripMenuItem1.Name = "还书ToolStripMenuItem1";
            this.还书ToolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.还书ToolStripMenuItem1.Text = "还书";
            this.还书ToolStripMenuItem1.Click += new System.EventHandler(this.还书ToolStripMenuItem1_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.帮助HToolStripMenuItem.Text = "帮助";
            this.帮助HToolStripMenuItem.Click += new System.EventHandler(this.帮助HToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.退出ToolStripMenuItem.Text = "退出登录";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 494);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "图书馆管理系统-用户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账号信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询书籍和借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 选座ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel userNameLabel;
    }
}