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
    public partial class xuanzuo : Form
    {
        public xuanzuo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xuanze rform = new xuanze();
            this.Hide();
            rform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("选座成功!", "提示");
            MainForm rform = new MainForm();
            this.Hide();
            rform.Show();
        }

        private void Xuanzuo_FormClosed(object sender, FormClosedEventArgs e)
        {
            xuanze rform = new xuanze();
            this.Hide();
            rform.Show();
        }

        private void Xuanzuo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认返回主界面？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
