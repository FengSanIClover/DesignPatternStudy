using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    /// <summary>
    /// 復仇者聯盟介面
    /// </summary>
   public interface IAvengers
    {
        /// <summary>
        /// 攻擊的方法
        /// </summary>
        void Attack();
    }
}
