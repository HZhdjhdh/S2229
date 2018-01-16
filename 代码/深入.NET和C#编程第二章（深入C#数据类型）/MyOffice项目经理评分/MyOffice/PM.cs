using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
    public class PM
    {
        //Id
        private string _ID;
        public string ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        //年龄
        private string _Age;
        public string Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
            }
        }
        //姓名
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        //性别
        private string _Sex;
        public string Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                _Sex = value;
            }
        }
        //资历
        private string _Zi;
        public string Zi
        {
            get
            {
                return _Zi;
            }
            set
            {
                _Zi = value;
            }
        }
        public void show(SE se, string ping, string fen)
        {
            se.ping = ping;
            se.fen = fen;
        }
    }
}
