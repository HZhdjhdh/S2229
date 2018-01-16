using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用多态输出形状
{
   public class Circle:Shape
    {

        public override void Draw()
        {
            Console.WriteLine("正在绘制圆形！");
        }
    }
}
