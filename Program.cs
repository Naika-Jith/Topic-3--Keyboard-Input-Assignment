using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_3__Keyboard_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Keyboard Input Assignment";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Keyboard Input Assignment!");
            Console.WriteLine();
            Console.WriteLine("Please press ENTER to continue");
            Console.ReadLine();
            Console.Clear();


            //Part 1: Greeting

            //FIX THIS PART/ DO BONUS!!!!!
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Part 1: Greeting");
            Console.WriteLine();

            string name;
            int age;
            int birthYear;
            int currentYear;

            Console.Write("Hello. What is your name? ");
            Console.WriteLine();
            name = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name + "!");
            Console.WriteLine();

            Console.Write("How old are you? ");
            Console.WriteLine();
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine();

            Console.Write("What year were you born? ");
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You were born in " + birthYear + ".");
            Console.WriteLine();

            Console.Write("What is the current year? ");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The current year is " + currentYear + ".");
            Console.WriteLine();
            
            Console.WriteLine("Hello " + name + ", you are " + age + " years old, you were born in " + birthYear + ", and the current year is " + currentYear + ".");
            Console.WriteLine();
            //FIX THIS PART/ DO BONUS!!!!!

            //Part 2: Adder

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Part 2: Adder");
            Console.WriteLine();
            
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int sum = num1 + num2 + num3;

            Console.WriteLine("The sum of " + num1 + ", " + num2 + ", and " + num3 + " is " + sum + ".");
            Console.WriteLine();


            //Part 3: Distance

            double distance1;
            double distance2;
            double distance3;
            double averageDistance;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Part 3: Distance");
            Console.WriteLine();
            
            Console.Write("Please enter the first distance: ");
            distance1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the second distance: ");
            distance2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter the third distance: ");
            distance3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double average = (distance1 + distance2 + distance3) / 3;
            Console.WriteLine("The average of " + distance1 + ", " + distance2 + ", and " + distance3 + " is " + average + ".");

            //Part 4: Hypotenuse


            











        }
    }
}
