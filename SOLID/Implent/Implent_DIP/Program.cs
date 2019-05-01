using DependencyInversionPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = DependencyInversionPrinciple.Task;

namespace Implent_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var introduce = $"實作結合了 依賴反轉原則 和 依賴注入原則 的範例 \n";
            Console.WriteLine(introduce);

            var doctorStrange = new DoctorStrange();
            var hulk = new Hulk();

            var task1 = new Task(doctorStrange);
            task1.ShowTime();

            Console.WriteLine("\n=====================================\n");

            var task2 = new Task(hulk);
            task2.ShowTime();

            Console.WriteLine("\n===== The End =====");
            Console.Read();
        }
    }
}
