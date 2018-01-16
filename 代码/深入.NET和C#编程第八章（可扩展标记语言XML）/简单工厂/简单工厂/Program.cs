using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace 简单工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDataDocument doc = new XmlDataDocument();
            doc.Load("XMLFile1.xml");
            XmlNode root = doc.DocumentElement;
            foreach (XmlNode book in root.ChildNodes)
            {
                foreach (XmlNode item in book.ChildNodes)
                {
                    Console.WriteLine(item.InnerText);
                }
            }
            //}Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
