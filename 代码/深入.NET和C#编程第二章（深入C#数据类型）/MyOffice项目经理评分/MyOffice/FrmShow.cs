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
    public partial class FrmShow : Form
    {
        public SE[] a = new SE[3];
        public FrmShow()
        {
            InitializeComponent();
        }

        private void FrmShow_Load(object sender, EventArgs e)
        {
            inti();
            UpdateView();
        }
        public void inti() {
            a[0] = new SE();
            a[0].number = "111";
            a[0].Name="王一名";
            a[0].Age="13";
            a[0].ping = "未评价";
            a[0].fen = "0";
            a[1] = new SE();
            a[1].number = "112";
            a[1].Name = "王二名";
            a[1].Age = "20";
            a[1].ping = "未评价";
            a[1].fen = "0";
            a[2] = new SE();
            a[2].number = "113";
            a[2].Name = "王三名";
            a[2].Age = "7";
            a[2].ping = "未评价";
            a[2].fen = "0";
        }
        public void UpdateView() {
            lVAssess.Items.Clear();
            for (int i = 0; i < a.Length;i++ )
            {
                ListViewItem item = new ListViewItem(a[i].number);
                item.SubItems.Add(a[i].Name);
                item.SubItems.Add(a[i].Age);
                item.SubItems.Add(a[i].ping);
                item.SubItems.Add(a[i].fen);
                this.lVAssess.Items.Add(item);
            }
        }

        private void lVAssess_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(this.lVAssess.SelectedItems.Count==0){
            //    return;
            //}
            //int index = 0;
            //for (int i = 0; i < a.Length;i++ )
            //{
            //    if(a[i].number==this.lVAssess.SelectedItems[0].Text.Trim()){
            //        index = i;
            //        break;
            //    }
            //}
            //FrmJudge aa = new FrmJudge(index,this);
            //aa.Show();
        }

        private void lVAssess_DoubleClick(object sender, EventArgs e)
        {
             if(this.lVAssess.SelectedItems.Count==0){
                return;
            }
            int index = 0;
            for (int i = 0; i < a.Length;i++ )
            {
                if(a[i].number==this.lVAssess.SelectedItems[0].Text.Trim()){
                    index = i;
                    break;
                }
            }
            FrmJudge aa = new FrmJudge(index,this);
            aa.Show();
        
        }
    }
}
