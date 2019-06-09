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
    public partial class AddForm : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");

        public AddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string s1 = textBox1.Text.Trim();

                string str_sql = "select * from Book where Bno = '" + s1 + "' ";
                SqlCommand cmd = new SqlCommand(str_sql, conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {

                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("提示：请输入入库数量！", "提示");
                        return;
                    }

                    sdr.Close();
                    //string s2 = textBox2.Text.Trim();
                    int n = int.Parse(textBox2.Text);
                    //int n = 1;
                    string sqStr2 = "update Book set Bnumber+=" + n + " where Bno='" + s1 + "'";
                    SqlCommand sCommand2 = new SqlCommand(sqStr2, conn);  //执行SQL命令
                    sCommand2.ExecuteNonQuery();

                    MessageBox.Show("提示：入库成功！", "提示");
                    return;
                }
                else
                {
                    MessageBox.Show("警告：查询不到该书籍！", "警告");
                    return;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("警告：入库失败！", "警告");
            }
            finally
            {
                conn.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" )
                {
                    MessageBox.Show("提示：请输入书籍序列号！", "提示");
                    return;
                }

                conn.Open();
                string sqlStr = "select * from Book where Bno='" + textBox1.Text.Trim() + "' ";
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                DataSet dataSet1 = new DataSet();  //创建数据集对象
                sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                dataGridView1.DataSource = dataSet1.Tables[0];
                dataGridView1.BackgroundColor = Color.LightGray;
                this.dataGridView1.Columns[0].HeaderText = "书籍序列号";
                this.dataGridView1.Columns[1].HeaderText = "书名";
                this.dataGridView1.Columns[2].HeaderText = "类型";
                this.dataGridView1.Columns[3].HeaderText = "作者";
                this.dataGridView1.Columns[4].HeaderText = "出版社";
                this.dataGridView1.Columns[5].HeaderText = "价格";
                this.dataGridView1.Columns[6].HeaderText = "库存数量";
            }
            catch (Exception)
            {

                MessageBox.Show("警告：查询失败！", "警告");
            }
            finally
            {
                conn.Close();
            }
        }

        private void AddForm_Leave(object sender, EventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
