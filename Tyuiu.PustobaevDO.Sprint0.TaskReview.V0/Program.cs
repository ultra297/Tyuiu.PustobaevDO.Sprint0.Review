using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PustobaevDO.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PustobaevDO.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите значение x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение z:");
            int z = int.Parse(Console.ReadLine());
            
            DataService dataService = new DataService();           
            int result = dataService.Calc(x, y, z);
           
            Console.WriteLine($"Результат вычисления: {result}");
            
            Console.ReadLine(); 
        }
    }    
}
