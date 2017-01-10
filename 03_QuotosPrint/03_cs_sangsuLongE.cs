using System;

namespace _03_cs_sangsuLongE_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the Quote ? ");
            Quote.QUOTE = Console.ReadLine();
            Console.Write("Who said it ? ");
            Quote.Name = Console.ReadLine();

            Console.WriteLine(Quote.Name + " says, " + "\"" + Quote.QUOTE + "\"");           
        }
    }
    class Quote
    {
        public static string QUOTE { get; set; }
        public static string Name { get; set; }
    }
}
