using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Invers inobj = new Invers();
            Console.Write(" Enter your number: ");
            string num = Console.ReadLine();
            int m = inobj.CalInvers();
            Console.WriteLine("your result is:{0} ",m.ToString());
            Console.ReadKey();

            
        }
    }
}
