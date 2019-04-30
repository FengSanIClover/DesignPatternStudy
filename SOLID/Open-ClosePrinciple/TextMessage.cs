using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosePrinciple
{
    public class TextMessage : INotify
    {
        /// <summary>
        /// 寄簡訊通知繳稅
        /// </summary>
        public void Send()
        {
            Console.WriteLine("寄簡訊通知繳稅");
        }
    }
}
