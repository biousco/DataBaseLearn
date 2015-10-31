using StudyBLL;
using StudyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin u = new Admin();
            u.AdminUser = this.textBox1.Text.ToString();
            u.AdminPwd = this.textBox2.Text.ToString();
            if(BLL.sysLogin(u) > 0)
            {
                this.label3.Text = "登录成功！马上进入管理平台...";
            } else
            {
                this.label3.Text = "用户或密码错误，请重新输入！";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
