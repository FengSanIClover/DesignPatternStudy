using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosePrinciple
{
    /// <summary>
    /// 雷神索爾類別，繼承復仇者聯盟介面，並實作攻擊方法
    /// </summary>
    public class Thor : IAvengers
    {
        /// <summary>
        /// 攻擊方法，加入 virtual 供子類別修改擴充 
        /// </summary>
        public virtual void Attack()
        {
             Console.WriteLine("索爾運用雷神之槌攻擊。\n");

            // 變更攻擊方法
            // Console.WriteLine("索爾運用雷霆戰斧-風暴破壞者 攻擊。\n");
        }
    }
}
