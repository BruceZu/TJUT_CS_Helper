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
    public partial class YuForm : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");
        static string id = "";
        static string bno = "";
        static string btime = "";
        static string rtime = "";
        static string state = "";

        public YuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "select * from Borrow where ID = '" + textBox1.Text.Trim() + "' ";
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
            DataSet dataSet1 = new DataSet();  //创建数据集对象
            sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

            dataGridView1.DataSource = dataSet1.Tables[0];
            dataGridView1.BackgroundColor = Color.LightGray;
            this.dataGridView1.Columns[0].HeaderText = "账号";
            this.dataGridView1.Columns[1].HeaderText = "书籍序列号";
            this.dataGridView1.Columns[2].HeaderText = "借书时间";
            this.dataGridView1.Columns[3].HeaderText = "到期时间";
            this.dataGridView1.Columns[4].HeaderText = "借阅状态";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                int CIndex = e.ColumnIndex; //获取当前列的索引
                if (CIndex == 0)

                {
                    int a = dataGridView1.CurrentRow.Index;
                     id = dataGridView1.Rows[a].Cells["ID"].Value.ToString();
                     bno = dataGridView1.Rows[a].Cells["Bno"].Value.ToString();               
                     btime= dataGridView1.Rows[a].Cells["Borrowtime"].Value.ToString();
                     rtime = dataGridView1.Rows[a].Cells["Returntime"].Value.ToString();
                     state = dataGridView1.Rows[a].Cells["Borrowstate"].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("提示：选择记录失败，请重试！", "提示");
            }
            finally
            {
                conn.Close();
            }
        }
        public static int executeCommand(string sqlStr)
        {
           
            SqlCommand sqlCommand1 = new SqlCommand(sqlStr, conn);  //执行SQL命令
                                                                    // sqlCommand1.ExecuteNonQuery();
            int Succnum = sqlCommand1.ExecuteNonQuery();
            return Succnum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
              try
              {
                if(id=="")
                {
                    MessageBox.Show("提示：请选择一条记录！", "提示");
                    return;
                }
                conn.Open();
                string sqlStr = "delete from Borrow where ID='" + id.Trim() + "'and Bno='" + bno.Trim() + "'";
                //SqlCommand sqlCommand2 = new SqlCommand(sqlStr, conn);  //执行SQL命令
                //sqlCommand2.ExecuteNonQuery();
                int Succnum = executeCommand(sqlStr);
                if (Succnum > 0)
                {
                    //对表格信息进行更新
                    string sqlStr1 = "select * from Borrow where ID = '" +id.Trim() + "' ";
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr1, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                    DataSet dataSet1 = new DataSet();  //创建数据集对象
                    sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                    dataGridView1.DataSource = dataSet1.Tables[0];

                    //将对应书籍库存+1
                    string sqlStr2 = "update Book set Bnumber = Bnumber+1 where Bno='" + bno.Trim() + "'";
                    SqlCommand sqlCommand2 = new SqlCommand(sqlStr2, conn);  //执行SQL命令
                    sqlCommand2.ExecuteNonQuery();

                    //将对应账号已借书量+1
                    string sqlStr3 = "update Account set Borrownum= Borrownum-1 where ID='" + id.Trim() + "'";
                    SqlCommand sqlCommand3 = new SqlCommand(sqlStr3, conn);  //执行SQL命令
                    sqlCommand3.ExecuteNonQuery();

                    MessageBox.Show("提示：还书成功！", "提示");
                }
              }
              catch (Exception)
              {
                MessageBox.Show("提示：还书失败，请重试！", "提示");
              }
              finally
              {
                conn.Close();
              }    
            // MessageBox.Show(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void YuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }
    }
}
