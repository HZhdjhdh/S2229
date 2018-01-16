using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单列播放
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Song> list = new List<Song>()
{            new Song(1, "富士山下", "C:\\Users\\win-10\\Music\\ktv音乐\\陈奕迅 - 富士山下.mkv"),
            new Song(2, "我好想你", "C:\\Users\\win-10\\Music\\ktv音乐\\苏打绿 - 我好想你.mkv"),
            new Song(3, "富士山下", "C:\\Users\\win-10\\Music\\ktv音乐\\陈奕迅 - 富士山下.mkv")
        };
            dgvSong.DataSource = new BindingList<Song>(list);
        }

        private void tmPlay_Click(object sender, EventArgs e)
        {
            Play a = Play.pal();
            string path=dgvSong.SelectedRows[0].Cells["Url"].Value.ToString();
            a.path = path;
            a.Show();
            a.Bony();
            
        }
       
    }
    
}
