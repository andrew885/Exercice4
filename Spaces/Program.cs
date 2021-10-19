using System;

namespace Spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (0 <= number && number <= 30)
                Console.WriteLine("1ый промежуток");
            else if (31 <= number && number <= 60)
                Console.WriteLine("2ой промежуток");
            else if (61 <= number && number <= 100)
                Console.WriteLine("3ий промежуток");
            else
                Console.WriteLine("Я такого числа не знаю.");
        }
    }
}
