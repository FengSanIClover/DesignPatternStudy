using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    ///  復仇者聯盟介面，定義任務方法
    /// </summary>
    public interface IAvengers
    {
        /// <summary>
        /// 執行任務的方法
        /// </summary>
        void ExecutiveTask();
    }
}
