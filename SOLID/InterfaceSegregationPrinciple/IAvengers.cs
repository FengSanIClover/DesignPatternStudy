using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    /// <summary>
    /// 復仇者聯盟介面
    /// </summary>
   public interface IAvengers
    {
        /// <summary>
        /// 攻擊方法
        /// </summary>
        void Attack();

        ///// <summary>
        ///// 飛行方法
        ///// </summary>
        //void Fly();

        // 因為不是所有人都需要，運用介面隔離原則 隔離飛行的方法
    }
}
