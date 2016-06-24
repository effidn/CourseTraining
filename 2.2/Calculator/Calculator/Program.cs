using System;

namespace Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {

            double num1;
            double num2;
            float result;
            string operand;
            

            Console.WriteLine("Insert First Number");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insert Second Number");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter An Operand For Calculation : '+'  '*'  '-'  '/' ");
            operand = Console.ReadLine();

            switch (operand)
            {
                case "+":
                {
                    result = (float) (num1 + num2);
                    Console.WriteLine(num1+ "+" +num2 + "=" + result);
                    break;
                }

                case "*":
                {
                    result = (float) (num1 * num2);
                    Console.WriteLine(num1+ "*" +num2+ "=" +result);
                    break;
                }

                case "-":
                {
                    result = (float) (num1 - num2);
                    Console.WriteLine(num1+ "-" +num2+ "=" + result);
                        break;
                }

                case "/":
                {
                        if((Convert.ToInt32(num2)) == 0)
                        {
                            Console.WriteLine("Cannot Divide by Zero");
                        }
                        else
                        {
                            result = (float) (num1 / num2);
                            result = (float) Math.Round(result,2);
                            Console.WriteLine(num1 + "/" + num2 + "=" + result);
                        }
                        break;
                }

                default:
                    Console.WriteLine("No Operand is selected");
                    break;
               }
            Console.ReadLine();
        }
    }
}
