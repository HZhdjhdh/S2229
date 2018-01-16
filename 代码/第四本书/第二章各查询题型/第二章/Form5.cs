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
    public partial class Form5 : Form
    {
        private const string sqlcon = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Pwd=abcdefg928";
        SqlConnection conn = new SqlConnection(sqlcon);
        public Form5()
        {
            InitializeComponent();
        }
        DataSet a = new DataSet();
        private void Form5_Load(object sender, EventArgs e)
        {
            string sql = "select * from Grade";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(a, "Grade");
            DataRow row = a.Tables["Grade"].NewRow();
            row["GradeId"] = -1;
            row["GradeName"] = "请选择";
            a.Tables["Grade"].Rows.InsertAt(row, 0);
            this.comboBox1.DataSource = a.Tables["Grade"];
            this.comboBox1.ValueMember = "GradeId";
            this.comboBox1.DisplayMember = "GradeName";
            this.dataGridView1.AutoGenerateColumns = false;
            SearchStuent();
        }
        private void bntan_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.comboBox1.SelectedValue) == -1)
            {
                MessageBox.Show("对不起，请选择对应年级", "温馨提示", MessageBoxButtons.OKCancel);
            }       
                 SearchStuent();     
        }
        public void SearchStuent()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select Student.*,Grade.* from Student,Grade where Student.GradeId=Grade.GradeId ");
            if (Convert.ToInt32(this.comboBox1.SelectedValue) != -1)
            {
                sql.AppendFormat("and Student.GradeId={0}", this.comboBox1.SelectedValue);
            
                if (a.Tables["Student"] != null)
                {
                    a.Tables["Student"].Clear();
                }             
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sql.ToString(), conn);
            adapter.Fill(a, "Student");
            this.dataGridView1.DataSource = a.Tables["Student"];
        }
        }
    }

