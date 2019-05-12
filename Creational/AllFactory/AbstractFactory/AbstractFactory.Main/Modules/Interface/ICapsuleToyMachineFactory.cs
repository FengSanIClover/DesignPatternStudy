using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main.Modules.Interface
{
    /// <summary>
    /// 扭蛋機的工廠介面
    /// 這只是一個概念或規範，要產生什麼留給子類別實作
    /// </summary>
    public interface ICapsuleToyMachineFactory
    {
        /// <summary>
        /// 回傳對應的繼承扭蛋機介面的類別
        /// </summary>
        /// <returns></returns>
        ICapsuleToyMachine GetCapsuleToyMachine();
    }
}
