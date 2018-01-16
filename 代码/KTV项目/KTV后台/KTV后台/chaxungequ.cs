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
    public partial class chaxungequ : Form
    {
        int ee;
        private const string sqlcon = "Data Source=.;Initial Catalog=MyKTVHZ;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        public chaxungequ()
        {
            InitializeComponent();
        }
        //最大框代码
        private void chaxungequ_Load(object sender, EventArgs e)
        {
            BindGrade();
            comboBox1.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false;
            SearchStuent();
        }
        //查询全部信息
        DataSet a = new DataSet();
        string ss = "";
        public void SearchStuent()
        {
            if (a.Tables["dbo.song_info"] != null)
            {
                a.Tables["dbo.song_info"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select dbo.song_info.*,song_type.* ,sing_lnfo.* from dbo.song_info,song_type,sing_lnfo where dbo.song_info.songtype_id=song_type.songtype_id and song_info.sing_id=sing_lnfo.sing_id");
            sql.AppendFormat(ss);
          
            SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "dbo.song_info");
            this.dataGridView1.DataSource = a.Tables["dbo.song_info"];
        }
        //文本框添加歌曲类型
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
                   // this.comboBox1.ValueMember = Reader["songtype_id"].ToString();
                    
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
        //查询按钮
        private void btnchaxun_Click(object sender, EventArgs e)
        {
            Search();
            SearchStuent();
        }
        //查询
        public int s()
        {
            string number1 = comboBox1.Text;
            string number = string.Format("select songtype_id from song_type where songtype_name='{0}'", number1);
            conn.Open();
            SqlCommand cc = new SqlCommand(number, conn);
            SqlDataReader read1 = cc.ExecuteReader();
            while (read1.Read())
            {
                ee = Convert.ToInt32(read1["songtype_id"]);
            }
            read1.Close();
            conn.Close();
            return ee;
        }
        //模糊查询
        public void Search()
        {
           // DataView dv = new DataView(a.Tables["song_info"]);
            string name = this.txtName.Text;
            int i = s();
            ss = string.Format(" and song_name like '%{0}%' and  song_type.songtype_id={1}", name, i);
            //this.dataGridView1.DataSource = dv;
        }
        //右键删除代码
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult choice;
            choice = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           
            if (choice == DialogResult.Yes)
            {
                
                if (dataGridView1.SelectedRows.Count > 0)
                {
               
                    int song_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["song_id"].Value);
                    try
                    {
                        conn.Open();
                        string sql = string.Format("delete from dbo.song_info where song_id='{0}'", song_id);
                        SqlCommand com = new SqlCommand(sql, conn);                      
                      //  sql = string.Format("delete from sing_lnfo where sing_id='{0}'", sing_id);
                        //com.CommandText = sql;
                        int result = com.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("删除成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SearchStuent();
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
        }
        //右键退出
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //右键修改代码
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tianjiagequ f = new tianjiagequ();
            f.button3.Visible = false;
            f.Show();
            string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            f.textBox1.Text = name;
            f.textBox1.ReadOnly = true;
            string typeid = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            f.textBox4.Text = typeid.ToString();
            string miaosh = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            f.comboBox1.Text = miaosh;
            string miao = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            f.textBox2.Text = miao;
            string miaos = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            f.textBox3.Text = miaos;
        }
    }
}
