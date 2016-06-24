using System;

namespace MultiBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            for (x = 1; x <= 10; x++)
            {
                for (y = 1; y <= 10; y++)
                {
                    Console.Write(x * y);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
