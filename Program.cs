using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class simplemethod
    {
       public void student()
        {
            Console.WriteLine("in this year svce mca all students got the job");
        }
    }
    class method1
    {
        static void Main(string[] args)
        {
            simplemethod obj1 = new simplemethod();
            obj1.student();
        }
    }
}
