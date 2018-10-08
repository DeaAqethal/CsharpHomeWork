using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class clock
    {
        static void Main(string[] args)
        {
            string a = "";
            int h = 0;
            int m = 0;
            int s = 0;
            Console.Write("Please input the hour: ");
            a = Console.ReadLine();
            h = Int32.Parse(a);
            Console.Write("Please input the minute: ");
            a = Console.ReadLine();
            m = Int32.Parse(a);
            Console.Write("Please input the second: ");
            a = Console.ReadLine();
            s = Int32.Parse(a);
            Console.Write("The time of clock is : " + h + ":" + m + ":" + s);
            if(DateTime.Now.Hour ==h&& DateTime.Now.Minute == m&& DateTime.Now.Second == s)
            {
                Console.Write("The clock is on time");
            }
        }
    }
}
