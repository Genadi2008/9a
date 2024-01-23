using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("въведи x");
            int x = int.Parse(Console.ReadLine());

            Console.Write("въведи y");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && 0 < y)

                x = y; y = x;
        Console.WriteLine("крадрад 2");


        }
    }
}
