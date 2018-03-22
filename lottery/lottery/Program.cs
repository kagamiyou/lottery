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

            //建立亂數物件
            Random rand = new Random();

            //紀錄次數變數
            int count = 1;

            //重複產生
            while (count <= 10) 
            {
                //用亂數物件產生亂數
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);

                //顯示
                Console.WriteLine("[{0:00}] {1:00} {2:00} {3:00} {4:00} {5:00} {6:00}", count, r1, r2, r3, r4, r5, r6);

                //累加次數
                count = count + 1;
            }

            //防止視窗自動關閉
            Console.ReadLine();
        }
    }
}
