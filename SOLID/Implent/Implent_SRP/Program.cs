using SingleResponsibilityPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implent_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MultiTaskWaiter 為一個可以執行多項工作的超好用服務生，");
            Console.WriteLine("可以同時執行內、外場的餐廳服務工作，但如果一直讓他內、外場不停地跑，");
            Console.WriteLine("疲勞值累積會加快，很快就會累倒，");
            Console.WriteLine("這是一個違反單一職責原則的例子。");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n========================違反單一職責原則範例========================\n");

            var multiTaskWaiter = new UserfulWaiter("店小二");
            multiTaskWaiter.Order();
            multiTaskWaiter.Cook();
            multiTaskWaiter.Preparation();
            multiTaskWaiter.CheckOut();
            multiTaskWaiter.CleanTable();
            multiTaskWaiter.Preparation();

            Console.WriteLine("\n========================單一職責原則範例========================\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("內、外場職責分離後，員工就不需要一人身兼多職，");
            Console.WriteLine("只需做好份內的事，疲勞度也就不會增加得太快。\n");
            Console.ForegroundColor = ConsoleColor.White;

            var insideWaiter = new InsideWaiter("店小三");
            insideWaiter.Cook();
            insideWaiter.Preparation();

            var outerWaiter = new OuterWaiter("店小四");
            outerWaiter.Order();
            outerWaiter.CheckOut();
            outerWaiter.CleanTable();

            Console.Read();
        }
    }
}
