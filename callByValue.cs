using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class callByValue
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 1;
            Console.WriteLine("before calling to method a and b is:" + a + "," + b);
            swap(a, b);
            Console.WriteLine("after calling to method a and b is:" + a + "," + b);
        }
        static void swap(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("swaped elements a and b is:" + a + "," + b);
        }
    }
}
