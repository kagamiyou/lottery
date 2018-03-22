using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            //產生六個亂數
            Random rand = new Random();
            int r1 = rand.Next(1, 43);
            int r2 = rand.Next(1, 43);
            int r3 = rand.Next(1, 43);
            int r4 = rand.Next(1, 43);
            int r5 = rand.Next(1, 43);
            int r6 = rand.Next(1, 43);

            

            //印出
            Console.WriteLine("{0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", r1, r2, r3, r4, r5, r6);

            //防止視窗自動關閉
            Console.ReadLine();
        }
    }
}
