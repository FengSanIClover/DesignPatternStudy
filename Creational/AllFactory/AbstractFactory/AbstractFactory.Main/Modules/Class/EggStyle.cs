using AbstractFactory.Main.Modules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Main.Modules.Class
{
    /// <summary>
    /// 扭蛋外型類別，繼承扭蛋外型介面
    /// </summary>
    public class EggStyle : IEggStyle
    {
        /// <summary>
        /// 設定扭蛋的外型
        /// </summary>
        private string shape;
        public string Shape
        {
            get { return this.shape; }
            set { this.shape = value; }
        }

        /// <summary>
        /// 說明詳細樣式的方法
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine($"此機台的扭蛋外型為:{this.Shape}外型的形狀");
        }
    }
}
