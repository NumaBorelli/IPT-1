using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countdown = 5; while
                (countdown > 0)
            {
                Console.WriteLine(countdown);
                --countdown;
                if (countdown == 0)
                {
                    Console.WriteLine("Start");
                }
            }
        }
    }
}
