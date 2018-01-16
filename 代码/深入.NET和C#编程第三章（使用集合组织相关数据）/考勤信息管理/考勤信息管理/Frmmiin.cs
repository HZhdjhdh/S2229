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
    public partial class Frmmiin : Form
    {
        public FrmMian s { get; set; }
        public Frmmiin()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SE pr = new SE();
                pr.No = this.txtNo.Text.Trim();
                pr.Age = this.txtAge.Text.Trim();
                pr.Nameee = this.txtName.Text.Trim();
                pr.Sex = this.cobSex.Text;
                //if (this.cobSex.SelectedItem.ToString() == "男")
                //{
                //    pr.Sex = Sex.男;
                //}
                //else {
                //    pr.Sex = Sex.女;
                //}
                foreach (SE item in FrmMian.b) { 
                    if(item.No==pr.No){
                        MessageBox.Show("此工号以存在！");
                        return;
                    }
                }
                FrmMian.b.Add(pr);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错",ex.Message);
            }
            finally {
                s.BindGrid(FrmMian.b);
            }
        }

        private void Frmmiin_Load(object sender, EventArgs e)
        {

        }
    }
}
