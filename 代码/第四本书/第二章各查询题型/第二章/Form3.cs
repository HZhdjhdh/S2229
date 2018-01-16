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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private const string sqlcon = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        private void Form3_Load(object sender, EventArgs e)
        {
            this.FillListView();
            this.lvQQ.View = View.Details;
        }
        public void FillListView() { 
           //if(lvQQ.Items.Count>0){
           //    lvQQ.Items.Clear();
           //}
           
           string sql = string.Format("select s.StudentNo,s.StudentName,s.Sex,g.GradeName from Student AS s join Grade AS g on(s.GradeId=g.GradeId) where s.StudentName like '%{0}%'", textBox1.Text);
           try
           {
               conn.Open();
               SqlCommand com = new SqlCommand(sql, conn);
               SqlDataReader Reader = com.ExecuteReader();
               if (Reader.HasRows)
               {
                   lvQQ.Items.Clear();
                   while (Reader.Read())
                   {
                       string StudentNo = Reader["StudentNo"].ToString();
                       string StudentName = Reader["StudentName"].ToString();
                       string Sex = Reader["Sex"].ToString();
                       string GradeName = Reader["GradeName"].ToString();
                       ListViewItem live = new ListViewItem(StudentNo);
                       live.SubItems.Add(StudentName);
                       live.SubItems.Add(Sex);
                       live.SubItems.Add(GradeName);
                       this.lvQQ.Items.Add(live);
                   }
               }
               else
               {
                   MessageBox.Show("没有要查找的记录！", "温馨提示",MessageBoxButtons.OKCancel);
               }
               Reader.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
           }
           finally {
               conn.Close();
           }
        }     
        //查找
        private void btncha_Click(object sender, EventArgs e)
        {
            FillListView();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Student = this.lvQQ.SelectedItems[0].SubItems[0].Text;
            MessageBox.Show(Student);
            DialogResult result = MessageBox.Show("想好要删除吗？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {

                    string sql = "DELETE from Student where StudentNo='" + Student + "'";
                    conn.Open();
                    SqlCommand com = new SqlCommand(sql, conn);
                    int i = com.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("删除成功");
                        conn.Close();
                        FillListView();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
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
        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studnt();
            if (this.lvQQ.SelectedItems.Count > 0)
            {
                Form2 Student = new Form2();
                Student.txtStudent.Text = this.lvQQ.SelectedItems[0].Text;
                Student.txtped.Text = this.lvQQ.SelectedItems[0].SubItems[1].Text;
                Student.txtpwd1.Text = this.lvQQ.SelectedItems[0].SubItems[1].Text;
                Student.txtName.Text = this.lvQQ.SelectedItems[0].SubItems[1].Text;
             //   Student.panel1.Text = this.lvQQ.SelectedItems[0].SubItems[2].Text;
                Student.cbogread.Text = this.lvQQ.SelectedItems[0].SubItems[3].Text;
                
                Student.MdiParent = this.MdiParent;
                Student.Show();
            }
            else {
                MessageBox.Show("请选择一个学生", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public string name;
        public string time;
          public bool Studnt() {
            bool success = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendFormat("UPDATE [TVReport] SET [TName]='{0}'",name);
                sql.AppendFormat(" ,[StartTime]='{0}'", time);
                conn.Open();
                SqlCommand com = new SqlCommand(sql.ToString(), conn);
                int i = com.ExecuteNonQuery();
                if (i == 1) {
                    success = true;
                }
            }
            catch (Exception)
            {
                success = false;
            }
            finally {
                conn.Close();
            }
            return success;
        }
    }
}
       

