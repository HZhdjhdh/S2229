using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟汽车行驶
{
    public class Truck:Vehicle
    {
        //构造函数
        public Truck(string type,string place):base(type,place) { 
        
        }
        //TruckRun()方法
        public void TruckRun() {
            Console.WriteLine(string.Format("型号为{0},产地为{1}的卡车在行驶！",this.Type,this.Place));
        }
    }
}
