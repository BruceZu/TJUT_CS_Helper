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
    public partial class UForm : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");
        static int flag=0;
        public UForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "")
                {
                    MessageBox.Show("提示：请输入需要查询的账号！", "警告");
                    return;
                }

                conn.Open();

                if (flag==1)
                {
                    
                    string sqlStr = "select Sno,Sname,Ssex,Smajor,Sclass,Sphone from Student where Sno = '" + textBox1.Text.Trim() + "' ";
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                    DataSet dataSet1 = new DataSet();  //创建数据集对象
                    sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                    dataGridView1.DataSource = dataSet1.Tables[0];
                    dataGridView1.BackgroundColor = Color.LightGray;
                    this.dataGridView1.Columns[0].HeaderText = "学号";
                    this.dataGridView1.Columns[1].HeaderText = "姓名";
                    this.dataGridView1.Columns[2].HeaderText = "性别";
                    this.dataGridView1.Columns[3].HeaderText = "专业";
                    this.dataGridView1.Columns[4].HeaderText = "班级";
                    this.dataGridView1.Columns[5].HeaderText = "电话";
                    
                    return;
                }
                else if(flag==2)
                {
                    
                    string sqlStr = "select * from Teacher where Tno = '" + textBox1.Text.Trim() + "' ";
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                    DataSet dataSet1 = new DataSet();  //创建数据集对象
                    sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                    dataGridView1.DataSource = dataSet1.Tables[0];
                    dataGridView1.BackgroundColor = Color.LightGray;
                    this.dataGridView1.Columns[0].HeaderText = "教师编号";
                    this.dataGridView1.Columns[1].HeaderText = "姓名";
                    this.dataGridView1.Columns[2].HeaderText = "性别";
                    this.dataGridView1.Columns[3].HeaderText = "学院";
                    this.dataGridView1.Columns[4].HeaderText = "电话";
                   
                    return;
                }
                else if (flag == 3)
                {
                    
                    string sqlStr = "select * from Administrator where Aid = '" + textBox1.Text.Trim() + "' ";
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
                    DataSet dataSet1 = new DataSet();  //创建数据集对象
                    sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里

                    dataGridView1.DataSource = dataSet1.Tables[0];
                    dataGridView1.BackgroundColor = Color.LightGray;
                    this.dataGridView1.Columns[0].HeaderText = "管理员编号";
                    this.dataGridView1.Columns[1].HeaderText = "姓名";
                    this.dataGridView1.Columns[2].HeaderText = "性别";
                    this.dataGridView1.Columns[3].HeaderText = "电话";
                    
                    return;
                }
                else
                    MessageBox.Show("提示：请选择查询账号类型！", "提示");

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            flag = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admainForm borForm = new admainForm();
            this.Hide();
            borForm.Show();
        }

        private void UForm_FormClosing(object sender, FormClosingEventArgs e)
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
