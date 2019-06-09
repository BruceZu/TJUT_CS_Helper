using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class MainForm : Form
    {
        public string gvUser;

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // String str_temp = Form1.queryData("select * from Account");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = gvUser + "，欢迎使用！";
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 书籍管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorForm borForm = new BorForm();
            this.Hide();
            borForm.Show();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RForm rform = new RForm();
            this.Hide();
            rform.Show();
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm rform = new HelpForm();
            this.Hide();
            rform.Show();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InForm borForm = new InForm();
            this.Hide();
            borForm.Show();

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasForm borForm = new PasForm();
            this.Hide();
            borForm.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login borForm = new Login();
            this.Hide();
            borForm.Show();
        }

        private void 账号信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InForm borForm = new InForm();
            this.Hide();
            borForm.Show();
        }

        private void 修改密码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasForm borForm = new PasForm();
            this.Hide();
            borForm.Show();
        }

        private void 查询书籍和借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorForm borForm = new BorForm();
            this.Hide();
            borForm.Show();
        }

        private void 还书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RForm rform = new RForm();
            this.Hide();
            rform.Show();
        }

        private void 选座ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            zuoweiForm rform = new zuoweiForm();
            this.Hide();
            rform.Show();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("确认退出？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
    }
}
