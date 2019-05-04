using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// 負責外場的服務生，繼承外場服務的介面
    /// </summary>
    public class OuterWaiter : IOuterRestaurantService
    {
        /// <summary>
        /// 服務生名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 疲勞度
        /// </summary>
        private int tire;
        public int Tire { get => this.tire; }

        /// <summary>
        /// 初始化外場服務生資訊的建構子
        /// </summary>
        /// <param name="name"></param>
        public OuterWaiter(string name)
        {
            this.Name = name;
            this.tire = 0;
        }

        /// <summary>
        /// 執行外場-結帳服務
        /// </summary>
        public void CheckOut()
        {
            this.ShowMessage(this.Name, "結帳");
        }

        /// <summary>
        /// 執行外場-清理桌面服務
        /// </summary>
        public void CleanTable()
        {
            this.ShowMessage(this.Name, "清理桌面");
        }

        /// <summary>
        /// 執行外場-點餐服務
        /// </summary>
        public void Order()
        {
            this.ShowMessage(this.Name, "點餐");
        }

        /// <summary>
        /// 回傳結果訊息
        /// </summary>
        /// <param name="name">服務生名字</param>
        /// <param name="workName">工作名稱</param>
        private void ShowMessage(string name,string workName)
        {
            this.tire += 1;
            Console.WriteLine($"{name}服務生，執行了 外場 {workName}的工作");
            Console.WriteLine($"{name}服務生完成服務，累積疲勞值{this.Tire}\n");
        }
    }
}
