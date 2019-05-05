using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    // 1.目前的寫法任務類別太過依賴奇異博士的類別，形成一個高耦合的狀態
    // 2.運用 依賴反轉原則 依賴抽象不依賴實體，進行重構，但由於還是有建立實體物件，耦合還是太高了
    // 3.運用 依賴注入原則 進行重構

    /// <summary>
    /// 任務類別
    /// </summary>
    public class Task
    {
        // 1
        // DoctorStrange doctorStrange = new DoctorStrange();

        // 2 3
        private IAvengers hero;
        public Task(IAvengers hero)
        {
            // 2
            // this.hero = new DoctorStrange();

            // 3
            this.hero = hero;
        }

        public void ShowTime()
        {
            // 1
            //doctorStrange.Attack();
            //doctorStrange.Defense();

            // 2
            this.hero.Attack();
        }
    }
}
