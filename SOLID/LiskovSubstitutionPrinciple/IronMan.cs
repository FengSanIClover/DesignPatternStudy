using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    /// 鋼鐵人類別繼承復仇者介面
    /// </summary>
    public class IronMan : IAvengers
    {
        /// <summary>
        /// 實作攻擊
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("鋼鐵人發射光束攻擊");
        }

        /// <summary>
        /// 實作防禦
        /// </summary>
        public void Defense()
        {
            Console.WriteLine("鋼鐵人飛走了");
        }
    }
}
