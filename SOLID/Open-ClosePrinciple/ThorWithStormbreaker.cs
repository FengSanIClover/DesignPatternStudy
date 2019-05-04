using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosePrinciple
{
    /// <summary>
    /// 使用雷霆戰斧 的索爾類別
    /// </summary>
    public class ThorWithStormbreaker : Thor
    {
        // 繼承原本的索爾類別，並覆寫攻擊方法

        public override void Attack()
        {
            Console.WriteLine("索爾運用雷霆戰斧-風暴破壞者 攻擊。\n");
        }
    }
}
