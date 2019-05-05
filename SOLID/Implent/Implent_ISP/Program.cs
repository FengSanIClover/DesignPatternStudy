using InterfaceSegregationPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implent_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("以下為 介面隔離原則 的範例!!");
            Console.WriteLine("使用者可以挑選英雄執行任務，");
            Console.WriteLine("如果該英雄會飛，還能使用飛行的能力。");
            Console.ForegroundColor = ConsoleColor.White;

            // 使用者輸入英雄選項，顯示結果
            string opt = string.Empty;
            while (true)
            {
                Mission executiveMission;
                opt = Choice();
                switch (opt)
                {
                    case "1":
                        var antMan = new AntMan();

                        Console.Write("訊息:\n");

                        executiveMission = new Mission(antMan);
                        executiveMission.ShowTime();

                        Console.WriteLine("==========================執行成功============================\n");
                        break;
                    case "2":
                        var thor = new Thor();
                        executiveMission = new Mission(thor);

                        // 判斷是否要飛行
                        if (FlyAway() == "1")
                        {
                            Console.Write("訊息:\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("使用飛行的能力!!");

                            // 把索爾類別傳入，執行飛行方法
                            executiveMission.FlyAway(thor);
                        }
                        else
                        {
                            Console.Write("訊息:");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("選擇不飛行!!\n");
                        }
                        Console.ForegroundColor = ConsoleColor.White;

                        executiveMission.ShowTime();

                        Console.WriteLine("==========================執行成功============================\n");
                        break;
                    default:
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
            Console.WriteLine("輸入 1 : 蟻人。");
            Console.WriteLine("輸入 2 : 雷神索爾。");
            Console.WriteLine("輸入 1、2 以外任意字 : 範例結束。\n");
            Console.Write("輸入:");
            return Console.ReadLine();
        }

        /// <summary>
        /// 提示使用者操作的方法，並回傳輸入值
        /// </summary>
        /// <returns>輸入值</returns>
        public static string FlyAway()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n雷神索爾是可以飛行的英雄，");
            Console.WriteLine("要嘗試飛行嗎?\n");
            Console.WriteLine("輸入 1 : 飛行。");
            Console.WriteLine("輸入 任意字 :不飛行。\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("輸入:");
            return Console.ReadLine();
        }
    }
}
