using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟银行自动柜员机
{
    //内地卡
    public class Mainland_card : LoginInfo
    {
        public Mainland_card(string id, string password, string name, double money)
            : base(id, password, name, money) { }
        public override double Mong(double money)
        {
            this.Money -= money;
            return this.Money;
        }
    }
}

