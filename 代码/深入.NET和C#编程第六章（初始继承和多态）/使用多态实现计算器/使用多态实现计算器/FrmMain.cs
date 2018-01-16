using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 使用多态实现计算器
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            label2.Text = "";
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        //单击“计算”按钮的响应
        private void bntNumber_Click(object sender, EventArgs e)
        {
            //验证
            if(string.IsNullOrEmpty(this.txt1.Text.Trim())){
                MessageBox.Show("操作数不能为空！");
                this.txt1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(this.txt2.Text.Trim()))
            {
                MessageBox.Show("操作数不能为空！");
                this.txt2.Focus();
                return;
            }
            try
            {
                Operation opr = new Operation();
                //加法
                //减法
                //乘法
                //除法
                switch (this.cbo1.SelectedItem.ToString().Trim()) {
                    case "+":
                        {
                            opr = new OperationAdd();
                            break;
                        }
                    case "-":
                        {
                            opr = new Operationsub();
                            break;
                        }
                    case "*":
                        {
                            opr = new Operationmul();
                            break;
                        }
                    case "/":
                        {
                            opr = new OperationDiv();
                            break;
                        }
                }
                opr.NumberA = double.Parse(this.txt1.Text.Trim());
                opr.NumberB = double.Parse(this.txt2.Text.Trim());
                //计算
                this.label2.Text = opr.GetResult().ToString();
                this.lblJi.Visible = true;
                this.label2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误！"+ex.Message);
            }
        }
    }
}
