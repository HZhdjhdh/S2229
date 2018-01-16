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

namespace KTV后台
{
    public partial class denglu : Form
    {
        private const string sqlcon = "Data Source=.;Initial Catalog=MyKTVHZ;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        public denglu()
        {
            InitializeComponent();
        }
        //登录操作
        private void btndeng_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    conn.Open();
                    string sql = "select count(*) from dbo.denglumima where adminNo='" + this.txtzhang.Text + "' and adminpwd='" + this.txtmima.Text + "'";
                    SqlCommand com = new SqlCommand(sql, conn);
                    int count = (int)com.ExecuteScalar();
                    if (count > 0)
                    {
                        this.Hide();
                        chaxun a = new chaxun();
                        a.Show();
                    }
                    else
                    {
                        MessageBox.Show("登陆失败！", "操作提示");
                        this.txtzhang.Clear();
                        this.txtmima.Clear();
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
        //非空验证
        public bool CheckInput()
        {
            if (this.txtzhang.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtzhang.Focus();
                return false;
            }
            else if (this.txtmima.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtmima.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        //取消按钮登录
        private void btnqu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定取消登录吗？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //清空所有信息
                this.txtzhang.Clear();
                this.txtmima.Clear();
            }

        }

        private void denglu_Load(object sender, EventArgs e)
        {

        }

    }
}
