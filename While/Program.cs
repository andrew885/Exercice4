using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 200;
            do
            {
                if (i % 17 == 0)
                    Console.Write(i+", ");
                i++;
            }
            while (i <= 500);
        }
    }
}
