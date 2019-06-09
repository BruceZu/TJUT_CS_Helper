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
    public partial class NForm : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");

        public NForm()
        {
            InitializeComponent();
        }
        //执行指定的SQL命令语句(insert,delete,update等),并返回命令所影响的行数

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string str_sql = "select * from Book where Bno='" + textBox1.Text.Trim() + "'";     
                SqlCommand cmd = new SqlCommand(str_sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    MessageBox.Show("提示：该书籍已存在！", "提示");
                    return;
                }
                 
                string str1 = textBox1.Text.Trim();
                string str2 = textBox2.Text.Trim();
                string str3 = textBox3.Text.Trim();
                string str4 = textBox4.Text.Trim();
                string str5 = textBox5.Text.Trim();
                string str6 = textBox6.Text.Trim();
                string str7 = textBox7.Text.Trim();
                string sqlStr = "insert into Book  values('" + str1 + "','" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "','" + str6 + "','" + str7 + "')";
                sdr.Close();
                SqlCommand sqlCommand2 = new SqlCommand(sqlStr, conn);  //执行SQL命令
                sqlCommand2.ExecuteNonQuery();
                MessageBox.Show("提示：入库成功！", "提示");
             
            }
            catch(Exception)
              {
                MessageBox.Show("警告：入库失败，请重试！", "警告");
            }
              finally
            {
                conn.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void NForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void NForm_FormClosing(object sender, FormClosingEventArgs e)
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
