using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastKnowledgePrinciple
{
    /// <summary>
    /// 廚師類別
    /// </summary>
   public class Cooker
    {
        /// <summary>
        /// 製作餐點
        /// </summary>
        /// <param name="food">客人點的餐點</param>
        /// <returns>做好的餐點</returns>
        public string Cook(string food)
        {
            return $"餐點:{food}，好了。\n";
        }
    }
}
