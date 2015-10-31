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

namespace ExecuteScaler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "Server=.\\SQLEXPRESS;Initial Catalog=study;Integrated Security=SSPI";
            //SQL语句，查询Student表中的记录数
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string sqlstring = "SELECT count(*) FROM admin where username = '" + username + "'and password = '" + password + "'";//集合函数count()的使用
            //建立连接对象
            SqlConnection conn = new SqlConnection(connstring);

            //建立数据命令对象
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            //打开连接
            conn.Open();

            //执行命令，返回影响的行数
            int o = (int)cmd.ExecuteScalar();
            if(o == 1)
            {
                label3.Text = "登录成功！！";
            } else
            {
                label3.Text = "用户名或密码错误";
            }
            
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
