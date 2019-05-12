using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    /// <summary>
    /// 定義飛行方法的介面，運用介面隔離出特定方法
    /// </summary>
   public interface IFly
    {
        /// <summary>
        /// 飛行方法
        /// </summary>
        void Fly();
    }
}
