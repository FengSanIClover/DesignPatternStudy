using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    /// 鋼鐵人類別，繼承復仇者聯盟介面，並實作任務方法
    /// </summary>
    public class IronMan : IAvengers
    {
        /// <summary>
        /// 實作執行任務
        /// </summary>
        public void ExecutiveTask()
        {
            Console.WriteLine("鋼鐵人出發執行任務\n");
        }
    }
}
