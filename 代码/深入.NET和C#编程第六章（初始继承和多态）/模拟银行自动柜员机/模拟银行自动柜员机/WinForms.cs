using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 模拟银行自动柜员机
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();       
        }
        public void Beok() {
            this.lblmoney.Text = "";
            this.lbladmin.Text = "";
            this.lblName.Text = "";
            this.bntmoney.Enabled = false;
            this.bntmoney1.Enabled = false;
            this.bntmoney2.Enabled = false;
            this.txtName.Focus();
        }
        //储存内地卡
        List<LoginInfo> list = new List<LoginInfo>();
        //外地卡
        //List<Field_card> list1 = new List<Field_card>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            Beok();
            Mainland_card mainland_card = new Mainland_card("1","123","黄振",1000);
            Field_card field_card = new Field_card("2", "123", "张明", 2000);
            list.Add(mainland_card);
            list.Add(field_card);
        }
        //退出
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //登录
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtpwd.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空！", "温馨提示");
            }else
            {
                string id = txtName.Text;
                string pwd = txtpwd.Text;
                string a = this.txtName.Text;
                string name = lblName.Text;
                //内地卡
                foreach (LoginInfo item in list)
                {

                    if (item is Mainland_card)
                    {
                        if (item.Id == id && item.Password == pwd)
                        {
                            this.bntmoney.Enabled = true;
                            this.bntmoney1.Enabled = true;
                            this.bntmoney2.Enabled = true;
                            this.lbladmin.Text = a;
                            this.lblName.Text = item.Name;

                            break;
                        }
                        else if (item.Id != id && item.Password != pwd)
                        {
                            MessageBox.Show("用户名或密码不正确，请重新输入！", "温馨提示");
                            this.txtpwd.Clear();
                            this.txtName.Clear();
                        }

                    }
                    else 
                    {
                        this.bntmoney.Enabled = true;
                        this.bntmoney1.Enabled = true;
                        this.bntmoney2.Enabled = false;
                        this.lbladmin.Text = a;
                        this.lblName.Text = item.Name;
                    }

                }
            }
        }
        //退卡
        private void button5_Click(object sender, EventArgs e)
        {
            this.txtName.Clear();  
            this.txtmoney.Clear();
            this.txtmoney1.Clear();
            this.txtName1.Clear();
            this.txtpwd.Clear();
            this.lblmoney.Text = "";
            this.lbladmin.Text = "";
            this.lblName.Text = "";
            this.bntmoney.Enabled = false;
            this.bntmoney1.Enabled = false;
            this.bntmoney2.Enabled = false;
        }
        //查询余额
        private void bntmoney_Click(object sender, EventArgs e)
        {
            //内地卡
            foreach (LoginInfo item in list)
            {
                if (txtName.Text == item.Id)
                {
                    this.lblmoney.Text = item.Money.ToString();
                }
            }
        }
      
        private void bntmoney1_Click(object sender, EventArgs e)
        {
            //内地卡
            double money2 =double.Parse(this.txtmoney.Text);
            foreach (LoginInfo item in list)
            {
                if (txtName.Text == item.Id)
                {
                    double Result = item.Mong(money2);
                    this.lblmoney.Text = Result.ToString();
                    MessageBox.Show("取款成功！","温馨提示");
                }
            }
        }
        //转账
        private void bntmoney2_Click(object sender, EventArgs e)
        {
            double Ruk = double.Parse(this.txtmoney1.Text);
              foreach (LoginInfo item in list)
            {
            if (this.txtName1.Text==item.Id)
            {
             
                item.Money += Ruk;
            } if (this.txtName.Text == item.Id)
            {
                item.Money -= Ruk;
                this.lblmoney.Text = item.Money.ToString();
                MessageBox.Show("转账成功！", "温馨提示");
                this.txtmoney1.Clear();
                this.txtName1.Clear();
            }
            }
        }
    }
}
