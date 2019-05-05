using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastKnowledgePrinciple
{
    /// <summary>
    /// 服務生類別
    /// </summary>
   public class Waiter
    {
        private Cooker cooker;

        public Waiter()
        {
            this.cooker = new Cooker();
        }

        /// <summary>
        /// 錯誤-不應該直接回傳廚師的類別給客人
        /// </summary>
        /// <param name="meal">客人點的餐</param>
        /// <returns>廚師物件</returns>
        public Cooker GetCooker(string meal)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n服務生帶 '廚師' 出來見客人，詢問要點什麼菜。({meal})\n");
            Console.ForegroundColor = ConsoleColor.White;

            return this.cooker;
        }

        /// <summary>
        /// 正確-透過服務生向廚師點餐的方法
        /// </summary>
        /// <param name="food">客人點的餐</param>
        /// <returns>做好的餐點</returns>
        public string OrderMeal(string food)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n '服務生' 將客人點的菜單交給廚師處理。\n");
            Console.ForegroundColor = ConsoleColor.White;

            return this.cooker.Cook(food);
        }
    }
}
