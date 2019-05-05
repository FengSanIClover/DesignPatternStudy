using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastKnowledgePrinciple
{
    /// <summary>
    /// 顧客類別
    /// </summary>
   public class Client
    {
        // 錯誤
        // 在顧客的類別內，不應該出現廚師的類別
        // 客人類別 與 服務生類別 內部的 廚師類別 強烈耦合，若想要換掉 廚師類別，
        // 則 客人類別 必須跟著修改，也就是暴露內部物件。

        // 客人類別 為了要拿到餐點，竟然還必須知道 服務生類別 內部使用了 廚師類別 ，
        // 先使用 GetCooker() 取得 廚師物件 才行，也就是暴露實踐細節。

        // 正確
        // 顧客不需要廚師怎麼做菜的，只需要跟服務生點餐，並拿到餐點就好，
        // 重構透過服務生的取餐方法拿到食物
        // 客人只知道服務生，而服務生只知道廚師

        private Waiter waiter;

        public Client()
        {
            this.waiter = new Waiter();
        }

        /// <summary>
        /// 錯誤-叫服務生帶廚師出來讓客人點菜
        /// </summary>
        /// <param name="meal">客人點的餐點</param>
        public void OrderToCooker(string meal)
        {
            // 直接取得廚師的類別並做菜，寫出 Train Wreck 火車一樣，一長串
            var dish = this.waiter.GetCooker(meal).Cook(meal);
            Console.WriteLine($"{dish}\n'廚師' 把客人點的{meal}，交給客人。\n");
        }

        /// <summary>
        /// 正確-讓客人向服務生點菜
        /// </summary>
        /// <param name="meal">客人點的餐點</param>
        public void OrderToWaiter(string meal)
        {
            // 重構後的方法
            var dish = this.waiter.OrderMeal(meal);
            Console.WriteLine($"{dish}\n'服務生' 把客人點的{meal}，交給客人。");
        }

        /// <summary>
        ///  Train Wreck 示範
        /// </summary>
        private void TrainWreck()
        {
            // 是否產生 Train Wreck 關鍵在於有沒有 暴露內部物件 與 暴露實踐細節
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = number
                .Where(n => n > 5)
                .OrderBy(n => n)
                .Skip(5)
                .Take(10)
                .Select(n => n);
            // Where()、OrderBy()... 這些，並沒有回傳其內部物件，
            // 而是傳回 this，因此沒有 暴露內部物件 與 暴露實踐細節 的問題。
        }
    }
}
