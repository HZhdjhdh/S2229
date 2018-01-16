using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实现工作汇报
{
    public partial class MyOffice : Form
    {
        List<Employee> empls = new List<Employee>();
        public MyOffice()
        {
            InitializeComponent();
            Init();
        }

        private void MyOffice_Load(object sender, EventArgs e)
        {

        }
        //员工信息初始化
        public void Init() { 
        //实例化SE对象
            List<Job> list1 = new List<Job>();
            list1.Add(new Job ("编码","购物车模块"));
            list1.Add(new Job("测试","给购物车模块做单元测试"));
            SE ai = new SE("112", "艾边成", 25, Gender.male, 100, list1);
          
            List<Job> list2 = new List<Job>();
            list2.Add(new Job("设计", "数据库建模"));
            list2.Add(new Job("编写文档", "详细设计说明书"));
            SE joe = new SE("113", "joe", 30, Gender.female, 200, list2);
            //实例化PM对象
            PM pm = new PM("890", "盖茨", 50, Gender.female, 30, null);
            empls.Add(ai);
            empls.Add(joe);
            empls.Add(pm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Employee emp in empls){
            if(emp is PM){
                MessageBox.Show(((PM)emp).DoWork(),"汇报");
            }
                if(emp is SE){
                    MessageBox.Show(((SE)emp).DoWork(), "汇报");
                }
            }
        }

    }
}
