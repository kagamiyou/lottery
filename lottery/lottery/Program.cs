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
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            //一開始輸入要產生幾組號碼
            Console.Write("請輸入要產生幾組號碼:");
            int total = int.Parse(Console.ReadLine());

            //設一個計數器
            int time = 1;

            //設定亂數產生器
            Random rand = new Random();

            //用迴圈判斷要產生幾組號碼
            while (time <= total)
            {
                int r1 = rand.Next(0, 43);
                int r2 = rand.Next(0, 43);
                int r3 = rand.Next(0, 43);
                int r4 = rand.Next(0, 43);
                int r5 = rand.Next(0, 43);
                int r6 = rand.Next(0, 43);

                //用if判斷每個數字是否有重複
                if (r1 != r2 && r1 != r3 && r1 != r4 && r1 != r5 && r1 != r6 && r2 != r3 && r2 != r4 && r2 != r5 && r2 != r6 && r3 != r4 && r3 != r5 && r3 != r6 && r4 != r5 && r4 != r6 && r5 != r6)
                {
                    Console.WriteLine("號碼組第{0:00}組:  {1:00}  {2:00}  {3:00}  {4:00}  {5:00}  {6:00}", time, r1, r2, r3, r4, r5, r6);

                    time += 1;
                }
            }

            //結束暫停畫面
            Console.ReadLine();
        }
    }
}
