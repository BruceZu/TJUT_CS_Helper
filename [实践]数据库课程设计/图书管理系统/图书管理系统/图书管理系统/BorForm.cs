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
    public partial class BorForm : Form
    {
        public BorForm()
        {
            InitializeComponent();
        }
        static string bno;
        static public string id;
        static public int  Bnumber;
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");

        private void BorForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“library_loan_management_systemDataSet.Book”中。您可以根据需要移动或删除它。
            this.bookTableAdapter.Fill(this.library_loan_management_systemDataSet.Book);

           

        }

        public static string getBno(string sqlStr)
        {
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
            DataSet dataSet1 = new DataSet();  //创建数据集对象
            sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里
            return dataSet1.Tables[0].Rows[0]["Bno"].ToString(); //把查询结果的第一行指定列下的数据以string类型返回
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            try
            {
                

                label3.Text = "";
                label5.Text = "";
                label7.Text = "";
                label9.Text = "";
                label11.Text = "";



                if (textBox1.Text == "")
                {
                    MessageBox.Show("提示：请输入需要查询的书名！", "警告");
                    return;
                }
                conn.Open();
                 //label11.Text = getBno("select Bno from Book where Bname like '%" + textBox1.Text.Trim() + "%'");

                string sqlStr = "select * from Book where Bname like '%" + textBox1.Text.Trim() + "%' ";
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

               // dataGridView1.DataSource = dataSet1.Tables[0].DefaultView; //把数据集中的查询结果绑定到dataGridView1中 

                // int a = dataGridView1.CurrentRow.Index;
               /* int a = 0;
                label3.Text = dataGridView1.Rows[a].Cells["Bno"].Value.ToString();
                label5.Text = dataGridView1.Rows[a].Cells["Bname"].Value.ToString();
                label7.Text = dataGridView1.Rows[a].Cells["Bpublish"].Value.ToString();
                label9.Text = dataGridView1.Rows[a].Cells["Bprice"].Value.ToString();
                label11.Text = dataGridView1.Rows[a].Cells["Bbumber"].Value.ToString(); // */


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
            private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("提示：已点击！", "提示");
            /*
            int a = dataGridView1.CurrentRow.Index;
            label3.Text = dataGridView1.Rows[a].Cells["Bno"].Value.ToString();
            label5.Text = dataGridView1.Rows[a].Cells["Bname"].Value.ToString();
            label7.Text = dataGridView1.Rows[a].Cells["Bpublish"].Value.ToString();
            label9.Text = dataGridView1.Rows[a].Cells["Bprice"].Value.ToString();
            label11.Text = dataGridView1.Rows[a].Cells["Bbumber"].Value.ToString(); // */
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("提示：已点击！", "提示");
            /* // 开关文本框的锁定，将表格内的数据显示到文本框内  
             int a = dataGridView1.CurrentRow.Index;
             label3.Text = dataGridView1.Rows[a].Cells["Bno"].Value.ToString();
             label5.Text = dataGridView1.Rows[a].Cells["Bname"].Value.ToString();
             label7.Text = dataGridView1.Rows[a].Cells["Bpublish"].Value.ToString();
             label9.Text = dataGridView1.Rows[a].Cells["Bprice"].Value.ToString();
             label11.Text = dataGridView1.Rows[a].Cells["Bbumber"].Value.ToString(); 
           // */


        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* int a = dataGridView1.CurrentRow.Index;
             label3.Text = dataGridView1.Rows[a].Cells["Bno"].Value.ToString();
             label5.Text = dataGridView1.Rows[a].Cells["Bname"].Value.ToString();
             label7.Text = dataGridView1.Rows[a].Cells["Bpublish"].Value.ToString();
             label9.Text = dataGridView1.Rows[a].Cells["Bprice"].Value.ToString();
             label11.Text = dataGridView1.Rows[a].Cells["Bbumber"].Value.ToString(); */

            string filename = dataGridView1.Rows[0].Cells["Bno"].Value.ToString();

            label3.Text = filename;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int CIndex = e.ColumnIndex; //获取当前列的索引
                if (CIndex == 0)

                {
                    int a = dataGridView1.CurrentRow.Index;
                    label3.Text = dataGridView1.Rows[a].Cells["Bno"].Value.ToString();
                    bno = label3.Text.Trim();
                    label5.Text = dataGridView1.Rows[a].Cells["Bname"].Value.ToString();
                    label7.Text = dataGridView1.Rows[a].Cells["Bpublish"].Value.ToString();
                    label9.Text = dataGridView1.Rows[a].Cells["Bprice"].Value.ToString();
                    label11.Text = dataGridView1.Rows[a].Cells["Bnumber"].Value.ToString();
                    Bnumber = Convert.ToInt32(label11.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("提示：选择图书失败，请重试！", "提示");
            }
            finally
            {
                conn.Close();
            }
        }

        //执行指定的SQL命令语句(insert,delete,update等),并返回命令所影响的行数
        public static int executeCommand(string sqlStr)
        {
           // conn.Open();      //打开数据库连接
            SqlCommand sqlCommand1 = new SqlCommand(sqlStr, conn);  //执行SQL命令
           // sqlCommand1.ExecuteNonQuery();
            int Succnum = sqlCommand1.ExecuteNonQuery();
            return Succnum;
        }


        private void button2_Click(object sender, EventArgs e)
        {
           try
            {
                string sqlStr5 = "select Borrownum from Account where ID='" + id.Trim() + "'";
            //SqlCommand sqlCommand5 = new SqlCommand(sqlStr5, conn);  //执行SQL命令
            // int num = Convert.ToInt32(sqlCommand5.ExecuteScalar().ToString());

               conn.Open();

               SqlCommand cmd = new SqlCommand(sqlStr5,conn);
               SqlDataReader sdr = cmd.ExecuteReader();
               sdr.Close();
               int count = Convert.ToInt32(cmd.ExecuteScalar());//count 就是你查询得到值， 比如你查看ID就得到你的ID值然后转换成Int类型 你可以对其进行赋值 计算 等等。
  

                //MessageBox.Show(val);

                if (count >= 3)
                {
                    MessageBox.Show("提示：已达到最大借书量！借书失败！", "提示");
                    return;
                } 

                //如果没有查询信息就不能借书
                if (label3.Text=="")
                {
                    return;
                }
                if(Bnumber==0)
                {
                    MessageBox.Show("提示：库存不足！", "提示");
                    return ;
                }

                //System.DateTime currentTime = new System.DateTime();
                DateTime dt = DateTime.Now;
                string str = dt.ToString();        //这是最直接的转化方法
                string str2 = dt.ToString("yyy-MM-dd");
                dt = dt.AddDays(30);  //可借书时间为30天
                string str3 = dt.ToString("yyy-MM-dd");

                // MessageBox.Show(bno + "," + id);

                //string  sqlStr = "insert into Borrow( ID , Bno,Borrowtime,Returntime,Borrowstate )values(id ,bno,str2,str3,1)";
                string sqlStr = "insert into Borrow(ID,Bno,Borrowtime,Returntime,Borrowstate ) values('" + id.Trim() + "','" + bno.Trim() + "','" + str2.Trim() + "','" + str3.Trim() + "',0)";
                // string sqlStr = "insert into Borrow(ID,Bno,Borrowtime,Returntime,Borrowstate ) values('123','002'," + str2.Trim() + "," + str3.Trim() + ",1)";
                 
                SqlCommand sqlCommand1 = new SqlCommand(sqlStr, conn);  //执行SQL命令
                                                               
                //执行指定的SQL命令语句,并返回命令所影响的行数
                int Succnum = executeCommand(sqlStr);
                if (Succnum > 0)
                {            
                    string sqlStr1 = "update Book set Bnumber = Bnumber-1 where Bno='" + bno.Trim() + "'";
                    SqlCommand sqlCommand2 = new SqlCommand(sqlStr1, conn);  //执行SQL命令
                    sqlCommand2.ExecuteNonQuery();

                    string sqlStr3 = "update Account set Borrownum = Borrownum+1 where ID='" + id.Trim() + "'";
                    SqlCommand sqlCommand3 = new SqlCommand(sqlStr3, conn);  //执行SQL命令
                    sqlCommand3.ExecuteNonQuery();

                    MessageBox.Show("提示：借书成功！", "提示");
                }

            }
            
            catch (Exception)
            {

                MessageBox.Show("提示：您已经借过该书籍了！", "提示");
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();
        }

        private void BorForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BorForm_Leave(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();
        }
    }
}
