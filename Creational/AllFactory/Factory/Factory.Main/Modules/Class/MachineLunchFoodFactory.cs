﻿using Factory.Main.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Main.Modules.Class
{
    /// <summary>
    /// 中午覓食機-食物的工廠類別
    /// </summary>
    public class MachineLunchFoodFactory : ICapsuleToyMachineFactory
    {
        /// <summary>
        /// 回傳對應的扭蛋機類別
        /// </summary>
        /// <returns></returns>
        public ICapsuleToyMachine GetCapsuleToyMachine()
        {
            Console.WriteLine("選擇了 中午覓食機-食物 扭蛋機");
            return new MachineLunchFood();
        }
    }
}
