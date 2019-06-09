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
    public partial class ResetForm : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");

        public ResetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = "select ID,Password from Account where ID = '" + textBox1.Text.Trim() + "' ";
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                DataSet dataSet1 = new DataSet();  //创建数据集对象
                sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                dataGridView1.DataSource = dataSet1.Tables[0];
                dataGridView1.BackgroundColor = Color.LightGray;
                this.dataGridView1.Columns[0].HeaderText = "账号";
                this.dataGridView1.Columns[1].HeaderText = "密码";
            }
            catch (Exception)
            {
                MessageBox.Show("提示：查询失败，请重试！", "提示");
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr2 = "update Account set Password = '000000' where ID='" + textBox1.Text.Trim() + "'";
                SqlCommand sqlCommand2 = new SqlCommand(sqlStr2, conn);  //执行SQL命令
                sqlCommand2.ExecuteNonQuery();

                MessageBox.Show("提示：重置密码成功！", "提示");

            }
            catch (Exception)
            {
                MessageBox.Show("提示：重置密码失败，请重试！", "提示");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void ResetForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ResetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }
    }
}
