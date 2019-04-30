using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// 單一職責(數據處理)
    /// </summary>
   public interface IDataChannel
    {
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
