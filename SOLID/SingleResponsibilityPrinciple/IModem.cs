using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// 數據機介面
    /// </summary>
    public interface IModem
    {
        // Dial、Hangup 的職責屬於連線
        // Send、Receive 的職責屬於數據溝通
        // 假如某天數據機的'連線'要升級，因此需要修改 IModem
        // 會導致與連線無關的 Send 與 Receive 跟著重新編譯與佈署
        // 風險隨之增加，重構的方法之一，利用介面抽離 2 個單一職責的介面
        // IConnection 和 IDataChannel
        /// <summary>
        /// 撥號
        /// </summary>
        void Dial();

        /// <summary>
        /// 掛斷
        /// </summary>
        void Hangup();

        /// <summary>
        /// 發送資料
        /// </summary>
        void Send();

        /// <summary>
        /// 接收資料
        /// </summary>
        void Receive();
    }
}
