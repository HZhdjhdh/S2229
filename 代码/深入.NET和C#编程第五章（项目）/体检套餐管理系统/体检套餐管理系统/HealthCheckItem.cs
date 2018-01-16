using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 体检套餐管理系统
{
   public class HealthCheckItem
    {
       //项目描述
        public string  Description { get; set; }
       //项目名称
        public string  Nameee{ get; set; }
       //项目价格
        public string  Price { get; set; }
        public HealthCheckItem(string nameee, string description, string price)
        {
            this.Nameee = nameee;
            this.Description = description;
            this.Price = price;
       }
    }
}
