using System;

namespace _1._1_Hello_World_Program.hellowWorld
{
    public class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello, C#!");
            Console.WriteLine();

            string[] prints = { "hello world", "Effi Diner Nachmani", "Haifa, Shimshom 20/2" };

            Console.WriteLine(" My first Strings and Console APP: ");
            Console.WriteLine("***********************************");

            foreach (string print in prints)
            {
                Console.WriteLine(print);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
