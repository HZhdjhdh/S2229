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
    public partial class tianjiagequ : Form
    {
        int number;
        private const string sqlcon = "Data Source=.;Initial Catalog=MyKTVHZ;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        public tianjiagequ()
        {
            InitializeComponent();
        }
        //主事件
        private void tianjiagequ_Load(object sender, EventArgs e)
        {
            show();
            textBox2.Text = Text;
            BindGrade();
            comboBox1.SelectedIndex = 0;
            this.listView1.Visible = false;
        }
        //文本框添加数值
        public void BindGrade()
        {
            try
            {
                conn.Open();
                string sql = "select * from song_type";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader Reader = com.ExecuteReader();
                comboBox1.Items.Add("请选择");
                while (Reader.Read())
                {
                    this.comboBox1.Items.Add(Reader["songtype_name"]);
                }
                Reader.Close();
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
        public bool Yanzheng()
        {
            if (this.textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入歌曲名称", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox1.Focus();
                return false;
            }
            else if (this.textBox4.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入歌曲拼音缩写", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox4.Focus();
                return false;
            }
            else if (this.comboBox1.Text.Trim() == "请选择")
            {
                MessageBox.Show("请至少选择一个歌曲类型", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.comboBox1.Focus();
                return false;
            }
            else if (this.comboBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择歌曲类型", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.comboBox1.Focus();
                return false;
            }
            else if (this.textBox2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请查询一位歌手", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Focus();
                return false;
            }
            else if (this.textBox3.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入歌曲文件名", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox3.Focus();
                return false;
            }
            return true;
        }
        //保存按钮
        private void button3_Click(object sender, EventArgs e)
        {
            if (Yanzheng())
            {
                string song_name = textBox1.Text.Trim();
                string song_ab = textBox4.Text.Trim();
                string songtype_id = comboBox1.Text;
                int typeid = ss();
                string sing_name = textBox2.Text;
                int type = sss();
                string song_url = textBox3.Text.Trim();
                string sql = string.Format("insert dbo.song_info(song_name,song_ab,songtype_id,sing_id,song_url) values('{0}','{1}','{2}','{3}','{4}')", song_name, song_ab, typeid, type, song_url);
                try
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);
                    int song_id = com.ExecuteNonQuery();
                    if (song_id == 1)
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
        public int ss()
        {
            conn.Open();
            string songtype_id = comboBox1.Text;
            string sql = String.Format(@"select dbo.song_type.songtype_id from dbo.song_type where dbo.song_type.songtype_name='{0}'", songtype_id);
            SqlCommand mand = new SqlCommand(sql, conn);
            SqlDataReader read = mand.ExecuteReader();

            while (read.Read())
            {
                number = Convert.ToInt32(read["songtype_id"]);
            }
            read.Close();
            conn.Close();
            return number;
        }
        public int sss()
        {
            conn.Open();
            string sing_name = textBox2.Text;
            string sql = String.Format(@"select sing_lnfo.sing_id from dbo.sing_lnfo,dbo.song_info where dbo.sing_lnfo.sing_id=dbo.song_info.sing_id and dbo.sing_lnfo.sing_name='{0}'", sing_name);
            SqlCommand mand = new SqlCommand(sql, conn);
            SqlDataReader read = mand.ExecuteReader();
            while (read.Read())
            {
                number = Convert.ToInt32(read["sing_id"]);
            }
            read.Close();
            conn.Close();
            return number;
        }
        //查询歌手按钮
        private void button1_Click(object sender, EventArgs e)
        {
            this.listView1.Visible = true;
        }
        //浏览按钮事件
        //string path;
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            string songFileName = openFileDialog1.SafeFileName;
            int index = songFileName.LastIndexOf(".");
            //点击确定
            if (result == DialogResult.OK)
            {
                //获得文件名
                textBox3.Text = songFileName;
            }
            //OpenFileDialog open = new OpenFileDialog();
            //open.InitialDirectory = Application.StartupPath;
            //open.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    path = open.FileName.ToString();
            //    textBox3.Text = path;
            //}
        }
        //修改按钮
        private void button5_Click(object sender, EventArgs e)
        {
            if (Yanzheng())
            {
                string song_name = textBox1.Text.Trim();
                string song_ab = textBox4.Text.Trim();              
                string songtype_id = comboBox1.Text;
                int typeid = dd();
                string sing_name = textBox2.Text;
                int type = ddd();
                string song_url = textBox3.Text.Trim();
                string sql = "UPDATE dbo.song_info SET song_ab='" + song_ab + "',songtype_id='" + typeid + "',sing_id='" + type + "',song_url='" + song_url + "' where song_name='" + song_name + "'";
                try
                {
                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);
                    int song_id = com.ExecuteNonQuery();
                    if (song_id == 1)
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
            } 
        }
        public int dd()
        {
            conn.Open();
            string songtype_id = comboBox1.Text;
            string sql = String.Format(@"select dbo.song_type.songtype_id from dbo.song_type where dbo.song_type.songtype_name='{0}'", songtype_id);
            SqlCommand mand = new SqlCommand(sql, conn);
            SqlDataReader read = mand.ExecuteReader();
            while (read.Read())
            {
                number = Convert.ToInt32(read["songtype_id"]);
            }
            read.Close();
            conn.Close();
            return number;
        }
        public int ddd()
        {
            conn.Open();
            string sing_name = textBox2.Text;
            string sql = String.Format(@"select sing_lnfo.sing_id from dbo.sing_lnfo,dbo.song_info where dbo.sing_lnfo.sing_id=dbo.song_info.sing_id and dbo.sing_lnfo.sing_name='{0}'", sing_name);
            SqlCommand mand = new SqlCommand(sql, conn);
            SqlDataReader read = mand.ExecuteReader();
            while (read.Read())
            {
                number = Convert.ToInt32(read["sing_id"]);
            }
            read.Close();
            conn.Close();
            return number;
        }
        //关闭按钮
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
        }
        public void show() 
        {
            try
            {
                conn.Open();
                string sql = "select sing_id,sing_name from dbo.sing_lnfo";
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader reader = com.ExecuteReader();               
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["sing_id"]);
                    string name = reader["sing_name"].ToString();
                    ListViewItem item = new ListViewItem(Convert.ToString(id));
                    item.SubItems.Add(name);
                    this.listView1.Items.Add(item);
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }          
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string name = this.listView1.SelectedItems[0].SubItems[1].Text;
            this.textBox2.Text = name;         
            this.listView1.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
