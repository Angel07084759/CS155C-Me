using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        
        static void PassBy(ref int v)
        {
            v = 1;
        }


        static void Main(string[] args)
        {
            double a = 5.5;
            double b = 6.9;
            //int sum = a + b;

            int v =  0;
            PassBy(ref v);

            Console.WriteLine(v);

            Console.ReadLine();
        }
    }
}
