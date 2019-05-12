using AbstractFactory.Main.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main.Modules.Class
{
    /// <summary>
    /// 哆啦A夢工廠類別，繼承負責外觀的工廠介面
    /// </summary>
    public class DoraemonFactory : IEquipmentFactory
    {
        /// <summary>
        /// 設定扭蛋的外型
        /// </summary>
        /// <returns></returns>
        public IEggStyle SetEggStyleType()
        {
            var bellStyle = new EggStyle();

            bellStyle.Shape = "鈴鐺";

            return bellStyle;
        }

        /// <summary>
        /// 設定機台的外型
        /// </summary>
        /// <returns></returns>
        public IMachineStyle SetMachineStyleType()
        {
            var doraemonStyle = new MachineStyle();

            doraemonStyle.Style = "哆啦A夢";

            return doraemonStyle;
        }
    }
}
