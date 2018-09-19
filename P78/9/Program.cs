using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            for (int i = 2; i <= n; i++)
            {
                int j = 2; while (i % j != 0) {
                    j++;
                }
                if (j == i) {
                    Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine("结束");
        }
    }
}
