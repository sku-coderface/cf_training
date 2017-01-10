using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_cs_sangsuLongE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the first number? ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("What is the second number? ");
            int secondNumber = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("{0} + {1} = {2} \n{0} - {1} = {3}\n{0} * {1} = {4}\n{0} / {1} = {5}"
                , firstNumber, secondNumber, (firstNumber + secondNumber), (firstNumber - secondNumber)
                , (firstNumber * secondNumber), (firstNumber / secondNumber));
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("\nError You can't divide by zero\n\n" + e.StackTrace);
            }
        }
    }
}
