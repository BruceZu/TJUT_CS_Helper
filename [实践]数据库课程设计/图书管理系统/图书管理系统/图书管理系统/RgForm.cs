using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class RgForm : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");
        static int flag=0;

        public RgForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login borForm = new Login();
            this.Hide();
            borForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                conn.Open();
                string str_sql = "select * from Account where ID='" + textBox1.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(str_sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    MessageBox.Show("提示：该账户已存在！", "提示");
                    return;
                }

                string npas = textBox2.Text.Trim();
                byte[] sarr = System.Text.Encoding.Default.GetBytes(npas);
                int len = sarr.Length;
                if (len < 6)
                {
                    MessageBox.Show("提示：密码长度小于6位！请重新输入", "警告");
                    textBox2.Text = "";
                    return;
                }

                if(flag==0)
                {
                    MessageBox.Show("提示：请选择用户类型", "警告");
                    return;
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("提示：请输入帐户名！", "警告");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("提示：请输入密码！", "警告");
                    return;
                }
                string str1 = textBox1.Text.Trim();
                string str2 = textBox2.Text.Trim();
                
                string sqlStr = "insert into Account values('" + str1 + "','" + str2 + "','" + flag + "',0,0)";
                sdr.Close();
                SqlCommand sqlCommand2 = new SqlCommand(sqlStr, conn);  //执行SQL命令
                sqlCommand2.ExecuteNonQuery();
                MessageBox.Show("提示：注册成功！", "提示");

            }
            catch (Exception)
            {
                MessageBox.Show("警告：注册失败，请重试！", "警告");
            }
            finally
            {
                conn.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void RgForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
                textBox2.PasswordChar = '*';
        }

        private void RgForm_FormClosing(object sender, FormClosingEventArgs e)
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
