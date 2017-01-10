using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a noun: ");
            string noun = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string adjective = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            string adverb = Console.ReadLine();

            Console.WriteLine("Do you {0} your {1} {2} {3}", verb, adjective, noun, adverb);
        }
    }
}
