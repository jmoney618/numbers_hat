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
            Console.WriteLine("I will pick a random number out of a range from the magic hat for you,");
            Console.WriteLine("but I need you to tell me what the range is.");
            Console.WriteLine("");

            bool rerun = true; // Rerun the number generate if user chooses to
            while (rerun)
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
                    var highNum = Max(int1, int2);

                    // Select random number in given range
                    Random rnd = new Random();
                    var selectedNum = rnd.Next(lowNum, highNum + 1);

                    // Display the random number
                    Console.WriteLine("Your random number is \"" + selectedNum +"\".");

                    while(true)
                    {
                        // Ask if user would like to select another random number
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to generate another random number?");
                        Console.WriteLine("Type Y for \"Yes\" or N to quit.");
                        var repeat = Console.ReadLine().ToLower();

                        try
                        {
                            if (repeat == "y")
                            {
                                break; // Exit loop and rerun generator
                            }
                            else if (repeat == "n")
                            {
                                Console.Write("Thank you for using the Number Hat.  Goodbye.");
                                rerun = false; // User has decided not to rerun the random number generator. Exit loop and end program.
                                break;
                            }
                            else
                            {
                                Console.WriteLine("That was not a valid entry");
                                Console.WriteLine("Please enter a valid response.");
                                continue;
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That was not a valid entry");
                            Console.WriteLine("Please enter a valid response.");
                            continue;
                        }
                    }
                    
                    // Repeat loop, user has decided to rerun the generator
                    continue;
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