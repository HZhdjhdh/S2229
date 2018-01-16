using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟银行自动柜员机
{
   public class LoginInfo
    {
        public string  Id { get; set; }
        public string  Password { get; set; }
        public string Name { get; set; }
        public double Money { get; set; }
        public virtual double Mong(double money)
        {
            return this.Money;
        }
        public LoginInfo(string id, string password, string name, double money) {
            this.Id = id;
            this.Password = password;
            this.Name = name;
            this.Money = money;
        }
    }
}
