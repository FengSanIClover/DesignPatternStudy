using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    /// <summary>
    /// 單一職責(連線)
    /// </summary>
   public interface IConnection
    {
        /// <summary>
        /// 撥號
        /// </summary>
        void Dial();

        /// <summary>
        /// 掛斷
        /// </summary>
        void Hangup();
    }
}
