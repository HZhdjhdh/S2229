using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV后台
{
    public partial class chaxun : Form
    {
        public chaxun()
        {
            InitializeComponent();
        }
        //退出程序
        private void 退出WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //打开查询歌手页面
        private void 查询歌手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            geshouchaxun a = new geshouchaxun();
            a.ShowDialog();
        }
        //打开新添歌手页面
        private void 新添歌手AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tianjiageshou a = new tianjiageshou();
            a.button4.Visible = false;
            a.ShowDialog();       
        }
        //打开新添歌曲页面
        private void 新添歌曲DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tianjiagequ a = new tianjiagequ();
            a.ShowDialog();
        }
        //打开歌曲信息页面
        private void 查询歌曲信息BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chaxungequ a = new chaxungequ();
            a.ShowDialog();
        }
        //打开歌曲路径页面
        private void 歌曲路径YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gequlujing a = new gequlujing ();
            a.ShowDialog();
        }
        //打开歌手路径页面
        private void 歌手图片路径VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            geshoutuplujing a = new geshoutuplujing();
            a.ShowDialog();
        }
        //退出程序
        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chaxun_Load(object sender, EventArgs e)
        {

        }

       
    }
}
