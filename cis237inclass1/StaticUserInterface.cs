using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
   static class StaticUserInterface
    {

        // No Variables
        // No Properties
        // No Constructor. We will just us the default

        // ******************************************
        // Public Methods
       static public int GetUserInput()
        {
            // Print out a menu
            PrintMenu();
        // Get the input from the user
        String input = Console.ReadLine();

            // While the input is not valid re-get the input

            while(input != "1" && input != "2")
            {
                // Print the error message
                PrintErrorMessage();
                // Re-print the menu
                PrintMenu();
        //Get the input from the Console again

        input = Console.ReadLine();
            }

            //At this point, I know the input is a valid number of either a 1 or a  2

            return Int32.Parse(input);
        }


// Any Interaction that used the Console will be in this file.
static public void Output(string outputString)
{
    Console.WriteLine(outputString);
}


//*****************************************************
//Private Methods

static private void PrintMenu()
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Print List");
    Console.WriteLine("2. Exit");
}


static private void PrintErrorMessage()
{
    Console.WriteLine("Not a valid Entry");
    Console.WriteLine("Please make a valid choice.");
    Console.WriteLine();
}

    }
}
