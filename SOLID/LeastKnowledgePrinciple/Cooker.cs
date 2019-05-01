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
        public string Cook(string food)
        {
            return $"餐點:{food}，好了";
        }
    }
}
