using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the gradebook!");

            Console.Write("Please enter an integer grade: ");
            string input = Console.ReadLine();
          
            int grade;
            bool success = int.TryParse(input, out grade);
            
            if (success)
            {
                if (grade >= 90)
                {
                    Console.WriteLine("You got an A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("You got a B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("You got a C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("You got a D");
                }
                else
                {
                    Console.WriteLine("You failed");
                }
                Console.WriteLine("Thanks!");
            }
            else
            {
                Console.WriteLine("that wasn't an int");
            }

            Console.ReadKey();
        }
    }
}
