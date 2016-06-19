using System;

namespace HelloPerson
{

    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            bool isValid = false;
            
            // uname - user name string
            Console.WriteLine("What is Your name?\n");
            string uname = Console.ReadLine();

            Console.WriteLine("Hello User : " + uname + "\n");
            Console.WriteLine("Enter any number beteen 1 to 10 :");

            // num - Input veriable
            isValid = double.TryParse(Console.ReadLine(), out num);

            while (!isValid || num < 0 || num >= 11)
            {
                Console.WriteLine("Number must be from 1 to 10:");
                isValid = double.TryParse(Console.ReadLine(), out num);
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(uname);
                uname = " " + uname;
            }

            Console.ReadLine();
        }
    }
}
