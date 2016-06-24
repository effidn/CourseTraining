using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string insertion = string.Empty;

            Console.Write("type in sentence \n");
            insertion = Console.ReadLine();

            if (insertion != null)
            {
                string[] newstring = insertion.Split();
                int count = newstring.Length;

                Console.Write("Number of words is " + count);
                Console.ReadKey();

                for (int i = 0; i <= count; i++)
                {
                    
                }

            }
        }
    }
}
