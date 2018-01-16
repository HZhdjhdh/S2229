using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 考勤信息管理
{
    public partial class FrmMian : Form
    {
        public FrmMian()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Frmmiin a = new Frmmiin();
            a.s = this;
            a.ShowDialog();

        }
        
         public static List<SE> b = new List<SE>();
        private void FrmMian_Load(object sender, EventArgs e)
        {
            inti();
        }
        public void inti() {
            SE se1=new SE();
            se1.No = "111";
            se1.Nameee = "芜湖";
            se1.Age = "13";
            se1.Sex = "男";
            SE se2 = new SE();
            se2.No = "112";
            se2.Nameee = "湖南";
            se2.Age = "19";
            se2.Sex = "女";
            b.Add(se1);
            b.Add(se2);
            this.dataGridView1.DataSource = new BindingList<SE>(b);
        }
        public void BindGrid(List<SE>List) {
            this.dataGridView1.DataSource = new BindingList<SE>(b);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bntName_Click(object sender, EventArgs e)
        {
            List<SE> temp = new List<SE>();
            foreach (SE item in FrmMian.b)
            {
                if (item.No.IndexOf(this.txtNo.Text.Trim())!=-1)
                {
                    temp.Add(item);
            }
              
            }
            this.dataGridView1.DataSource = new BindingList<SE>(temp);
        }
    
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            string d = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult delete;
            delete= MessageBox.Show("确定要删除吗？","温馨提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (delete == DialogResult.Yes) {
                foreach (SE item in FrmMian.b)
                {
                    if(item.No==d){
                    b.Remove(item);
                    break;
                    }
                }         
            }
            this.dataGridView1.DataSource = new BindingList<SE>(b);
           
        }
        //记录打卡记录的Dictionary
        public static  Dictionary<string, Record> recordList = new Dictionary<string, Record>();
        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //验证
            //确保有选中的行
            if(this.dataGridView1.SelectedRows.Count!=1){
                MessageBox.Show("请选择一行");
                return;
            }
            //确保没有签到

            string workNo = dataGridView1.CurrentRow.Cells["No"].Value.ToString();

            MessageBox.Show("test1");

            foreach (string id in recordList.Keys) {
                MessageBox.Show("test");
                if (workNo == id)
                {
                    MessageBox.Show("您已经签过到！");
                    return;
                }
              
                //执行签到
               
            Record record = new Record();
         
            record.ID = workNo;
            record.Namss = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            record.SingInTime = DateTime.Now;
            recordList.Add(record.ID,record);
            MessageBox.Show("签到成功！");
            }
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            FrmQing k = new FrmQing();
            k.Show();
        }
    }
}
