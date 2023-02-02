using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            int sum = x + y;
            int subtract = x - y;
            int multiplication = x * y;
            int divide = x / y;
            int modulo = x % y;
            Console.WriteLine(sum);
            Console.WriteLine(subtract);
            Console.WriteLine(multiplication);
            Console.WriteLine(divide);
            Console.WriteLine(modulo);

            Console.ReadLine();
        }
        
    }
}
