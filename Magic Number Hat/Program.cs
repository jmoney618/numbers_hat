using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;


/*
 *  written my Jose Quinones
 *  This simple console app will request a range of numbers from the user and output a random number in the given range.
 *  This app can be useful for allowing decisions to be made by "chance".
*/
namespace Numbers_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output a simple intro message to the user
            Console.WriteLine("Welcome to the Magic Number Hat app.");
            Console.WriteLine("I will pick a random number out of a range from the magic hat for you, but I need you to tell me what the range is.");

            while (true)
            {
                try
                {

                    // Request the first number in the range
                    Console.Write("Please enter the first number in the range: ");
                    var firstEntry = Console.ReadLine();
                    var int1 = int.Parse(firstEntry);

                    // Request the second number in the range
                    Console.Write("Now enter the second number in the range: ");
                    var secondEntry = Console.ReadLine();
                    var int2 = int.Parse(secondEntry);

                    var lowNum = Min(int1, int2);
                    var highNum = Max(int1, int2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, only enter whole numbers.");
                    continue;
                }
            }
            

            Console.ReadLine();
        }
    } 
}