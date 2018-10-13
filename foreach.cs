using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Foreach
    {

        static void Main(string[] args)
        {
            string[] names = new string[] { "naresh", "mahesh", "swathi", "lokesh", "suresh"," subbu", "shahul" };
            foreach(string ss in names )
            {
                Console.WriteLine("names are:" + ss);
            }
        }
    }
}
