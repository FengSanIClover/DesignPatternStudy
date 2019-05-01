using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    /// 美國隊長類別繼承復仇者
    /// </summary>
    public class CaptainAmerica : IAvengers
    {
        /// <summary>
        /// 實作攻擊
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("美國隊長運用盾牌攻擊");
        }

        /// <summary>
        /// 實作防禦
        /// </summary>
        public void Defense()
        {
            Console.WriteLine("美國隊長運用盾牌防守");
        }
    }
}
