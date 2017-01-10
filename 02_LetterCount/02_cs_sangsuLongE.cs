using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_cs_sangsuLongE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the input string? : ");
            string input = Console.ReadLine();
            Console.WriteLine(input + " has "+(input.Length-1)+"characters");
        }
    }
}
