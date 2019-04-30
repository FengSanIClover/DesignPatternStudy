using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosePrinciple
{
    /// <summary>
    /// 重構後的國稅局類別
    /// </summary>
    public class ReNationalTaxAdministration
    {
        /// <summary>
        /// 利用介面抽離寄送通知的方法
        /// </summary>
        private INotify notify;

        public ReNationalTaxAdministration()
        {
            // 透過不同類別實作 Send 方法
            // 這樣更改程式碼時就不會一直動到舊有的 NotifyPayTax 方法
            this.notify = new Letter();
            // this.notify = new TextMessage();
        }
        public void NotifyPayTax()
        {
            this.notify.Send();
        }
    }
}
