using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV后台
{
    public partial class geshoutuplujing : Form
    {
        private const string sqlcon = "Data Source=.;Initial Catalog=MyKTVHZ;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        public geshoutuplujing()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialong = new FolderBrowserDialog();
            if (dialong.ShowDialog() == DialogResult.OK)
            {
                this.textBox5.Text = dialong.SelectedPath;
            }
        }
        private void geshoutuplujing_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select resource_paty from dbo.resource_path where resource_type='图片'";
                SqlCommand com = new SqlCommand(sql,conn);
                conn.Open();
                SqlDataReader read = com.ExecuteReader();
                if (read.Read())
                {
                    this.textBox4.Text = read["resource_paty"].ToString();
                }
                read.Close();
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string path3 = this.textBox4.Text;
            string path4 = this.textBox5.Text;
            string[] files = Directory.GetFiles(path3);
            foreach (string file in files)
            {
                string f = file;
                string g = f.Substring(f.LastIndexOf("\\") + 1, (f.Length) - 1 - f.LastIndexOf("\\"));
                File.Move(file, path4 + "\\" + g);
            }

            DialogResult choice;
            choice = MessageBox.Show("确定要更改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            string pata = textBox5.Text.Trim();
            string sql = "UPDATE dbo.resource_path SET resource_paty='" + pata + "' where resource_id=1";
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                int resource_id = com.ExecuteNonQuery();
                if (resource_id >0)
                {
                    MessageBox.Show("更新成功", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("更新失败", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
        }
    }
}
