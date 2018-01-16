using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第一章
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public const string ADMIN = "系统学员";
        private void tetName_TextChanged(object sender, EventArgs e)
        {
            if (true)
            {
                if (this.tetName.Text.Equals(ADMIN)) {
                    Form2 frmAdmin = new Form2();
                    frmAdmin.Show();
                }
                this.Hide();
            }
        
        }
    }
}
