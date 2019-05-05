using LeastKnowledgePrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implent_LKP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("以下為尚未符合 最少知識原則(迪米特法則) 的範例!!");
            Console.WriteLine("客人不應該能向廚師直接做點餐的動作。\n");
            Console.ForegroundColor = ConsoleColor.White;

            var client = new Client();

            var meal = Choice();
            if (meal == "1" || meal == "2")
            {
                client.OrderToCooker(Order(meal));
            }

            Console.WriteLine("===============================錯誤範例結束===============================");
            Console.WriteLine("================================我是分隔線================================");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("以下為符合 最少知識原則(迪米特法則) 的範例!!");
            Console.WriteLine("客人只需要向服務生點餐並拿到餐點就好。\n");
            Console.ForegroundColor = ConsoleColor.White;

            var food = Choice();
            if (food == "1" || food == "2")
            {
                client.OrderToWaiter(Order(food));
            }

            Console.WriteLine("\n=================================範例結束=================================");
            Console.Read();
        }

        /// <summary>
        /// 提示使用者操作的方法，並回傳輸入值
        /// </summary>
        /// <returns>輸入值</returns>
        public static string Choice()
        {
            Console.WriteLine("請輸入要點的餐點:");
            Console.WriteLine("輸入 1 : 花生熔岩卡啦雞腿堡重量級XL套餐。");
            Console.WriteLine("輸入 2 : (柴魚舞浪)大阪燒脆雞重量級XL套餐。");
            Console.WriteLine("輸入 1、2 以外任意字 : 不看結果，結束此範例。\n");
            Console.Write("輸入:");
            return Console.ReadLine();
        }

        /// <summary>
        /// 根據輸入號碼對應餐點
        /// </summary>
        /// <returns>輸入值</returns>
        public static string Order(string mealNumber)
        {
            var result = string.Empty;

            switch (mealNumber)
            {
                case "1":
                    result = "花生熔岩卡啦雞腿堡重量級XL套餐";
                    break; ;
                case "2":
                    result = "(柴魚舞浪)大阪燒脆雞重量級XL套餐";
                    break;
            }

            return result;
        }
    }
}
