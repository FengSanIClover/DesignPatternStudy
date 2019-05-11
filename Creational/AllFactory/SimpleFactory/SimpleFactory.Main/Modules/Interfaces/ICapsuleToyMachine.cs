using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Main.Modules.Interfaces
{
    /// <summary>
    /// 扭蛋機介面
    /// </summary>
   public interface ICapsuleToyMachine
    {
        /// <summary>
        /// 轉動扭蛋機，取得結果
        /// </summary>
        /// <returns>扭蛋結果</returns>
        string TurnHandle();
    }
}
