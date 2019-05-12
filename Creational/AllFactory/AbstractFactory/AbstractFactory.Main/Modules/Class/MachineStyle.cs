using AbstractFactory.Main.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main.Modules.Class
{
    /// <summary>
    /// 設定扭蛋機台外型的類別
    /// </summary>
    public class MachineStyle : IMachineStyle
    {
        /// <summary>
        /// 設定扭蛋機的外型
        /// </summary>
        private string style;
        public string Style
        {
            get { return this.style; }
            set { this.style = value; }
        }

        /// <summary>
        /// 說明詳細樣式的方法
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine($"此機台的外型為:{this.Style}外型的形狀\n");
        }
    }
}
