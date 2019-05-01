using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    /// 復仇者介面
    /// </summary>
   public interface IAvengers
    {
        /// <summary>
        /// 攻擊
        /// </summary>
        void Attack();

        /// <summary>
        /// 防禦
        /// </summary>
        void Defense();
    }
}
