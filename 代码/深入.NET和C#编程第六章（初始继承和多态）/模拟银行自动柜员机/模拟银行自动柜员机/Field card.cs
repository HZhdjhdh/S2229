using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟银行自动柜员机
{
    //外地卡
    public class Field_card : LoginInfo
    {
        public Field_card(string id, string password, string name, double money) 
            : base(id, password, name, money) { }
        public override double Mong(double money)
        {
            this.Money -= money+2;
            return this.Money;
        }
    }
}
