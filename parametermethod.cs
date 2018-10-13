using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class parametermethod
    {
        public int add(int a ,int b)
        {
            return a + b;
        }
        public int sub(int i,int k,int l )
        {
            return i - k - l;
        }
    }
    class parametermethod1
    {
        static void Main(string[] args)
        {
            parametermethod obj1 = new parametermethod();
            Console.WriteLine("sum is:"+obj1.add(2, 4));
            Console.WriteLine("substraction is:" + obj1.sub(2, 3, 6));
        }
    }
}
