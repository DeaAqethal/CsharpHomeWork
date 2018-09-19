using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int []A = { 43, 62, 13, 46, 485, 24, 71, 79, 123,12 };
            int max,min,sum;
            float average;
            for(int i = 1; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (A[i] < A[j])
                    {
                        int T = A[i];
                        A[i] = A[j];
                        A[j] = T;
                    }
                }
            }
            max = A[9];
            min = A[0];
            sum = 0;
            for(int i = 0; i < 10; i++) {
                sum = A[i] + sum;
            }
            average = sum / 10;
            Console.WriteLine(max+" "+ min+ " " + average + " " + sum);
            Console.WriteLine("结束");
        }
    }
}
