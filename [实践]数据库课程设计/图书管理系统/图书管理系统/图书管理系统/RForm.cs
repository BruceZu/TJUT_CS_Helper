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
    public partial class RForm : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");
        static public string id;
        static public string bno;
        static public string time;
        static public string bstate;
        static public int state=0;
        static public DateTime retime;

        public RForm()
        {
            InitializeComponent();
        }

        private void RForm_Load(object sender, EventArgs e)
        {
            string sqlStr = "select * from Borrow where ID = '" + id.Trim() + "' ";
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

           /* DateTime td1 = DateTime.Now;
            TimeSpan costtime1 = td1 - retime;
            int t1 = costtime1.Days;
            if (t1 < 0)
            {
                string sqlStr3 = "update Borrow set Borrowstate= 2 where ID='" + id.Trim() + "'and Bno = '" + bno.Trim() + "'";
                SqlCommand sqlCommand3 = new SqlCommand(sqlStr3, conn);  //执行SQL命令
                sqlCommand3.ExecuteNonQuery();
            }
            */
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
                    time = dataGridView1.Rows[a].Cells["Returntime"].Value.ToString();
                    retime = DateTime.Parse(time);
                   

                    //判断是否超期
                    DateTime td1 = DateTime.Now;
                    TimeSpan costtime1 = td1 - retime;
                    int t1 = costtime1.Days;
                    if (t1 > 0)
                    {
                        string sqlStr3 = "update Borrow set Borrowstate=1 where ID='" + id.Trim() + "'and Bno = '" + bno.Trim() + "'";
                        SqlCommand sqlCommand3 = new SqlCommand(sqlStr3, conn);  //执行SQL命令
                        sqlCommand3.ExecuteNonQuery();

                        bstate = "1";
                    }
                    else
                    {
                        bstate = dataGridView1.Rows[a].Cells["Borrowstate"].Value.ToString();
                    }
          
                    state = Convert.ToInt32(bstate);

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
            conn.Open();      //打开数据库连接
            SqlCommand sqlCommand1 = new SqlCommand(sqlStr, conn);  //执行SQL命令
                                                                    // sqlCommand1.ExecuteNonQuery();
            int Succnum = sqlCommand1.ExecuteNonQuery();
            return Succnum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
              try
             {
                conn.Open();
                if (state==1)
                {
                    DateTime td = DateTime.Now;
                    TimeSpan costtime = td - retime;
                    int t = costtime.Days;
                    int  cost = 1 * t;
                    string message = string.Format("所选书籍已逾期！请去服务台交费还书！费用为：{0}元", cost);
                    MessageBox.Show(message, "计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //将对应账户的缴费金额进行更新
                     string sqlStr4 = "update Account set Cost+=" + cost + " where ID='" + id.Trim() + "'";
                     SqlCommand sqlCommand4 = new SqlCommand(sqlStr4, conn);  //执行SQL命令
                     sqlCommand4.ExecuteNonQuery(); 

                    string sqlStr1 = "select * from Borrow where ID = '" + id.Trim() + "' ";
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr1, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                    DataSet dataSet1 = new DataSet();  //创建数据集对象
                    sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                    dataGridView1.DataSource = dataSet1.Tables[0];

                    return ;
                }

                string sqlStr = "delete from Borrow where ID='" + id.Trim() + "'and Bno='" + bno.Trim() + "'";
                //SqlCommand sqlCommand2 = new SqlCommand(sqlStr, conn);  //执行SQL命令
                //sqlCommand2.ExecuteNonQuery();
                int Succnum = executeCommand(sqlStr);
                if (Succnum > 0)
                {       
                    //对表格信息进行更新
                    string sqlStr1 = "select * from Borrow where ID = '" + id.Trim() + "' ";
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr1, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                    DataSet dataSet1 = new DataSet();  //创建数据集对象
                    sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                    dataGridView1.DataSource = dataSet1.Tables[0];

                    //将对应书籍库存+1
                    string sqlStr2 = "update Book set Bnumber = Bnumber+1 where Bno='" + bno.Trim() + "'";
                    SqlCommand sqlCommand2 = new SqlCommand(sqlStr2, conn);  //执行SQL命令
                    sqlCommand2.ExecuteNonQuery();

                    string sqlStr3 = "update Account set Borrownum= Borrownum-1 where ID='" + id.Trim() + "'";
                    SqlCommand sqlCommand3 = new SqlCommand(sqlStr3, conn);  //执行SQL命令
                    sqlCommand3.ExecuteNonQuery();

                    MessageBox.Show("提示：还书成功！", "提示");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("提示：还书失败，请重试！", "警告");
            }
            finally
            {
                conn.Close();
                
                
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr1 = "select * from Borrow where ID = '" + id.Trim() + "' ";
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr1, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                DataSet dataSet1 = new DataSet();  //创建数据集对象
                sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                dataGridView1.DataSource = dataSet1.Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("提示：刷新失败，请重试！", "警告");
            }
            finally
            {
                conn.Close();

            }
        }

        private void RForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();
        }

        private void RForm_FormClosing(object sender, FormClosingEventArgs e)
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
