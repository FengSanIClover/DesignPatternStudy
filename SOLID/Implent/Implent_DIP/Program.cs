using DependencyInversionPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = DependencyInversionPrinciple.Task;

namespace Implent_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("實作結合了 依賴反轉原則 和 依賴注入原則 的範例，");
            Console.WriteLine("根據使用者輸入，選擇注入相對應英雄類別。\n");
            Console.ForegroundColor = ConsoleColor.White;

            // 使用者輸入英雄選項，顯示結果
            string opt = string.Empty;
            while (true)
            {
                opt = Choice();
                if (opt == "1" || opt == "2")
                {
                    var hero = GetAvenger(opt);
                    Console.Write("訊息:\n");
                    var executiveTask = new Task(hero);
                    executiveTask.ShowTime();

                    Console.WriteLine("==========================執行成功============================\n");
                }
                else
                {
                    Console.WriteLine("======================範例結束請按任意鍵======================\n");
                    Console.Read();
                    return;
                }
            }
        }

        /// <summary>
        /// 提示使用者操作的方法，並回傳輸入值
        /// </summary>
        /// <returns>輸入值</returns>
        public static string Choice()
        {
            Console.WriteLine("請輸入要指派的英雄:");
            Console.WriteLine("輸入 1 : 奇異博士。");
            Console.WriteLine("輸入 2 : 浩克。");
            Console.WriteLine("輸入 1、2 以外任意字 : 範例結束。\n");
            Console.Write("輸入:");
            return Console.ReadLine();
        }

        /// <summary>
        /// 運用工廠模式，根據傳入值回傳對應的英雄類別
        /// </summary>
        /// <param name="heroType">傳入選項的值</param>
        /// <returns></returns>
        public static IAvengers GetAvenger(string heroType)
        {
            IAvengers avenger;
            if (heroType == "1")
                return avenger = new DoctorStrange();
            if (heroType == "2")
                return avenger = new Hulk();

            return null;
        }
    }
}
