using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class recursion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine( fact(num));
        }
        static int fact(int num)
        {
            if(num ==0)
            {
                return 1;
            }
            else
            {
                return num=num * fact(num - 1);
            }
        }
    }
}
