using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// 負責餐廳內場服務的介面
    /// </summary>
    public interface InsideRestaurantService
    {
        /// <summary>
        /// 做餐點
        /// </summary>
        void Cook();

        /// <summary>
        /// 備料
        /// </summary>
        void Preparation();
    }
}
