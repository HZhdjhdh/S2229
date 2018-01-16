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
    public partial class Form6 : Form
    {
        private const string sqlcon = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        public Form6()
        {
            InitializeComponent();
        }
        DataSet a = new DataSet();
        private void Form6_Load(object sender, EventArgs e)
        {
            this.dgvShow.AutoGenerateColumns = false;
            SearchStuent();
        }
        public void SearchStuent()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select Student.*,Grade.* from Student,Grade where Student.GradeId=Grade.GradeId ");
            SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "Student");
            this.dgvShow.DataSource = a.Tables["Student"];
        }

        private void tvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //创建DataView
            DataView view = new DataView(a.Tables["Student"]);

            if(this.tvShow.SelectedNode.Level==1){
                string name = this.tvShow.SelectedNode.Text;
                view.RowFilter = "GradeName='" + name + "'";
            }
            if (this.tvShow.SelectedNode.Level == 2)
            {
                //拿到男或女节点
                string name = this.tvShow.SelectedNode.Parent.Text;
                string sex = this.tvShow.SelectedNode.Text;
                view.RowFilter = "GradeName='" + name + "'and Sex='"+sex+"'";
            }
            //排序
            view.Sort = "StudentNo desc";
            //重新绑定数据源
            this.dgvShow.DataSource = view;
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult choice;
            choice=MessageBox.Show("确定要删除该学生吗？同时也会删除该学生成绩！","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (choice==DialogResult.Yes)
            {
            if(dgvShow.SelectedRows.Count>0){
                string StudentNo = this.dgvShow.SelectedRows[0].Cells["StudentNo"].Value.ToString();
                try
                {
                    conn.Open();
                    string sql = string.Format("delete from Student where StudentNo='{0}'", StudentNo);
                    SqlCommand com = new SqlCommand(sql, conn);
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
    }
}
