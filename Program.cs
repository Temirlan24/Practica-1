using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIO: Yerzatuly Temirlan");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int number1 = Convert.ToInt32(a);
            int number2 = Convert.ToInt32(b);
            
            Console.WriteLine(number1+number2);
            Console.ReadKey();

        }
    }
}