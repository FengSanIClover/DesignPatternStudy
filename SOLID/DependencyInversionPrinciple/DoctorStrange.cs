using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    /// <summary>
    /// 奇異博士類別繼承復仇者聯盟介面
    /// </summary>
    public class DoctorStrange : IAvengers
    {
        /// <summary>
        /// 實作 IAvengers 攻擊方法
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("奇異博士使用魔法攻擊");
        }

        /// <summary>
        /// 實作 IAvengers 防禦方法
        /// </summary>
        public void Defense()
        {
            Console.WriteLine("奇異博士使用了防護罩");
        }
    }
}
