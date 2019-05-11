using SimpleFactory.Main.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Main.Models.Class
{
    /// <summary>
    /// 中午覓食機-食物(內有 大學日燒肉丼食堂、真好吃燒腊、18廚房、二前二町拉麵、南方水餃)，
    /// 繼承扭蛋機介面，實作方法
    /// </summary>
    public class MachineLunchFood : ICapsuleToyMachine
    {
        /// <summary>
        /// 轉動扭蛋機，取得結果
        /// </summary>
        /// <returns>扭蛋結果</returns>
        public string TurnHandle()
        {
            var result = string.Empty;
            var rand = new Random();
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

            return $"扭蛋機:中午覓食機-食物 \n扭出的扭蛋是:{result}";
        }
    }
}
