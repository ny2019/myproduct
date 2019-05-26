using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculate
{
   public class Invers
    {
       string num;
       int x=0;
       int len;
       int n;
       public string Num
       {
           get { return num; }
           set { num = value; }
       }
       public int CalInvers()
       {
           len = num.Length;
           n = int.Parse(num);

           for (int i = 1; i <= len ;i++ )
           {
               x += (int)((n % 10) * Math.Pow(10, (len - i)));
               n = n / 10;
               return x;
           }
           return x;


       }

    }
}
