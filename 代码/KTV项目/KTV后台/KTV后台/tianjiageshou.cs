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
    public partial class tianjiageshou : Form
    {
        int number;
            private const string sqlcon = "Data Source=.;Initial Catalog=MyKTVHZ;User ID=sa;Pwd=abcdefg928";
            SqlConnection conn = new SqlConnection(sqlcon);
        public tianjiageshou()
        {
            InitializeComponent();
        }
        //最大框代码
        private void tianjia_Load(object sender, EventArgs e)
        {
            BindGrade();
            comboBox1.SelectedIndex = 0;
        }
        //文本添加歌手地区信息
        public void BindGrade()
        {
            try
            {
                conn.Open();
                string sql = "select * from sing_type";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader myReader = com.ExecuteReader();
                comboBox1.Items.Add("请选择");
                while (myReader.Read())
                {
                    this.comboBox1.Items.Add(myReader["singtype_name"]);
                }
                myReader.Close();
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
        //非空验证
        public bool CheckInput()
        {
            if (this.textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Focus();
                return false;
            }
            else if (this.comboBox1.Text.Trim() == "请选择")
            {
                MessageBox.Show("至少选择一个地名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.comboBox1.Focus();
                return false;
            }
            else if (this.comboBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入地名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.comboBox1.Focus();
                return false;
            }
            else if (this.txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入歌手描述", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        //添加歌手信息代码
        DataSet a = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string sing_name = textBox1.Text.Trim();
                string gender = String.Empty;
                if (radioButton1.Checked)
                {
                    gender = "男";
                }
                if (radioButton2.Checked)
                {
                    gender = "女";
                }
                if (radioButton3.Checked)
                {
                    gender = "组合";
                }
                string type = comboBox1.Text;              
                int typeid = ss();                
                string sing_ption = txtName.Text.Trim();
                string sql = string.Format("insert sing_lnfo(sing_name,sing_gend,singtype_id,sing_photo_urll,sing_ption) values('{0}','{1}',{2},'{3}','{4}')", sing_name, gender, typeid,path, sing_ption);
                try
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);
                    int sing_id = com.ExecuteNonQuery();
                    if (sing_id ==1)
                    {
                        MessageBox.Show("新增成功", "提示");
                        this.Close(); 
                    }
                    else
                    {
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
        //添加中歌手地区信息代码
        public int ss() {
            conn.Open();
           string type= comboBox1.Text;
            string sql = String.Format(@"select dbo.sing_type.singtype_id from dbo.sing_type where dbo.sing_type.singtype_name='{0}'", type);
         SqlCommand mand=new SqlCommand(sql,conn);
         SqlDataReader read = mand.ExecuteReader();
         
         while (read.Read())
         {
             number =Convert.ToInt32( read["singtype_id"]);
             
         }
         read.Close();
         conn.Close();
         return number;
        }
        //关闭按钮
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       //浏览按钮代码
        string path;
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Application.StartupPath;
            open.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName.ToString();
               
                pictureBox2.Image = Image.FromFile(path);
            }
        }      
        //修改语句
        private void button4_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {              
                string sing_name = textBox1.Text.Trim();
                string gender = String.Empty;
                if (radioButton1.Checked)
                {
                    gender = "男";
                }
                if (radioButton2.Checked)
                {
                    gender = "女";
                }
                if (radioButton3.Checked)
                {
                    gender = "组合";
                }            
                string type = comboBox1.Text; 
                int typeid = sss();
                string sing_ption = txtName.Text.Trim();             
                string sql = "UPDATE dbo.sing_lnfo SET sing_gend='" + gender + "',singtype_id='" + typeid + "',sing_photo_urll='" + path + "',sing_ption='" + sing_ption + "' where sing_name='" + sing_name + "'";
                try
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);
                    int sing_id = com.ExecuteNonQuery();
                    if (sing_id == 1)
                    {                    
                        MessageBox.Show("修改成功", "提示");                      
                        this.Close();                   
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示");
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
            }}
        //修改查询歌手地区语句
             public int sss() {
            conn.Open();
           string type= comboBox1.Text;
            string sql = String.Format(@"select dbo.sing_type.singtype_id from dbo.sing_type where dbo.sing_type.singtype_name='{0}'", type);
         SqlCommand mand=new SqlCommand(sql,conn);
         SqlDataReader read = mand.ExecuteReader();
         
         while (read.Read())
         {
             number =Convert.ToInt32( read["singtype_id"]);            
         }
         read.Close();
         conn.Close();
         return number;
        }           
        }
    }
