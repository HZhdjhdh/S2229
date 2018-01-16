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

namespace 第二章
{
    public partial class Form2 : Form
    {
        private const string sqlcon = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        public Form2()
        {
            InitializeComponent();
        }
        private void btnbao_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string LoginPwd = txtped.Text.Trim();
                string StudentName = txtName.Text.Trim();
                int Sex = 0;
                if (rdoboy.Checked)
                {
                    Sex = 1;
                }
                else
                {
                    Sex = 0;
                }
                int GradeId = GreadId();
                string Phone = txtPhone.Text.Trim();
                string Address = txtAddress.Text.Trim();
                DateTime BornDate = dtpDate.Value;
                string Email = txtEmail.Text.Trim();
                string sql = string.Format("insert into Student2 values('{0}','{1}',{2},{3},'{4}','{5}','{6}','{7}')", LoginPwd, StudentName, Sex, GradeId, Phone, Address, BornDate, Email);
                try
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);
                    //int i = com.ExecuteNonQuery();
                    int StudentNo =com.ExecuteNonQuery();
                    if (StudentNo > 0)
                    {
                        MessageBox.Show("新增成功", "提示");
                        //txtStudent.Text = StudentNo + "";
                    }
                    else {
                        MessageBox.Show("新增失败", "提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            if (this.txtped.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtped.Focus();
                return false;
            }
            else if (this.txtpwd1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请再次输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpwd1.Focus();
                return false;
            }
            else if (this.txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return false;
            }
            else if (this.cbogread.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择年级", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbogread.Focus();
                return false;
            }
            else if (this.cbogread.Text.Trim()=="请选择")
            {
                MessageBox.Show("至少选择一个年级", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbogread.Focus();
                return false;
            }
            else if (this.txtPhone.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入电话", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPhone.Focus();
                return false;
            }
            else if (!this.txtped.Text.Trim().Equals(this.txtpwd1.Text.Trim()))
            {
                MessageBox.Show("两次密码不正确", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpwd1.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            BindGrade();
            cbogread.SelectedIndex = 0;
        }   
        //添加年级
        public void BindGrade() {
            try
            {
                conn.Open();
                string sql = "select * from Grade";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader myReader = com.ExecuteReader();
                cbogread.Items.Add("请选择");
                while (myReader.Read()) {
                    this.cbogread.Items.Add(myReader["GradeName"]);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
        }
        //根据年级名称查询年级名称
        public int GreadId() {
            string sql =string.Format( "select GradeId from Grade where GradeName='{0}'",cbogread.Text);
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                int i = Convert.ToInt32(com.ExecuteScalar());
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally {
                conn.Close();
            }
        }

        private void cbogread_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
        }
    }

