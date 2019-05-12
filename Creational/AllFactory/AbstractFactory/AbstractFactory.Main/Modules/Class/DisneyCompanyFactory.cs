using AbstractFactory.Main.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main.Modules.Class
{
    /// <summary>
    /// 迪士尼公司工廠類別，繼承負責外觀的工廠介面
    /// </summary>
    public class DisneyCompanyFactory : IEquipmentFactory
    {
        /// <summary>
        /// 設定扭蛋的外型
        /// </summary>
        /// <returns></returns>
        public IEggStyle SetEggStyleType()
        {
            var mickeyShape = new EggStyle();

            mickeyShape.Shape = "米奇";

            return mickeyShape;
        }

        /// <summary>
        /// 設定機台的外型
        /// </summary>
        /// <returns></returns>
        public IMachineStyle SetMachineStyleType()
        {
            var minnieStyle = new MachineStyle();

            minnieStyle.Style = "米妮";

            return minnieStyle;
        }
    }
}
