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
    public partial class geshouchaxun : Form
    {
        int ee;
        private const string sqlcon = "Data Source=.;Initial Catalog=MyKTVHZ;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        public geshouchaxun()
        {
            InitializeComponent();
        }
        //最大框
        private void geshouchaxun_Load(object sender, EventArgs e)
        {
            BindGrade();
            comboBox1.SelectedIndex = 0;
            this.dataGridView1.AutoGenerateColumns = false;
            SearchStuent();
        }
        //组合框内容
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
        //得到全部数据库值
        DataSet a = new DataSet();
        public void SearchStuent()
        {
            if (a.Tables["sing_lnfo"] != null)
            {
                a.Tables["sing_lnfo"].Clear();
            }
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select sing_lnfo.*,sing_type.* from sing_lnfo,sing_type where sing_lnfo.singtype_id=sing_type.singtype_id ");
            SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), conn);         
            adapter.Fill(a, "sing_lnfo");
            this.dataGridView1.DataSource = a.Tables["sing_lnfo"];
        }
        private void btnchaxun_Click(object sender, EventArgs e)
        {
            Search();
        }
        //模糊查询
        public int s() {
            string number1=comboBox1.Text;
            string number = string.Format("select dbo.sing_type.singtype_id from dbo.sing_type where dbo.sing_type.singtype_name='{0}'", number1);
                conn.Open();
                SqlCommand cc = new SqlCommand(number, conn);
                SqlDataReader read1 = cc.ExecuteReader();
                while (read1.Read())
                {
                    ee = Convert.ToInt32(read1["singtype_id"]);
                }
                read1.Close();          
                conn.Close();
                return ee;
        }
        public void Search()
        {         
           DataView dv = new DataView(a.Tables["sing_lnfo"]);
            string name = this.txtName.Text;        
            int i = s();
            dv.RowFilter = string.Format(" sing_name like '%{0}%' and  singtype_id={1}", name,i);
            this.dataGridView1.DataSource = dv;

        }
      //退出按钮
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //删除语句
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {      
             DialogResult choice;
            choice=MessageBox.Show("确定要删除吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (choice == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                   int sing_id =Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["sing_id"].Value);
                    try
                    {
                        conn.Open();
                        string sql = string.Format("delete from dbo.song_info where sing_id='{0}'", sing_id);
                        SqlCommand com = new SqlCommand(sql, conn);
                        com.ExecuteNonQuery();
                        sql = string.Format("delete from sing_lnfo where sing_id='{0}'", sing_id);
                        com.CommandText = sql;
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
        //右键修改歌手
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tianjiageshou f = new tianjiageshou();
            f.button1.Visible = false;
            f.Show();         
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            f.textBox1.Text = name;
           f. textBox1.ReadOnly = true;
            string typeid = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            f.comboBox1.Text = typeid.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Equals("男"))
            {
                f.radioButton1.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Equals("女"))
            {
                f.radioButton2.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Equals("组合"))
            {
                f.radioButton3.Checked = true;
            }        
            string miaoshu = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            f.txtName.Text = miaoshu;        
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tianjiagequ t = new tianjiagequ();
            t.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            t.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        }
    }

