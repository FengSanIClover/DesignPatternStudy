using AbstractFactory.Main.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main.Modules.Class
{
    /// <summary>
    /// 中午覓食機-飲料店(內有 二芳水果茶、六十嵐、夏陽茶事、麻吉、龜小方)，
    /// 繼承扭蛋機介面，實作方法
    /// </summary>
    public class MachineLunchDrink : ICapsuleToyMachine
    {
        /// <summary>
        /// 扭蛋形狀
        /// </summary>
        public IEggStyle EggShape { get; set; }

        /// <summary>
        /// 機台外型
        /// </summary>
        public IMachineStyle MachineShape { get; set; }

        /// <summary>
        /// 轉動扭蛋機，取得結果
        /// </summary>
        /// <returns>扭蛋結果</returns>
        public string TurnHandle()
        {
            var result = string.Empty;
            var rand = new Random();
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

            return $"扭蛋機:中午覓食機-飲料店 \n扭出的扭蛋是:{result}";
        }
    }
}
