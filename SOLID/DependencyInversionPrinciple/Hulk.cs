using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    /// <summary>
    /// 浩克類別繼承復仇者聯盟介面
    /// </summary>
    public class Hulk : IAvengers
    {
        /// <summary>
        /// 實作 IAvengers 攻擊方法
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("浩克使用拳頭攻擊");
        }

        /// <summary>
        /// 實作 IAvengers 防禦方法
        /// </summary>
        public void Defense()
        {
            Console.WriteLine("浩克防禦");
        }
    }
}
