using LiskovSubstitutionPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = LiskovSubstitutionPrinciple.Task;

namespace Implent_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("以下為尚未符合 里氏替換原則 的範例!!");
            Console.WriteLine("平時復仇者聯盟出任務時，因為美國隊長有滿滿的正義感，");
            Console.WriteLine("都會搶先出動，因此結果會為:\n");
            Console.ForegroundColor = ConsoleColor.White;

            var whoExecutiveTask = new Task();
            whoExecutiveTask.ShowTime();

            Console.WriteLine("==========================我是分隔線==========================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("但有時委派人會希望由別的英雄去執行任務，");
            Console.WriteLine("因此就必須根據需求修改指派的英雄，");
            Console.WriteLine("讓復仇者聯盟的成員都能夠依指派去出任務。\n");
            Console.WriteLine("以下為符合 里氏替換原則 的範例!!");
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
                    executiveTask.ShowTimeWithLSP();
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
            Console.WriteLine("輸入 1 : 鋼鐵人。");
            Console.WriteLine("輸入 2 : 美國隊長。");
            Console.WriteLine("輸入 1、2 以外任意字 : 範例結束。\n");
            Console.Write("輸入:");
            return Console.ReadLine();
        }

        /// <summary>
        /// 運用工廠模式，根據傳入值回傳對應的英雄類別
        /// </summary>
        /// <param name="weaponType">傳入選項的值</param>
        /// <returns></returns>
        public static IAvengers GetAvenger(string weaponType)
        {
            IAvengers avenger;
            if (weaponType == "1")
                return avenger = new IronMan();
            if (weaponType == "2")
                return avenger = new CaptainAmerica();

            return null;
        }
    }
}
