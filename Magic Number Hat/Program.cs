using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;


/*
 *  Authur: Jose Quinones
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
                    Console.Write("Enter the first number in the range: ");
                    var firstEntry = Console.ReadLine();
                    var int1 = int.Parse(firstEntry);

                    // Request the second number in the range
                    Console.Write("Now enter the second number in the range: ");
                    var secondEntry = Console.ReadLine();
                    var int2 = int.Parse(secondEntry);

                    // Sort input values into a low number and a high number
                    var lowNum = Min(int1, int2);
                    Console.WriteLine("lowNum = " + lowNum);
                    var highNum = Max(int1, int2);
                    Console.WriteLine("highNum = " + highNum);

                    // Select random number in given range
                    Random rnd = new Random();
                    var selectedNum = rnd.Next(lowNum, highNum + 1);
                    Console.WriteLine("Random number = " + selectedNum);

                    // Display a count down before the random number is show to the user
                    Console.WriteLine("And the random number is...");
                    for (var i = 10; i == 0; i--)
                    {
                        Console.WriteLine(i);
                    }

                    // Display the random number
                    Console.WriteLine("\"" + selectedNum +"\"");

                    while(true)
                    {
                        // Ask if user would like to select another random number
                        Console.WriteLine("Would you like to generate another random number?");
                        Console.Write("Type Y for \"Yes\" or N to quit.");
                        var repeat = Console.ReadLine().ToLower();


                        try
                        {
                            if (repeat != "y" || repeat != "n")
                            {
                                Console.WriteLine("That was not a valid entry");
                                Console.Write("Please enter a valid response.");
                                continue;
                            }
                            if (repeat == "y")
                            {
                                continue;
                            }
                            else
                            {
                                Console.Write("Thank you for using the Number Hat.  Goodbye.");
                                break;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That was not a valid entry");
                            Console.Write("Please enter a valid response.");
                            continue;
                        }
                    }
                    
                    // End the loop and end the program
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please, enter only whole numbers.");
                    continue;
                }
            }
            
            Console.ReadLine();
        }
    } 
}