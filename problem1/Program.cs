using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var t in args)
            {
                int x = int.Parse(t);
                if (x%3 == 0 && x%5 != 0)
                {
                    Console.WriteLine(t);
                }
                

            }
            Console.ReadKey();
        }
    }
}
