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
        // 假如要替換預設英雄，那就必須改寫整個程式
        // 改用復仇者介面替換掉英雄類別
        // 之後只要英雄類別有繼承復仇者聯盟這個介面，都能夠任意的替換

        private CaptainAmerica captainAmerica;
        private IAvengers avengers;

        // 重構前
        public Task()
        {
            // 預設只能由美國隊長執行任務
            this.captainAmerica = new CaptainAmerica();
        }

        public void ShowTime()
        {
            this.captainAmerica.ExecutiveTask();
        }

        // 重構後 只要有繼承復仇者聯盟介面的英雄類別都可以執行任務
        public Task(IAvengers hero)
        {
            this.avengers = hero;
        }

        public void ShowTimeWithLSP()
        {
            this.avengers.ExecutiveTask();
        }
    }
}
