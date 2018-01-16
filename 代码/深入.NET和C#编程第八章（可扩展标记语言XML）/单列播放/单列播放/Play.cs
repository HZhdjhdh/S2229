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
    public partial class Play : Form
    {
       private Play()
        {
            InitializeComponent();
        }
       private static Play paly;
       public static Play pal() { 
       if(paly==null){
           paly = new Play();
       }
       return paly;
       }
        public string path;
        private void Play_Load(object sender, EventArgs e)
        {
          
        }
        public void Bony() {
            axWindowsMediaPlayer1.URL = path;
        }
    }
}
