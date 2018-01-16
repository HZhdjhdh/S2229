using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟汽车行驶
{
   public class Vehicle
    {
       //型号
        public string  Type { get; set; }
       //产地
        public string  Place { get; set; }
       //构造函数
        public Vehicle(string type,string place) {
            this.Type = type;
            this.Place = place;
        }
       //VehicleRun()方法
        public void VehicleRun() {
            Console.WriteLine("汽车在行驶！");
        }
    }
}
