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

namespace KTV前台
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter;
        private const string sqlcon = "Data Source=.;Initial Catalog=MyKTVHZ;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);    
        song[] songlist = new song[100];
        DataSet a = new DataSet();
        int r = 0;
        public Form1()
        {
            InitializeComponent();
        }
        #region 框的链接
        //KTV主页面（0）
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listView1.Visible = false;
            this.panel2.Visible = false;
            this.panel3.Visible = false;
            this.panel4.Visible = false;
            this.panel5.Visible = false;
            this.panel6.Visible = false;
            this.panel7.Visible = false;
            this.panel8.Visible = false;
            this.panel9.Visible = false;
            this.panel10.Visible = false;
            //axWindowsMediaPlayer1.URL = @"C:\Users\win-10\Music\ktv音乐\陈奕迅 - 十年.mkv.mkv";
            GetUrl();
            //url();
        }
        //歌星点歌类型（1）
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = true;
            this.panel3.Visible = false;
        }
        //歌星点歌页面退出
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //歌星点歌地区类型页面退出
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //歌星点歌地区类型页面首页
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
        }
        //歌星点歌地区类型页面返回
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
        }
        //歌星点歌大陆歌手跳转男女歌手分类页面（2）
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = true;
        }
        //歌星点歌大陆歌手跳转男女歌手分类页面退出
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //歌星点歌大陆歌手跳转男女歌手返回上一页
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
        }
        //歌星点歌大陆歌手跳转男女歌手返回首页
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
            this.panel2.Visible = false;
        }
        //歌星点歌男女歌手分类跳转男歌手页面（3）
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.panel4.Visible = true;
        }
        //歌星点歌男女歌手分类跳转男歌手页面退出
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //歌星点歌男歌手返回上一页
        private void pictureBox36_Click(object sender, EventArgs e)
        {
            this.panel4.Visible = false;
        }
        //歌星点歌男歌手返回首页
        private void pictureBox38_Click(object sender, EventArgs e)
        {
            this.panel4.Visible = false;
            this.panel3.Visible = false;
            this.panel2.Visible = false;
        }
        //歌星点歌跳转歌曲页面（4）
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.panel5.Visible = true;
        }
        //歌星点歌歌曲返回上一页退出
        private void pictureBox42_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //歌星点歌歌曲返回上一页
        private void pictureBox43_Click(object sender, EventArgs e)
        {
            this.panel5.Visible = false;
        }
        //歌星点歌歌曲返回首页
        private void pictureBox45_Click(object sender, EventArgs e)
        {
            this.panel5.Visible = false;
            this.panel4.Visible = false;
            this.panel3.Visible = false;
            this.panel2.Visible = false;
        }
        //拼音点歌(5)
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.panel6.Visible = true;
            sss();
        }
        //拼音点歌返回上一页退出
        private void pictureBox49_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //拼音点歌返回上一页
        private void pictureBox50_Click(object sender, EventArgs e)
        {
            this.panel6.Visible = false;
        }
        //拼音点歌返回首页
        private void pictureBox52_Click(object sender, EventArgs e)
        {
            this.panel6.Visible = false;
            this.panel2.Visible = false;
        }
        //曲种点歌(6)
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.panel7.Visible = true;
        }
        private void pictureBox56_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //曲种点歌返回上一页
        private void pictureBox57_Click(object sender, EventArgs e)
        {
            this.panel7.Visible = false;
            //SearchStuent();
        }
        //曲种点歌返回首页
        private void pictureBox59_Click(object sender, EventArgs e)
        {
            this.panel7.Visible = false;
            this.panel2.Visible = false;
        }
        //字数点歌(7)
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.panel8.Visible = true;
        }
        //字数点歌返回上一页退出
        private void pictureBox63_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //字数点歌返回上一页
        private void pictureBox64_Click(object sender, EventArgs e)
        {
            this.panel8.Visible = false;
        }
        //字数点歌返回首页
        private void pictureBox66_Click(object sender, EventArgs e)
        {
            this.panel8.Visible = false;
            this.panel2.Visible = false;
        }
        //歌曲排行(8)
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.panel9.Visible = true;
            ssss();
        }
        //歌曲排行返回上一页退出
        private void pictureBox70_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //歌曲排行返回上一页
        private void pictureBox71_Click(object sender, EventArgs e)
        {
            this.panel9.Visible = false;
        }
        //歌曲排行返回首页
        private void pictureBox73_Click(object sender, EventArgs e)
        {
            this.panel9.Visible = false;
            this.panel2.Visible = false;
        }
        #endregion
        #region 曲种查询
        //歌手查询
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            SearchStuent();
        }
        //歌手查询全部    
        public void SearchStuent()
        {
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select song_name,sing_name from dbo.song_info,dbo.sing_lnfo where dbo.song_info.sing_id=dbo.sing_lnfo.sing_id and sing_lnfo.sing_id='21'");
            SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a,"dbo.song_info");
            this.dataGridView1.DataSource = a.Tables["dbo.song_info"];
        }
        //拼音点歌查询
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            this.dataGridView2.AutoGenerateColumns = false;

        }
        //拼音点歌查询全部
        public void sss()
        {
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select dbo.song_info.song_name,dbo.sing_lnfo.sing_name from dbo.sing_lnfo,dbo.song_info where dbo.sing_lnfo.sing_id=dbo.song_info.sing_id");
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView2.DataSource = a.Tables["dbo.song_info"];
        }
        //曲种点歌查询
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            BindGrade();
            //comboBox2.SelectedIndex = 0;

            Search();
        }
        //曲种点歌查询全部
        public void Search()
        {
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select dbo.song_info.song_name,dbo.sing_lnfo.sing_name from dbo.sing_lnfo,dbo.song_info where dbo.sing_lnfo.sing_id=dbo.song_info.sing_id");
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView3.DataSource = a.Tables["dbo.song_info"];
        }
        //曲种点歌查询文本框
        public void BindGrade()
        {
            this.dataGridView3.AutoGenerateColumns = false;
            if (a.Tables["song_type"] != null)
            {
                a.Tables["song_type"].Clear();
            }
            // this.cbo2.DataSource = null;
            try
            {
                string sql = string.Format("select songtype_id,songtype_name from song_type");
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                //adapter = new SqlDataAdapter(sql, conn);
                //adapter.Fill(a, "song");
                //this.cbo2.DataSource = a.Tables["song"];
                //this.cbo2.ValueMember = "songtype_id";
                //this.cbo2.DisplayMember = "songtype_name";
                SqlDataReader myReader = com.ExecuteReader();
                //cbo2.Items.Add("请选择");
                while (myReader.Read())
                {
                    this.cbo2.Items.Add(myReader["songtype_name"]);
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
        //歌曲排行
        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            this.dataGridView4.AutoGenerateColumns = false;
        }
        public void ssss()
        {
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select dbo.sing_lnfo.sing_name,dbo.song_info.song_name ,dbo.song_info.song_piay_count from dbo.song_info,dbo.sing_lnfo where dbo.song_info.sing_id=dbo.sing_lnfo.sing_id ORDER BY song_piay_count desc");
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView4.DataSource = a.Tables["dbo.song_info"];
        }
        #endregion
        #region 拼音查询
        //拼音
        private void button1_Click_1(object sender, EventArgs e)
        {
            Searcho();
        }
        public void Searcho()
        {
            if (a.Tables["song_ab"] != null)
            {
                a.Tables["song_ab"].Clear();
            }
            string number1 = textBox1.Text;
            string number = string.Format("select song_name,sing_name from dbo.song_info,dbo.sing_lnfo where dbo.song_info.sing_id=dbo.sing_lnfo.sing_id and dbo.song_info.song_ab like '%{0}%'", number1);
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(number, conn);
                adapter.Fill(a, "song_ab");

                this.dataGridView2.DataSource = a.Tables["song_ab"];
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
        #endregion
        #region 字数查询
        private void label12_Click(object sender, EventArgs e)
        {
            this.dataGridView5.AutoGenerateColumns = false;
            one();
        }
        //1个字
        public void one()
        {
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select song_name,sing_name from dbo.song_info,dbo.sing_lnfo where dbo.song_info.sing_id=dbo.sing_lnfo.sing_id and song_word_count='1'");
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView5.DataSource = a.Tables["dbo.song_info"];
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有歌曲");
            }
        }
        //2个字
        private void label21_Click(object sender, EventArgs e)
        {
            this.dataGridView5.AutoGenerateColumns = false;
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select song_name,sing_name from dbo.song_info,dbo.sing_lnfo where dbo.song_info.sing_id=dbo.sing_lnfo.sing_id and song_word_count='2'");
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView5.DataSource = a.Tables["dbo.song_info"];
        }
        //3个字
        private void label13_Click(object sender, EventArgs e)
        {
            this.dataGridView5.AutoGenerateColumns = false;
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select song_name,sing_name from dbo.song_info,dbo.sing_lnfo where dbo.song_info.sing_id=dbo.sing_lnfo.sing_id and song_word_count='3'");
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView5.DataSource = a.Tables["dbo.song_info"];
        }
        //4个字
        private void label20_Click(object sender, EventArgs e)
        {
            this.dataGridView5.AutoGenerateColumns = false;
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select song_name,sing_name from dbo.song_info,dbo.sing_lnfo where dbo.song_info.sing_id=dbo.sing_lnfo.sing_id and song_word_count='4'");
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView5.DataSource = a.Tables["dbo.song_info"];
        }
        //5个字
        private void label14_Click(object sender, EventArgs e)
        {
            this.dataGridView5.AutoGenerateColumns = false;
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select song_name,sing_name from dbo.song_info,dbo.sing_lnfo where dbo.song_info.sing_id=dbo.sing_lnfo.sing_id and song_word_count='5'");
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView5.DataSource = a.Tables["dbo.song_info"];
        }
        //6个字
        private void label19_Click(object sender, EventArgs e)
        {
            this.dataGridView5.AutoGenerateColumns = false;
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select song_name,sing_name from dbo.song_info,dbo.sing_lnfo where dbo.song_info.sing_id=dbo.sing_lnfo.sing_id and song_word_count='6'");
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView5.DataSource = a.Tables["dbo.song_info"];
            if (dataGridView5.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有歌曲");
            }
        }
        #endregion
        #region 排行查询
        private void button2_Click(object sender, EventArgs e)
        {
            Leixing();
        }
        public void Leixing()
        {
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat(@"select dbo.sing_lnfo.sing_name,dbo.song_info.song_name from dbo.sing_lnfo 
INNER JOIN dbo.song_info ON(dbo.sing_lnfo.sing_id=dbo.song_info.sing_id)
INNER JOIN dbo.song_type ON(dbo.song_info.songtype_id=song_type.songtype_id)
where dbo.song_type.songtype_id='{0}'", this.cbo2.SelectedIndex + 1);
            adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView3.DataSource = a.Tables["dbo.song_info"];
        }
        #endregion
        #region 点歌到歌单
        //歌星点歌
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url3 = "";
            string iname = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                string sql = "select song_url from dbo.song_info where song_name='" + iname + "'";
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    url3 = reader["song_url"].ToString();
                }
                reader.Close();
                //利用for循环向数组中传值
                for (int a = 0; a < songlist.Length; a++)
                {
                    if (songlist[a] == null || songlist[a].SongName == "" || songlist[a].SongName == string.Empty)
                    {
                        songlist[a] = new song();
                        songlist[a].SongName = iname;
                        songlist[a].SongURL = url2 + "\\" + url3;
                        timer2.Enabled = true;
                        r++;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1");
            }
            finally
            {
                conn.Close();
            }
        }
        //拼音点歌
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url3 = "";
            string iname = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                string sql = "select song_url from dbo.song_info where song_name='" + iname + "'";
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    url3 = reader["song_url"].ToString();
                }
                reader.Close();
                //利用for循环向数组中传值
                for (int a = 0; a < songlist.Length; a++)
                {
                    if (songlist[a] == null || songlist[a].SongName == "" || songlist[a].SongName == string.Empty)
                    {
                        songlist[a] = new song();
                        songlist[a].SongName = iname;
                        songlist[a].SongURL = url2 + "\\" + url3;
                        timer2.Enabled = true;
                        r++;
                        break;
                    }
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1");
            }
            finally
            {
                conn.Close();
            }
        }
        //曲种点歌
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url3 = "";
            string iname = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                string sql = "select song_url from dbo.song_info where song_name='" + iname + "'";
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    url3 = reader["song_url"].ToString();
                }
                reader.Close();
                //利用for循环向数组中传值
                for (int a = 0; a < songlist.Length; a++)
                {
                    if (songlist[a] == null || songlist[a].SongName == "" || songlist[a].SongName == string.Empty)
                    {
                        songlist[a] = new song();
                        songlist[a].SongName = iname;
                        songlist[a].SongURL = url2 + "\\" + url3;
                        timer2.Enabled = true;
                        r++;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1");
            }
            finally
            {
                conn.Close();
            }
        }
        //字数点歌
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string url3 = "";
            string iname = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();         
            try
            {
                string sql = "select song_url from dbo.song_info where song_name='" + iname + "'";
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    url3 = reader["song_url"].ToString();
                }
                reader.Close();
                //利用for循环向数组中传值
                for (int a = 0; a < songlist.Length; a++)
                {
                    if (songlist[a] == null || songlist[a].SongName == "" || songlist[a].SongName == string.Empty)
                    {
                        songlist[a] = new song();
                        songlist[a].SongName = iname;
                        songlist[a].SongURL = url2 + "\\" + url3;
                        timer2.Enabled = true;
                        r++;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1");
            }
            finally
            {
                conn.Close();
            }
        }  
        //歌曲排行
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            string url3 = "";
            string iname = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            sssss(iname);
            try
            {
                string sql = "select song_url from dbo.song_info where song_name='" + iname + "'";
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    url3 = reader["song_url"].ToString();
                }
                reader.Close();
                //利用for循环向数组中传值
                for (int a = 0; a < songlist.Length; a++)
                {
                    if (songlist[a] == null || songlist[a].SongName == "" || songlist[a].SongName == string.Empty)
                    {
                        songlist[a] = new song();
                        songlist[a].SongName = iname;
                        songlist[a].SongURL = url2 +"\\"+ url3;
                        timer2.Enabled = true;
                        r++;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1");
            }
            finally
            {
                conn.Close();
            }
        }
        public void sssss(string song_name)
        {
            string sql = "update song_info set song_piay_count=song_piay_count+1 where song_name='"+song_name+"'";
            SqlCommand coom = new SqlCommand(sql, conn);
            conn.Open();
            coom.ExecuteNonQuery();
            conn.Close();
        }
        #endregion
        #region 已点歌曲
        private void pictureBox77_Click(object sender, EventArgs e)
        {
            this.panel10.Visible = true;
            this.listView1.Visible = true;
        }
        private void pictureBox77_DoubleClick(object sender, EventArgs e)
        {
            this.panel10.Visible = false;
            this.listView1.Visible = false;
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            this.panel10.Visible = true;
            this.listView1.Visible = true;
        }
        private void pictureBox23_DoubleClick(object sender, EventArgs e)
        {
            this.panel10.Visible = false;
            this.listView1.Visible = false;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            this.panel10.Visible = true;
            this.listView1.Visible = true;
        }
        private void pictureBox32_DoubleClick(object sender, EventArgs e)
        {
            this.panel10.Visible = false;
            this.listView1.Visible = false;
        }
        private void pictureBox39_Click(object sender, EventArgs e)
        {
            this.panel10.Visible = true;
            this.listView1.Visible = true;
        }
        private void pictureBox39_DoubleClick(object sender, EventArgs e)
        {
            this.panel10.Visible = false;
            this.listView1.Visible = false;
        }
        private void pictureBox46_Click(object sender, EventArgs e)
        {
            this.panel10.Visible = true;
            this.listView1.Visible = true;
        }
        private void pictureBox46_DoubleClick(object sender, EventArgs e)
        {
            this.panel10.Visible = false;
            this.listView1.Visible = false;
        }
        private void pictureBox53_Click(object sender, EventArgs e)
        {
            this.panel10.Visible = true;
            this.listView1.Visible = true;
        }
        private void pictureBox53_DoubleClick(object sender, EventArgs e)
        {
            this.panel10.Visible = false;
            this.listView1.Visible = false;
        }
        private void pictureBox60_Click(object sender, EventArgs e)
        {
            this.panel10.Visible = true;
            this.listView1.Visible = true;
        }
        private void pictureBox60_DoubleClick(object sender, EventArgs e)
        {
            this.panel10.Visible = false;
            this.listView1.Visible = false;
        }
        private void pictureBox67_Click(object sender, EventArgs e)
        {
            this.panel10.Visible = true;
            this.listView1.Visible = true;
        }
        private void pictureBox67_DoubleClick(object sender, EventArgs e)
        {
            this.panel10.Visible = false;
            this.listView1.Visible = false;
        }
        private void pictureBox74_Click(object sender, EventArgs e)
        {
            this.panel10.Visible = true;
            this.listView1.Visible = true;
        }
        private void pictureBox74_DoubleClick(object sender, EventArgs e)
        {
            this.panel10.Visible = false;
            this.listView1.Visible = false;
        }
        #endregion
        #region 歌单移除歌曲
        //int currentIndex = 0;
        private void 移除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.listView1.SelectedItems.Count > 0)//判断listview有被选中项
            //{
            //    currentIndex = this.listView1.SelectedItems[0].Index;//取当前选中项的index
            //    listView1.Items[currentIndex].Remove();
            //}
        }
        #endregion
        #region 获取当前时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.label93.Text = dt.ToString("yyyy-MM-dd HH:mm:ss");
        }
        #endregion   
        #region 歌曲重唱

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            videoStop();
            videoStart();
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            videoStop();
            videoStart();
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            videoStop();
            videoStart();
        }
        private void pictureBox34_Click(object sender, EventArgs e)
        {
            videoStop();
            videoStart();
        }
        private void pictureBox41_Click(object sender, EventArgs e)
        {
            videoStop();
            videoStart();
        }
        private void pictureBox48_Click(object sender, EventArgs e)
        {
            videoStop();
            videoStart();
        }
        private void pictureBox55_Click(object sender, EventArgs e)
        {
            videoStop();
            videoStart();
        }
        private void pictureBox62_Click(object sender, EventArgs e)
        {
            videoStop();
            videoStart();
        }
        private void pictureBox69_Click(object sender, EventArgs e)
        {
            videoStop();
            videoStart();
        }
        //播放
        public void videoStart()
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        //停止播放
        public void videoStop()
        {
            //axWindowsMediaPlayer1.currentPlaylist.clear();//清除列表
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        #endregion      
        #region 暂停播放
        private void pictureBox19_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBox19_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }
        #endregion
        //string URL;
        //public void url()
        //{
        //    string sql = "select resource_paty from dbo.resource_path where resource_type='歌曲'";
        //    conn.Open();
        //    SqlCommand mand = new SqlCommand(sql, conn);
        //    SqlDataReader read = mand.ExecuteReader();
        //    read.Read();
        //    URL = read["resource_paty"].ToString();
        //    read.Close();
        //    conn.Close();
        //}
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //string nane = listView1.SelectedItems[0].Text;
            //string sql = "select song_url from dbo.song_info where song_name='" + nane + "'";
            //SqlCommand mand = new SqlCommand(sql, conn);
            //conn.Open();
            //SqlDataReader read = mand.ExecuteReader();
            //read.Read();
            //axWindowsMediaPlayer1.URL = URL + read["song_url"];
            //read.Close();
            //conn.Close();
        }
         #region 实现切歌数组
            //所有歌曲存放路径
            string url2;
            public void GetUrl()
            {
                string sql = "select resource_paty from resource_path where resource_id=2";
                try
                {
                    SqlCommand com = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                    url2 = reader["resource_paty"].ToString();

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
        //计时器         
            private void timer2_Tick_1(object sender, EventArgs e)
            {
                if (listView1.Items != null)
                {
                    this.listView1.Items.Clear();
                }
                //将数组中的值传入已点歌曲
                for (int i = 0; i < songlist.Length; i++)
                {
                    if (songlist[i] != null)
                    {
                        ListViewItem lv = new ListViewItem();
                        lv.Text = songlist[i].SongName;
                        this.listView1.Items.Add(lv);
                    }
                }
                int s = Convert.ToInt32(this.axWindowsMediaPlayer1.playState);
                if (s == 1)
                {
                    for (int w = 0; w < songlist.Length; w++)
                    {
                        if (songlist[w] != null)
                        {
                            if (songlist[w + 1] == null)
                            {
                                r--;
                                songlist[w].SongName = "";
                                songlist[w].SongURL = "";
                                break;
                            }
                            songlist[w].SongName = songlist[w + 1].SongName;
                            songlist[w].SongURL = songlist[w + 1].SongURL;
                        }
                    }
                }
                if (s == 0 || s == 1 || s == 10)
                {
                    this.axWindowsMediaPlayer1.URL = songlist[0].SongURL;
                    toolStripTextBox1.Text = songlist[0].SongName;
                }
                string d = "待添加....";
                if (r > 1)
                {
                    toolStripTextBox2.Text = songlist[0 + 1].SongName;
                }
                else
                {
                    toolStripTextBox2.Text = d;
                }
                textBox2.Text = r.ToString();
            }
             #endregion
            #region 切歌
            //首页
            private void pictureBox18_Click(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            //歌曲排行
            private void pictureBox75_Click(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        //歌星点歌
            private void pictureBox24_Click(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            //歌星点歌
            private void pictureBox33_Click(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            //歌星点歌
            private void pictureBox40_Click(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            //歌星点歌
            private void pictureBox47_Click(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        //拼音点歌
            private void pictureBox54_Click(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        //曲种排行
            private void pictureBox61_Click(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        //字数排行
            private void pictureBox68_Click(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            #endregion

            private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
            {
            //    axWindowsMediaPlayer1.URL =@"C:\Users\win-10\Pictures\Camera Roll\张杰 - 我们都一样 (Live).mkv\";
            //    axWindowsMediaPlayer1.Ctlcontrols.play(); 
            }

            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
    }
    }

