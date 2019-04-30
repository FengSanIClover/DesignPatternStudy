using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_ClosePrinciple
{
    public class Letter : INotify
    {
        /// <summary>
        /// 寄信通知繳稅
        /// </summary>
        public void Send()
        {
            Console.WriteLine("寄信通知繳稅");
        }
    }
}
