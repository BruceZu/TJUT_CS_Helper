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
    public partial class PasForm : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");
        static public string id;
        static public string npsd;
        static public int flag=3;

        public PasForm()
        {
            InitializeComponent();
        }

        private void PasForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
            }
            else
                textBox1.PasswordChar = '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
                textBox2.PasswordChar = '*';
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.PasswordChar = '\0';
            }
            else
                textBox3.PasswordChar = '*';
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MainForm borForm = new MainForm();
            this.Hide();
            borForm.Show();
        }

        /* private bool checkValue()
         {
             return textBox1.Text.Trim().Equals(textBox1.Text.Trim());
             //Trim()是去掉文本框两端的空格
         }
         */

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
            
                string str1 = textBox2.Text.Trim();
                string str2 = textBox3.Text.Trim();
                if (str1 != str2)       //Trim()是去掉文本框两端的空格)
                {
                  MessageBox.Show("提示：两次输入的密码不一致！请重新输入!", "警告");
                  textBox3.Text = " ";
                  return;               
                }
                  conn.Open();
                  string sqlStr1 = "update Account set Password =‘" + npsd.Trim() + "’  where ID='" + id.Trim() + "'";
                  SqlCommand sqlCommand2 = new SqlCommand(sqlStr1, conn);  //执行SQL命令
                  sqlCommand2.ExecuteNonQuery();
                  conn.Close();
                  MessageBox.Show("提示：密码修改成功！", "提示");
               
            }
            catch (Exception)
            {
                MessageBox.Show("提示：密码修改出错！", "警告");
            }
            finally
            {
               
            }
            

        }

        private void textBox2_Click (object sender, EventArgs e)
        {
            try
            {
                string sqlStr5 = "select Password from Account where ID='" + id.Trim() + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr5, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Close();
                string  count =cmd.ExecuteScalar().ToString ().Trim();  
                //cmd.ExecuteScalar()返回执行sql语句的第一条结果
                                                                 
                // int count = Convert.ToInt32(cmd.ExecuteScalar());
                                                                
                // string pas = count.ToString();
                                                                
                //int a= Convert.ToInt32(textBox1.Text);

                string a = textBox1.Text.Trim();

                if ( count  == " + a + ")
                {
                    // MessageBox.Show("提示：密码验证正确！", "提示");
                    flag = 0;

                }
                else
                {
                    flag = 1;

                }
                if (flag == 1)
                {
                    MessageBox.Show("提示：密码错误！请重新输入", "警告");
                    textBox1.Text = "";
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("提示：密码验证异常！", "警告");
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == textBox2.Text)
                {
                    MessageBox.Show("提示：新密码与原密码重复！请重新输入！", "警告");
                    textBox2.Text = "";
                    return;
                }

                string npas = textBox2.Text.Trim();
                byte[] sarr = System.Text.Encoding.Default.GetBytes(npas);
                int len = sarr.Length;
                if (len < 6)
                {
                    MessageBox.Show("提示：新密码长度小于6位！请重新输入", "警告");
                    textBox2.Text = "";
                    return;
                }
                npsd = textBox2.Text.Trim();

            }
            catch (Exception)
            {
                MessageBox.Show("提示：新密码输入出错！", "警告");
            }
            finally
            {

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm borForm = new MainForm();
            this.Hide();
            borForm.Show();
        }

        private void PasForm_FormClosing(object sender, FormClosingEventArgs e)
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
