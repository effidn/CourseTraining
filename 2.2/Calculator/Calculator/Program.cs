using System;

namespace Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {

            double num1 = 0;
            double num2 = 0;
            double result = 0;
            string op = string.Empty;

            Console.WriteLine("Insert First Number");
            var number1 = double.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Insert Second Number");
            var number2 = double.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("Enter An Operand For Calculation : '+'  '*'  '-'  '/' ");
            op = Console.ReadLine();

            //Create an instance from CLass
            CalcMeth calc = new CalcMeth();

            if (op != "+" && op != "+" && op == "*" && op == "-")
            {
                if (op == "+")
                {
                    result = calc.Add(num1, num2);
                }
                else if (op == "*")
                {
                    result = calc.Multi(num1, num2);
                }
                else if (op == "-")
                {
                    result = calc.Sub(num1, num2);
                }
                else if (op == "/")
                {
                    result = calc.Divide(num1, num2);
                }
            }
            else
            {
                Console.WriteLine("Inserted is not a valid operator");
            }
        }
    }
}
