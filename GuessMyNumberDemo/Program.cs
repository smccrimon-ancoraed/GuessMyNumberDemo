using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *  Program:  Guess My Number
 *  Sample program that uses constant, primative data types, classes, private classes
 *  Use of calling the Random number function from the FLC (Foundation Class Library)
 * 
 */
 
namespace GuessMyNumberDemo
{

    class GuessMyNumber
    {

        // Declare global variables
        public const int NUMMAX = 9999;
        Random num = new Random();  // Not needed since we declare this in the function

        /*
          Function:  pickTheNumber(biggest-number)
          Returns a random generated number from 1 to biggest-number passed by Value
          We use a guess less than zero to quit unless we guess the number
         */


        // Generate a random number from 1 to nummax
        public int pickTheNumber(int nummax)
        {
            Random num = new Random();
            return num.Next(1, nummax);
        }


        static void Main(string[] args)
        {

            int numtrys = 0;       // Counter for tracking the number of trys
            int myguess;           //  The the user enters

            // Computer generates a random number from 1 to the value of the constant NUMMAX
            GuessMyNumber theNumber = new GuessMyNumber();
            int thepick = theNumber.pickTheNumber(NUMMAX);

            bool inProcess = true;                         // Program control flag
            PrintInstruction obj = new PrintInstruction();
            obj.displayInstruction();
            // Testing
            Console.WriteLine("hint: I picked " + thepick + "\n\n");

            // Try at least one, and keep going, see Instructions

            do
            {
                numtrys++;
                Console.WriteLine("Enter -1 to quit or guess a number ? ");
                myguess = Convert.ToInt32(Console.ReadLine());  // Read in an Integer number
                Console.WriteLine();

                if ((myguess < 0) || (myguess == thepick))
                {
                    inProcess = false;
                }
                else
                {
                    if (myguess > thepick)
                    {
                        Console.WriteLine(myguess + " is too high, try again.");
                    }
                    if (myguess < thepick)
                    {
                        Console.WriteLine(myguess + " is too low, try again.");
                    }
                }
            } while (inProcess);

            // Check if got it
            if (myguess == thepick)
            {
                Console.WriteLine("You got it in " + numtrys + " tries.\n");
                Console.WriteLine("to guess my number " + thepick+"\n");
            }
            else
            {
                Console.WriteLine("Sorry you didn't guess it in " + numtrys);
                Console.WriteLine();
            }


            Console.ReadKey();  // Done
         

        }  // Main
    }      // Class GuessMyNumber


    class PrintInstruction
    {

        public void displayInstruction()
        {

            // type in some instructions
            Console.WriteLine("Guess my number\n================\n");
            Console.WriteLine("The computer will generate a number from 1 to 9999.");
            Console.WriteLine("You will enter a number to guess that number.\n");
            Console.WriteLine("Hints will be given.");


        }  // Method displayInstructions
    } // Class PrintInstructions



}
