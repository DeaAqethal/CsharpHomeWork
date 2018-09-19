using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            Console.Write("Please input an int: ");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            int[] A = new int[n];
            int j = 0;
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                   A[j] = i;
                    j++;
                }
            }
            Console.WriteLine(n + "的所有质数因子是：");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("结束");
        }
    }
}
