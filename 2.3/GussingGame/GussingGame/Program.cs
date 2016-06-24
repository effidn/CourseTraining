using System;

namespace GussingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int random = new Random().Next(1, 100);
            int uguess = 0;
            int i = 0;
            bool value = false;

            Console.Write("The Guessing Number Game : \n");
            Console.Write("Enter number between 1-100\n You have total 7 tries to Guess a number: \n");

            for (i = 1; i < 8; i++)
            {

                Console.Write("Insert Guess Number " + i + " :");
                value = int.TryParse(Console.ReadLine(), out uguess);

                if (!value || uguess >= 1 && uguess <= 100)
                {
                    if (uguess > random)
                    {
                        Console.Write("Your Guess is too big, the number is " + random + "\n");
                    }
                    else if (uguess < random)
                    {
                        Console.Write("Your Guess is too small, the number is " + random + "\n");
                    }
                    else if (uguess == random)
                    {
                        Console.Write("Excellent you guessed the number" + random + "\n");
                        Console.Write("Number of tries is " + i);
                        break;
                    }
                }
            }

            if (i==8)
            {
                Console.WriteLine("You tried to guess 7 times and failed \n");
            }
        }
    }
}
