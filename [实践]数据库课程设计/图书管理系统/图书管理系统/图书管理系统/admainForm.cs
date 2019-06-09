using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class admainForm : Form
    {
        public string gvUser;

        public admainForm()
        {
            InitializeComponent();
        }

        private void 新书入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NForm borForm = new NForm();
            this.Hide();
            borForm.Show();
        }

        private void 图书增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm borForm = new AddForm();
            this.Hide();
            borForm.Show();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login borForm = new Login();
            this.Hide();
            borForm.Show();
        }

        private void 逾期处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YuForm borForm = new YuForm();
            this.Hide();
            borForm.Show();
        }

        private void 账户密码重置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm borForm = new ResetForm();
            this.Hide();
            borForm.Show();
        }

        private void 注销账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisaForm borForm = new DisaForm();
            this.Hide();
            borForm.Show();
        }

        private void 注销书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisbForm borForm = new DisbForm();
            this.Hide();
            borForm.Show();
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UForm borForm = new UForm();
            this.Hide();
            borForm.Show();
        }

        private void AdmainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void AdmainForm_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = gvUser + "，欢迎使用！";
        }

        private void AdmainForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
