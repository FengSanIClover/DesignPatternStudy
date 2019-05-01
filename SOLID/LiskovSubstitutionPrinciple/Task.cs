using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    /// <summary>
    /// 任務類別
    /// </summary>
   public class Task
    {
        // 目前有2名英雄可以出任務
        // 執行任務時，神盾局指揮官，會預設派一名英雄
        // 假如要替換預設英雄，那就必須改寫整個程式
        // 重構的方式之一，改用復仇者介面替換掉英雄類別
        // 之後只要英雄類別有繼承復仇者這個介面，都能夠任意的替換

        private IronMan ironMan;
        private CaptainAmerica captainAmerica;
        private IAvengers avengers;
        private IEnumerable<int> a = new List<int>();

        // 重構前
        public Task(IronMan ironMan)
        {
            this.ironMan = ironMan;
        }

        public void ShowTime()
        {
            this.ironMan.Attack();
            this.ironMan.Defense();
        }

        // 重構後 不管傳入的是鋼鐵人或美國隊長都可以
        public Task(IAvengers hero)
        {
            this.avengers = hero;
        }

        public void ShowTime2()
        {
            this.avengers.Attack();
            this.avengers.Defense();
        }
    }
}
