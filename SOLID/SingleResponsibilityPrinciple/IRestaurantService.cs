using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// 負責餐廳所有服務的介面
    /// </summary>
    public interface IRestaurantService
    {
        /// <summary>
        /// 點餐
        /// </summary>
        void Order();

        /// <summary>
        /// 清理桌面
        /// </summary>
        void CleanTable();

        /// <summary>
        /// 結帳
        /// </summary>
        void CheckOut();

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
