using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 魔兽
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //登录
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtpwd.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空！", "温馨提示");
            }
            else {
                string Name = txtName.Text;
                string pwd = txtpwd.Text;     
                foreach(LoginInfo item in array){
                if(item!=null){
                if(item.Email==Name && item.Password==pwd){

                    Frmzhu aa = new Frmzhu();
                    aa.Show();
                    break;
                }

                }
            
                }
            }
            this.Hide();
        }
        //注册
        private void label4_Click(object sender, EventArgs e)
        {
            FrmRegist a = new FrmRegist();
            a.fi = this;
            a.Show();
            this.Hide();
        }
        public LoginInfo[] array;    
        private void Form1_Load(object sender, EventArgs e)
        {
            array = new LoginInfo[10];
            LoginInfo info1 = new LoginInfo();
            info1.Name = "黄振";
            info1.Id = "110";
            info1.Email = "1";
            info1.Password = "123";
            array[0] = info1;

        }
    }
}
