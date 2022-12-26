using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassignment
{
   internal class odd
    {
        static void Main22(string[] args)
        {
            int a = 0;
            int j = 30;
            for (a = 0; a < j; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("it is even number" + a);
                }
                if (a % 2 != 0)
                {
                    Console.WriteLine("it is odd number" + a);
                }




            }
        }
    }
}
