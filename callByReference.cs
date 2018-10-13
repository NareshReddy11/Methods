using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class callByReference
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 1;
            Console.WriteLine("before calling methds a and b is:" + a + "," + b);
            swap(ref a, ref b);
            Console.WriteLine("after swapping a and b is:"+a+","+b);
        }
        static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("swapped elements a and b ia:" + a + "," + b);
        }
    }
}
