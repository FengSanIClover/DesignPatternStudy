using SimpleFactory.Main.Modules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Main.Modules.Class
{
    /// <summary>
    /// 簡易工廠類別
    /// </summary>
    public class CapsuleToyMachineFactory
    {
        public static string GetCapsuleToyMachineResult(string choiceType)
        {
            ICapsuleToyMachine machine;
            switch (choiceType)
            {
                case "1":
                    machine = new MachineLunchFood();
                    return  machine.TurnHandle();
                case "2":
                    machine = new MachineLunchDrink();
                    return machine.TurnHandle();
                default:
                    Console.WriteLine("結束範例");
                    return string.Empty;
            }
        }
    }
}
