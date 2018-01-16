using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice
{
    public partial class FrmJudge : Form
    {
        public SE a;
        public FrmShow main;
        public FrmJudge(int index,FrmShow Judge)
        {
            InitializeComponent();
            this.main = Judge;
            a=this.main.a[index] ;
        }

        private void FrmJudge_Load(object sender, EventArgs e)
        {
            this.txtName.Text = a.Name;
            this.txtping.Text = a.ping;
            this.txtfen.Text = a.fen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PM pm = new PM();
                pm.show(a, this.txtping.Text.Trim(), this.txtfen.Text.Trim());
                this.main.UpdateView();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("评分失败"+ex.ToString());
            }
        }
    }
}
