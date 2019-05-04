using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// 超好用的餐廳服務生類別，繼承餐廳服務
    /// </summary>
    public class UserfulWaiter : IRestaurantService
    {
        /// <summary>
        /// 服務生名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 計算疲勞度
        /// </summary>
        private int tire;
        public int Tire { get => this.tire; }

        /// <summary>
        /// 原本執行的工作
        /// </summary>
        public string oriWorkType;

        /// <summary>
        /// 目前執行的工作
        /// </summary>
        private string nowWorkType;

        /// <summary>
        /// 初始化超好用的餐廳服務生資訊的建構子
        /// </summary>
        /// <param name="name"></param>
        public UserfulWaiter(string name)
        {
            this.Name = name;
            this.tire = 0;
            this.oriWorkType = string.Empty;
            this.nowWorkType = string.Empty;
        }

        /// <summary>
        /// 執行外場-結帳服務
        /// </summary>
        public void CheckOut()
        {
            if (this.Tire >= 100)
            {
                Console.WriteLine($"{this.Name}超好用服務生已經累垮了!!");
                return;
            }

            Console.WriteLine($"{this.Name}超好用服務生，執行了 外場 結帳的工作");

            // System.Reflection.MethodBase.GetCurrentMethod().Name 可以取得當下方法名
            this.nowWorkType = "外場";
            this.FinishWork(this.nowWorkType, this.Name);
        }

        /// <summary>
        /// 執行外場-清理桌面服務
        /// </summary>
        public void CleanTable()
        {
            if (this.Tire >= 100)
            {
                Console.WriteLine($"{this.Name}超好用服務生已經累垮了!!");
                return;
            }

            Console.WriteLine($"{this.Name}超好用服務生，執行了 外場 清理桌面的工作");

            this.nowWorkType = "外場";
            this.FinishWork(this.nowWorkType, this.Name);
        }

        /// <summary>
        /// 執行外場-點餐服務
        /// </summary>
        public void Order()
        {
            if (this.Tire >= 100)
            {
                Console.WriteLine($"{this.Name}超好用服務生已經累垮了!!");
                return;
            }

            Console.WriteLine($"{this.Name}超好用服務生，執行了 外場 點餐的工作");

            this.nowWorkType = "外場";
            this.FinishWork(this.nowWorkType, this.Name);
        }

        /// <summary>
        /// 執行內場-做餐點服務
        /// </summary>
        public void Cook()
        {
            if (this.Tire >= 100)
            {
                Console.WriteLine($"{this.Name}超好用服務生已經累垮了!!");
                return;
            }

            Console.WriteLine($"{this.Name}超好用服務生，執行了 內場 做餐點的工作");

            this.nowWorkType = "內場";
            this.FinishWork(this.nowWorkType, this.Name);
        }

        /// <summary>
        /// 執行內場-備料服務
        /// </summary>
        public void Preparation()
        {
            if (this.Tire >= 100)
            {
                Console.WriteLine($"{this.Name}超好用服務生已經累垮了!!");
                return;
            }

            Console.WriteLine($"{this.Name}超好用服務生，執行了 內場 備料的工作");

            this.nowWorkType = "內場";
            this.FinishWork(this.nowWorkType, this.Name);
        }

        /// <summary>
        /// 累積服務生執行內、外場服務後的疲勞值
        /// </summary>
        /// <param name="workingType">1:外場，2:內場</param>
        /// <param name="waiterName">服務生姓名</param>
        private void FinishWork(string workType, string waiterName)
        {
            
            if (this.oriWorkType == workType || this.oriWorkType == string.Empty)
            {
                this.tire += 1;
            }
            else
            {
                this.tire += 50;
            }
            this.oriWorkType = workType;
            Console.WriteLine($"{waiterName}超好用服務生完成服務，累積疲勞值{this.Tire}\n");
        }
    }
}
