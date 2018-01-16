using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单列播放
{
   public class Song
    {
        public int SongID { get; set; }
        public string  SongName { get; set; }
        public string SongUrl { get; set; }
        public Song() { }
        public Song(int id,string name,string url) {
            this.SongID = id;
            this.SongName = name;
            this.SongUrl = url;

        }
    }
}
