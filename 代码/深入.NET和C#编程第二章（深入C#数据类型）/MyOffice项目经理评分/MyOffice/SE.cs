using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOffice
{
   public class SE
    {
       //工号
       private string _number;
       public string number {
           get {
               return _number;
           }
           set {
               _number = value;
           }
       }
       //年龄
       private string _Age;
       public string Age
       {
           get
           {
               return _Age;
           }
           set
           {
               _Age = value;
           }
       }
       //姓名
           private string _Name;
           public string Name
           {
               get
               {
                   return _Name;
               }
               set
               {
                   _Name = value;
               }
           }
       //性别
           private string _Sex;
           public string Sex
           {
               get
               {
                   return _Sex;
               }
               set
               {
                   _Sex = value;
               }
           }
       //人气值
           private string _qi;
           public string qi
           {
               get
               {
                   return _qi;
               }
               set
               {
                   _qi = value;
               }
           }
           private string _ping;
           public string ping
           {
               get
               {
                   return _ping;
               }
               set
               {
                   _ping = value;
               }
           }
           private string _fen;
           public string fen
           {
               get
               {
                   return _fen;
               }
               set
               {
                   _fen = value;
               }
           }
    }
}
