using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 第一章
{
    public partial class Form1 : Form
    {
        private const string sqlcon = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        public Form1()
        {
            InitializeComponent();
        }
        private void btnniun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定取消登录吗？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //清空所有信息
                this.tetName.Clear();
                this.tetpwd.Clear();
                this.cboName.SelectedIndex = -1;
            }
        }

        private void btuniu_Click(object sender, EventArgs e)
        {
            if (CheckInput()) {
                try {
                    conn.Open();
                    string sql = "select count(*) from Student where StudentNo='" + this.tetName.Text + "' and LoginPwd='" + this.tetpwd.Text + "'";
                    SqlCommand com = new SqlCommand(sql, conn);
                    int count = (int)com.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("登陆成功！", "操作提示");
                        Form2 test = new Form2();
                        test.tetName.Text = "欢迎您：" + this.tetName.Text;
                        test.Show();
                    }
                    else
                    {
                        MessageBox.Show("登陆失败！", "操作提示");
                        this.tetName.Clear();
                        this.tetpwd.Clear();
                        this.cboName.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                   finally
                {
                    conn.Close();
                }
            }

        }
        public bool CheckInput()
        {
            if (this.tetName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名","输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tetName.Focus();
                return false;
            }
            else if (this.tetpwd.Text.Trim().Equals(string.Empty))
            {
                    MessageBox.Show("请输入密码","输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tetpwd.Focus();
                    return false;
                }else if(this.cboName.Text.Trim().Equals(string.Empty)){
                  MessageBox.Show("请输入登录类型", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cboName.Focus();
                    return false;
                }
            else{
                 return true;
                }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

