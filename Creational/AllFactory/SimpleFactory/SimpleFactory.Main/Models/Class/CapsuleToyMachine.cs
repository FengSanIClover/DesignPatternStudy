using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Main.Models.Class
{
    /// <summary>
    /// 扭蛋機類別
    /// </summary>
   public class CapsuleToyMachine
    {
        /// <summary>
        /// 透過機台序號回傳相對結果
        /// </summary>
        /// <param name="machineNumber">扭蛋機台序號</param>
        /// <returns>結果</returns>
        public static string TurnHandle(string machineNumber)
        {
            var rand = new Random();
            var result = string.Empty;
            while (true)
            {
                switch (machineNumber)
                {
                    case "1":
                        var randFood = rand.Next(1, 11);
                        if (randFood <= 2)
                        {
                            result = "大學日燒肉丼食堂";
                        }
                        else if (randFood <= 4)
                        {
                            result = "真好吃燒腊";
                        }
                        else if (randFood <= 6)
                        {
                            result = "18廚房";
                        }
                        else if (randFood <= 8)
                        {
                            result = "二前二町拉麵";
                        }
                        else
                        {
                            result = "南方水餃";
                        }
                        break;
                    case "2":
                        var randDrink = rand.Next(1, 11);
                        if (randDrink <= 2)
                        {
                            result = "二芳水果茶";
                        }
                        else if (randDrink <= 4)
                        {
                            result = "六十嵐";
                        }
                        else if (randDrink <= 6)
                        {
                            result = "夏陽茶事";
                        }
                        else if (randDrink <= 8)
                        {
                            result = "麻吉";
                        }
                        else
                        {
                            result = "龜小方";
                        }
                        break;
                    default:
                        Console.WriteLine("結束範例");
                        return result;
                }
                machineNumber = machineNumber == "1" ? "中午覓食機-食物" : "中午覓食機-飲料店";
                return $"扭蛋機:{machineNumber}\n扭出的扭蛋是:{result}";
            }
        }
    }
}
