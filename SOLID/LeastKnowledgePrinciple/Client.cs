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
        // 在顧客的類別內，不應該出現廚師的類別
        // Client 與 Waiter 內部的 Cooker 強烈耦合，若想要換掉 Cooker 物件，則 Client 必須跟著修改，也就是暴露內部物件。

        // Client 為了要拿到餐點，竟然還必須知道 Waiter 內部使用了 Cooker 物件，
        // 先使用 GetCooker() 取得 Cooker 才行，也就是暴露實踐細節。

        // 顧客不需要廚師怎麼做菜的，只需要跟服務生點餐，並拿到餐點就好
        // 重構透過服務生的取餐方法拿到食物
        // 客人只知道服務生，而服務生只知道廚師

        private Waiter waiter;

        public Client()
        {
            this.waiter = new Waiter();
        }

        public void Order()
        {
            // 直接取得廚師的類別並做菜，寫出 Train Wreck 火車一樣，一長串
            // var meal = this.waiter.GetCooker().Cook("牛肉麵");

            // 重構後的方法
            var meal = this.waiter.OrderMeal("牛肉麵");

            // 是否產生 Train Wreck 關鍵在於有沒有暴露內部物件與暴露實踐細節
            List<int> number = new List<int>();
            var result = number
                .Where(n => n > 5)
                .OrderBy(n => n)
                .Skip(5)
                .Take(10)
                .Select(n => n);
            // Where()、OrderBy()... 這些，並沒有回傳其內部物件，而是傳回 this，因此沒有暴露內部物件與暴露實踐細節的問題
        }
    }
}
