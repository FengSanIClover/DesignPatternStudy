using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosePrinciple
{
    /// <summary>
    /// 國稅局類別
    /// </summary>
   public class NationalTaxAdministration
    {
        // 每年到了繳稅時，國稅局都要通知國人繳稅，
        // 1.往年都是寄信通知
        // 2.今年政策改變，改用寄簡訊通知
        // 假如後年政策再改，那通知繳稅的方法就會一直改變
        // 重構方法一 加入參數決定使用的通知方式
        // 此方法違反單一職責原則，寄信是一個職責，寄簡訊是另個職責
        // 重構方法二 透過介面抽換職責 -> ReNationalTaxAdministration
        public void NotifyPayTax(string notifyType)
        {
            // 1.寄信
            // this.SendLetter();

            // 2.寄簡訊
            // this.SendTextMessage();

            // 重構一
            switch (notifyType)
            {
                case "Letter":
                    this.SendLetter();
                    break;
                case "TextMessage":
                    this.SendTextMessage();
                    break;
                default:
                    Console.WriteLine("還沒想到...");
                    break;
            }
        }

        /// <summary>
        /// 寄信通知繳稅
        /// </summary>
        private void SendLetter()
        {
            Console.WriteLine("寄信通知繳稅");
        }

        /// <summary>
        /// 寄簡訊通知繳稅
        /// </summary>
        private void SendTextMessage()
        {
            Console.WriteLine("寄簡訊通知繳稅");
        }
    }
}
