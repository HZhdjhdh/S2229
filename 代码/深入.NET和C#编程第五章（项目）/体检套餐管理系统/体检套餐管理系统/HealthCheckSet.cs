using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 体检套餐管理系统
{
   public class HealthCheckSet
    {
        //HealthCheckItem的集合
       public List<HealthCheckItem> Items { get; set; }
       //套餐价格
        public string Price { get; set; }
       //套餐名称
        public string  Namee { get; set; }
        //构造方法
        public HealthCheckSet(string name, List<HealthCheckItem> items)
        {
            this.Namee = name;
            this.Items = items;
        }

        public void CalcPrice()
        {
            int totalPrice = 0;
            foreach (HealthCheckItem item in Items)
            {
                totalPrice += int.Parse(item.Price);
            }
          this.Price = totalPrice.ToString();
        }

    }
}
