using System;

namespace GussingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = new Random().Next(1,100);
            int num = secret;
            int count = 0;
            int guess = 0;
            bool value = false;

            Console.Write("The Guessing Number Game : \n");
            Console.Write("You have total 7 tries to Guess a number: \n");

            for (int i = 0; i < 7 ; i++)
            {
                count=count+1;
                Console.Write("Insert Guess Number " +count+" :");
                value = int.TryParse(Console.ReadLine(), out guess);

                if (!value || guess >=1&& guess <=100)
                {
                    if (guess  >num)
                    {
                        Console.Write("Your Guess is too big, the number is " + num+ "\n");
                    }
                    else if (guess < num)
                         {
                             Console.Write("Your Guess is too small, the number is " + num+ "\n");
                         }
                         else if(guess == num)
                         {
                             Console.Write("Excellent you guessed the number" +num+ "\n");
                             Console.Write("Number of tries are -" + count);
                             break;
                         }
                }
            }
            Console.ReadLine();

        }
    }
}
