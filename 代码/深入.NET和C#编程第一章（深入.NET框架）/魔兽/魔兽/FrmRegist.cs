using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 魔兽
{
    public partial class FrmRegist : Form
    {
        public FrmRegist()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public Form1 fi;
        private void button1_Click(object sender, EventArgs e)
        {
            LoginInfo info = new LoginInfo();
            info.Name = this.txtName.Text;
            info.Id = this.txtId.Text;
            info.Email = this.txtEmail.Text;
            info.Password = this.txtPassword1.Text;
            info.Password = this.txtPassword2.Text;
            info.Password = this.txtPassword3.Text;
            MessageBox.Show("恭喜！通过验证", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 1; i < fi.array.Length;i++ )
            {
                if(fi.array[i]==null){
                    fi.array[i] = info;
                    break;
                }
            }
            fi.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
