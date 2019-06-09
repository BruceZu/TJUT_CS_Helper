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
    public partial class Login : Form
    {
        public string gvUser = "";
       
        public Login()
        {
            InitializeComponent();
        }
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Library loan management system;Persist Security Info=True;User ID=sa;Password=wangfan418");


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("提示：请输入用户名和密码！", "警告");
                return;
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("提示：请输入账号！", "警告");
                    return;
                }
                else
                    MessageBox.Show("提示：请输入密码！", "警告");
                    return;

            }

            conn.Open();

            string str_sql = "select * from Account where ID = '" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(str_sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {

                /* SqlDataAdapter da = new SqlDataAdapter("select * from Account", conn);
                 DataSet ds = new DataSet();
                 da.Fill(ds);//取出连接库里某张表的数据。
                 Session["Atype"] = ds.Tables[0].Rows[0][0].ToString().Trim();  //将取出的数据第一行的某字段赋值给Session["st_user"]
                 string str = Session["st_user"].ToString(); */
                sdr.Close();
                string sqlstr = "select Atype from Account where ID = '" + textBox1.Text.Trim() + "'";
                string s = queryData(sqlstr);

                if (radioButton1.Checked == true)
                {
                    if (s =="1")
                    {
                        MessageBox.Show("登录成功!", "提示");
                        MainForm mainform = new MainForm();
                        mainform.gvUser = textBox1.Text;
                        BorForm.id = textBox1.Text.Trim();
                        RForm.id = textBox1.Text.Trim();
                        InForm.id = textBox1.Text.Trim();
                        PasForm.id= textBox1.Text.Trim();
                        this.Hide();
                        mainform.Show();
                    }
                    else
                        MessageBox.Show("所选类型与账号不匹配!", "警告");

                }
                else if (radioButton2.Checked == true)
                {
                    if (s == "2")
                    {
                        MessageBox.Show("登录成功!", "提示");
                        admainForm adform = new admainForm();
                        adform.gvUser = textBox1.Text;
                        this.Hide();
                        adform.Show();
                    }
                    else
                        MessageBox.Show("所选类型与账号不匹配!", "警告");
                }
                else
                    MessageBox.Show("提示：请选择账户类型!", "警告");
            }

            else
            {
                MessageBox.Show("提示：用户名或密码错误!", "警告");
                textBox1.Text = "";
                textBox2.Text = "";

            }
            conn.Close();

        }
        public static string queryData(string sqlStr)
        {
            //conn.Open();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlStr, conn);//利用已创建好的sqlConnection1,创建数据适配器sqlDataAdapter1
            DataSet dataSet1 = new DataSet();  //创建数据集对象
            sqlDataAdapter1.Fill(dataSet1);    //执行查询,查询的结果存放在数据集里
            //conn.Close();
            return dataSet1.Tables[0].Rows[0]["Atype"].ToString(); //把查询结果的第一行指定列下的数据以string类型返回
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
                textBox2.PasswordChar = '*';

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RgForm borForm = new RgForm();
            this.Hide();
            borForm.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
