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
    public partial class xuanze : Form
    {
        public xuanze()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           yuyue rform = new yuyue();
            this.Hide();
            rform.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            xuanzuo rform = new xuanzuo();
            this.Hide();
            rform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm rform = new MainForm();
            this.Hide();
            rform.Show();
        }

        private void Xuanze_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm rform = new MainForm();
            this.Hide();
            rform.Show();
        }
    }
}
