using AbstractFactory.Main.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main.Modules.Class
{
    /// <summary>
    /// 中午覓食機-飲料店的工廠類別
    /// </summary>
    public class MachineLunchDrinkFactory : ICapsuleToyMachineFactory
    {
        private DoraemonFactory doraemonFactory = new DoraemonFactory();

        /// <summary>
        /// 回傳對應的扭蛋機類別
        /// </summary>
        /// <returns></returns>
        public ICapsuleToyMachine GetCapsuleToyMachine()
        {
            Console.WriteLine("選擇了 中午覓食機-飲料店 扭蛋機\n");

            var machineLunchDrink = new MachineLunchDrink();

            // 設定機台外型
            machineLunchDrink.EggShape = doraemonFactory.SetEggStyleType();
            machineLunchDrink.MachineShape = doraemonFactory.SetMachineStyleType();

            // 顯示外型設定
            machineLunchDrink.EggShape.ShowDetails();
            machineLunchDrink.MachineShape.ShowDetails();

            return machineLunchDrink;
        }
    }
}
