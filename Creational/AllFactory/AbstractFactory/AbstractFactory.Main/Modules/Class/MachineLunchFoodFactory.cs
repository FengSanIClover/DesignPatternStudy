using AbstractFactory.Main.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main.Modules.Class
{
    /// <summary>
    /// 中午覓食機-食物的工廠類別
    /// </summary>
    public class MachineLunchFoodFactory : ICapsuleToyMachineFactory
    {
        private  DisneyCompanyFactory disneyCompanyFactory = new DisneyCompanyFactory();

        /// <summary>
        /// 回傳對應的扭蛋機類別
        /// </summary>
        /// <returns></returns>
        public ICapsuleToyMachine GetCapsuleToyMachine()
        {
            Console.WriteLine("選擇了 中午覓食機-食物 扭蛋機\n");

            var machineLunchFood = new MachineLunchFood();

            // 設定機台外型
            machineLunchFood.EggShape = disneyCompanyFactory.SetEggStyleType();
            machineLunchFood.MachineShape = disneyCompanyFactory.SetMachineStyleType();

            // 顯示外型設定
            machineLunchFood.EggShape.ShowDetails();
            machineLunchFood.MachineShape.ShowDetails();

            return machineLunchFood;
        }
    }
}
