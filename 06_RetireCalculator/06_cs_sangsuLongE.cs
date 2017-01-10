using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_cs_sangsuLongE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your current age? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("At what age would you like to retire? ");
            int retireAge = int.Parse(Console.ReadLine());

            int reqYear = retireAge - age;
            if(reqYear > 0)
            {
                Console.WriteLine("You have {0} years left until you can retire.", reqYear);
                Console.WriteLine("It's {0}, so you can retire in {1}"
                    , DateTime.Now.Year, DateTime.Now.Year + reqYear);
            }
            else
            {
                Console.WriteLine("You almost retire...");
            }   
        }
    }
}
