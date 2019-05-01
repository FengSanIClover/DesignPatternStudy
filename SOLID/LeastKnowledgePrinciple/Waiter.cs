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

        // 不應該直接回傳廚師的類別給別人
        public Cooker GetCooker()
        {
            return this.cooker;
        }

        // 重構實作點餐的方法
        public string OrderMeal(string food)
        {
            return this.cooker.Cook(food);
        }
    }
}
