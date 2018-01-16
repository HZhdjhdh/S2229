using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 体检套餐管理系统
{
    public partial class Health : Form
    {
        public Health()
        {
            InitializeComponent();
        }
        HealthCheckItem list1, list2, list3, list4, list5, list6, list7;
        public static List<HealthCheckItem> List = new List<HealthCheckItem>();
        //创建一个新的对象来接受自己选定的检查项的所有项
        HealthCheckSet healthCheckset;
        List<HealthCheckSet> ite = new List<HealthCheckSet>();
        List<HealthCheckItem> items = new List<HealthCheckItem>();
        public void Bick()
        {
            comboBox1.Items.Add("请选择");
            comboBox2.Items.Add("请选择");
            list1 = new HealthCheckItem("身高", "检查身高多少", "5");
           list2 = new HealthCheckItem("体重", "检查体重多少", "5");
             list3 = new HealthCheckItem("视力", "检查视力多少", "10");
             list4 = new HealthCheckItem("听力", "检查听力多少", "5");
             list5 = new HealthCheckItem("肝功能", "检查肝功能多少", "60");
            list6 = new HealthCheckItem("B超", "检查B超多少", "60");
             list7 = new HealthCheckItem("心电图", "检查心电图多少", "50");
            items.Add(list1);
            items.Add(list2);
            items.Add(list3);
            items.Add(list4);
            items.Add(list5);
            items.Add(list6);
            items.Add(list7);
            foreach(HealthCheckItem item in items){
            comboBox1.Items.Add(item.Nameee);
            }
            //学生人学体检
            All.Add(list1);
            All.Add(list2);
            All.Add(list3);
           healthCheckset = new HealthCheckSet("入学检测", All);
           ite.Add(healthCheckset);
        //       CalcPrice();
               comboBox2.Items.Add(healthCheckset.Namee);
               if (comboBox1.Text.Trim() == "请选择")
               {
                   dataGridView1.DataSource = new BindingList<HealthCheckItem>();
               }
                //this.bntName1.Enabled = false;
        }   
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = this.comboBox2.Text;
            this.lblName2.Text = a;
            if (a != "请选择")
            {
                //All.Add(list1);
                //All.Add(list2);
                //All.Add(list3);
                foreach (HealthCheckSet item in ite)
                {
                    healthCheckset = item;
                    lblName2.Text = item.Namee;
                    item.CalcPrice();
                    label3.Text = item.Price;
                    this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(All);
                    break;
                }
                this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(All);              
               
            }
            else if (a=="请选择")
            {
                this.lblName2.Text = null;
            }       
        }
        //拿下表0项
        private void Health_Load(object sender, EventArgs e)
        {
            Bick();
            this.comboBox2.SelectedIndex = 0;      
        }
        public void UpdateSet()
        {
            foreach (HealthCheckSet item in ite)
            {
                if (txtName.Text.Trim() == item.Namee)
                {
                    MessageBox.Show("已有套餐！请重新添加");
                }
            }
            List<HealthCheckItem> checkitem = new List<HealthCheckItem>();
            HealthCheckSet checkset = new HealthCheckSet(txtName.Text, checkitem);
            ite.Add(checkset);
            comboBox2.Items.Add(checkset.Namee);
            MessageBox.Show("添加成功！！！");
        }
        //添加套餐名称进行传值
        private void bntName_Click(object sender, EventArgs e)
        {
           //添加套餐的方法
            UpdateSet();
        }
        //删除
        private void bntShan_Click(object sender, EventArgs e)
        {
            string d = dataGridView1.SelectedRows[0].Cells["Nameee"].Value.ToString();
            DialogResult delete;
            delete = MessageBox.Show("确定要删除吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (delete == DialogResult.Yes)
            {
                foreach (HealthCheckItem item in All)
                {
                    if (item.Nameee == d)
                    {
                        All.Remove(item);
                        MessageBox.Show("删除成功！");
                        break;
                    }
                }
            }
            healthCheckset.CalcPrice();
            label3.Text = healthCheckset.Price;
            this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(All);         
        }  
    //价格
        //public void CalcPrice()
        //{
        //    int totalPrice=0;
        //    foreach (HealthCheckItem item in List)
        //    {
        //        totalPrice += int.Parse(item.Price);
        //    }
        //    this.label3.Text = totalPrice.ToString();
        //}
         //添加检查项的方法
        List<HealthCheckItem> All = new List<HealthCheckItem>();
        public void UqdateChneckitem()
        {
            string name = comboBox1.Text;
            for (int i = 0; i < All.Count;i++ ) {
               if(name.Equals(All[i].Nameee)){
                   MessageBox.Show("已经有检查项了！不能再添加了");
                          return;
               }
            }
            All.Add(items[comboBox1.SelectedIndex-1]);
            this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(All);


           
        }
        private void bntName1_Click(object sender, EventArgs e)
        {
           
            UqdateChneckitem();
            healthCheckset.CalcPrice();
            label3.Text = healthCheckset.Price;
        }

        private void lblName2_Click(object sender, EventArgs e)
        {

        }
       
    }
}
