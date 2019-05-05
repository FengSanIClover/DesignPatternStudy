using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    /// <summary>
    /// 任務類別
    /// </summary>
   public class Mission
    {
        private IAvengers avenger;

        /// <summary>
        /// 透過建構子將有繼承 IAvengers 的英雄物件傳給任務類別
        /// </summary>
        /// <param name="hero"></param>
        public Mission(IAvengers hero)
        {
            this.avenger = hero;
        }

        /// <summary>
        /// 英雄登場並攻擊，因為都有繼承 IAvengers 因此執行共同方法時不用再指定傳入的英雄參數
        /// </summary>
        public void ShowTime()
        {
            this.avenger.Attack();
        }

        /// <summary>
        /// 可以飛的英雄執行飛行，因為不是每個繼承 IAvengers 的英雄類別都有再繼承 IFly 介面
        /// 因次要限定傳入的英雄參數有繼承 IFly 才能執行飛行方法
        /// </summary>
        public void FlyAway(IFly canFlyHero)
        {
            canFlyHero.Fly();
        }
    }
}
