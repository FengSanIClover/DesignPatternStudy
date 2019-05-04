using Open_ClosePrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implent_OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("以下為尚未符合 開放封閉原則 的程式");
            Console.WriteLine("雷神索爾的攻擊武器有兩種，一種是使用雷神之槌作攻擊，如下範例。\n");
            Console.ForegroundColor = ConsoleColor.White;

            var thorWithMjolnir = new Thor();
            thorWithMjolnir.Attack();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("但如果要讓他更換武器作攻擊，就必須改寫類別的攻擊方法如下範例。\n");
            Console.ForegroundColor = ConsoleColor.White;

            var thorWithStormbreaker = new Thor();
            thorWithStormbreaker.Attack();

            Console.WriteLine("\n==========================我是分隔線==========================\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("可以看到因為更動原本的方法，導致索爾的武器被限制住了，");
            Console.WriteLine("這樣違反了開放封閉原則，新功能不應該是由修改舊方法而產生的，");
            Console.WriteLine("因此新增一個類別，去複寫原本的攻擊方法來做新功能的開發，");
            Console.WriteLine("從而讓程式符合開放封閉原則。\n");
            Console.WriteLine("擴充方法後，使用這就可以任意指定要使用的武器了。\n");
            Console.ForegroundColor = ConsoleColor.White;

            // 使用者輸入武器選項，顯示結果
            string opt = string.Empty;
            while (true)
            {
                opt = Choice();
                if (opt == "1" || opt == "2")
                {
                    var thor = GetThor(opt);
                    Console.Write("訊息:\n");
                    thor.Attack();
                    Console.WriteLine("========================執行成功========================\n");
                }
                else
                {
                    Console.WriteLine("========================範例結束請按任意鍵========================\n");
                    Console.Read();
                    return;
                }
            }
        }

        /// <summary>
        /// 提示使用者操作的方法，並回傳輸入值
        /// </summary>
        /// <returns>輸入值</returns>
        public static string Choice()
        {
            Console.WriteLine("請輸入索爾攻擊用的武器:");
            Console.WriteLine("輸入 1 : 使用雷神槌。");
            Console.WriteLine("輸入 2 : 使用雷霆戰斧 - 風暴破壞者。");
            Console.WriteLine("輸入 1、2 以外任意字 : 範例結束。\n");
            Console.Write("輸入:");
            return Console.ReadLine();
        }

        /// <summary>
        /// 運用工廠模式，根據傳入值回傳對應的索爾類別
        /// </summary>
        /// <param name="weaponType">傳入選項的值</param>
        /// <returns></returns>
        public static IAvengers GetThor(string weaponType)
        {
            IAvengers avenger;
            if (weaponType == "1")
                return avenger = new Thor();
            if (weaponType == "2")
                return avenger = new ThorWithStormbreaker();

            return null;
        }
    }
}
