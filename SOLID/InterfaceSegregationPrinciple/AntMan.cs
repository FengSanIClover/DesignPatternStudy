using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    /// <summary>
    /// 蟻人類別繼承復仇者聯盟介面
    /// </summary>
    public class AntMan : IAvengers
    {
        /// <summary>
        /// 實作 IAvengers 攻擊方法
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("蟻人變大後攻擊");
        }

        /// <summary>
        /// 實作 IAvengers 防禦方法
        /// </summary>
        public void Defense()
        {
            Console.WriteLine("蟻人縮小躲過攻擊");
        }

        ///// <summary>
        ///// 實作 IAvengers 飛行方法 (X 不需要)
        ///// </summary>
        //public void Fly()
        //{
        //    throw new Exception('不會飛啊!!!!!!');
        //}

        // 由於蟻人不需要飛行這個方法，復仇者聯盟內的成員也不一定都會飛行
        // 因此如果不會飛的英雄繼承了復仇者聯盟介面，硬要實作也怪怪的，
        // 丟出錯誤也不符合第三原則里氏替換原則，因此要再把飛行的方法另外抽離
        // 執行介面隔離原則
    }
}
