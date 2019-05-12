using AbstractFactory.Main.Modules.Class;
using AbstractFactory.Main.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("這是抽象工廠模式範例!!\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("歡迎來到扭蛋專賣店~!!\n");
            Console.WriteLine("請選擇要使用的扭蛋機\n");
            Console.WriteLine("1.中午覓食機-食物(內有 大學日燒肉丼食堂、真好吃燒腊、18廚房、二前二町拉麵、南方水餃)");
            Console.WriteLine("2.中午覓食機-飲料店(內有 二芳水果茶、六十嵐、夏陽茶事、麻吉、龜小方)");
            Console.WriteLine("離開請輸入1、2外的任意字");
            Console.ForegroundColor = ConsoleColor.White;

            var result = string.Empty;
            while (true)
            {
                ICapsuleToyMachineFactory capsuleToyMachineFactory;
                ICapsuleToyMachine capsuleToyMachine;

                Console.Write("請輸入:");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        capsuleToyMachineFactory = new MachineLunchFoodFactory();
                        capsuleToyMachine = capsuleToyMachineFactory.GetCapsuleToyMachine();
                        result = capsuleToyMachine.TurnHandle();
                        break;
                    case "2":
                        capsuleToyMachineFactory = new MachineLunchDrinkFactory();
                        capsuleToyMachine = capsuleToyMachineFactory.GetCapsuleToyMachine();
                        result = capsuleToyMachine.TurnHandle();
                        break;
                    default:
                        Console.WriteLine("結束範例!!");
                        Console.Read();
                        return;
                }

                Console.WriteLine(result);
                Console.WriteLine("=======================執行完畢=======================");
            }
        }
    }
}
