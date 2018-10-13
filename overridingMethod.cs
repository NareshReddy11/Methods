using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class overridingMethod
    {
        public void Base()
        {
            Console.WriteLine("from base clase");
        }
    }
    class derived :overridingMethod
    {
        public void Base()
        {
            Console.WriteLine("from derived class");
        }
    }
    class overridingmethod1
    {
        static void Main(string[] args)
        {
            overridingMethod[] obj1 = { new overridingMethod(), new derived(), new overridingMethod(), new derived() };
            foreach(overridingMethod value in obj1)
            {
                value.Base();
            }
        }
    }
}
