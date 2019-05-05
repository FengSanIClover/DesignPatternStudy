using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    /// <summary>
    /// 索爾類別繼承復仇者聯盟介面
    /// </summary>
    public class Thor : IAvengers ,IFly
    {
        /// <summary>
        /// 實作 IAvengers 攻擊方法
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("索爾使用雷神之槌攻擊。\n");
        }

        /// <summary>
        /// 實作 IFly 飛行方法
        /// </summary>
        public void Fly()
        {
            Console.WriteLine("索爾靠著雷神槌飛起來了。\n");
        }
    }
}
