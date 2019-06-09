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
    public partial class DisaForm : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");


        public DisaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = "select * from Account where ID = '" + textBox1.Text.Trim() + "' ";
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                DataSet dataSet1 = new DataSet();  //创建数据集对象
                sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                dataGridView1.DataSource = dataSet1.Tables[0];
                dataGridView1.BackgroundColor = Color.LightGray;
                this.dataGridView1.Columns[0].HeaderText = "账号";
                this.dataGridView1.Columns[1].HeaderText = "密码";
                this.dataGridView1.Columns[2].HeaderText = "用户类型";
                this.dataGridView1.Columns[3].HeaderText = "累计已借书";
                this.dataGridView1.Columns[4].HeaderText = "需缴费";
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

        private void button3_Click(object sender, EventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr3 = "delete from Account  where ID='" + textBox1.Text.Trim() + "'";
                SqlCommand sqlCommand3 = new SqlCommand(sqlStr3, conn);  //执行SQL命令
                sqlCommand3.ExecuteNonQuery();

                MessageBox.Show("提示：该账户已注销！", "提示");

            }
            catch (Exception)
            {
                MessageBox.Show("提示：该账户有未还书籍！", "提示");
            }
            finally
            {
                conn.Close();
            }

        }

        private void DisaForm_Load(object sender, EventArgs e)
        {

        }

        private void DisaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void DisaForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
