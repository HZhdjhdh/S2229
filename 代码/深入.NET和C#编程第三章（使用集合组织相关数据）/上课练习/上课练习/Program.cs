using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上课练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hashtable(哈希表)
            Hashtable table = new Hashtable();
            //SE jack = new SE();
            //jack.baneName = "农业银行";
            //jack.bane = "ABC";
            //table.Add(jack.bane,jack.baneName);
                 table.Add("ABC", "农业银行");
                 table.Add("ICBC","工商银行");
                 table.Add("CBC","建设银行");
                 Object baneName = table["ABC"];
                 Console.WriteLine(baneName);
                 Console.ReadLine();
            #endregion
        }
    }
}
