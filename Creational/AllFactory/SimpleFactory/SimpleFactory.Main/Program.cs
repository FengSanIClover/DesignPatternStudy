using SimpleFactory.Main.Modules.Class;
using SimpleFactory.Main.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("這是簡易工廠模式範例!!\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("歡迎來到扭蛋專賣店~!!\n");
            Console.WriteLine("請選擇要使用的扭蛋機\n");
            Console.WriteLine("1.中午覓食機-食物(內有 大學日燒肉丼食堂、真好吃燒腊、18廚房、二前二町拉麵、南方水餃)");
            Console.WriteLine("2.中午覓食機-飲料店(內有 二芳水果茶、六十嵐、夏陽茶事、麻吉、龜小方)");
            Console.WriteLine("離開請輸入1、2外的任意字");
            Console.ForegroundColor = ConsoleColor.White;
            #region 範例一 使用者介面與邏輯都寫在一起，耦合度高
            {
                //var rand = new Random();
                //var result = string.Empty;
                //while (true)
                //{
                //    Console.Write("請輸入:");
                //    var choice = Console.ReadLine();
                //    switch (choice)
                //    {
                //        case "1":
                //            var randFood = rand.Next(1, 11);
                //            if (randFood <= 2)
                //            {
                //                result = "大學日燒肉丼食堂";
                //            }
                //            else if (randFood <= 4)
                //            {
                //                result = "真好吃燒腊";
                //            }
                //            else if (randFood <= 6)
                //            {
                //                result = "18廚房";
                //            }
                //            else if (randFood <= 8)
                //            {
                //                result = "二前二町拉麵";
                //            }
                //            else
                //            {
                //                result = "南方水餃";
                //            }
                //            break;
                //        case "2":
                //            var randDrink = rand.Next(1, 11);
                //            if (randDrink <= 2)
                //            {
                //                result = "二芳水果茶";
                //            }
                //            else if (randDrink <= 4)
                //            {
                //                result = "六十嵐";
                //            }
                //            else if (randDrink <= 6)
                //            {
                //                result = "夏陽茶事";
                //            }
                //            else if (randDrink <= 8)
                //            {
                //                result = "麻吉";
                //            }
                //            else
                //            {
                //                result = "龜小方";
                //            }
                //            break;
                //        default:
                //            Console.WriteLine("結束範例");
                //            Console.Read();
                //            return;
                //    }
                //    choice = choice == "1" ? "中午覓食機-食物" : "中午覓食機-飲料店";
                //    Console.WriteLine($"扭蛋機:{choice}\n扭出的扭蛋是:{result}");
                //    Console.WriteLine("=======================執行完畢=======================");
                //}
            }
            #endregion

            #region 範例二使用類別將邏輯抽離
            {
                //var rand = new Random();
                //var result = string.Empty;
                //while (true)
                //{
                //    Console.Write("請輸入:");
                //    var choice = Console.ReadLine();

                //    result = CapsuleToyMachine.TurnHandle(choice);
                //    if (result == string.Empty)
                //    {
                //        Console.Read();
                //        return;
                //    }

                //    Console.WriteLine(result);
                //    Console.WriteLine("=======================執行完畢=======================");
                //}
            }
            #endregion

            #region 範例三運用簡易工廠模式
            {
                var rand = new Random();
                var result = string.Empty;
                while (true)
                {
                    Console.Write("請輸入:");
                    var choice = Console.ReadLine();

                    ICapsuleToyMachine machine;
                    switch (choice)
                    {
                        case "1":
                            machine = new MachineLunchFood();
                            result = machine.TurnHandle();
                            break;
                        case "2":
                            machine = new MachineLunchDrink();
                            result = machine.TurnHandle();
                            break;
                        default:
                            Console.WriteLine("結束範例");
                            Console.Read();
                            return;
                    }

                    Console.WriteLine(result);
                    Console.WriteLine("=======================執行完畢=======================");
                }
            }
            #endregion
        }
    }
}
