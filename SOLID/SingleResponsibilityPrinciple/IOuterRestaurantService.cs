using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// 負責餐廳外場服務的介面
    /// </summary>
    public interface IOuterRestaurantService
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
    }
}
