using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main.Modules.Interface
{
    /// <summary>
    /// 設定扭蛋機，機台、扭蛋外型的工廠介面
    /// </summary>
    public interface IEquipmentFactory
    {
        /// <summary>
        /// 設定扭蛋外型
        /// </summary>
        /// <returns>回傳設定好的類別</returns>
        IEggStyle SetEggStyleType();

        /// <summary>
        /// 設定機台外型
        /// </summary>
        /// <returns>回傳設定好的類別</returns>
        IMachineStyle SetMachineStyleType();
    }
}
