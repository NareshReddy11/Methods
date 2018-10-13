using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class returnMulValues
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int add ;
            int mul ;
            addmul(a, b, out add, out mul);
            Console.WriteLine("sum is:"+add);
            Console.WriteLine("multiplication is:"+mul);
        }
        static void addmul(int a, int b, out int add, out int mul)
        {
            add = a + b;
            mul = a * b;
        }
    }
}
